namespace PortableDevices.Sample.IO

module main = 
    open PortableDevices
    open PDGlobalTypes
    open PDContent
    open PDContent.IO
    open PDUtils
    open System
    open LogHelper
    
    let CreateBackupPathFromSourcePath device backupRoot (props : GeneralProperties) = 
        let (PropertyValue parentID) = readObjectProperty device props.Id PDHeader.WPD_OBJECT_PARENT_ID
        let (PropertyValue parentName) = GetObjectName device (FolderID parentID)
        let month = props.LastWriteTime.ToString("MMMM")
        let year = props.LastWriteTime.Year.ToString()
        let pathArray = [| backupRoot; parentName; year; month |]
        pathArray |> Array.reduce (fun state current -> 
                         let currentPath = sprintf "%s\\%s" state current
                         match IO.Directory.Exists(currentPath) with
                         | true -> currentPath
                         | false -> 
                             IO.Directory.CreateDirectory(currentPath) |> ignore
                             currentPath)
    
    let filterSource backupLogPath backupRoot = 
        let logDataArray = logData backupLogPath
        
        let latestDatesIndex = 
            query { 
                for log in logDataArray do
                    groupBy log.BackupPath into grp
                    select (grp.Key, grp)
            }
            |> Seq.map (fun (key, grp) -> 
                   key, 
                   grp
                   |> Seq.map (fun log -> log.LastEdited)
                   |> Seq.max)
            |> dict
        (fun device (genProp : GeneralProperties) -> 
        match genProp.Id with
        | FolderID _ -> 
            printfn "%s Cut" genProp.Name
            false
        | _ -> 
            printfn "%s Pass" genProp.Name
            let backupPath = CreateBackupPathFromSourcePath device backupRoot genProp
            let hash' = backupPath + "\\" + genProp.Name
            not ((latestDatesIndex.ContainsKey(hash')) && latestDatesIndex.[hash'].Ticks <= genProp.LastWriteTime.Ticks))
    
    [<EntryPoint>]
    let main argv = 
        let backupRoot = "c:\\WPD_BU"
        let backupLogPath = backupRoot + "\\log.csv"
        
        let sourceFolderIDs = 
            [| FolderID "o376A"
               FolderID "oA697"
               FolderID "o2704" |]
        
        let portableDeviceID = DeviceIdArray |> Seq.head
        // TO DO: 
        // let sourceFolderIDs = ExploreContent deviceID
        // let deviceID = FindDevices
        
        let mutable fileCount = 0
        DoOnDevice portableDeviceID (fun device -> 
            let (DeviceID deviceID) = portableDeviceID
            let (PropertyValue friendlyName) = readDeviceProperty device PDHeader.WPD_DEVICE_FRIENDLY_NAME
            sourceFolderIDs
            |> Seq.collect (ListNodeIDs device false)
            |> Seq.map (fun objectID -> GeneralProperties.CreateFromObjectID device objectID)
            |> Seq.where ((filterSource backupLogPath backupRoot) device)
            |> Seq.map (fun prop -> 
                   let backupPath = CreateBackupPathFromSourcePath device backupRoot prop
                   
                   let result = 
                       try 
                           DoOnDevice portableDeviceID (fun device' -> GetObject device' prop.Id backupPath) |> ignore
                           fileCount <- fileCount + 1
                           "OK"
                       with ex -> ex.Message
                   BackupLog.CreateFromGeneralProperties device deviceID friendlyName (backupPath + "\\" + prop.Name) result prop)
            |> Seq.iter (logOperationResult backupLogPath))
        |> ignore
        printf "Copied %d files." fileCount
        
        System.Console.ReadLine() |> ignore
        0 // return an integer exit code
