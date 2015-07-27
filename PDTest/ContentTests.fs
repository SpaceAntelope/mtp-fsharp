namespace PDTest

open Xunit
open Xunit.Abstractions
open Swensen.Unquote
open PortableDevices
open PDGlobalTypes

module PDContentTesting = 
    type ContentTests(_output : ITestOutputHelper) = 
        let output = _output
        let TestFolder = "TestFolder"
        let TestFile = "TestFile.txt"
        let ParentFolderID = FolderID "s10001"
        let existingFolder device = PDContent.SearchItemByName device TestFolder ParentFolderID
        let existingTestFile device (FolderID objID | ObjectID objID) = PDContent.SearchItemByName device "TestFile.txt" (FolderID objID)
        
        member this.Connect(action : ConnectedDevice -> unit) = 
            let device = 
                PDUtils.DeviceIdArray
                |> Array.head
                |> PDUtils.ConnectDevice
            match device with
            | Some dev -> 
                action dev
                PDUtils.disconnectDevice
            | _ -> failwith "Unable to connect to device"
        
        [<Fact>]
        member this.``1. Connect to first attached device``() = this.Connect(fun device -> Assert.IsType(typeof<PDGlobalTypes.ConnectedDevice>, device))
        
        [<Fact>]
        member this.``2. Create directory "TestFolder" in root of connected device``() = 
            this.Connect(fun device -> 
                Assert.True((existingFolder device).IsNone)
                PDContent.Utils.CreateFolder device TestFolder ParentFolderID
                Assert.True((existingFolder device).IsSome))
        
        [<Fact>]
        member this.``3. Copy file "TestFile.txt" in TestFolder``() = 
            let sourceFile = new System.IO.FileInfo(TestFile)
            Assert.True(sourceFile.Exists)
            this.Connect(fun device -> 
                match existingFolder device with
                | None -> Assert.True(false)
                | Some(FolderID objId | ObjectID objId) -> 
                    Assert.True((existingTestFile device (FolderID objId)).IsNone)
                    PDContent.Utils.SendFile device (FolderID objId) sourceFile
                    Assert.True((existingTestFile device (FolderID objId)).IsSome))
        
        [<Fact>]
        member this.``4. Delete test file``() = 
            this.Connect(fun device -> 
                let exFold = PDContent.SearchItemByName device TestFolder ParentFolderID
                Assert.True(exFold.IsSome)
                let exFile = existingTestFile device (exFold.Value)
                Assert.True(exFile.IsSome)
                PDContent.Utils.DeleteObject device (exFile.Value) false |> ignore
                Assert.True((existingTestFile device (exFold.Value)).IsNone))
        
        [<Fact>]
        member this.``5. Delete test folder``() = 
            this.Connect(fun device -> 
                let exFold = existingFolder device
                Assert.True(exFold.IsSome)
                PDContent.Utils.DeleteObject device (exFold.Value) false |> ignore
                Assert.True((existingFolder device).IsNone))
        
        [<Fact>]
        member this.``Results of ListNodeIDs must match node type``() = 
            this.Connect(fun device -> 
                PDContent.ListNodeIDs device false "s10001"
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
