namespace PDTest


open Xunit
open Xunit.Abstractions
open PortableDevices
open PDGlobalTypes

module PDIOTesting = 

    type IOTests(_output : ITestOutputHelper) = 
        let output = _output
        let TestFolder = "TestFolder"
        let TestFile = "TestFile.txt"
        let ParentFolderID = FolderID "s10001"
        let existingFolder device = PDContent.SearchBySpecificName device ParentFolderID TestFolder 
        let existingTestFile device (FolderID objID | ObjectID objID) = PDContent.SearchBySpecificName device (FolderID objID) "TestFile.txt"
        let objectExists device folderID fileName = (PDContent.SearchBySpecificName device folderID fileName).IsSome
        let getObjectIdByName device folderID fileName = PDContent.SearchBySpecificName device folderID fileName

        member this.Connect(action : ConnectedDevice -> unit) = 
            let device = 
                PDUtils.DeviceIdArray
                |> Array.head
                |> PDUtils.ConnectDevice
            match device with
            | Some dev -> 
                let (PropertyValue friendlyName) = PDUtils.readDeviceProperty dev PDHeader.WPD_DEVICE_FRIENDLY_NAME
                output.WriteLine("Connected to {0}", friendlyName)
                action dev
                PDUtils.disconnectDevice
            | _ -> failwith "Unable to connect to device"
        
        [<Fact>]
        member this.``1. Connect to first attached device``() = this.Connect(fun device -> Assert.IsType(typeof<PDGlobalTypes.ConnectedDevice>, device))
        
        [<Fact>]
        member this.``2. Create directory "TestFolder" in root of connected device``() = 
            this.Connect(fun device -> 
                Assert.True((existingFolder device).IsNone, "TestFolder already exists")
                PDContent.IO.CreateFolder device TestFolder ParentFolderID
                Assert.True((existingFolder device).IsSome, "TestFolder could not be created"))
        
        [<Fact>]
        member this.``3-1. Copy file "TestFile.txt" in TestFolder``() = 
            let sourceFile = new System.IO.FileInfo(TestFile)
            Assert.True(sourceFile.Exists, "File to be copied is missing")
            this.Connect(fun device -> 
                match existingFolder device with
                | None -> Assert.True(false)
                | Some(FolderID objId | ObjectID objId) -> 
                    Assert.True((existingTestFile device (FolderID objId)).IsNone, "Target folder already contains a file with this name")
                    PDContent.IO.SendFile device (FolderID objId) sourceFile ""
                    Assert.True((existingTestFile device (FolderID objId)).IsSome,"File could not be copied"))
        
        [<Fact>]
        member this.``3-2. Copy 10 instances of file "TestFile.txt" to "TestFile_##.txt" in TestFolder``() = 
            let sourceFile = new System.IO.FileInfo(TestFile)
            Assert.True(sourceFile.Exists, "file already created")
            this.Connect(fun device -> 
                match existingFolder device with
                | None -> Assert.True(false, "Target folder missing")
                | Some folderID -> 
                    [|1..10|] 
                    |> Array.map (sprintf "TestFile_%i.txt")
                    |> Array.iter (fun fileName -> 
                        Assert.True((not (objectExists device folderID fileName)), "Target file already created")
                        PDContent.IO.SendFile device folderID sourceFile fileName
                        Assert.True((objectExists device folderID fileName), "Target file not created")))

        [<Fact>]
        member this.``3-3. Rename "TestFile_10.txt" to "TestFile_00.txt" in TestFolder``() =             
            let targetFileName = "TestFile_10.txt"
            this.Connect(fun device -> 
                match existingFolder device with
                | None -> Assert.True(false, "Target folder missing")
                | Some folderID -> 
                    match (getObjectIdByName device folderID targetFileName) with
                        | None -> Assert.True(false, "Target file missing")
                        | Some fileID -> 
                            let result = PDContent.IO.RenameObject device fileID "TestFile_00.txt" 
                            Assert.True((objectExists device folderID "TestFile_00.txt"), "Target file was not renamed"))

        [<Fact>]
        member this.``3-4. Create test subfolder and move even numbered testfiles there ``() =             
            let targetSubfolderName = "TestSubfolder"
            this.Connect(fun device -> 
                match existingFolder device with
                | None -> Assert.True(false, "Τest folder missing")
                | Some folderID -> 
                    Assert.True(not (objectExists device folderID targetSubfolderName), "Target subfolder already created")
                    let subfolderID = PDContent.IO.CreateFolder device targetSubfolderName folderID 
                    let (Some subfolderID) = getObjectIdByName device folderID targetSubfolderName
                    Assert.True((objectExists device folderID targetSubfolderName), "Target subfolder creation failed")

                    let isFileEven filename = System.Text.RegularExpressions.Regex.Match(filename, "TestFile_\d").Success && (int filename.[9])%2 = 0

                    PDContent.ListNodeIDs device false folderID
                    |> Seq.map (fun (ObjectID objID | FolderID objID) -> (objID, PDUtils.readObjectProperty device objID PDHeader.WPD_OBJECT_NAME))
                    |> Seq.where (fun (_, PropertyValue filename) -> isFileEven filename)
                    |> Seq.map (fun (objID, _) -> objID)
                    |> Array.ofSeq                    
                    |> PDContent.IO.MoveObjectInDevice device subfolderID
                    //|> Seq.map (fun objID ->  PDContent.IO.CopyObjectInDevice device subfolderID objID )
                    |> ignore

                    Assert.True(
                        PDContent.ListNodeIDs device false folderID
                        |> Seq.map (fun (ObjectID objID | FolderID objID)  -> (objID, PDUtils.readObjectProperty device objID PDHeader.WPD_OBJECT_NAME))
                        |> Seq.where (fun (_, PropertyValue filename) ->  isFileEven filename)
                        |> Seq.length = 0, "Source files not deleted during move")

                    Assert.True(
                        PDContent.ListNodeIDs device false subfolderID
                        |> Seq.map (fun (ObjectID objID) -> (objID, PDUtils.readObjectProperty device objID PDHeader.WPD_OBJECT_NAME))
                        |> Seq.where (fun (_, PropertyValue filename) ->  isFileEven filename)
                        |> Seq.length = 5, "Source files never made it to subfolder")
                    )

        [<Fact>]
        member this.``4-1. Delete test file``() = 
            this.Connect(fun device -> 
                let exFold = PDContent.SearchBySpecificName device  ParentFolderID TestFolder
                Assert.True(exFold.IsSome)
                let exFile = existingTestFile device (exFold.Value)
                Assert.True(exFile.IsSome)
                PDContent.IO.DeleteObject device (exFile.Value) false |> ignore
                Assert.True((existingTestFile device (exFold.Value)).IsNone))

        [<Fact>]    
        member this.``4-2. Delete test subfolder and files recursively``() = 
            this.Connect(fun device -> 
                let exFold = PDContent.SearchBySpecificName device  ParentFolderID TestFolder
                Assert.True(exFold.IsSome, "File to delete parent folder was not found")
                let exFile = existingTestFile device (exFold.Value)
                Assert.True(exFile.IsSome, "File to delete was not found")
                PDContent.IO.DeleteObject device (exFile.Value) false |> ignore
                Assert.True((existingTestFile device (exFold.Value)).IsNone))
        
        [<Fact>]
        member this.``5-1. Delete not empty test folder with recursive = false and read errors``() = 
            this.Connect(fun device -> 
                let exFold = existingFolder device
                Assert.True(exFold.IsSome,"Folder to delete not found")
                PDContent.IO.DeleteObject device (exFold.Value) false
                |> PDUtils.enumeratePropVariantCollection
                |> Seq.iter (printfn "%A"))
                //Assert.True((existingFolder device).IsNone))

        [<Fact>]
        member this.``5-2. Delete tesfolder and contents``() = 
            this.Connect(fun device -> 
                let exFold = existingFolder device
                Assert.True(exFold.IsSome)
                PDContent.IO.DeleteObject device (exFold.Value) true |> ignore
                Assert.True((existingFolder device).IsNone))
               
        [<Fact>]
        member this.``Results of ListNodeIDs must match node type``() = 
            this.Connect(fun device -> 
                PDContent.ListNodeIDs device false (FolderID "s10001")
                |> Seq.forall (fun nodeID -> 
                       let getName objID = PDUtils.readObjectProperty device objID (PDHeader.WPD_OBJECT_ORIGINAL_FILE_NAME)
                       let getContentType = PDUtils.readObjectPropertyBySpecificType device (PDHeaderIndices.VARENUM.VT_CLSID) (PDHeader.WPD_OBJECT_CONTENT_TYPE)                       
                       let writeInfo objID = 
                           let (PropertyValueGuid contentType) = getContentType objID
                           let contentName = PDHeaderUtils.GetGuidName(contentType)
                           sprintf "%A --> %A" (getName objID) contentName
                       match nodeID with
                       | FolderID objID -> 
                           output.WriteLine("Folder {0}", (writeInfo objID))
                           (PropertyValueGuid PDHeader.WPD_CONTENT_TYPE_FOLDER) = (getContentType objID)
                       | ObjectID objID -> 
                           output.WriteLine("Object {0}", (writeInfo objID))
                           (PropertyValueGuid PDHeader.WPD_CONTENT_TYPE_FOLDER) <> (getContentType objID))
                |> Assert.True)
