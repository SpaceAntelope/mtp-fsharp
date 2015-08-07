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
        printfn "Filtering already copied files..."
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
            //printfn "%s Cut" genProp.Name
            false
        | _ -> 
            //printfn "%s Pass" genProp.Name
            let backupPath = CreateBackupPathFromSourcePath device backupRoot genProp
            let hash' = backupPath + "\\" + genProp.Name
            not ((latestDatesIndex.ContainsKey(hash')) && latestDatesIndex.[hash'].Ticks <= genProp.LastWriteTime.Ticks))
    
    [<EntryPoint>]
    let main argv = 
        
        (* Temporary hardcoded values that you probably do not want to use:
        let backupRoot = "j:\\WPD_BU"
        let backupLogPath = backupRoot + "\\log.csv"        

        let sourceFolderIDs = 
            [| FolderID "o2C"
               FolderID "oA2BC"
               FolderID "o21"
               FolderID "o376A"
               FolderID "o2704"
               FolderID "oA697"
               FolderID "o6"
               FolderID "o1618" 
               FolderID "o97E3" 
               FolderID "o1B2D"
               FolderID "o8E"
               FolderID "o8"
                |]
        
        let portableDeviceID = DeviceIdArray |> Seq.item 1
        *)
        // TO DO: 
        // let deviceID = FindDevices
        // let sourceFolderIDs = ExploreContent deviceID
        //ContentExplorer.ExploreContent portableDeviceID |> ignore

        let backupRoot = ""
        let backupLogPath = backupRoot + ""        
        let portableDeviceID = DeviceID ""
        let sourceFolderIDs = [||]

        let timer = new System.Diagnostics.Stopwatch()
        let totalTimer = new System.Diagnostics.Stopwatch()
        let mutable fileCount = 0
        let mutable totalSize = uint64 0
        let mutable partialSize = uint64 0
        let mutable currentParent = ""
        DoOnDevice portableDeviceID (fun device -> 
            let (DeviceID deviceID) = portableDeviceID
            let (PropertyValue friendlyName) = readDeviceProperty device PDHeader.WPD_DEVICE_FRIENDLY_NAME
            printfn "Finding data to copy... "
            let objectIDs = sourceFolderIDs |> Seq.collect (ListNodeIDs device false)
            timer.Start()
            totalTimer.Start()
            objectIDs
            |> Seq.map (fun objectID -> GeneralProperties.CreateFromObjectID device objectID)
            |> Seq.where ((filterSource backupLogPath backupRoot) device)
            |> Seq.map (fun prop -> 
                   if currentParent <> prop.ParentName then 
                       currentParent <- prop.ParentName
                       printfn "Copying from folder %s" currentParent
                   let backupPath = CreateBackupPathFromSourcePath device backupRoot prop
                   
                   let result = 
                       try 
                           DoOnDevice portableDeviceID (fun device' -> GetObject device' prop.Id backupPath) |> ignore
                           fileCount <- fileCount + 1
                           totalSize <- totalSize + prop.Length
                           partialSize <- partialSize + prop.Length
                           "OK"
                       with ex -> ex.Message
                   if timer.Elapsed.Seconds >= 10 then 
                       printfn "Progress: %.2f%% at %.2f MB/s, %s elapsed." ((float fileCount) / (float (objectIDs |> Seq.length)) * 100.0) (float32 partialSize / 10485760.0f) (totalTimer.Elapsed.ToString(@"hh\:mm\:ss"))
                       timer.Reset()
                       timer.Start()
                       partialSize <- uint64 0
                   BackupLog.CreateFromGeneralProperties device deviceID friendlyName (backupPath + "\\" + prop.Name) result prop)
            |> Seq.iter (logOperationResult backupLogPath))
        |> ignore
        printfn "Copied %d files" fileCount
        printfn "Total time: %s" (totalTimer.Elapsed.ToString(@"hh\:mm\:ss"))
        printfn "Total size: %.2f MB" (float32 totalSize / 1048576.0f)
        System.Console.ReadLine() |> ignore
        0 // return an integer exit code
