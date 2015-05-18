namespace PortableDevices

open PortableDeviceApiLib

module PDTypes = 
    type FilePath = 
        | DevicePath of string
        | BackupPath of string
    
    type TransferStatus = 
        | Complete
        | Error
        | Stalled
        | Unknown
    
    type DevicePropertyName = 
        | DevicePropertyName of string
    
    type DevicePropertyValue = 
        | DevicePropertyValue of string
    
    type DeviceID = 
        | DeviceID of string
    
    type PortableDevice = 
        { DeviceID : DeviceID
          Device : PortableDeviceClass }
    
    type ConnectionStatus<'a> = 
        | Connected of 'a
        | Disconnected of 'a
    
    type ConnectDevice = PortableDevice -> ConnectionStatus<PortableDevice>
    
    type DisconnectDevice = PortableDevice -> ConnectionStatus<PortableDevice>
    
    type ReadDeviceProperty = ConnectionStatus<PortableDevice> -> DevicePropertyName -> Option<DevicePropertyValue>
    
    type TransferToBackup = FilePath -> FilePath -> TransferStatus
