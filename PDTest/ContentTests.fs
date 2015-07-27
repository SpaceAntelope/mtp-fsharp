namespace PDTest


open Xunit
open Swensen.Unquote
open PortableDevices
open PDGlobalTypes

module ContentTests =

    let (Some device) = PDUtils.DeviceIdArray 
                        |> Array.head
                        |> PDUtils.ConnectDevice 

    let TestFolder = "TestFolder"
    let ParentFolderID = FolderID "s10001"
    
    let existingFolder = (fun () -> PDContent.SearchItemByName device TestFolder ParentFolderID)                 

    [<Fact>]
    let ``1. Connect to first attached device``()=    
        test <@ device.GetType () = typeof<PDGlobalTypes.ConnectedDevice> @>

    [<Fact>]
    let ``2. Create directory "TestFolder" in root of connected device``() =
        Assert.True(existingFolder().IsNone)
        let (FolderID testFolderID) = PDContent.Utils.CreateFolder device TestFolder ParentFolderID
        Assert.True(existingFolder().IsSome)

    [<Fact>]
    let ``3. Delete test folder``() =
        let exFold = existingFolder()
        
        Assert.True(exFold.IsSome)
        
        PDContent.Utils.DeleteFile device (exFold.Value) |> ignore
        
        Assert.True(existingFolder().IsNone)
