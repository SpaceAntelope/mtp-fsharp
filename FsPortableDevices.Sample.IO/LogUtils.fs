namespace PortableDevices.Sample.IO

open System
open PortableDevices
open PDGlobalTypes
open PDContent
open PDContent.IO
open PDUtils
open PDHeader

module LogHelper = 
    type BackupLog = 
        { DeviceID : string
          DeviceFriendlyName : string
          ObjectID : string
          OriginalFilename : string
          BackupPath : string
          SourcePathID : string
          SourcePath : string
          LastEdited : DateTime
          LastStored : DateTime
          OperationResult : string }
        static member CsvHeaders = [| "DeviceID"; "DeviceFriendlyName"; "ObjectID"; "OriginalFilename"; "BackupPath"; "SourcePathID"; "SourcePath"; "LastEdited"; "LastStored"; "OperationResult" |] |> Array.reduce (sprintf "%s,%s")
        static member CsvLine(log : BackupLog) = 
            sprintf "%s·,%s·,%s·,%s·,%s·,%s·,%s·,%d·,%d·,%s" log.DeviceID log.DeviceFriendlyName log.ObjectID log.OriginalFilename log.BackupPath log.SourcePathID log.SourcePath (log.LastEdited.Ticks) (log.LastStored.Ticks) log.OperationResult
        
        static member CreateFromCsvLine line = 
            let record = System.Text.RegularExpressions.Regex.Split(line, "·,")
            { DeviceID = record.[0]
              DeviceFriendlyName = record.[1]
              ObjectID = record.[2]
              OriginalFilename = record.[3]
              BackupPath = record.[4]
              SourcePathID = record.[5]
              SourcePath = record.[6]
              LastEdited = new DateTime(int64 record.[7])
              LastStored = new DateTime(int64 record.[8])
              OperationResult = record.[9] }
        
        static member CreateFromGeneralProperties device deviceID deviceName backupPath operationResult (props : GeneralProperties) = 
            { DeviceID = deviceID
              DeviceFriendlyName = deviceName
              ObjectID = DeconstructContentID props.Id
              OriginalFilename = props.Name
              BackupPath = backupPath
              SourcePathID = ObjectPathIDs device props.Id
              SourcePath = ObjectPathNames device props.Id
              LastEdited = props.LastWriteTime
              LastStored = DateTime.Now
              OperationResult = operationResult }
    
    let datePattern = "yyyy/MM/dd:HH:mm:ss.fff"    
    
    let logData backupLog = 
        let logFile = new System.IO.FileInfo(backupLog)
        match logFile.Exists with
        | true -> 
            IO.File.ReadAllLines(backupLog)
            |> Array.skip 1
            |> Array.map BackupLog.CreateFromCsvLine
        | false -> [||]

    let logOperationResult backupLogPath (log : BackupLog) = 
        match (IO.File.Exists(backupLogPath)) with
        | false -> 
            IO.File.Create(backupLogPath).Close()
            IO.File.WriteAllLines(backupLogPath, 
                                  [| BackupLog.CsvHeaders
                                     BackupLog.CsvLine(log) |])
        | true -> IO.File.AppendAllLines(backupLogPath, [| BackupLog.CsvLine(log) |])