namespace PortableDevices

module PortableDeviceHeader = 
    open PortableDeviceApiLib
    
    /// This section defines the legacy WPD Properties
    module legacy_WPD_Properties = 
        /// [ VT_LPWSTR ] Uniquely identifies object on the Portable Device.
        let WPD_OBJECT_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 2)
        
        /// [ VT_LPWSTR ] Object identifier indicating the parent object.
        let WPD_OBJECT_PARENT_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 3)
        
        /// [ VT_LPWSTR ] The display name for this object.
        let WPD_OBJECT_NAME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 4)
        
        /// [ VT_LPWSTR ] Uniquely identifies the object on the Portable Device, similar to WPD_OBJECT_ID, but this ID will not change between sessions.
        let WPD_OBJECT_PERSISTENT_UNIQUE_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 5)
        
        /// [ VT_CLSID ] Indicates the format of the object's data.
        let WPD_OBJECT_FORMAT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 6)
        
        /// [ VT_BOOL ] Indicates whether the object should be hidden.
        let WPD_OBJECT_ISHIDDEN = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 9)
        
        /// [ VT_BOOL ] Indicates whether the object represents system data.
        let WPD_OBJECT_ISSYSTEM = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 10)
        
        /// [ VT_UI8 ] The size of the object data.
        let WPD_OBJECT_SIZE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 11)
        
        /// [ VT_LPWSTR ] Contains the name of the file this object represents.
        let WPD_OBJECT_ORIGINAL_FILE_NAME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 12)
        
        /// [ VT_BOOL ] This property determines whether or not this object is intended to be understood by the device, or whether it has been placed on the device just for storage.
        let WPD_OBJECT_NON_CONSUMABLE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 13)
        
        /// [ VT_LPWSTR ] String containing a list of keywords associated with this object.
        let WPD_OBJECT_KEYWORDS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 15)
        
        /// [ VT_LPWSTR ] Opaque string set by client to retain state between sessions without retaining a catalogue of connected device content.
        let WPD_OBJECT_SYNC_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 16)
        
        /// [ VT_BOOL ] Indicates whether the media data is DRM protected.
        let WPD_OBJECT_IS_DRM_PROTECTED = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 17)
        
        /// [ VT_DATE ] Indicates the date and time the object was created on the device.
        let WPD_OBJECT_DATE_CREATED = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 18)
        
        /// [ VT_DATE ] Indicates the date and time the object was modified on the device.
        let WPD_OBJECT_DATE_MODIFIED = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 19)
        
        /// [ VT_DATE ] Indicates the date and time the object was authored (e.g. for music, this would be the date the music was recorded).
        let WPD_OBJECT_DATE_AUTHORED = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 20)
        
        /// [ VT_UNKNOWN ] IPortableDevicePropVariantCollection of type VT_LPWSTR indicating a list of ObjectIDs.
        let WPD_OBJECT_BACK_REFERENCES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 21)
        
        /// [ VT_BOOL ] Indicates whether the object can be deleted, or not.
        let WPD_OBJECT_CAN_DELETE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 26)
        
        /// [ VT_LPWSTR ] Identifies the language of this object. If multiple languages are contained in this object, it should identify the primary language (if any).
        let WPD_OBJECT_LANGUAGE_LOCALE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 27)
    
    /// binary data.
    module This_section_defines_all_Resource_keys = 
        /// 
        let WPD_RESOURCE_DEFAULT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xE81E79BE, int16 0x34F0, 
                                                                                 int16 0x41BF, byte 0xB5, byte 0x3F, 
                                                                                 byte 0xF1, byte 0xA0, byte 0x6A, 
                                                                                 byte 0xE8, byte 0x78, byte 0x42), 
                                                         pid = uint32 0)
        
        /// 
        let WPD_RESOURCE_CONTACT_PHOTO = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2C4D6803, int16 0x80EA, 
                                                                                 int16 0x4580, byte 0xAF, byte 0x9A, 
                                                                                 byte 0x5B, byte 0xE1, byte 0xA2, 
                                                                                 byte 0x3E, byte 0xDD, byte 0xCB), 
                                                         pid = uint32 0)
        
        /// 
        let WPD_RESOURCE_THUMBNAIL = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xC7C407BA, int16 0x98FA, 
                                                                                 int16 0x46B5, byte 0x99, byte 0x60, 
                                                                                 byte 0x23, byte 0xFE, byte 0xC1, 
                                                                                 byte 0x24, byte 0xCF, byte 0xDE), 
                                                         pid = uint32 0)
        
        /// 
        let WPD_RESOURCE_ICON = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF195FED8, int16 0xAA28, 
                                                                                 int16 0x4EE3, byte 0xB1, byte 0x53, 
                                                                                 byte 0xE1, byte 0x82, byte 0xDD, 
                                                                                 byte 0x5E, byte 0xDC, byte 0x39), 
                                                         pid = uint32 0)
        
        /// 
        let WPD_RESOURCE_AUDIO_CLIP = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x3BC13982, int16 0x85B1, 
                                                                                 int16 0x48E0, byte 0x95, byte 0xA6, 
                                                                                 byte 0x8D, byte 0x3A, byte 0xD0, 
                                                                                 byte 0x6B, byte 0xE1, byte 0x17), 
                                                         pid = uint32 0)
        
        /// 
        let WPD_RESOURCE_ALBUM_ART = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF02AA354, int16 0x2300, 
                                                                                 int16 0x4E2D, byte 0xA1, byte 0xB9, 
                                                                                 byte 0x3B, byte 0x67, byte 0x30, 
                                                                                 byte 0xF7, byte 0xFA, byte 0x21), 
                                                         pid = uint32 0)
        
        /// 
        let WPD_RESOURCE_GENERIC = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB9B9F515, int16 0xBA70, 
                                                                                 int16 0x4647, byte 0x94, byte 0xDC, 
                                                                                 byte 0xFA, byte 0x49, byte 0x25, 
                                                                                 byte 0xE9, byte 0x5A, byte 0x07), 
                                                         pid = uint32 0)
        
        /// 
        let WPD_RESOURCE_VIDEO_CLIP = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB566EE42, int16 0x6368, 
                                                                                 int16 0x4290, byte 0x86, byte 0x62, 
                                                                                 byte 0x70, byte 0x18, byte 0x2F, 
                                                                                 byte 0xB7, byte 0x9F, byte 0x20), 
                                                         pid = uint32 0)
        
        /// 
        let WPD_RESOURCE_BRANDING_ART = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB633B1AE, int16 0x6CAF, 
                                                                                 int16 0x4A87, byte 0x95, byte 0x89, 
                                                                                 byte 0x22, byte 0xDE, byte 0xD6, 
                                                                                 byte 0xDD, byte 0x58, byte 0x99), 
                                                         pid = uint32 0)
    
    /// The properties in this category describe API options.
    module WPD_API_OPTIONS_V1 = 
        /// [ VT_BOOL ] Indicates that the data stream created for data transfer will be clear only (i.e. No DRM will be involved).
        let WPD_API_OPTION_USE_CLEAR_DATA_STREAM = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x10E54A3E, int16 0x052D, 
                                                                                 int16 0x4777, byte 0xA1, byte 0x3C, 
                                                                                 byte 0xDE, byte 0x76, byte 0x14, 
                                                                                 byte 0xBE, byte 0x2B, byte 0xC4), 
                                                         pid = uint32 2)
        
        /// [ VT_UI4 ] An optional property that clients can add to the IN parameter set of IPortableDevice::SendCommand to specify the access required for the command. The Portable Device API uses this to identify whether the IOCTL sent to the driver is sent with FILE_READ_ACCESS or (FILE_READ_ACCESS | FILE_WRITE_ACCESS) access flags.
        let WPD_API_OPTION_IOCTL_ACCESS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x10E54A3E, int16 0x052D, 
                                                                                 int16 0x4777, byte 0xA1, byte 0x3C, 
                                                                                 byte 0xDE, byte 0x76, byte 0x14, 
                                                                                 byte 0xBE, byte 0x2B, byte 0xC4), 
                                                         pid = uint32 3)
    
    /// This category is for properties common to all appointment objects.
    module WPD_APPOINTMENT_OBJECT_PROPERTIES_V1 = 
        /// [ VT_LPWSTR ] Indicates the location of the appointment e.g. "Building 5, Conf. room 7".
        let WPD_APPOINTMENT_LOCATION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF99EFD03, int16 0x431D, 
                                                                                 int16 0x40D8, byte 0xA1, byte 0xC9, 
                                                                                 byte 0x4E, byte 0x22, byte 0x0D, 
                                                                                 byte 0x9C, byte 0x88, byte 0xD3), 
                                                         pid = uint32 3)
        
        /// [ VT_LPWSTR ] Indicates the type of appointment e.g. "Personal", "Business" etc.
        let WPD_APPOINTMENT_TYPE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF99EFD03, int16 0x431D, 
                                                                                 int16 0x40D8, byte 0xA1, byte 0xC9, 
                                                                                 byte 0x4E, byte 0x22, byte 0x0D, 
                                                                                 byte 0x9C, byte 0x88, byte 0xD3), 
                                                         pid = uint32 7)
        
        /// [ VT_LPWSTR ] Semi-colon separated list of required attendees.
        let WPD_APPOINTMENT_REQUIRED_ATTENDEES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF99EFD03, int16 0x431D, 
                                                                                 int16 0x40D8, byte 0xA1, byte 0xC9, 
                                                                                 byte 0x4E, byte 0x22, byte 0x0D, 
                                                                                 byte 0x9C, byte 0x88, byte 0xD3), 
                                                         pid = uint32 8)
        
        /// [ VT_LPWSTR ] Semi-colon separated list of optional attendees.
        let WPD_APPOINTMENT_OPTIONAL_ATTENDEES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF99EFD03, int16 0x431D, 
                                                                                 int16 0x40D8, byte 0xA1, byte 0xC9, 
                                                                                 byte 0x4E, byte 0x22, byte 0x0D, 
                                                                                 byte 0x9C, byte 0x88, byte 0xD3), 
                                                         pid = uint32 9)
        
        /// [ VT_LPWSTR ] Semi-colon separated list of attendees who have accepted the appointment.
        let WPD_APPOINTMENT_ACCEPTED_ATTENDEES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF99EFD03, int16 0x431D, 
                                                                                 int16 0x40D8, byte 0xA1, byte 0xC9, 
                                                                                 byte 0x4E, byte 0x22, byte 0x0D, 
                                                                                 byte 0x9C, byte 0x88, byte 0xD3), 
                                                         pid = uint32 10)
        
        /// [ VT_LPWSTR ] Semi-colon separated list of resources needed for the appointment.
        let WPD_APPOINTMENT_RESOURCES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF99EFD03, int16 0x431D, 
                                                                                 int16 0x40D8, byte 0xA1, byte 0xC9, 
                                                                                 byte 0x4E, byte 0x22, byte 0x0D, 
                                                                                 byte 0x9C, byte 0x88, byte 0xD3), 
                                                         pid = uint32 11)
        
        /// [ VT_LPWSTR ] Semi-colon separated list of attendees who have tentatively accepted the appointment.
        let WPD_APPOINTMENT_TENTATIVE_ATTENDEES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF99EFD03, int16 0x431D, 
                                                                                 int16 0x40D8, byte 0xA1, byte 0xC9, 
                                                                                 byte 0x4E, byte 0x22, byte 0x0D, 
                                                                                 byte 0x9C, byte 0x88, byte 0xD3), 
                                                         pid = uint32 12)
        
        /// [ VT_LPWSTR ] Semi-colon separated list of attendees who have declined the appointment.
        let WPD_APPOINTMENT_DECLINED_ATTENDEES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF99EFD03, int16 0x431D, 
                                                                                 int16 0x40D8, byte 0xA1, byte 0xC9, 
                                                                                 byte 0x4E, byte 0x22, byte 0x0D, 
                                                                                 byte 0x9C, byte 0x88, byte 0xD3), 
                                                         pid = uint32 13)
    
    /// This command category is used to query capabilities of the device.
    module WPD_CATEGORY_CAPABILITIES = 
        /// [ Required ]  WPD_PROPERTY_CAPABILITIES_SUPPORTED_COMMANDS 
        let WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_COMMANDS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 2)
        
        /// [ Required ]  WPD_PROPERTY_CAPABILITIES_COMMAND_OPTIONS 
        let WPD_COMMAND_CAPABILITIES_GET_COMMAND_OPTIONS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 3)
        
        /// [ Required ]  WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_CATEGORIES 
        let WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FUNCTIONAL_CATEGORIES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 4)
        
        /// [ Required ]  WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_OBJECTS 
        let WPD_COMMAND_CAPABILITIES_GET_FUNCTIONAL_OBJECTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 5)
        
        /// [ Required ]  WPD_PROPERTY_CAPABILITIES_CONTENT_TYPES 
        let WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_CONTENT_TYPES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 6)
        
        /// [ Required ]  WPD_PROPERTY_CAPABILITIES_FORMATS 
        let WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FORMATS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 7)
        
        /// [ Required ]  WPD_PROPERTY_CAPABILITIES_PROPERTY_KEYS 
        let WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FORMAT_PROPERTIES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 8)
        
        /// [ Required ]  WPD_PROPERTY_CAPABILITIES_PROPERTY_ATTRIBUTES 
        let WPD_COMMAND_CAPABILITIES_GET_FIXED_PROPERTY_ATTRIBUTES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 9)
        
        /// [ Required ]  WPD_PROPERTY_CAPABILITIES_SUPPORTED_EVENTS 
        let WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_EVENTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 10)
        
        /// [ Required ]  WPD_PROPERTY_CAPABILITIES_EVENT_OPTIONS 
        let WPD_COMMAND_CAPABILITIES_GET_EVENT_OPTIONS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 11)
        
        /// [ VT_UNKNOWN ] IPortableDeviceKeyCollection containing all commands a driver supports.
        let WPD_PROPERTY_CAPABILITIES_SUPPORTED_COMMANDS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 1001)
        
        /// [ VT_UNKNOWN ] Indicates the command whose options the caller is interested in.
        let WPD_PROPERTY_CAPABILITIES_COMMAND = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 1002)
        
        /// [ VT_UNKNOWN ] Contains an IPortableDeviceValues with the relevant command options.
        let WPD_PROPERTY_CAPABILITIES_COMMAND_OPTIONS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 1003)
        
        /// [ VT_UNKNOWN ] An IPortableDevicePropVariantCollection of type VT_CLSID which indicates the functional categories supported by the driver.
        let WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_CATEGORIES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 1004)
        
        /// [ VT_CLSID ] The category the caller is interested in.
        let WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_CATEGORY = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 1005)
        
        /// [ VT_UNKNOWN ] An IPortableDevicePropVariantCollection (of type VT_LPWSTR) containing the ObjectIDs of the functional objects who belong to the specified functional category.
        let WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_OBJECTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 1006)
        
        /// [ VT_UNKNOWN ] Indicates list of content types supported for the specified functional category.
        let WPD_PROPERTY_CAPABILITIES_CONTENT_TYPES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 1007)
        
        /// [ VT_CLSID ] Indicates the content type whose formats the caller is interested in.
        let WPD_PROPERTY_CAPABILITIES_CONTENT_TYPE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 1008)
        
        /// [ VT_UNKNOWN ] An IPortableDevicePropVariantCollection of VT_CLSID values indicating the formats supported for the specified content type.
        let WPD_PROPERTY_CAPABILITIES_FORMATS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 1009)
        
        /// [ VT_CLSID ] Specifies the format the caller is interested in.
        let WPD_PROPERTY_CAPABILITIES_FORMAT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 1010)
        
        /// [ VT_UNKNOWN ] An IPortableDeviceKeyCollection containing the property keys.
        let WPD_PROPERTY_CAPABILITIES_PROPERTY_KEYS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 1011)
        
        /// [ VT_UNKNOWN ] An IPortableDeviceValues containing the property attributes.
        let WPD_PROPERTY_CAPABILITIES_PROPERTY_ATTRIBUTES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 1012)
        
        /// [ VT_UNKNOWN ] IPortableDevicePropVariantCollection of VT_CLSID values containing all events a driver supports.
        let WPD_PROPERTY_CAPABILITIES_SUPPORTED_EVENTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 1013)
        
        /// [ VT_CLSID ] Indicates the event the caller is interested in.
        let WPD_PROPERTY_CAPABILITIES_EVENT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 1014)
        
        /// [ VT_UNKNOWN ] Contains an IPortableDeviceValues with the relevant event options.
        let WPD_PROPERTY_CAPABILITIES_EVENT_OPTIONS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0CABEC78, int16 0x6B74, 
                                                                                 int16 0x41C6, byte 0x92, byte 0x16, 
                                                                                 byte 0x26, byte 0x39, byte 0xD1, 
                                                                                 byte 0xFC, byte 0xE3, byte 0x56), 
                                                         pid = uint32 1015)
    
    /// 
    module WPD_CATEGORY_COMMON = 
        /// 
        let WPD_COMMAND_COMMON_RESET_DEVICE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF0422A9C, int16 0x5DC8, 
                                                                                 int16 0x4440, byte 0xB5, byte 0xBD, 
                                                                                 byte 0x5D, byte 0xF2, byte 0x88, 
                                                                                 byte 0x35, byte 0x65, byte 0x8A), 
                                                         pid = uint32 2)
        
        /// [ Required ]  WPD_PROPERTY_COMMON_OBJECT_IDS 
        let WPD_COMMAND_COMMON_GET_OBJECT_IDS_FROM_PERSISTENT_UNIQUE_IDS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF0422A9C, int16 0x5DC8, 
                                                                                 int16 0x4440, byte 0xB5, byte 0xBD, 
                                                                                 byte 0x5D, byte 0xF2, byte 0x88, 
                                                                                 byte 0x35, byte 0x65, byte 0x8A), 
                                                         pid = uint32 3)
        
        /// [ Optional ]  WPD_PROPERTY_COMMON_CLIENT_INFORMATION_CONTEXT 
        let WPD_COMMAND_COMMON_SAVE_CLIENT_INFORMATION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF0422A9C, int16 0x5DC8, 
                                                                                 int16 0x4440, byte 0xB5, byte 0xBD, 
                                                                                 byte 0x5D, byte 0xF2, byte 0x88, 
                                                                                 byte 0x35, byte 0x65, byte 0x8A), 
                                                         pid = uint32 4)
        
        /// [ VT_CLSID ] Specifies the command Category (i.e. the GUID portion of the PROPERTYKEY indicating the command).
        let WPD_PROPERTY_COMMON_COMMAND_CATEGORY = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF0422A9C, int16 0x5DC8, 
                                                                                 int16 0x4440, byte 0xB5, byte 0xBD, 
                                                                                 byte 0x5D, byte 0xF2, byte 0x88, 
                                                                                 byte 0x35, byte 0x65, byte 0x8A), 
                                                         pid = uint32 1001)
        
        /// [ VT_UI4 ] Specifies the command ID, which is the PID portion of the PROPERTYKEY indicating the command.
        let WPD_PROPERTY_COMMON_COMMAND_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF0422A9C, int16 0x5DC8, 
                                                                                 int16 0x4440, byte 0xB5, byte 0xBD, 
                                                                                 byte 0x5D, byte 0xF2, byte 0x88, 
                                                                                 byte 0x35, byte 0x65, byte 0x8A), 
                                                         pid = uint32 1002)
        
        /// [ VT_ERROR ] The driver sets this to be the HRESULT of the requested operation.
        let WPD_PROPERTY_COMMON_HRESULT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF0422A9C, int16 0x5DC8, 
                                                                                 int16 0x4440, byte 0xB5, byte 0xBD, 
                                                                                 byte 0x5D, byte 0xF2, byte 0x88, 
                                                                                 byte 0x35, byte 0x65, byte 0x8A), 
                                                         pid = uint32 1003)
        
        /// [ VT_UI4 ] Special driver specific code which driver may return on error. Typically only for use with diagnostic tools or vertical solutions.
        let WPD_PROPERTY_COMMON_DRIVER_ERROR_CODE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF0422A9C, int16 0x5DC8, 
                                                                                 int16 0x4440, byte 0xB5, byte 0xBD, 
                                                                                 byte 0x5D, byte 0xF2, byte 0x88, 
                                                                                 byte 0x35, byte 0x65, byte 0x8A), 
                                                         pid = uint32 1004)
        
        /// [ VT_LPWSTR ] Identifies the object which the command is intended for.
        let WPD_PROPERTY_COMMON_COMMAND_TARGET = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF0422A9C, int16 0x5DC8, 
                                                                                 int16 0x4440, byte 0xB5, byte 0xBD, 
                                                                                 byte 0x5D, byte 0xF2, byte 0x88, 
                                                                                 byte 0x35, byte 0x65, byte 0x8A), 
                                                         pid = uint32 1006)
        
        /// [ VT_UNKNOWN ] IPortableDevicePropVariantCollection of type VT_LPWSTR specifying list of Persistent Unique IDs.
        let WPD_PROPERTY_COMMON_PERSISTENT_UNIQUE_IDS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF0422A9C, int16 0x5DC8, 
                                                                                 int16 0x4440, byte 0xB5, byte 0xBD, 
                                                                                 byte 0x5D, byte 0xF2, byte 0x88, 
                                                                                 byte 0x35, byte 0x65, byte 0x8A), 
                                                         pid = uint32 1007)
        
        /// [ VT_UNKNOWN ] IPortableDevicePropVariantCollection of type VT_LPWSTR specifying list of Objects IDs.
        let WPD_PROPERTY_COMMON_OBJECT_IDS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF0422A9C, int16 0x5DC8, 
                                                                                 int16 0x4440, byte 0xB5, byte 0xBD, 
                                                                                 byte 0x5D, byte 0xF2, byte 0x88, 
                                                                                 byte 0x35, byte 0x65, byte 0x8A), 
                                                         pid = uint32 1008)
        
        /// [ VT_UNKNOWN ] IPortableDeviceValues used to identify itself to the driver.
        let WPD_PROPERTY_COMMON_CLIENT_INFORMATION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF0422A9C, int16 0x5DC8, 
                                                                                 int16 0x4440, byte 0xB5, byte 0xBD, 
                                                                                 byte 0x5D, byte 0xF2, byte 0x88, 
                                                                                 byte 0x35, byte 0x65, byte 0x8A), 
                                                         pid = uint32 1009)
        
        /// [ VT_LPWSTR ] Driver specified context which will be sent for the particular client on all subsequent operations.
        let WPD_PROPERTY_COMMON_CLIENT_INFORMATION_CONTEXT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF0422A9C, int16 0x5DC8, 
                                                                                 int16 0x4440, byte 0xB5, byte 0xBD, 
                                                                                 byte 0x5D, byte 0xF2, byte 0x88, 
                                                                                 byte 0x35, byte 0x65, byte 0x8A), 
                                                         pid = uint32 1010)
        
        /// [ VT_CLSID ] An optional ActivityID set either by a client or by WPD API, when ETW tracing is enabled.
        let WPD_PROPERTY_COMMON_ACTIVITY_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF0422A9C, int16 0x5DC8, 
                                                                                 int16 0x4440, byte 0xB5, byte 0xBD, 
                                                                                 byte 0x5D, byte 0xF2, byte 0x88, 
                                                                                 byte 0x35, byte 0x65, byte 0x8A), 
                                                         pid = uint32 1011)
        
        /// [ VT_UNKNOWN ]  IPortableDevicePropVariantCollection of type VT_LPWSTR specifying list of Objects IDs of the objects that support the command. 
        let WPD_OPTION_VALID_OBJECT_IDS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF0422A9C, int16 0x5DC8, 
                                                                                 int16 0x4440, byte 0xB5, byte 0xBD, 
                                                                                 byte 0x5D, byte 0xF2, byte 0x88, 
                                                                                 byte 0x35, byte 0x65, byte 0x8A), 
                                                         pid = uint32 5001)
    
    /// The commands in this category relate to hints that a device can provide to improve end-user experience.
    module WPD_CATEGORY_DEVICE_HINTS = 
        /// [ Required ]  WPD_PROPERTY_DEVICE_HINTS_CONTENT_LOCATIONS 
        let WPD_COMMAND_DEVICE_HINTS_GET_CONTENT_LOCATION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0D5FB92B, int16 0xCB46, 
                                                                                 int16 0x4C4F, byte 0x83, byte 0x43, 
                                                                                 byte 0x0B, byte 0xC3, byte 0xD3, 
                                                                                 byte 0xF1, byte 0x7C, byte 0x84), 
                                                         pid = uint32 2)
        
        /// [ VT_CLSID ] Indicates the WPD content type that the caller is looking for. For example, to get the top-level folder objects that contain images, this parameter would be WPD_CONTENT_TYPE_IMAGE.
        let WPD_PROPERTY_DEVICE_HINTS_CONTENT_TYPE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0D5FB92B, int16 0xCB46, 
                                                                                 int16 0x4C4F, byte 0x83, byte 0x43, 
                                                                                 byte 0x0B, byte 0xC3, byte 0xD3, 
                                                                                 byte 0xF1, byte 0x7C, byte 0x84), 
                                                         pid = uint32 1001)
        
        /// [ VT_UNKNOWN ] IPortableDevicePropVariantCollection of type VT_LPWSTR indicating a list of folder ObjectIDs.
        let WPD_PROPERTY_DEVICE_HINTS_CONTENT_LOCATIONS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0D5FB92B, int16 0xCB46, 
                                                                                 int16 0x4C4F, byte 0x83, byte 0x43, 
                                                                                 byte 0x0B, byte 0xC3, byte 0xD3, 
                                                                                 byte 0xF1, byte 0x7C, byte 0x84), 
                                                         pid = uint32 1002)
    
    /// 
    module WPD_CATEGORY_MEDIA_CAPTURE = 
        /// [ Required ]  WPD_PROPERTY_COMMON_COMMAND_TARGET 
        let WPD_COMMAND_MEDIA_CAPTURE_START = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x59B433BA, int16 0xFE44, 
                                                                                 int16 0x4D8D, byte 0x80, byte 0x8C, 
                                                                                 byte 0x6B, byte 0xCB, byte 0x9B, 
                                                                                 byte 0x0F, byte 0x15, byte 0xE8), 
                                                         pid = uint32 2)
        
        /// [ Required ]  WPD_PROPERTY_COMMON_COMMAND_TARGET 
        let WPD_COMMAND_MEDIA_CAPTURE_STOP = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x59B433BA, int16 0xFE44, 
                                                                                 int16 0x4D8D, byte 0x80, byte 0x8C, 
                                                                                 byte 0x6B, byte 0xCB, byte 0x9B, 
                                                                                 byte 0x0F, byte 0x15, byte 0xE8), 
                                                         pid = uint32 3)
        
        /// [ Required ]  WPD_PROPERTY_COMMON_COMMAND_TARGET 
        let WPD_COMMAND_MEDIA_CAPTURE_PAUSE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x59B433BA, int16 0xFE44, 
                                                                                 int16 0x4D8D, byte 0x80, byte 0x8C, 
                                                                                 byte 0x6B, byte 0xCB, byte 0x9B, 
                                                                                 byte 0x0F, byte 0x15, byte 0xE8), 
                                                         pid = uint32 4)
    
    /// The commands in this category are used for Network Association and WiFi Configuration.
    module WPD_CATEGORY_NETWORK_CONFIGURATION = 
        /// [ Required ]  WPD_PROPERTY_PUBLIC_KEY 
        let WPD_COMMAND_GENERATE_KEYPAIR = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x78F9C6FC, int16 0x79B8, 
                                                                                 int16 0x473C, byte 0x90, byte 0x60, 
                                                                                 byte 0x6B, byte 0xD2, byte 0x3D, 
                                                                                 byte 0xD0, byte 0x72, byte 0xC4), 
                                                         pid = uint32 2)
        
        /// [ Required ]  WPD_PROPERTY_PUBLIC_KEY 
        let WPD_COMMAND_COMMIT_KEYPAIR = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x78F9C6FC, int16 0x79B8, 
                                                                                 int16 0x473C, byte 0x90, byte 0x60, 
                                                                                 byte 0x6B, byte 0xD2, byte 0x3D, 
                                                                                 byte 0xD0, byte 0x72, byte 0xC4), 
                                                         pid = uint32 3)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_OBJECT_ID 
        let WPD_COMMAND_PROCESS_WIRELESS_PROFILE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x78F9C6FC, int16 0x79B8, 
                                                                                 int16 0x473C, byte 0x90, byte 0x60, 
                                                                                 byte 0x6B, byte 0xD2, byte 0x3D, 
                                                                                 byte 0xD0, byte 0x72, byte 0xC4), 
                                                         pid = uint32 4)
        
        /// [ VT_VECTOR | VT_UI1 ] A public key generated for RSA key exchange.
        let WPD_PROPERTY_PUBLIC_KEY = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x78F9C6FC, int16 0x79B8, 
                                                                                 int16 0x473C, byte 0x90, byte 0x60, 
                                                                                 byte 0x6B, byte 0xD2, byte 0x3D, 
                                                                                 byte 0xD0, byte 0x72, byte 0xC4), 
                                                         pid = uint32 1001)
    
    /// This category is used exclusively for the NULL property key define.
    module WPD_CATEGORY_NULL = 
        /// [ VT_EMPTY ] A NULL property key.
        let WPD_PROPERTY_NULL = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x00000000, int16 0x0000, 
                                                                                 int16 0x0000, byte 0x00, byte 0x00, 
                                                                                 byte 0x00, byte 0x00, byte 0x00, 
                                                                                 byte 0x00, byte 0x00, byte 0x00), 
                                                         pid = uint32 0)
    
    /// The commands in this category are used for basic object enumeration.
    module WPD_CATEGORY_OBJECT_ENUMERATION = 
        /// [ Required ]  WPD_PROPERTY_OBJECT_ENUMERATION_CONTEXT 
        let WPD_COMMAND_OBJECT_ENUMERATION_START_FIND = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB7474E91, int16 0xE7F8, 
                                                                                 int16 0x4AD9, byte 0xB4, byte 0x00, 
                                                                                 byte 0xAD, byte 0x1A, byte 0x4B, 
                                                                                 byte 0x58, byte 0xEE, byte 0xEC), 
                                                         pid = uint32 2)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_ENUMERATION_OBJECT_IDS 
        let WPD_COMMAND_OBJECT_ENUMERATION_FIND_NEXT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB7474E91, int16 0xE7F8, 
                                                                                 int16 0x4AD9, byte 0xB4, byte 0x00, 
                                                                                 byte 0xAD, byte 0x1A, byte 0x4B, 
                                                                                 byte 0x58, byte 0xEE, byte 0xEC), 
                                                         pid = uint32 3)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_ENUMERATION_CONTEXT 
        let WPD_COMMAND_OBJECT_ENUMERATION_END_FIND = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB7474E91, int16 0xE7F8, 
                                                                                 int16 0x4AD9, byte 0xB4, byte 0x00, 
                                                                                 byte 0xAD, byte 0x1A, byte 0x4B, 
                                                                                 byte 0x58, byte 0xEE, byte 0xEC), 
                                                         pid = uint32 4)
        
        /// [ VT_LPWSTR ] The ObjectID specifying the parent object where enumeration should start.
        let WPD_PROPERTY_OBJECT_ENUMERATION_PARENT_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB7474E91, int16 0xE7F8, 
                                                                                 int16 0x4AD9, byte 0xB4, byte 0x00, 
                                                                                 byte 0xAD, byte 0x1A, byte 0x4B, 
                                                                                 byte 0x58, byte 0xEE, byte 0xEC), 
                                                         pid = uint32 1001)
        
        /// [ VT_UNKNOWN ] This is an IPortableDeviceValues which specifies the properties used to filter on. If the caller does not want filtering, then this value will not be set.
        let WPD_PROPERTY_OBJECT_ENUMERATION_FILTER = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB7474E91, int16 0xE7F8, 
                                                                                 int16 0x4AD9, byte 0xB4, byte 0x00, 
                                                                                 byte 0xAD, byte 0x1A, byte 0x4B, 
                                                                                 byte 0x58, byte 0xEE, byte 0xEC), 
                                                         pid = uint32 1002)
        
        /// [ VT_UNKNOWN ] This is an IPortableDevicePropVariantCollection of ObjectIDs (of type VT_LPWSTR). If 0 objects are returned, this should be an empty collection, not NULL.
        let WPD_PROPERTY_OBJECT_ENUMERATION_OBJECT_IDS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB7474E91, int16 0xE7F8, 
                                                                                 int16 0x4AD9, byte 0xB4, byte 0x00, 
                                                                                 byte 0xAD, byte 0x1A, byte 0x4B, 
                                                                                 byte 0x58, byte 0xEE, byte 0xEC), 
                                                         pid = uint32 1003)
        
        /// [ VT_LPWSTR ] This is a driver-specified identifier for the context associated with this enumeration.
        let WPD_PROPERTY_OBJECT_ENUMERATION_CONTEXT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB7474E91, int16 0xE7F8, 
                                                                                 int16 0x4AD9, byte 0xB4, byte 0x00, 
                                                                                 byte 0xAD, byte 0x1A, byte 0x4B, 
                                                                                 byte 0x58, byte 0xEE, byte 0xEC), 
                                                         pid = uint32 1004)
        
        /// [ VT_UI4 ] The maximum number of ObjectIDs to return back to the client.
        let WPD_PROPERTY_OBJECT_ENUMERATION_NUM_OBJECTS_REQUESTED = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB7474E91, int16 0xE7F8, 
                                                                                 int16 0x4AD9, byte 0xB4, byte 0x00, 
                                                                                 byte 0xAD, byte 0x1A, byte 0x4B, 
                                                                                 byte 0x58, byte 0xEE, byte 0xEC), 
                                                         pid = uint32 1005)
    
    /// The commands specified in this category are used to Create/Delete objects on the device.
    module WPD_CATEGORY_OBJECT_MANAGEMENT = 
        /// [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_ID 
        let WPD_COMMAND_OBJECT_MANAGEMENT_CREATE_OBJECT_WITH_PROPERTIES_ONLY = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 2)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_CONTEXT 
        let WPD_COMMAND_OBJECT_MANAGEMENT_CREATE_OBJECT_WITH_PROPERTIES_AND_DATA = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 3)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_NUM_BYTES_WRITTEN 
        let WPD_COMMAND_OBJECT_MANAGEMENT_WRITE_OBJECT_DATA = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 4)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_ID 
        let WPD_COMMAND_OBJECT_MANAGEMENT_COMMIT_OBJECT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 5)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_CONTEXT 
        let WPD_COMMAND_OBJECT_MANAGEMENT_REVERT_OBJECT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 6)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_DELETE_RESULTS 
        let WPD_COMMAND_OBJECT_MANAGEMENT_DELETE_OBJECTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 7)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_MOVE_RESULTS 
        let WPD_COMMAND_OBJECT_MANAGEMENT_MOVE_OBJECTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 8)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_COPY_RESULTS 
        let WPD_COMMAND_OBJECT_MANAGEMENT_COPY_OBJECTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 9)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_OPTIMAL_TRANSFER_BUFFER_SIZE 
        let WPD_COMMAND_OBJECT_MANAGEMENT_UPDATE_OBJECT_WITH_PROPERTIES_AND_DATA = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 10)
        
        /// [ VT_UNKNOWN ] This is an IPortableDeviceValues which specifies the properties used to create the new object.
        let WPD_PROPERTY_OBJECT_MANAGEMENT_CREATION_PROPERTIES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 1001)
        
        /// [ VT_LPWSTR ] This is a driver-specified identifier for the context associated with this 'create object' operation.
        let WPD_PROPERTY_OBJECT_MANAGEMENT_CONTEXT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 1002)
        
        /// [ VT_UI4 ] Specifies the number of bytes the client is requesting to write.
        let WPD_PROPERTY_OBJECT_MANAGEMENT_NUM_BYTES_TO_WRITE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 1003)
        
        /// [ VT_UI4 ] Indicates the number of bytes written for the object.
        let WPD_PROPERTY_OBJECT_MANAGEMENT_NUM_BYTES_WRITTEN = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 1004)
        
        /// [ VT_VECTOR | VT_UI1 ] Indicates binary data of the object being created on the device.
        let WPD_PROPERTY_OBJECT_MANAGEMENT_DATA = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 1005)
        
        /// [ VT_LPWSTR ] Identifies a newly created object on the device.
        let WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 1006)
        
        /// [ VT_UI4 ] Indicates if the delete operation should be recursive or not.
        let WPD_PROPERTY_OBJECT_MANAGEMENT_DELETE_OPTIONS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 1007)
        
        /// [ VT_UI4 ] Indicates the optimal transfer buffer size (in bytes) that clients should use when writing this object's data.
        let WPD_PROPERTY_OBJECT_MANAGEMENT_OPTIMAL_TRANSFER_BUFFER_SIZE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 1008)
        
        /// [ VT_UNKNOWN ] IPortableDevicePropVariantCollection of type VT_LPWSTR, containing the ObjectIDs to delete.
        let WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_IDS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 1009)
        
        /// [ VT_UNKNOWN ] IPortableDevicePropVariantCollection of type VT_ERROR, where each element is the HRESULT indicating the success or failure of the operation.
        let WPD_PROPERTY_OBJECT_MANAGEMENT_DELETE_RESULTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 1010)
        
        /// [ VT_LPWSTR ] Indicates the destination folder for the move operation.
        let WPD_PROPERTY_OBJECT_MANAGEMENT_DESTINATION_FOLDER_OBJECT_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 1011)
        
        /// [ VT_UNKNOWN ] IPortableDevicePropVariantCollection of type VT_ERROR, where each element is the HRESULT indicating the success or failure of the operation.
        let WPD_PROPERTY_OBJECT_MANAGEMENT_MOVE_RESULTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 1012)
        
        /// [ VT_UNKNOWN ] IPortableDevicePropVariantCollection of type VT_ERROR, where each element is the HRESULT indicating the success or failure of the operation.
        let WPD_PROPERTY_OBJECT_MANAGEMENT_COPY_RESULTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 1013)
        
        /// [ VT_UNKNOWN ] IPortableDeviceValues containing the object properties to update.
        let WPD_PROPERTY_OBJECT_MANAGEMENT_UPDATE_PROPERTIES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 1014)
        
        /// [ VT_UNKNOWN ] IPortableDeviceKeyCollection containing the property keys required to update this object.
        let WPD_PROPERTY_OBJECT_MANAGEMENT_PROPERTY_KEYS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 1015)
        
        /// [ VT_CLSID ] Indicates the object format the caller is interested in.
        let WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_FORMAT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 1016)
        
        /// [ VT_BOOL ]  Indicates whether the driver supports recursive deletion. 
        let WPD_OPTION_OBJECT_MANAGEMENT_RECURSIVE_DELETE_SUPPORTED = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF1E43DD, int16 0xA9ED, 
                                                                                 int16 0x4341, byte 0x8B, byte 0xCC, 
                                                                                 byte 0x18, byte 0x61, byte 0x92, 
                                                                                 byte 0xAE, byte 0xA0, byte 0x89), 
                                                         pid = uint32 5001)
    
    /// This category of commands is used to perform basic property operations such as Reading/Writing values, listing supported values and so on.
    module WPD_CATEGORY_OBJECT_PROPERTIES = 
        /// [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_KEYS 
        let WPD_COMMAND_OBJECT_PROPERTIES_GET_SUPPORTED = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x9E5582E4, int16 0x0814, 
                                                                                 int16 0x44E6, byte 0x98, byte 0x1A, 
                                                                                 byte 0xB2, byte 0x99, byte 0x8D, 
                                                                                 byte 0x58, byte 0x38, byte 0x04), 
                                                         pid = uint32 2)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_ATTRIBUTES 
        let WPD_COMMAND_OBJECT_PROPERTIES_GET_ATTRIBUTES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x9E5582E4, int16 0x0814, 
                                                                                 int16 0x44E6, byte 0x98, byte 0x1A, 
                                                                                 byte 0xB2, byte 0x99, byte 0x8D, 
                                                                                 byte 0x58, byte 0x38, byte 0x04), 
                                                         pid = uint32 3)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_VALUES 
        let WPD_COMMAND_OBJECT_PROPERTIES_GET = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x9E5582E4, int16 0x0814, 
                                                                                 int16 0x44E6, byte 0x98, byte 0x1A, 
                                                                                 byte 0xB2, byte 0x99, byte 0x8D, 
                                                                                 byte 0x58, byte 0x38, byte 0x04), 
                                                         pid = uint32 4)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_WRITE_RESULTS 
        let WPD_COMMAND_OBJECT_PROPERTIES_SET = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x9E5582E4, int16 0x0814, 
                                                                                 int16 0x44E6, byte 0x98, byte 0x1A, 
                                                                                 byte 0xB2, byte 0x99, byte 0x8D, 
                                                                                 byte 0x58, byte 0x38, byte 0x04), 
                                                         pid = uint32 5)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_VALUES 
        let WPD_COMMAND_OBJECT_PROPERTIES_GET_ALL = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x9E5582E4, int16 0x0814, 
                                                                                 int16 0x44E6, byte 0x98, byte 0x1A, 
                                                                                 byte 0xB2, byte 0x99, byte 0x8D, 
                                                                                 byte 0x58, byte 0x38, byte 0x04), 
                                                         pid = uint32 6)
        
        /// [ Optional ]  WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_DELETE_RESULTS 
        let WPD_COMMAND_OBJECT_PROPERTIES_DELETE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x9E5582E4, int16 0x0814, 
                                                                                 int16 0x44E6, byte 0x98, byte 0x1A, 
                                                                                 byte 0xB2, byte 0x99, byte 0x8D, 
                                                                                 byte 0x58, byte 0x38, byte 0x04), 
                                                         pid = uint32 7)
        
        /// [ VT_LPWSTR ] The ObjectID specifying the object whose properties are being queried/manipulated.
        let WPD_PROPERTY_OBJECT_PROPERTIES_OBJECT_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x9E5582E4, int16 0x0814, 
                                                                                 int16 0x44E6, byte 0x98, byte 0x1A, 
                                                                                 byte 0xB2, byte 0x99, byte 0x8D, 
                                                                                 byte 0x58, byte 0x38, byte 0x04), 
                                                         pid = uint32 1001)
        
        /// [ VT_UNKNOWN ] An IPortableDeviceKeyCollection identifying which specific property values we are querying/manipulating.
        let WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_KEYS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x9E5582E4, int16 0x0814, 
                                                                                 int16 0x44E6, byte 0x98, byte 0x1A, 
                                                                                 byte 0xB2, byte 0x99, byte 0x8D, 
                                                                                 byte 0x58, byte 0x38, byte 0x04), 
                                                         pid = uint32 1002)
        
        /// [ VT_UNKNOWN ] This is an IPortableDeviceValues which contains the attributes for each property requested.
        let WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_ATTRIBUTES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x9E5582E4, int16 0x0814, 
                                                                                 int16 0x44E6, byte 0x98, byte 0x1A, 
                                                                                 byte 0xB2, byte 0x99, byte 0x8D, 
                                                                                 byte 0x58, byte 0x38, byte 0x04), 
                                                         pid = uint32 1003)
        
        /// [ VT_UNKNOWN ] This is an IPortableDeviceValues which contains the values read. For any property whose value could not be read, the type must be set to VT_ERROR, and the 'scode' field must contain the failure HRESULT.
        let WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_VALUES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x9E5582E4, int16 0x0814, 
                                                                                 int16 0x44E6, byte 0x98, byte 0x1A, 
                                                                                 byte 0xB2, byte 0x99, byte 0x8D, 
                                                                                 byte 0x58, byte 0x38, byte 0x04), 
                                                         pid = uint32 1004)
        
        /// [ VT_UNKNOWN ] This is an IPortableDeviceValues which contains the result of each property write operation.
        let WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_WRITE_RESULTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x9E5582E4, int16 0x0814, 
                                                                                 int16 0x44E6, byte 0x98, byte 0x1A, 
                                                                                 byte 0xB2, byte 0x99, byte 0x8D, 
                                                                                 byte 0x58, byte 0x38, byte 0x04), 
                                                         pid = uint32 1005)
        
        /// [ VT_UNKNOWN ] This is an IPortableDeviceValues which contains the result of each property delete operation.
        let WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_DELETE_RESULTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x9E5582E4, int16 0x0814, 
                                                                                 int16 0x44E6, byte 0x98, byte 0x1A, 
                                                                                 byte 0xB2, byte 0x99, byte 0x8D, 
                                                                                 byte 0x58, byte 0x38, byte 0x04), 
                                                         pid = uint32 1006)
    
    /// This category contains commands and properties for property operations across multiple objects.
    module WPD_CATEGORY_OBJECT_PROPERTIES_BULK = 
        /// [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT 
        let WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_LIST_START = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x11C824DD, int16 0x04CD, 
                                                                                 int16 0x4E4E, byte 0x8C, byte 0x7B, 
                                                                                 byte 0xF6, byte 0xEF, byte 0xB7, 
                                                                                 byte 0x94, byte 0xD8, byte 0x4E), 
                                                         pid = uint32 2)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_VALUES 
        let WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_LIST_NEXT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x11C824DD, int16 0x04CD, 
                                                                                 int16 0x4E4E, byte 0x8C, byte 0x7B, 
                                                                                 byte 0xF6, byte 0xEF, byte 0xB7, 
                                                                                 byte 0x94, byte 0xD8, byte 0x4E), 
                                                         pid = uint32 3)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT 
        let WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_LIST_END = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x11C824DD, int16 0x04CD, 
                                                                                 int16 0x4E4E, byte 0x8C, byte 0x7B, 
                                                                                 byte 0xF6, byte 0xEF, byte 0xB7, 
                                                                                 byte 0x94, byte 0xD8, byte 0x4E), 
                                                         pid = uint32 4)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT 
        let WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_FORMAT_START = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x11C824DD, int16 0x04CD, 
                                                                                 int16 0x4E4E, byte 0x8C, byte 0x7B, 
                                                                                 byte 0xF6, byte 0xEF, byte 0xB7, 
                                                                                 byte 0x94, byte 0xD8, byte 0x4E), 
                                                         pid = uint32 5)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_VALUES 
        let WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_FORMAT_NEXT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x11C824DD, int16 0x04CD, 
                                                                                 int16 0x4E4E, byte 0x8C, byte 0x7B, 
                                                                                 byte 0xF6, byte 0xEF, byte 0xB7, 
                                                                                 byte 0x94, byte 0xD8, byte 0x4E), 
                                                         pid = uint32 6)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT 
        let WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_FORMAT_END = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x11C824DD, int16 0x04CD, 
                                                                                 int16 0x4E4E, byte 0x8C, byte 0x7B, 
                                                                                 byte 0xF6, byte 0xEF, byte 0xB7, 
                                                                                 byte 0x94, byte 0xD8, byte 0x4E), 
                                                         pid = uint32 7)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT 
        let WPD_COMMAND_OBJECT_PROPERTIES_BULK_SET_VALUES_BY_OBJECT_LIST_START = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x11C824DD, int16 0x04CD, 
                                                                                 int16 0x4E4E, byte 0x8C, byte 0x7B, 
                                                                                 byte 0xF6, byte 0xEF, byte 0xB7, 
                                                                                 byte 0x94, byte 0xD8, byte 0x4E), 
                                                         pid = uint32 8)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_WRITE_RESULTS 
        let WPD_COMMAND_OBJECT_PROPERTIES_BULK_SET_VALUES_BY_OBJECT_LIST_NEXT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x11C824DD, int16 0x04CD, 
                                                                                 int16 0x4E4E, byte 0x8C, byte 0x7B, 
                                                                                 byte 0xF6, byte 0xEF, byte 0xB7, 
                                                                                 byte 0x94, byte 0xD8, byte 0x4E), 
                                                         pid = uint32 9)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT 
        let WPD_COMMAND_OBJECT_PROPERTIES_BULK_SET_VALUES_BY_OBJECT_LIST_END = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x11C824DD, int16 0x04CD, 
                                                                                 int16 0x4E4E, byte 0x8C, byte 0x7B, 
                                                                                 byte 0xF6, byte 0xEF, byte 0xB7, 
                                                                                 byte 0x94, byte 0xD8, byte 0x4E), 
                                                         pid = uint32 10)
        
        /// [ VT_UNKNOWN ] A collection of ObjectIDs for which supported property list must be returned.
        let WPD_PROPERTY_OBJECT_PROPERTIES_BULK_OBJECT_IDS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x11C824DD, int16 0x04CD, 
                                                                                 int16 0x4E4E, byte 0x8C, byte 0x7B, 
                                                                                 byte 0xF6, byte 0xEF, byte 0xB7, 
                                                                                 byte 0x94, byte 0xD8, byte 0x4E), 
                                                         pid = uint32 1001)
        
        /// [ VT_LPWSTR ] The driver-specified context identifying this particular bulk operation.
        let WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x11C824DD, int16 0x04CD, 
                                                                                 int16 0x4E4E, byte 0x8C, byte 0x7B, 
                                                                                 byte 0xF6, byte 0xEF, byte 0xB7, 
                                                                                 byte 0x94, byte 0xD8, byte 0x4E), 
                                                         pid = uint32 1002)
        
        /// [ VT_UNKNOWN ] Contains an IPortableDeviceValuesCollection specifying the next set of IPortableDeviceValues elements.
        let WPD_PROPERTY_OBJECT_PROPERTIES_BULK_VALUES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x11C824DD, int16 0x04CD, 
                                                                                 int16 0x4E4E, byte 0x8C, byte 0x7B, 
                                                                                 byte 0xF6, byte 0xEF, byte 0xB7, 
                                                                                 byte 0x94, byte 0xD8, byte 0x4E), 
                                                         pid = uint32 1003)
        
        /// [ VT_UNKNOWN ] Contains an IPortableDeviceKeyCollection specifying which properties the caller wants to return. May not exist, which indicates caller wants ALL properties.
        let WPD_PROPERTY_OBJECT_PROPERTIES_BULK_PROPERTY_KEYS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x11C824DD, int16 0x04CD, 
                                                                                 int16 0x4E4E, byte 0x8C, byte 0x7B, 
                                                                                 byte 0xF6, byte 0xEF, byte 0xB7, 
                                                                                 byte 0x94, byte 0xD8, byte 0x4E), 
                                                         pid = uint32 1004)
        
        /// [ VT_UI4 ] Contains a value specifying the hierarchical depth from the parent to include in this operation.
        let WPD_PROPERTY_OBJECT_PROPERTIES_BULK_DEPTH = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x11C824DD, int16 0x04CD, 
                                                                                 int16 0x4E4E, byte 0x8C, byte 0x7B, 
                                                                                 byte 0xF6, byte 0xEF, byte 0xB7, 
                                                                                 byte 0x94, byte 0xD8, byte 0x4E), 
                                                         pid = uint32 1005)
        
        /// [ VT_LPWSTR ] Contains the ObjectID of the object to start the operation from.
        let WPD_PROPERTY_OBJECT_PROPERTIES_BULK_PARENT_OBJECT_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x11C824DD, int16 0x04CD, 
                                                                                 int16 0x4E4E, byte 0x8C, byte 0x7B, 
                                                                                 byte 0xF6, byte 0xEF, byte 0xB7, 
                                                                                 byte 0x94, byte 0xD8, byte 0x4E), 
                                                         pid = uint32 1006)
        
        /// [ VT_CLSID ] Specifies the object format the client is interested in.
        let WPD_PROPERTY_OBJECT_PROPERTIES_BULK_OBJECT_FORMAT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x11C824DD, int16 0x04CD, 
                                                                                 int16 0x4E4E, byte 0x8C, byte 0x7B, 
                                                                                 byte 0xF6, byte 0xEF, byte 0xB7, 
                                                                                 byte 0x94, byte 0xD8, byte 0x4E), 
                                                         pid = uint32 1007)
        
        /// [ VT_UNKNOWN ] Contains an IPortableDeviceValuesCollection specifying the set of IPortableDeviceValues elements indicating the write results for each property set.
        let WPD_PROPERTY_OBJECT_PROPERTIES_BULK_WRITE_RESULTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x11C824DD, int16 0x04CD, 
                                                                                 int16 0x4E4E, byte 0x8C, byte 0x7B, 
                                                                                 byte 0xF6, byte 0xEF, byte 0xB7, 
                                                                                 byte 0x94, byte 0xD8, byte 0x4E), 
                                                         pid = uint32 1008)
    
    /// The commands in this category are used for basic object resource enumeration and transfer.
    module WPD_CATEGORY_OBJECT_RESOURCES = 
        /// [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_KEYS 
        let WPD_COMMAND_OBJECT_RESOURCES_GET_SUPPORTED = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 2)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_ATTRIBUTES 
        let WPD_COMMAND_OBJECT_RESOURCES_GET_ATTRIBUTES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 3)
        
        /// [ Optional ]  WPD_PROPERTY_OBJECT_RESOURCES_SUPPORTS_UNITS 
        let WPD_COMMAND_OBJECT_RESOURCES_OPEN = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 4)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_DATA 
        let WPD_COMMAND_OBJECT_RESOURCES_READ = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 5)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_WRITTEN 
        let WPD_COMMAND_OBJECT_RESOURCES_WRITE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 6)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_CONTEXT 
        let WPD_COMMAND_OBJECT_RESOURCES_CLOSE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 7)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_KEYS 
        let WPD_COMMAND_OBJECT_RESOURCES_DELETE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 8)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_OPTIMAL_TRANSFER_BUFFER_SIZE 
        let WPD_COMMAND_OBJECT_RESOURCES_CREATE_RESOURCE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 9)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_CONTEXT 
        let WPD_COMMAND_OBJECT_RESOURCES_REVERT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 10)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_POSITION_FROM_START 
        let WPD_COMMAND_OBJECT_RESOURCES_SEEK = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 11)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_CONTEXT 
        let WPD_COMMAND_OBJECT_RESOURCES_COMMIT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 12)
        
        /// [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_POSITION_FROM_START 
        let WPD_COMMAND_OBJECT_RESOURCES_SEEK_IN_UNITS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 13)
        
        /// [ VT_LPWSTR ] 
        let WPD_PROPERTY_OBJECT_RESOURCES_OBJECT_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 1001)
        
        /// [ VT_UI4 ] Specifies the type of access the client is requesting for the resource.
        let WPD_PROPERTY_OBJECT_RESOURCES_ACCESS_MODE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 1002)
        
        /// [ VT_UNKNOWN ] 
        let WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_KEYS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 1003)
        
        /// [ VT_UNKNOWN ] This is an IPortableDeviceValues which contains the attributes for the resource requested.
        let WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_ATTRIBUTES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 1004)
        
        /// [ VT_LPWSTR ] This is a driver-specified identifier for the context associated with the resource operation.
        let WPD_PROPERTY_OBJECT_RESOURCES_CONTEXT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 1005)
        
        /// [ VT_UI4 ] Specifies the number of bytes the client is requesting to read.
        let WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_TO_READ = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 1006)
        
        /// [ VT_UI4 ] Specifies the number of bytes actually read from the resource.
        let WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_READ = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 1007)
        
        /// [ VT_UI4 ] Specifies the number of bytes the client is requesting to write.
        let WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_TO_WRITE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 1008)
        
        /// [ VT_UI4 ] Driver sets this to let caller know how many bytes were actually written.
        let WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_WRITTEN = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 1009)
        
        /// [ VT_VECTOR | VT_UI1 ] 
        let WPD_PROPERTY_OBJECT_RESOURCES_DATA = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 1010)
        
        /// [ VT_UI4 ] Indicates the optimal transfer buffer size (in bytes) that clients should use when reading/writing this resource.
        let WPD_PROPERTY_OBJECT_RESOURCES_OPTIMAL_TRANSFER_BUFFER_SIZE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 1011)
        
        /// [ VT_I8 ] Displacement to be added to the location indicated by the WPD_PROPERTY_OBJECT_RESOURCES_SEEK_ORIGIN_FLAG parameter.
        let WPD_PROPERTY_OBJECT_RESOURCES_SEEK_OFFSET = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 1012)
        
        /// [ VT_UI4 ] Specifies the origin of the displacement for the seek operation.
        let WPD_PROPERTY_OBJECT_RESOURCES_SEEK_ORIGIN_FLAG = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 1013)
        
        /// [ VT_UI8 ] Value of the new seek pointer from the beginning of the data stream.
        let WPD_PROPERTY_OBJECT_RESOURCES_POSITION_FROM_START = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 1014)
        
        /// [ VT_BOOL ] A Boolean value that specifies whether this resource supports operations (such as seek) using alternate units. This occurs if the driver can understand WPD_COMMAND_OBJECT_RESOURCES_SEEK_IN_UNITS.
        let WPD_PROPERTY_OBJECT_RESOURCES_SUPPORTS_UNITS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 1015)
        
        /// [ VT_UI4 ] The units for the WPD_PROPERTY_OBJECT_SEEK_OFFSET parameter and the WPD_PROPERTY_OBJECT_RESOURCES_POSITION_FROM_START result.
        let WPD_PROPERTY_OBJECT_RESOURCES_STREAM_UNITS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 1016)
        
        /// [ VT_BOOL ]  Indicates whether the driver can Seek on a resource opened for Read access. 
        let WPD_OPTION_OBJECT_RESOURCES_SEEK_ON_READ_SUPPORTED = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 5001)
        
        /// [ VT_BOOL ]  Indicates whether the driver can Seek on a resource opened for Write access. 
        let WPD_OPTION_OBJECT_RESOURCES_SEEK_ON_WRITE_SUPPORTED = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 5002)
        
        /// [ VT_BOOL ]  Indicates whether the driver requires an input buffer for WPD_COMMAND_OBJECT_RESOURCES_READ. If not set, defaults to False. 
        let WPD_OPTION_OBJECT_RESOURCES_NO_INPUT_BUFFER_ON_READ = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3A2B22D, int16 0xA595, 
                                                                                 int16 0x4108, byte 0xBE, byte 0x0A, 
                                                                                 byte 0xFC, byte 0x3C, byte 0x96, 
                                                                                 byte 0x5F, byte 0x3D, byte 0x4A), 
                                                         pid = uint32 5003)
    
    /// The commands in this category relate to capabilities of a device service.
    module WPD_CATEGORY_SERVICE_CAPABILITIES = 
        /// [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_SUPPORTED_METHODS 
        let WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_METHODS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 2)
        
        /// [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_SUPPORTED_METHODS 
        let WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_METHODS_BY_FORMAT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 3)
        
        /// [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_METHOD_ATTRIBUTES 
        let WPD_COMMAND_SERVICE_CAPABILITIES_GET_METHOD_ATTRIBUTES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 4)
        
        /// [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_PARAMETER_ATTRIBUTES 
        let WPD_COMMAND_SERVICE_CAPABILITIES_GET_METHOD_PARAMETER_ATTRIBUTES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 5)
        
        /// [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_FORMATS 
        let WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_FORMATS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 6)
        
        /// [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_FORMAT_ATTRIBUTES 
        let WPD_COMMAND_SERVICE_CAPABILITIES_GET_FORMAT_ATTRIBUTES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 7)
        
        /// [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_PROPERTY_KEYS 
        let WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_FORMAT_PROPERTIES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 8)
        
        /// [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_PROPERTY_ATTRIBUTES 
        let WPD_COMMAND_SERVICE_CAPABILITIES_GET_FORMAT_PROPERTY_ATTRIBUTES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 9)
        
        /// [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_SUPPORTED_EVENTS 
        let WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_EVENTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 10)
        
        /// [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_EVENT_ATTRIBUTES 
        let WPD_COMMAND_SERVICE_CAPABILITIES_GET_EVENT_ATTRIBUTES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 11)
        
        /// [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_PARAMETER_ATTRIBUTES 
        let WPD_COMMAND_SERVICE_CAPABILITIES_GET_EVENT_PARAMETER_ATTRIBUTES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 12)
        
        /// [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_INHERITED_SERVICES 
        let WPD_COMMAND_SERVICE_CAPABILITIES_GET_INHERITED_SERVICES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 13)
        
        /// [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_RENDERING_PROFILES 
        let WPD_COMMAND_SERVICE_CAPABILITIES_GET_FORMAT_RENDERING_PROFILES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 14)
        
        /// [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_SUPPORTED_COMMANDS 
        let WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_COMMANDS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 15)
        
        /// [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_COMMAND_OPTIONS 
        let WPD_COMMAND_SERVICE_CAPABILITIES_GET_COMMAND_OPTIONS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 16)
        
        /// [ VT_UNKNOWN ] IPortableDevicePropVariantCollection (of type VT_CLSID) containing methods that apply to a service.
        let WPD_PROPERTY_SERVICE_CAPABILITIES_SUPPORTED_METHODS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 1001)
        
        /// [ VT_CLSID ] Indicates the format the caller is interested in.
        let WPD_PROPERTY_SERVICE_CAPABILITIES_FORMAT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 1002)
        
        /// [ VT_CLSID ] Indicates the method the caller is interested in.
        let WPD_PROPERTY_SERVICE_CAPABILITIES_METHOD = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 1003)
        
        /// [ VT_UNKNOWN ] IPortableDeviceValues containing the method attributes.
        let WPD_PROPERTY_SERVICE_CAPABILITIES_METHOD_ATTRIBUTES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 1004)
        
        /// [ VT_UNKNOWN ] IPortableDeviceKeyCollection containing the parameter the caller is interested in.
        let WPD_PROPERTY_SERVICE_CAPABILITIES_PARAMETER = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 1005)
        
        /// [ VT_UNKNOWN ] IPortableDeviceValues containing the parameter attributes.
        let WPD_PROPERTY_SERVICE_CAPABILITIES_PARAMETER_ATTRIBUTES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 1006)
        
        /// [ VT_UNKNOWN ] IPortableDevicePropVariantCollection (of type VT_CLSID) containing the formats.
        let WPD_PROPERTY_SERVICE_CAPABILITIES_FORMATS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 1007)
        
        /// [ VT_UNKNOWN ] IPortableDeviceValues containing the format attributes, such as the format name and MIME Type.
        let WPD_PROPERTY_SERVICE_CAPABILITIES_FORMAT_ATTRIBUTES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 1008)
        
        /// [ VT_UNKNOWN ] IPortableDeviceKeyCollection containing the supported property keys.
        let WPD_PROPERTY_SERVICE_CAPABILITIES_PROPERTY_KEYS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 1009)
        
        /// [ VT_UNKNOWN ] IPortableDeviceValues containing the property attributes.
        let WPD_PROPERTY_SERVICE_CAPABILITIES_PROPERTY_ATTRIBUTES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 1010)
        
        /// [ VT_UNKNOWN ] IPortableDevicePropVariantCollection (of type VT_CLSID) containing all events supported by the service.
        let WPD_PROPERTY_SERVICE_CAPABILITIES_SUPPORTED_EVENTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 1011)
        
        /// [ VT_CLSID ] Indicates the event the caller is interested in.
        let WPD_PROPERTY_SERVICE_CAPABILITIES_EVENT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 1012)
        
        /// [ VT_UNKNOWN ] IPortableDeviceValues containing the event attributes.
        let WPD_PROPERTY_SERVICE_CAPABILITIES_EVENT_ATTRIBUTES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 1013)
        
        /// [ VT_UI4 ] Indicates the inheritance type the caller is interested in.
        let WPD_PROPERTY_SERVICE_CAPABILITIES_INHERITANCE_TYPE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 1014)
        
        /// [ VT_UNKNOWN ] Contains the list of inherited services.
        let WPD_PROPERTY_SERVICE_CAPABILITIES_INHERITED_SERVICES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 1015)
        
        /// [ VT_UNKNOWN ] Contains the list of format rendering profiles.
        let WPD_PROPERTY_SERVICE_CAPABILITIES_RENDERING_PROFILES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 1016)
        
        /// [ VT_UNKNOWN ] IPortableDeviceKeyCollection containing all commands a driver supports for a service.
        let WPD_PROPERTY_SERVICE_CAPABILITIES_SUPPORTED_COMMANDS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 1017)
        
        /// [ VT_UNKNOWN ] Indicates the command whose options the caller is interested in.
        let WPD_PROPERTY_SERVICE_CAPABILITIES_COMMAND = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 1018)
        
        /// [ VT_UNKNOWN ] Contains an IPortableDeviceValues with the relevant command options.
        let WPD_PROPERTY_SERVICE_CAPABILITIES_COMMAND_OPTIONS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x24457E74, int16 0x2E9F, 
                                                                                 int16 0x44F9, byte 0x8C, byte 0x57, 
                                                                                 byte 0x1D, byte 0x1B, byte 0xCB, 
                                                                                 byte 0x17, byte 0x0B, byte 0x89), 
                                                         pid = uint32 1019)
    
    /// The commands in this category relate to a device service.
    module WPD_CATEGORY_SERVICE_COMMON = 
        /// [ Required ]  WPD_PROPERTY_SERVICE_OBJECT_ID 
        let WPD_COMMAND_SERVICE_COMMON_GET_SERVICE_OBJECT_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x322F071D, int16 0x36EF, 
                                                                                 int16 0x477F, byte 0xB4, byte 0xB5, 
                                                                                 byte 0x6F, byte 0x52, byte 0xD7, 
                                                                                 byte 0x34, byte 0xBA, byte 0xEE), 
                                                         pid = uint32 2)
        
        /// [ VT_LPWSTR ] Contains the service object identifier.
        let WPD_PROPERTY_SERVICE_OBJECT_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x322F071D, int16 0x36EF, 
                                                                                 int16 0x477F, byte 0xB4, byte 0xB5, 
                                                                                 byte 0x6F, byte 0x52, byte 0xD7, 
                                                                                 byte 0x34, byte 0xBA, byte 0xEE), 
                                                         pid = uint32 1001)
    
    /// The commands in this category relate to methods of a device service.
    module WPD_CATEGORY_SERVICE_METHODS = 
        /// [ Required ]  WPD_PROPERTY_SERVICE_METHOD_CONTEXT 
        let WPD_COMMAND_SERVICE_METHODS_START_INVOKE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2D521CA8, int16 0xC1B0, 
                                                                                 int16 0x4268, byte 0xA3, byte 0x42, 
                                                                                 byte 0xCF, byte 0x19, byte 0x32, 
                                                                                 byte 0x15, byte 0x69, byte 0xBC), 
                                                         pid = uint32 2)
        
        /// [ Required ]  WPD_PROPERTY_SERVICE_METHOD_CONTEXT 
        let WPD_COMMAND_SERVICE_METHODS_CANCEL_INVOKE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2D521CA8, int16 0xC1B0, 
                                                                                 int16 0x4268, byte 0xA3, byte 0x42, 
                                                                                 byte 0xCF, byte 0x19, byte 0x32, 
                                                                                 byte 0x15, byte 0x69, byte 0xBC), 
                                                         pid = uint32 3)
        
        /// [ Required ]  WPD_PROPERTY_SERVICE_METHOD_HRESULT 
        let WPD_COMMAND_SERVICE_METHODS_END_INVOKE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2D521CA8, int16 0xC1B0, 
                                                                                 int16 0x4268, byte 0xA3, byte 0x42, 
                                                                                 byte 0xCF, byte 0x19, byte 0x32, 
                                                                                 byte 0x15, byte 0x69, byte 0xBC), 
                                                         pid = uint32 4)
        
        /// [ VT_CLSID ] Indicates the method to invoke.
        let WPD_PROPERTY_SERVICE_METHOD = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2D521CA8, int16 0xC1B0, 
                                                                                 int16 0x4268, byte 0xA3, byte 0x42, 
                                                                                 byte 0xCF, byte 0x19, byte 0x32, 
                                                                                 byte 0x15, byte 0x69, byte 0xBC), 
                                                         pid = uint32 1001)
        
        /// [ VT_UNKNOWN ] IPortableDeviceValues containing the method parameters.
        let WPD_PROPERTY_SERVICE_METHOD_PARAMETER_VALUES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2D521CA8, int16 0xC1B0, 
                                                                                 int16 0x4268, byte 0xA3, byte 0x42, 
                                                                                 byte 0xCF, byte 0x19, byte 0x32, 
                                                                                 byte 0x15, byte 0x69, byte 0xBC), 
                                                         pid = uint32 1002)
        
        /// [ VT_UNKNOWN ] IPortableDeviceValues containing the method results.
        let WPD_PROPERTY_SERVICE_METHOD_RESULT_VALUES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2D521CA8, int16 0xC1B0, 
                                                                                 int16 0x4268, byte 0xA3, byte 0x42, 
                                                                                 byte 0xCF, byte 0x19, byte 0x32, 
                                                                                 byte 0x15, byte 0x69, byte 0xBC), 
                                                         pid = uint32 1003)
        
        /// [ VT_LPWSTR ] The unique context identifying this method operation.
        let WPD_PROPERTY_SERVICE_METHOD_CONTEXT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2D521CA8, int16 0xC1B0, 
                                                                                 int16 0x4268, byte 0xA3, byte 0x42, 
                                                                                 byte 0xCF, byte 0x19, byte 0x32, 
                                                                                 byte 0x15, byte 0x69, byte 0xBC), 
                                                         pid = uint32 1004)
        
        /// [ VT_ERROR ] Contains the status HRESULT of this method invocation.
        let WPD_PROPERTY_SERVICE_METHOD_HRESULT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2D521CA8, int16 0xC1B0, 
                                                                                 int16 0x4268, byte 0xA3, byte 0x42, 
                                                                                 byte 0xCF, byte 0x19, byte 0x32, 
                                                                                 byte 0x15, byte 0x69, byte 0xBC), 
                                                         pid = uint32 1005)
    
    /// The commands in this category relate to Short-Message-Service functionality, typically exposed on mobile phones.
    module WPD_CATEGORY_SMS = 
        /// [ Optional ]  WPD_PROPERTY_SMS_BINARY_MESSAGE 
        let WPD_COMMAND_SMS_SEND = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xAFC25D66, int16 0xFE0D, 
                                                                                 int16 0x4114, byte 0x90, byte 0x97, 
                                                                                 byte 0x97, byte 0x0C, byte 0x93, 
                                                                                 byte 0xE9, byte 0x20, byte 0xD1), 
                                                         pid = uint32 2)
        
        /// [ VT_LPWSTR ] Indicates the recipient's address.
        let WPD_PROPERTY_SMS_RECIPIENT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xAFC25D66, int16 0xFE0D, 
                                                                                 int16 0x4114, byte 0x90, byte 0x97, 
                                                                                 byte 0x97, byte 0x0C, byte 0x93, 
                                                                                 byte 0xE9, byte 0x20, byte 0xD1), 
                                                         pid = uint32 1001)
        
        /// [ VT_UI4 ] Indicates whether the message is binary or text.
        let WPD_PROPERTY_SMS_MESSAGE_TYPE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xAFC25D66, int16 0xFE0D, 
                                                                                 int16 0x4114, byte 0x90, byte 0x97, 
                                                                                 byte 0x97, byte 0x0C, byte 0x93, 
                                                                                 byte 0xE9, byte 0x20, byte 0xD1), 
                                                         pid = uint32 1002)
        
        /// [ VT_LPWSTR ] if WPD_PROPERTY_SMS_MESSAGE_TYPE == SMS_TEXT_MESSAGE, then this will contain the message body.
        let WPD_PROPERTY_SMS_TEXT_MESSAGE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xAFC25D66, int16 0xFE0D, 
                                                                                 int16 0x4114, byte 0x90, byte 0x97, 
                                                                                 byte 0x97, byte 0x0C, byte 0x93, 
                                                                                 byte 0xE9, byte 0x20, byte 0xD1), 
                                                         pid = uint32 1003)
        
        /// [ VT_VECTOR | VT_UI1 ] if WPD_PROPERTY_SMS_MESSAGE_TYPE == SMS_BINARY_MESSAGE, then this will contain the binary message body.
        let WPD_PROPERTY_SMS_BINARY_MESSAGE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xAFC25D66, int16 0xFE0D, 
                                                                                 int16 0x4114, byte 0x90, byte 0x97, 
                                                                                 byte 0x97, byte 0x0C, byte 0x93, 
                                                                                 byte 0xE9, byte 0x20, byte 0xD1), 
                                                         pid = uint32 1004)
        
        /// [ VT_BOOL ]  Indicates whether the driver can support binary messages as well as text messages. 
        let WPD_OPTION_SMS_BINARY_MESSAGE_SUPPORTED = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xAFC25D66, int16 0xFE0D, 
                                                                                 int16 0x4114, byte 0x90, byte 0x97, 
                                                                                 byte 0x97, byte 0x0C, byte 0x93, 
                                                                                 byte 0xE9, byte 0x20, byte 0xD1), 
                                                         pid = uint32 5001)
    
    /// 
    module WPD_CATEGORY_STILL_IMAGE_CAPTURE = 
        /// [ Required ]  WPD_PROPERTY_COMMON_COMMAND_TARGET 
        let WPD_COMMAND_STILL_IMAGE_CAPTURE_INITIATE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x4FCD6982, int16 0x22A2, 
                                                                                 int16 0x4B05, byte 0xA4, byte 0x8B, 
                                                                                 byte 0x62, byte 0xD3, byte 0x8B, 
                                                                                 byte 0xF2, byte 0x7B, byte 0x32), 
                                                         pid = uint32 2)
    
    /// This category is for commands and parameters for storage functional objects.
    module WPD_CATEGORY_STORAGE = 
        /// [ Required ]  WPD_PROPERTY_STORAGE_OBJECT_ID 
        let WPD_COMMAND_STORAGE_FORMAT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xD8F907A6, int16 0x34CC, 
                                                                                 int16 0x45FA, byte 0x97, byte 0xFB, 
                                                                                 byte 0xD0, byte 0x07, byte 0xFA, 
                                                                                 byte 0x47, byte 0xEC, byte 0x94), 
                                                         pid = uint32 2)
        
        /// [ Required ]  WPD_PROPERTY_STORAGE_OBJECT_ID 
        let WPD_COMMAND_STORAGE_EJECT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xD8F907A6, int16 0x34CC, 
                                                                                 int16 0x45FA, byte 0x97, byte 0xFB, 
                                                                                 byte 0xD0, byte 0x07, byte 0xFA, 
                                                                                 byte 0x47, byte 0xEC, byte 0x94), 
                                                         pid = uint32 4)
        
        /// [ VT_LPWSTR ] Indicates the object to format, move or eject.
        let WPD_PROPERTY_STORAGE_OBJECT_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xD8F907A6, int16 0x34CC, 
                                                                                 int16 0x45FA, byte 0x97, byte 0xFB, 
                                                                                 byte 0xD0, byte 0x07, byte 0xFA, 
                                                                                 byte 0x47, byte 0xEC, byte 0x94), 
                                                         pid = uint32 1001)
        
        /// [ VT_LPWSTR ] Indicates the (folder) object destination for a move operation.
        let WPD_PROPERTY_STORAGE_DESTINATION_OBJECT_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xD8F907A6, int16 0x34CC, 
                                                                                 int16 0x45FA, byte 0x97, byte 0xFB, 
                                                                                 byte 0xD0, byte 0x07, byte 0xFA, 
                                                                                 byte 0x47, byte 0xEC, byte 0x94), 
                                                         pid = uint32 1002)
    
    /// This category of properties relates to options used for the WPD device class extension
    module WPD_CLASS_EXTENSION_OPTIONS_V1 = 
        /// [ VT_UNKNOWN ] Indicates the (super-set) list of content types supported by the driver (similar to calling WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_CONTENT_TYPES on WPD_FUNCTIONAL_CATEGORY_ALL).
        let WPD_CLASS_EXTENSION_OPTIONS_SUPPORTED_CONTENT_TYPES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x6309FFEF, int16 0xA87C, 
                                                                                 int16 0x4CA7, byte 0x84, byte 0x34, 
                                                                                 byte 0x79, byte 0x75, byte 0x76, 
                                                                                 byte 0xE4, byte 0x0A, byte 0x96), 
                                                         pid = uint32 2)
        
        /// [ VT_BOOL ] Indicates that the caller does not want the WPD class extension library to register the WPD Device Class interface. The caller will take responsibility for doing it.
        let WPD_CLASS_EXTENSION_OPTIONS_DONT_REGISTER_WPD_DEVICE_INTERFACE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x6309FFEF, int16 0xA87C, 
                                                                                 int16 0x4CA7, byte 0x84, byte 0x34, 
                                                                                 byte 0x79, byte 0x75, byte 0x76, 
                                                                                 byte 0xE4, byte 0x0A, byte 0x96), 
                                                         pid = uint32 3)
        
        /// [ VT_BOOL ] Indicates that the caller wants the WPD class extension library to register the private WPD Device Class interface.
        let WPD_CLASS_EXTENSION_OPTIONS_REGISTER_WPD_PRIVATE_DEVICE_INTERFACE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x6309FFEF, int16 0xA87C, 
                                                                                 int16 0x4CA7, byte 0x84, byte 0x34, 
                                                                                 byte 0x79, byte 0x75, byte 0x76, 
                                                                                 byte 0xE4, byte 0x0A, byte 0x96), 
                                                         pid = uint32 4)
    
    /// This category of properties relates to options used for the WPD device class extension
    module WPD_CLASS_EXTENSION_OPTIONS_V2 = 
        /// [ VT_BOOL ] Indicates that the caller wants the WPD class extension library to go into Multi-Transport mode (if TRUE).
        let WPD_CLASS_EXTENSION_OPTIONS_MULTITRANSPORT_MODE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x3E3595DA, int16 0x4D71, 
                                                                                 int16 0x49FE, byte 0xA0, byte 0xB4, 
                                                                                 byte 0xD4, byte 0x40, byte 0x6C, 
                                                                                 byte 0x3A, byte 0xE9, byte 0x3F), 
                                                         pid = uint32 2)
        
        /// [ VT_UNKNOWN ] This is an IPortableDeviceValues which contains the device identification values (WPD_DEVICE_MANUFACTURER, WPD_DEVICE_MODEL, WPD_DEVICE_FIRMWARE_VERSION and WPD_DEVICE_FUNCTIONAL_UNIQUE_ID). Include this with other Class Extension options when initializing.
        let WPD_CLASS_EXTENSION_OPTIONS_DEVICE_IDENTIFICATION_VALUES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x3E3595DA, int16 0x4D71, 
                                                                                 int16 0x49FE, byte 0xA0, byte 0xB4, 
                                                                                 byte 0xD4, byte 0x40, byte 0x6C, 
                                                                                 byte 0x3A, byte 0xE9, byte 0x3F), 
                                                         pid = uint32 3)
        
        /// [ VT_UI4 ] Indicates the theoretical maximum bandwidth of the transport in kilobits per second.
        let WPD_CLASS_EXTENSION_OPTIONS_TRANSPORT_BANDWIDTH = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x3E3595DA, int16 0x4D71, 
                                                                                 int16 0x49FE, byte 0xA0, byte 0xB4, 
                                                                                 byte 0xD4, byte 0x40, byte 0x6C, 
                                                                                 byte 0x3A, byte 0xE9, byte 0x3F), 
                                                         pid = uint32 4)
    
    /// This category of properties relates to options used for the WPD device class extension
    module WPD_CLASS_EXTENSION_OPTIONS_V3 = 
        /// [ VT_BOOL ] Indicates that the caller wants Autoplay to be silent when the device is connected (if TRUE).
        let WPD_CLASS_EXTENSION_OPTIONS_SILENCE_AUTOPLAY = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x65C160F8, int16 0x1367, 
                                                                                 int16 0x4CE2, byte 0x93, byte 0x9D, 
                                                                                 byte 0x83, byte 0x10, byte 0x83, 
                                                                                 byte 0x9F, byte 0x0D, byte 0x30), 
                                                         pid = uint32 2)
    
    /// The commands in this category relate to the WPD device class extension.
    module WPD_CLASS_EXTENSION_V1 = 
        /// [ Required ]  WPD_PROPERTY_CLASS_EXTENSION_DEVICE_INFORMATION_WRITE_RESULTS 
        let WPD_COMMAND_CLASS_EXTENSION_WRITE_DEVICE_INFORMATION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x33FB0D11, int16 0x64A3, 
                                                                                 int16 0x4FAC, byte 0xB4, byte 0xC7, 
                                                                                 byte 0x3D, byte 0xFE, byte 0xAA, 
                                                                                 byte 0x99, byte 0xB0, byte 0x51), 
                                                         pid = uint32 2)
        
        /// [ VT_UNKNOWN ] This is an IPortableDeviceValues which contains the values.
        let WPD_PROPERTY_CLASS_EXTENSION_DEVICE_INFORMATION_VALUES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x33FB0D11, int16 0x64A3, 
                                                                                 int16 0x4FAC, byte 0xB4, byte 0xC7, 
                                                                                 byte 0x3D, byte 0xFE, byte 0xAA, 
                                                                                 byte 0x99, byte 0xB0, byte 0x51), 
                                                         pid = uint32 1001)
        
        /// [ VT_UNKNOWN ] This is an IPortableDeviceValues which contains the result of each value write operation.
        let WPD_PROPERTY_CLASS_EXTENSION_DEVICE_INFORMATION_WRITE_RESULTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x33FB0D11, int16 0x64A3, 
                                                                                 int16 0x4FAC, byte 0xB4, byte 0xC7, 
                                                                                 byte 0x3D, byte 0xFE, byte 0xAA, 
                                                                                 byte 0x99, byte 0xB0, byte 0x51), 
                                                         pid = uint32 1002)
    
    /// The commands in this category relate to the WPD device class extension.
    module WPD_CLASS_EXTENSION_V2 = 
        /// [ Required ]  WPD_PROPERTY_CLASS_EXTENSION_SERVICE_REGISTRATION_RESULTS 
        let WPD_COMMAND_CLASS_EXTENSION_REGISTER_SERVICE_INTERFACES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x7F0779B5, int16 0xFA2B, 
                                                                                 int16 0x4766, byte 0x9C, byte 0xB2, 
                                                                                 byte 0xF7, byte 0x3B, byte 0xA3, 
                                                                                 byte 0x0B, byte 0x67, byte 0x58), 
                                                         pid = uint32 2)
        
        /// [ Required ]  WPD_PROPERTY_CLASS_EXTENSION_SERVICE_REGISTRATION_RESULTS 
        let WPD_COMMAND_CLASS_EXTENSION_UNREGISTER_SERVICE_INTERFACES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x7F0779B5, int16 0xFA2B, 
                                                                                 int16 0x4766, byte 0x9C, byte 0xB2, 
                                                                                 byte 0xF7, byte 0x3B, byte 0xA3, 
                                                                                 byte 0x0B, byte 0x67, byte 0x58), 
                                                         pid = uint32 3)
        
        /// [ VT_LPWSTR ] The Object ID of the service.
        let WPD_PROPERTY_CLASS_EXTENSION_SERVICE_OBJECT_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x7F0779B5, int16 0xFA2B, 
                                                                                 int16 0x4766, byte 0x9C, byte 0xB2, 
                                                                                 byte 0xF7, byte 0x3B, byte 0xA3, 
                                                                                 byte 0x0B, byte 0x67, byte 0x58), 
                                                         pid = uint32 1001)
        
        /// [ VT_UNKNOWN ] This is an IPortablePropVariantCollection of type VT_CLSID which contains the interface GUIDs that this service implements, including the service type GUID.
        let WPD_PROPERTY_CLASS_EXTENSION_SERVICE_INTERFACES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x7F0779B5, int16 0xFA2B, 
                                                                                 int16 0x4766, byte 0x9C, byte 0xB2, 
                                                                                 byte 0xF7, byte 0x3B, byte 0xA3, 
                                                                                 byte 0x0B, byte 0x67, byte 0x58), 
                                                         pid = uint32 1002)
        
        /// [ VT_UNKNOWN ] This is an IPortablePropVariantCollection of type VT_ERROR, where each element is the HRESULT indicating the success or failure of the operation.
        let WPD_PROPERTY_CLASS_EXTENSION_SERVICE_REGISTRATION_RESULTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x7F0779B5, int16 0xFA2B, 
                                                                                 int16 0x4766, byte 0x9C, byte 0xB2, 
                                                                                 byte 0xF7, byte 0x3B, byte 0xA3, 
                                                                                 byte 0x0B, byte 0x67, byte 0x58), 
                                                         pid = uint32 1003)
    
    /// 
    module WPD_CLIENT_INFORMATION_PROPERTIES_V1 = 
        /// [ VT_LPWSTR ] Specifies the name the client uses to identify itself.
        let WPD_CLIENT_NAME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x204D9F0C, int16 0x2292, 
                                                                                 int16 0x4080, byte 0x9F, byte 0x42, 
                                                                                 byte 0x40, byte 0x66, byte 0x4E, 
                                                                                 byte 0x70, byte 0xF8, byte 0x59), 
                                                         pid = uint32 2)
        
        /// [ VT_UI4 ] Specifies the major version of the client.
        let WPD_CLIENT_MAJOR_VERSION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x204D9F0C, int16 0x2292, 
                                                                                 int16 0x4080, byte 0x9F, byte 0x42, 
                                                                                 byte 0x40, byte 0x66, byte 0x4E, 
                                                                                 byte 0x70, byte 0xF8, byte 0x59), 
                                                         pid = uint32 3)
        
        /// [ VT_UI4 ] Specifies the major version of the client.
        let WPD_CLIENT_MINOR_VERSION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x204D9F0C, int16 0x2292, 
                                                                                 int16 0x4080, byte 0x9F, byte 0x42, 
                                                                                 byte 0x40, byte 0x66, byte 0x4E, 
                                                                                 byte 0x70, byte 0xF8, byte 0x59), 
                                                         pid = uint32 4)
        
        /// [ VT_UI4 ] Specifies the revision (or build number) of the client.
        let WPD_CLIENT_REVISION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x204D9F0C, int16 0x2292, 
                                                                                 int16 0x4080, byte 0x9F, byte 0x42, 
                                                                                 byte 0x40, byte 0x66, byte 0x4E, 
                                                                                 byte 0x70, byte 0xF8, byte 0x59), 
                                                         pid = uint32 5)
        
        /// [ VT_VECTOR | VT_UI1 ] Specifies the Windows Media DRM application private key of the client.
        let WPD_CLIENT_WMDRM_APPLICATION_PRIVATE_KEY = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x204D9F0C, int16 0x2292, 
                                                                                 int16 0x4080, byte 0x9F, byte 0x42, 
                                                                                 byte 0x40, byte 0x66, byte 0x4E, 
                                                                                 byte 0x70, byte 0xF8, byte 0x59), 
                                                         pid = uint32 6)
        
        /// [ VT_VECTOR | VT_UI1 ] Specifies the Windows Media DRM application certificate of the client.
        let WPD_CLIENT_WMDRM_APPLICATION_CERTIFICATE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x204D9F0C, int16 0x2292, 
                                                                                 int16 0x4080, byte 0x9F, byte 0x42, 
                                                                                 byte 0x40, byte 0x66, byte 0x4E, 
                                                                                 byte 0x70, byte 0xF8, byte 0x59), 
                                                         pid = uint32 7)
        
        /// [ VT_UI4 ] Specifies the Security Quality of Service for the connection to the driver. This relates to the Security Quality of Service flags for CreateFile. For example, these allow or disallow a driver to impersonate the client.
        let WPD_CLIENT_SECURITY_QUALITY_OF_SERVICE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x204D9F0C, int16 0x2292, 
                                                                                 int16 0x4080, byte 0x9F, byte 0x42, 
                                                                                 byte 0x40, byte 0x66, byte 0x4E, 
                                                                                 byte 0x70, byte 0xF8, byte 0x59), 
                                                         pid = uint32 8)
        
        /// [ VT_UI4 ] Specifies the desired access the client is requesting to this driver. The possible values are the same as for CreateFile (e.g. GENERIC_READ, GENERIC_WRITE etc.).
        let WPD_CLIENT_DESIRED_ACCESS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x204D9F0C, int16 0x2292, 
                                                                                 int16 0x4080, byte 0x9F, byte 0x42, 
                                                                                 byte 0x40, byte 0x66, byte 0x4E, 
                                                                                 byte 0x70, byte 0xF8, byte 0x59), 
                                                         pid = uint32 9)
        
        /// [ VT_UI4 ] Specifies the share mode the client is requesting to this driver. The possible values are the same as for CreateFile (e.g. FILE_SHARE_READ, FILE_SHARE_WRITE etc.).
        let WPD_CLIENT_SHARE_MODE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x204D9F0C, int16 0x2292, 
                                                                                 int16 0x4080, byte 0x9F, byte 0x42, 
                                                                                 byte 0x40, byte 0x66, byte 0x4E, 
                                                                                 byte 0x70, byte 0xF8, byte 0x59), 
                                                         pid = uint32 10)
        
        /// [ VT_LPWSTR ] Client supplied cookie returned by the driver in events posted as a direct result of operations issued by this client.
        let WPD_CLIENT_EVENT_COOKIE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x204D9F0C, int16 0x2292, 
                                                                                 int16 0x4080, byte 0x9F, byte 0x42, 
                                                                                 byte 0x40, byte 0x66, byte 0x4E, 
                                                                                 byte 0x70, byte 0xF8, byte 0x59), 
                                                         pid = uint32 11)
        
        /// [ VT_UI4 ] Specifies the minimum buffer size (in bytes) used for sending commands to the driver.
        let WPD_CLIENT_MINIMUM_RESULTS_BUFFER_SIZE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x204D9F0C, int16 0x2292, 
                                                                                 int16 0x4080, byte 0x9F, byte 0x42, 
                                                                                 byte 0x40, byte 0x66, byte 0x4E, 
                                                                                 byte 0x70, byte 0xF8, byte 0x59), 
                                                         pid = uint32 12)
        
        /// [ VT_BOOL ] An advanced option for clients that wish to manually call IPortableDevice::Close or IPortableDeviceService::Close for each object on device disconnect, instead of relying on the API to call Close on its behalf.
        let WPD_CLIENT_MANUAL_CLOSE_ON_DISCONNECT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x204D9F0C, int16 0x2292, 
                                                                                 int16 0x4080, byte 0x9F, byte 0x42, 
                                                                                 byte 0x40, byte 0x66, byte 0x4E, 
                                                                                 byte 0x70, byte 0xF8, byte 0x59), 
                                                         pid = uint32 13)
    
    /// This category is properties that pertain to informational objects such as appointments, tasks, memos and even documents.
    module WPD_COMMON_INFORMATION_OBJECT_PROPERTIES_V1 = 
        /// [ VT_LPWSTR ] Indicates the subject field of this object.
        let WPD_COMMON_INFORMATION_SUBJECT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB28AE94B, int16 0x05A4, 
                                                                                 int16 0x4E8E, byte 0xBE, byte 0x01, 
                                                                                 byte 0x72, byte 0xCC, byte 0x7E, 
                                                                                 byte 0x09, byte 0x9D, byte 0x8F), 
                                                         pid = uint32 2)
        
        /// [ VT_LPWSTR ] This property contains the body text of an object, in plaintext or HTML format.
        let WPD_COMMON_INFORMATION_BODY_TEXT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB28AE94B, int16 0x05A4, 
                                                                                 int16 0x4E8E, byte 0xBE, byte 0x01, 
                                                                                 byte 0x72, byte 0xCC, byte 0x7E, 
                                                                                 byte 0x09, byte 0x9D, byte 0x8F), 
                                                         pid = uint32 3)
        
        /// [ VT_UI4 ] Indicates the priority of this object.
        let WPD_COMMON_INFORMATION_PRIORITY = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB28AE94B, int16 0x05A4, 
                                                                                 int16 0x4E8E, byte 0xBE, byte 0x01, 
                                                                                 byte 0x72, byte 0xCC, byte 0x7E, 
                                                                                 byte 0x09, byte 0x9D, byte 0x8F), 
                                                         pid = uint32 4)
        
        /// [ VT_DATE ] For appointments, tasks and similar objects, this indicates the date/time that this item is scheduled to start.
        let WPD_COMMON_INFORMATION_START_DATETIME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB28AE94B, int16 0x05A4, 
                                                                                 int16 0x4E8E, byte 0xBE, byte 0x01, 
                                                                                 byte 0x72, byte 0xCC, byte 0x7E, 
                                                                                 byte 0x09, byte 0x9D, byte 0x8F), 
                                                         pid = uint32 5)
        
        /// [ VT_DATE ] For appointments, tasks and similar objects, this indicates the date/time that this item is scheduled to end.
        let WPD_COMMON_INFORMATION_END_DATETIME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB28AE94B, int16 0x05A4, 
                                                                                 int16 0x4E8E, byte 0xBE, byte 0x01, 
                                                                                 byte 0x72, byte 0xCC, byte 0x7E, 
                                                                                 byte 0x09, byte 0x9D, byte 0x8F), 
                                                         pid = uint32 6)
        
        /// [ VT_LPWSTR ] For appointments, tasks and similar objects, this indicates any notes for this object.
        let WPD_COMMON_INFORMATION_NOTES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB28AE94B, int16 0x05A4, 
                                                                                 int16 0x4E8E, byte 0xBE, byte 0x01, 
                                                                                 byte 0x72, byte 0xCC, byte 0x7E, 
                                                                                 byte 0x09, byte 0x9D, byte 0x8F), 
                                                         pid = uint32 7)
    
    /// This category is for properties common to all contact objects.
    module WPD_CONTACT_OBJECT_PROPERTIES_V1 = 
        /// [ VT_LPWSTR ] Indicates the display name of the contact (e.g "John Doe")
        let WPD_CONTACT_DISPLAY_NAME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 2)
        
        /// [ VT_LPWSTR ] Indicates the first name of the contact (e.g. "John")
        let WPD_CONTACT_FIRST_NAME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 3)
        
        /// [ VT_LPWSTR ] Indicates the middle name of the contact
        let WPD_CONTACT_MIDDLE_NAMES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 4)
        
        /// [ VT_LPWSTR ] Indicates the last name of the contact (e.g. "Doe")
        let WPD_CONTACT_LAST_NAME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 5)
        
        /// [ VT_LPWSTR ] Indicates the prefix of the name of the contact (e.g. "Mr.")
        let WPD_CONTACT_PREFIX = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 6)
        
        /// [ VT_LPWSTR ] Indicates the suffix of the name of the contact (e.g. "Jr.")
        let WPD_CONTACT_SUFFIX = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 7)
        
        /// [ VT_LPWSTR ] The phonetic guide for pronouncing the contact's first name.
        let WPD_CONTACT_PHONETIC_FIRST_NAME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 8)
        
        /// [ VT_LPWSTR ] The phonetic guide for pronouncing the contact's last name.
        let WPD_CONTACT_PHONETIC_LAST_NAME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 9)
        
        /// [ VT_LPWSTR ] Indicates the full postal address of the contact (e.g. "555 Dial Drive, PhoneLand, WA 12345")
        let WPD_CONTACT_PERSONAL_FULL_POSTAL_ADDRESS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 10)
        
        /// [ VT_LPWSTR ] Indicates the first line of a postal address of the contact (e.g. "555 Dial Drive")
        let WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_LINE1 = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 11)
        
        /// [ VT_LPWSTR ] Indicates the second line of a postal address of the contact
        let WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_LINE2 = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 12)
        
        /// [ VT_LPWSTR ] Indicates the city of a postal address of the contact (e.g. "PhoneLand")
        let WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_CITY = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 13)
        
        /// [ VT_LPWSTR ] Indicates the region of a postal address of the contact
        let WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_REGION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 14)
        
        /// [ VT_LPWSTR ] Indicates the postal code of the address.
        let WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_POSTAL_CODE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 15)
        
        /// [ VT_LPWSTR ] 
        let WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_COUNTRY = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 16)
        
        /// [ VT_LPWSTR ] Indicates the full postal address of the contact (e.g. "555 Dial Drive, PhoneLand, WA 12345")
        let WPD_CONTACT_BUSINESS_FULL_POSTAL_ADDRESS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 17)
        
        /// [ VT_LPWSTR ] Indicates the first line of a postal address of the contact (e.g. "555 Dial Drive")
        let WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_LINE1 = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 18)
        
        /// [ VT_LPWSTR ] Indicates the second line of a postal address of the contact
        let WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_LINE2 = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 19)
        
        /// [ VT_LPWSTR ] Indicates the city of a postal address of the contact (e.g. "PhoneLand")
        let WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_CITY = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 20)
        
        /// [ VT_LPWSTR ] 
        let WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_REGION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 21)
        
        /// [ VT_LPWSTR ] Indicates the postal code of the address.
        let WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_POSTAL_CODE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 22)
        
        /// [ VT_LPWSTR ] 
        let WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_COUNTRY = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 23)
        
        /// [ VT_LPWSTR ] Indicates the full postal address of the contact (e.g. "555 Dial Drive, PhoneLand, WA 12345").
        let WPD_CONTACT_OTHER_FULL_POSTAL_ADDRESS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 24)
        
        /// [ VT_LPWSTR ] Indicates the first line of a postal address of the contact (e.g. "555 Dial Drive").
        let WPD_CONTACT_OTHER_POSTAL_ADDRESS_LINE1 = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 25)
        
        /// [ VT_LPWSTR ] Indicates the second line of a postal address of the contact.
        let WPD_CONTACT_OTHER_POSTAL_ADDRESS_LINE2 = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 26)
        
        /// [ VT_LPWSTR ] Indicates the city of a postal address of the contact (e.g. "PhoneLand").
        let WPD_CONTACT_OTHER_POSTAL_ADDRESS_CITY = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 27)
        
        /// [ VT_LPWSTR ] Indicates the region of a postal address of the contact.
        let WPD_CONTACT_OTHER_POSTAL_ADDRESS_REGION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 28)
        
        /// [ VT_LPWSTR ] Indicates the postal code of the address.
        let WPD_CONTACT_OTHER_POSTAL_ADDRESS_POSTAL_CODE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 29)
        
        /// [ VT_LPWSTR ] Indicates the country/region of the postal address.
        let WPD_CONTACT_OTHER_POSTAL_ADDRESS_POSTAL_COUNTRY = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 30)
        
        /// [ VT_LPWSTR ] Indicates the primary email address for the contact e.g. "someone@example.com"
        let WPD_CONTACT_PRIMARY_EMAIL_ADDRESS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 31)
        
        /// [ VT_LPWSTR ] Indicates the personal email address for the contact e.g. "someone@example.com"
        let WPD_CONTACT_PERSONAL_EMAIL = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 32)
        
        /// [ VT_LPWSTR ] Indicates an alternate personal email address for the contact e.g. "someone@example.com"
        let WPD_CONTACT_PERSONAL_EMAIL2 = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 33)
        
        /// [ VT_LPWSTR ] Indicates the business email address for the contact e.g. "someone@example.com"
        let WPD_CONTACT_BUSINESS_EMAIL = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 34)
        
        /// [ VT_LPWSTR ] Indicates an alternate business email address for the contact e.g. "someone@example.com"
        let WPD_CONTACT_BUSINESS_EMAIL2 = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 35)
        
        /// [ VT_UNKNOWN ] An IPortableDevicePropVariantCollection of type VT_LPWSTR, where each element is an alternate email addresses for the contact.
        let WPD_CONTACT_OTHER_EMAILS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 36)
        
        /// [ VT_LPWSTR ] Indicates the primary phone number for the contact.
        let WPD_CONTACT_PRIMARY_PHONE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 37)
        
        /// [ VT_LPWSTR ] Indicates the personal phone number for the contact.
        let WPD_CONTACT_PERSONAL_PHONE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 38)
        
        /// [ VT_LPWSTR ] Indicates an alternate personal phone number for the contact.
        let WPD_CONTACT_PERSONAL_PHONE2 = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 39)
        
        /// [ VT_LPWSTR ] Indicates the business phone number for the contact.
        let WPD_CONTACT_BUSINESS_PHONE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 40)
        
        /// [ VT_LPWSTR ] Indicates an alternate business phone number for the contact.
        let WPD_CONTACT_BUSINESS_PHONE2 = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 41)
        
        /// [ VT_LPWSTR ] Indicates the mobile phone number for the contact.
        let WPD_CONTACT_MOBILE_PHONE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 42)
        
        /// [ VT_LPWSTR ] Indicates an alternate mobile phone number for the contact.
        let WPD_CONTACT_MOBILE_PHONE2 = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 43)
        
        /// [ VT_LPWSTR ] Indicates the personal fax number for the contact.
        let WPD_CONTACT_PERSONAL_FAX = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 44)
        
        /// [ VT_LPWSTR ] Indicates the business fax number for the contact.
        let WPD_CONTACT_BUSINESS_FAX = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 45)
        
        /// [ VT_LPWSTR ] 
        let WPD_CONTACT_PAGER = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 46)
        
        /// [ VT_UNKNOWN ] An IPortableDevicePropVariantCollection of type VT_LPWSTR, where each element is an alternate phone number for the contact.
        let WPD_CONTACT_OTHER_PHONES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 47)
        
        /// [ VT_LPWSTR ] Indicates the primary web address for the contact.
        let WPD_CONTACT_PRIMARY_WEB_ADDRESS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 48)
        
        /// [ VT_LPWSTR ] Indicates the personal web address for the contact.
        let WPD_CONTACT_PERSONAL_WEB_ADDRESS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 49)
        
        /// [ VT_LPWSTR ] Indicates the business web address for the contact.
        let WPD_CONTACT_BUSINESS_WEB_ADDRESS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 50)
        
        /// [ VT_LPWSTR ] Indicates the instant messenger address for the contact.
        let WPD_CONTACT_INSTANT_MESSENGER = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 51)
        
        /// [ VT_LPWSTR ] Indicates an alternate instant messenger address for the contact.
        let WPD_CONTACT_INSTANT_MESSENGER2 = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 52)
        
        /// [ VT_LPWSTR ] Indicates an alternate instant messenger address for the contact.
        let WPD_CONTACT_INSTANT_MESSENGER3 = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 53)
        
        /// [ VT_LPWSTR ] Indicates the company name for the contact.
        let WPD_CONTACT_COMPANY_NAME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 54)
        
        /// [ VT_LPWSTR ] The phonetic guide for pronouncing the contact's company name.
        let WPD_CONTACT_PHONETIC_COMPANY_NAME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 55)
        
        /// [ VT_LPWSTR ] Indicates the role for the contact e.g. "Software Engineer".
        let WPD_CONTACT_ROLE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 56)
        
        /// [ VT_DATE ] Indicates the birthdate for the contact.
        let WPD_CONTACT_BIRTHDATE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 57)
        
        /// [ VT_LPWSTR ] Indicates the primary fax number for the contact.
        let WPD_CONTACT_PRIMARY_FAX = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 58)
        
        /// [ VT_LPWSTR ] Indicates the full name of the spouse/domestic partner for the contact.
        let WPD_CONTACT_SPOUSE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 59)
        
        /// [ VT_UNKNOWN ] An IPortableDevicePropVariantCollection of type VT_LPWSTR, where each element is the full name of a child of the contact.
        let WPD_CONTACT_CHILDREN = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 60)
        
        /// [ VT_LPWSTR ] Indicates the full name of the assistant for the contact.
        let WPD_CONTACT_ASSISTANT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 61)
        
        /// [ VT_DATE ] Indicates the anniversary date for the contact.
        let WPD_CONTACT_ANNIVERSARY_DATE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 62)
        
        /// [ VT_LPWSTR ] Indicates an object id of a ringtone file on the device.
        let WPD_CONTACT_RINGTONE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xFBD4FDAB, int16 0x987D, 
                                                                                 int16 0x4777, byte 0xB3, byte 0xF9, 
                                                                                 byte 0x72, byte 0x61, byte 0x85, 
                                                                                 byte 0xA9, byte 0x31, byte 0x2B), 
                                                         pid = uint32 63)
    
    /// 
    module WPD_DEVICE_PROPERTIES_V1 = 
        /// [ VT_LPWSTR ] Indicates a human-readable description of a synchronization partner for the device.
        let WPD_DEVICE_SYNC_PARTNER = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x26D4979A, int16 0xE643, 
                                                                                 int16 0x4626, byte 0x9E, byte 0x2B, 
                                                                                 byte 0x73, byte 0x6D, byte 0xC0, 
                                                                                 byte 0xC9, byte 0x2F, byte 0xDC), 
                                                         pid = uint32 2)
        
        /// [ VT_LPWSTR ] Indicates the firmware version for the device.
        let WPD_DEVICE_FIRMWARE_VERSION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x26D4979A, int16 0xE643, 
                                                                                 int16 0x4626, byte 0x9E, byte 0x2B, 
                                                                                 byte 0x73, byte 0x6D, byte 0xC0, 
                                                                                 byte 0xC9, byte 0x2F, byte 0xDC), 
                                                         pid = uint32 3)
        
        /// [ VT_UI4 ] Indicates the power level of the device's battery.
        let WPD_DEVICE_POWER_LEVEL = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x26D4979A, int16 0xE643, 
                                                                                 int16 0x4626, byte 0x9E, byte 0x2B, 
                                                                                 byte 0x73, byte 0x6D, byte 0xC0, 
                                                                                 byte 0xC9, byte 0x2F, byte 0xDC), 
                                                         pid = uint32 4)
        
        /// [ VT_UI4 ] Indicates the power source of the device e.g. whether it is battery or external.
        let WPD_DEVICE_POWER_SOURCE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x26D4979A, int16 0xE643, 
                                                                                 int16 0x4626, byte 0x9E, byte 0x2B, 
                                                                                 byte 0x73, byte 0x6D, byte 0xC0, 
                                                                                 byte 0xC9, byte 0x2F, byte 0xDC), 
                                                         pid = uint32 5)
        
        /// [ VT_LPWSTR ] Identifies the device protocol being used.
        let WPD_DEVICE_PROTOCOL = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x26D4979A, int16 0xE643, 
                                                                                 int16 0x4626, byte 0x9E, byte 0x2B, 
                                                                                 byte 0x73, byte 0x6D, byte 0xC0, 
                                                                                 byte 0xC9, byte 0x2F, byte 0xDC), 
                                                         pid = uint32 6)
        
        /// [ VT_LPWSTR ] Identifies the device manufacturer.
        let WPD_DEVICE_MANUFACTURER = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x26D4979A, int16 0xE643, 
                                                                                 int16 0x4626, byte 0x9E, byte 0x2B, 
                                                                                 byte 0x73, byte 0x6D, byte 0xC0, 
                                                                                 byte 0xC9, byte 0x2F, byte 0xDC), 
                                                         pid = uint32 7)
        
        /// [ VT_LPWSTR ] Identifies the device model.
        let WPD_DEVICE_MODEL = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x26D4979A, int16 0xE643, 
                                                                                 int16 0x4626, byte 0x9E, byte 0x2B, 
                                                                                 byte 0x73, byte 0x6D, byte 0xC0, 
                                                                                 byte 0xC9, byte 0x2F, byte 0xDC), 
                                                         pid = uint32 8)
        
        /// [ VT_LPWSTR ] Identifies the serial number of the device.
        let WPD_DEVICE_SERIAL_NUMBER = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x26D4979A, int16 0xE643, 
                                                                                 int16 0x4626, byte 0x9E, byte 0x2B, 
                                                                                 byte 0x73, byte 0x6D, byte 0xC0, 
                                                                                 byte 0xC9, byte 0x2F, byte 0xDC), 
                                                         pid = uint32 9)
        
        /// [ VT_BOOL ] Indicates whether the device supports non-consumable objects.
        let WPD_DEVICE_SUPPORTS_NON_CONSUMABLE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x26D4979A, int16 0xE643, 
                                                                                 int16 0x4626, byte 0x9E, byte 0x2B, 
                                                                                 byte 0x73, byte 0x6D, byte 0xC0, 
                                                                                 byte 0xC9, byte 0x2F, byte 0xDC), 
                                                         pid = uint32 10)
        
        /// [ VT_DATE ] Represents the current date and time settings of the device.
        let WPD_DEVICE_DATETIME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x26D4979A, int16 0xE643, 
                                                                                 int16 0x4626, byte 0x9E, byte 0x2B, 
                                                                                 byte 0x73, byte 0x6D, byte 0xC0, 
                                                                                 byte 0xC9, byte 0x2F, byte 0xDC), 
                                                         pid = uint32 11)
        
        /// [ VT_LPWSTR ] Represents the friendly name set by the user on the device.
        let WPD_DEVICE_FRIENDLY_NAME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x26D4979A, int16 0xE643, 
                                                                                 int16 0x4626, byte 0x9E, byte 0x2B, 
                                                                                 byte 0x73, byte 0x6D, byte 0xC0, 
                                                                                 byte 0xC9, byte 0x2F, byte 0xDC), 
                                                         pid = uint32 12)
        
        /// [ VT_UNKNOWN ] An IPortableDevicePropVariantCollection of VT_LPWSTR values indicating the Digital Rights Management schemes supported by the driver.
        let WPD_DEVICE_SUPPORTED_DRM_SCHEMES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x26D4979A, int16 0xE643, 
                                                                                 int16 0x4626, byte 0x9E, byte 0x2B, 
                                                                                 byte 0x73, byte 0x6D, byte 0xC0, 
                                                                                 byte 0xC9, byte 0x2F, byte 0xDC), 
                                                         pid = uint32 13)
        
        /// [ VT_BOOL ] Indicates whether the supported formats returned from the device are in a preferred order. (First format in the list is most preferred by the device, while the last is the least preferred.)
        let WPD_DEVICE_SUPPORTED_FORMATS_ARE_ORDERED = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x26D4979A, int16 0xE643, 
                                                                                 int16 0x4626, byte 0x9E, byte 0x2B, 
                                                                                 byte 0x73, byte 0x6D, byte 0xC0, 
                                                                                 byte 0xC9, byte 0x2F, byte 0xDC), 
                                                         pid = uint32 14)
        
        /// [ VT_UI4 ] Indicates the device type, used for representation purposes only. Functional characteristics of the device are decided through functional objects.
        let WPD_DEVICE_TYPE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x26D4979A, int16 0xE643, 
                                                                                 int16 0x4626, byte 0x9E, byte 0x2B, 
                                                                                 byte 0x73, byte 0x6D, byte 0xC0, 
                                                                                 byte 0xC9, byte 0x2F, byte 0xDC), 
                                                         pid = uint32 15)
        
        /// [ VT_UI8 ] Indicates the EUI-64 network identifier of the device, used for out-of-band Network Association operations.
        let WPD_DEVICE_NETWORK_IDENTIFIER = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x26D4979A, int16 0xE643, 
                                                                                 int16 0x4626, byte 0x9E, byte 0x2B, 
                                                                                 byte 0x73, byte 0x6D, byte 0xC0, 
                                                                                 byte 0xC9, byte 0x2F, byte 0xDC), 
                                                         pid = uint32 16)
    
    /// 
    module WPD_DEVICE_PROPERTIES_V2 = 
        /// [ VT_VECTOR | VT_UI1 ] Indicates a unique 16 byte identifier common across multiple transports supported by the device.
        let WPD_DEVICE_FUNCTIONAL_UNIQUE_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x463DD662, int16 0x7FC4, 
                                                                                 int16 0x4291, byte 0x91, byte 0x1C, 
                                                                                 byte 0x7F, byte 0x4C, byte 0x9C, 
                                                                                 byte 0xCA, byte 0x97, byte 0x99), 
                                                         pid = uint32 2)
        
        /// [ VT_VECTOR | VT_UI1 ] Indicates a unique 16 byte identifier for cosmetic differentiation among different models of the device.
        let WPD_DEVICE_MODEL_UNIQUE_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x463DD662, int16 0x7FC4, 
                                                                                 int16 0x4291, byte 0x91, byte 0x1C, 
                                                                                 byte 0x7F, byte 0x4C, byte 0x9C, 
                                                                                 byte 0xCA, byte 0x97, byte 0x99), 
                                                         pid = uint32 3)
        
        /// [ VT_UI4 ] Indicates the transport type (USB, IP, Bluetooth, etc.).
        let WPD_DEVICE_TRANSPORT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x463DD662, int16 0x7FC4, 
                                                                                 int16 0x4291, byte 0x91, byte 0x1C, 
                                                                                 byte 0x7F, byte 0x4C, byte 0x9C, 
                                                                                 byte 0xCA, byte 0x97, byte 0x99), 
                                                         pid = uint32 4)
        
        /// [ VT_BOOL ] If this property exists and is set to TRUE, the device can be used with Device Stage.
        let WPD_DEVICE_USE_DEVICE_STAGE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x463DD662, int16 0x7FC4, 
                                                                                 int16 0x4291, byte 0x91, byte 0x1C, 
                                                                                 byte 0x7F, byte 0x4C, byte 0x9C, 
                                                                                 byte 0xCA, byte 0x97, byte 0x99), 
                                                         pid = uint32 5)
    
    /// This category is for properties common to all email objects.
    module WPD_EMAIL_OBJECT_PROPERTIES_V1 = 
        /// [ VT_LPWSTR ] Indicates the normal recipients for the message.
        let WPD_EMAIL_TO_LINE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x41F8F65A, int16 0x5484, 
                                                                                 int16 0x4782, byte 0xB1, byte 0x3D, 
                                                                                 byte 0x47, byte 0x40, byte 0xDD, 
                                                                                 byte 0x7C, byte 0x37, byte 0xC5), 
                                                         pid = uint32 2)
        
        /// [ VT_LPWSTR ] Indicates the copied recipients for the message.
        let WPD_EMAIL_CC_LINE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x41F8F65A, int16 0x5484, 
                                                                                 int16 0x4782, byte 0xB1, byte 0x3D, 
                                                                                 byte 0x47, byte 0x40, byte 0xDD, 
                                                                                 byte 0x7C, byte 0x37, byte 0xC5), 
                                                         pid = uint32 3)
        
        /// [ VT_LPWSTR ] Indicates the recipients for the message who receive a "blind copy".
        let WPD_EMAIL_BCC_LINE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x41F8F65A, int16 0x5484, 
                                                                                 int16 0x4782, byte 0xB1, byte 0x3D, 
                                                                                 byte 0x47, byte 0x40, byte 0xDD, 
                                                                                 byte 0x7C, byte 0x37, byte 0xC5), 
                                                         pid = uint32 4)
        
        /// [ VT_BOOL ] Indicates whether the user has read this message.
        let WPD_EMAIL_HAS_BEEN_READ = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x41F8F65A, int16 0x5484, 
                                                                                 int16 0x4782, byte 0xB1, byte 0x3D, 
                                                                                 byte 0x47, byte 0x40, byte 0xDD, 
                                                                                 byte 0x7C, byte 0x37, byte 0xC5), 
                                                         pid = uint32 7)
        
        /// [ VT_DATE ] Indicates at what time the message was received.
        let WPD_EMAIL_RECEIVED_TIME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x41F8F65A, int16 0x5484, 
                                                                                 int16 0x4782, byte 0xB1, byte 0x3D, 
                                                                                 byte 0x47, byte 0x40, byte 0xDD, 
                                                                                 byte 0x7C, byte 0x37, byte 0xC5), 
                                                         pid = uint32 8)
        
        /// [ VT_BOOL ] Indicates whether this message has attachments.
        let WPD_EMAIL_HAS_ATTACHMENTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x41F8F65A, int16 0x5484, 
                                                                                 int16 0x4782, byte 0xB1, byte 0x3D, 
                                                                                 byte 0x47, byte 0x40, byte 0xDD, 
                                                                                 byte 0x7C, byte 0x37, byte 0xC5), 
                                                         pid = uint32 9)
        
        /// [ VT_LPWSTR ] Indicates who sent the message.
        let WPD_EMAIL_SENDER_ADDRESS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x41F8F65A, int16 0x5484, 
                                                                                 int16 0x4782, byte 0xB1, byte 0x3D, 
                                                                                 byte 0x47, byte 0x40, byte 0xDD, 
                                                                                 byte 0x7C, byte 0x37, byte 0xC5), 
                                                         pid = uint32 10)
    
    /// The properties in this category describe event attributes.
    module WPD_EVENT_ATTRIBUTES_V1 = 
        /// [ VT_LPWSTR ] Contains the name of the event.
        let WPD_EVENT_ATTRIBUTE_NAME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x10C96578, int16 0x2E81, 
                                                                                 int16 0x4111, byte 0xAD, byte 0xDE, 
                                                                                 byte 0xE0, byte 0x8C, byte 0xA6, 
                                                                                 byte 0x13, byte 0x8F, byte 0x6D), 
                                                         pid = uint32 2)
        
        /// [ VT_UNKNOWN ] IPortableDeviceKeyCollection containing the event parameters.
        let WPD_EVENT_ATTRIBUTE_PARAMETERS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x10C96578, int16 0x2E81, 
                                                                                 int16 0x4111, byte 0xAD, byte 0xDE, 
                                                                                 byte 0xE0, byte 0x8C, byte 0xA6, 
                                                                                 byte 0x13, byte 0x8F, byte 0x6D), 
                                                         pid = uint32 3)
        
        /// [ VT_UNKNOWN ] IPortableDeviceValues containing the event options.
        let WPD_EVENT_ATTRIBUTE_OPTIONS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x10C96578, int16 0x2E81, 
                                                                                 int16 0x4111, byte 0xAD, byte 0xDE, 
                                                                                 byte 0xE0, byte 0x8C, byte 0xA6, 
                                                                                 byte 0x13, byte 0x8F, byte 0x6D), 
                                                         pid = uint32 4)
    
    /// The properties in this category describe event options.
    module WPD_EVENT_OPTIONS_V1 = 
        /// [ VT_BOOL ] Indicates that the event is broadcast to all clients.
        let WPD_EVENT_OPTION_IS_BROADCAST_EVENT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3D8DAD7, int16 0xA361, 
                                                                                 int16 0x4B83, byte 0x8A, byte 0x48, 
                                                                                 byte 0x5B, byte 0x02, byte 0xCE, 
                                                                                 byte 0x10, byte 0x71, byte 0x3B), 
                                                         pid = uint32 2)
        
        /// [ VT_BOOL ] Indicates that the event is sent to and handled by Autoplay.
        let WPD_EVENT_OPTION_IS_AUTOPLAY_EVENT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB3D8DAD7, int16 0xA361, 
                                                                                 int16 0x4B83, byte 0x8A, byte 0x48, 
                                                                                 byte 0x5B, byte 0x02, byte 0xCE, 
                                                                                 byte 0x10, byte 0x71, byte 0x3B), 
                                                         pid = uint32 3)
    
    /// The properties in this category are for properties that may be needed for event processing, but do not have object property equivalents (i.e. they are not exposed as object properties, but rather, used only as event parameters).
    module WPD_EVENT_PROPERTIES_V1 = 
        /// [ VT_LPWSTR ] Indicates the device that originated the event.
        let WPD_EVENT_PARAMETER_PNP_DEVICE_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x15AB1953, int16 0xF817, 
                                                                                 int16 0x4FEF, byte 0xA9, byte 0x21, 
                                                                                 byte 0x56, byte 0x76, byte 0xE8, 
                                                                                 byte 0x38, byte 0xF6, byte 0xE0), 
                                                         pid = uint32 2)
        
        /// [ VT_CLSID ] Indicates the event sent.
        let WPD_EVENT_PARAMETER_EVENT_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x15AB1953, int16 0xF817, 
                                                                                 int16 0x4FEF, byte 0xA9, byte 0x21, 
                                                                                 byte 0x56, byte 0x76, byte 0xE8, 
                                                                                 byte 0x38, byte 0xF6, byte 0xE0), 
                                                         pid = uint32 3)
        
        /// [ VT_UI4 ] Indicates the current state of the operation (e.g. started, running, stopped etc.).
        let WPD_EVENT_PARAMETER_OPERATION_STATE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x15AB1953, int16 0xF817, 
                                                                                 int16 0x4FEF, byte 0xA9, byte 0x21, 
                                                                                 byte 0x56, byte 0x76, byte 0xE8, 
                                                                                 byte 0x38, byte 0xF6, byte 0xE0), 
                                                         pid = uint32 4)
        
        /// [ VT_UI4 ] Indicates the progress of a currently executing operation. Value is from 0 to 100, with 100 indicating that the operation is complete.
        let WPD_EVENT_PARAMETER_OPERATION_PROGRESS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x15AB1953, int16 0xF817, 
                                                                                 int16 0x4FEF, byte 0xA9, byte 0x21, 
                                                                                 byte 0x56, byte 0x76, byte 0xE8, 
                                                                                 byte 0x38, byte 0xF6, byte 0xE0), 
                                                         pid = uint32 5)
        
        /// [ VT_LPWSTR ] Uniquely identifies the parent object, similar to WPD_OBJECT_PARENT_ID, but this ID will not change between sessions.
        let WPD_EVENT_PARAMETER_OBJECT_PARENT_PERSISTENT_UNIQUE_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x15AB1953, int16 0xF817, 
                                                                                 int16 0x4FEF, byte 0xA9, byte 0x21, 
                                                                                 byte 0x56, byte 0x76, byte 0xE8, 
                                                                                 byte 0x38, byte 0xF6, byte 0xE0), 
                                                         pid = uint32 6)
        
        /// [ VT_LPWSTR ] This is the cookie handed back to a client when it requested an object creation using the IPortableDeviceContent::CreateObjectWithPropertiesAndData method.
        let WPD_EVENT_PARAMETER_OBJECT_CREATION_COOKIE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x15AB1953, int16 0xF817, 
                                                                                 int16 0x4FEF, byte 0xA9, byte 0x21, 
                                                                                 byte 0x56, byte 0x76, byte 0xE8, 
                                                                                 byte 0x38, byte 0xF6, byte 0xE0), 
                                                         pid = uint32 7)
        
        /// [ VT_BOOL ] Indicates that the child hiearchy for the object has changed.
        let WPD_EVENT_PARAMETER_CHILD_HIERARCHY_CHANGED = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x15AB1953, int16 0xF817, 
                                                                                 int16 0x4FEF, byte 0xA9, byte 0x21, 
                                                                                 byte 0x56, byte 0x76, byte 0xE8, 
                                                                                 byte 0x38, byte 0xF6, byte 0xE0), 
                                                         pid = uint32 8)
    
    /// The properties in this category are for properties that may be needed for event processing, but do not have object property equivalents (i.e. they are not exposed as object properties, but rather, used only as event parameters).
    module WPD_EVENT_PROPERTIES_V2 = 
        /// [ VT_LPWSTR ] Indicates the service method invocation context.
        let WPD_EVENT_PARAMETER_SERVICE_METHOD_CONTEXT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x52807B8A, int16 0x4914, 
                                                                                 int16 0x4323, byte 0x9B, byte 0x9A, 
                                                                                 byte 0x74, byte 0xF6, byte 0x54, 
                                                                                 byte 0xB2, byte 0xB8, byte 0x46), 
                                                         pid = uint32 2)
    
    /// This category is for properties common to all folder objects.
    module WPD_FOLDER_OBJECT_PROPERTIES_V1 = 
        /// [ VT_UNKNOWN ] Indicates the subset of content types that can be created in this folder directly (i.e. children may have different restrictions).
        let WPD_FOLDER_CONTENT_TYPES_ALLOWED = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x7E9A7ABF, int16 0xE568, 
                                                                                 int16 0x4B34, byte 0xAA, byte 0x2F, 
                                                                                 byte 0x13, byte 0xBB, byte 0x12, 
                                                                                 byte 0xAB, byte 0x17, byte 0x7D), 
                                                         pid = uint32 2)
    
    /// The properties in this category describe format attributes.
    module WPD_FORMAT_ATTRIBUTES_V1 = 
        /// [ VT_LPWSTR ] Contains the name of the format.
        let WPD_FORMAT_ATTRIBUTE_NAME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xA0A02000, int16 0xBCAF, 
                                                                                 int16 0x4BE8, byte 0xB3, byte 0xF5, 
                                                                                 byte 0x23, byte 0x3F, byte 0x23, 
                                                                                 byte 0x1C, byte 0xF5, byte 0x8F), 
                                                         pid = uint32 2)
        
        /// [ VT_LPWSTR ] Contains the MIME type of the format.
        let WPD_FORMAT_ATTRIBUTE_MIMETYPE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xA0A02000, int16 0xBCAF, 
                                                                                 int16 0x4BE8, byte 0xB3, byte 0xF5, 
                                                                                 byte 0x23, byte 0x3F, byte 0x23, 
                                                                                 byte 0x1C, byte 0xF5, byte 0x8F), 
                                                         pid = uint32 3)
    
    /// This category is for properties common to all functional objects.
    module WPD_FUNCTIONAL_OBJECT_PROPERTIES_V1 = 
        /// [ VT_CLSID ] Indicates the object's functional category.
        let WPD_FUNCTIONAL_OBJECT_CATEGORY = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x8F052D93, int16 0xABCA, 
                                                                                 int16 0x4FC5, byte 0xA5, byte 0xAC, 
                                                                                 byte 0xB0, byte 0x1D, byte 0xF4, 
                                                                                 byte 0xDB, byte 0xE5, byte 0x98), 
                                                         pid = uint32 2)
    
    /// This category is for properties common to all image objects.
    module WPD_IMAGE_OBJECT_PROPERTIES_V1 = 
        /// [ VT_UI4 ] Indicates the bitdepth of an image
        let WPD_IMAGE_BITDEPTH = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x63D64908, int16 0x9FA1, 
                                                                                 int16 0x479F, byte 0x85, byte 0xBA, 
                                                                                 byte 0x99, byte 0x52, byte 0x21, 
                                                                                 byte 0x64, byte 0x47, byte 0xDB), 
                                                         pid = uint32 3)
        
        /// [ VT_UI4 ] Signals whether the file has been cropped.
        let WPD_IMAGE_CROPPED_STATUS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x63D64908, int16 0x9FA1, 
                                                                                 int16 0x479F, byte 0x85, byte 0xBA, 
                                                                                 byte 0x99, byte 0x52, byte 0x21, 
                                                                                 byte 0x64, byte 0x47, byte 0xDB), 
                                                         pid = uint32 4)
        
        /// [ VT_UI4 ] Signals whether the file has been color corrected.
        let WPD_IMAGE_COLOR_CORRECTED_STATUS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x63D64908, int16 0x9FA1, 
                                                                                 int16 0x479F, byte 0x85, byte 0xBA, 
                                                                                 byte 0x99, byte 0x52, byte 0x21, 
                                                                                 byte 0x64, byte 0x47, byte 0xDB), 
                                                         pid = uint32 5)
        
        /// [ VT_UI4 ] Identifies the aperture setting of the lens when this image was captured.
        let WPD_IMAGE_FNUMBER = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x63D64908, int16 0x9FA1, 
                                                                                 int16 0x479F, byte 0x85, byte 0xBA, 
                                                                                 byte 0x99, byte 0x52, byte 0x21, 
                                                                                 byte 0x64, byte 0x47, byte 0xDB), 
                                                         pid = uint32 6)
        
        /// [ VT_UI4 ] Identifies the shutter speed of the device when this image was captured.
        let WPD_IMAGE_EXPOSURE_TIME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x63D64908, int16 0x9FA1, 
                                                                                 int16 0x479F, byte 0x85, byte 0xBA, 
                                                                                 byte 0x99, byte 0x52, byte 0x21, 
                                                                                 byte 0x64, byte 0x47, byte 0xDB), 
                                                         pid = uint32 7)
        
        /// [ VT_UI4 ] Identifies the emulation of film speed settings when this image was captured.
        let WPD_IMAGE_EXPOSURE_INDEX = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x63D64908, int16 0x9FA1, 
                                                                                 int16 0x479F, byte 0x85, byte 0xBA, 
                                                                                 byte 0x99, byte 0x52, byte 0x21, 
                                                                                 byte 0x64, byte 0x47, byte 0xDB), 
                                                         pid = uint32 8)
        
        /// [ VT_R8 ] Indicates the horizontal resolution (DPI) of an image
        let WPD_IMAGE_HORIZONTAL_RESOLUTION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x63D64908, int16 0x9FA1, 
                                                                                 int16 0x479F, byte 0x85, byte 0xBA, 
                                                                                 byte 0x99, byte 0x52, byte 0x21, 
                                                                                 byte 0x64, byte 0x47, byte 0xDB), 
                                                         pid = uint32 9)
        
        /// [ VT_R8 ] Indicates the vertical resolution (DPI) of an image
        let WPD_IMAGE_VERTICAL_RESOLUTION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x63D64908, int16 0x9FA1, 
                                                                                 int16 0x479F, byte 0x85, byte 0xBA, 
                                                                                 byte 0x99, byte 0x52, byte 0x21, 
                                                                                 byte 0x64, byte 0x47, byte 0xDB), 
                                                         pid = uint32 10)
    
    /// This category is for properties common to media objects (e.g. audio and video).
    module WPD_MEDIA_PROPERTIES_V1 = 
        /// [ VT_UI4 ] The total number of bits that one second will consume.
        let WPD_MEDIA_TOTAL_BITRATE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 2)
        
        /// [ VT_UI4 ] Further qualifies the bitrate of audio or video data.
        let WPD_MEDIA_BITRATE_TYPE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 3)
        
        /// [ VT_LPWSTR ] Indicates the copyright information.
        let WPD_MEDIA_COPYRIGHT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 4)
        
        /// [ VT_LPWSTR ] Provides additional information to identify a piece of content relative to an online subscription service.
        let WPD_MEDIA_SUBSCRIPTION_CONTENT_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 5)
        
        /// [ VT_UI4 ] Indicates the total number of times this media has been played or viewed on the device.
        let WPD_MEDIA_USE_COUNT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 6)
        
        /// [ VT_UI4 ] Indicates the total number of times this media was setup to be played or viewed but was manually skipped by the user.
        let WPD_MEDIA_SKIP_COUNT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 7)
        
        /// [ VT_DATE ] Indicates the date and time the media was last accessed on the device.
        let WPD_MEDIA_LAST_ACCESSED_TIME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 8)
        
        /// [ VT_LPWSTR ] Indicates the parental rating of the media file.
        let WPD_MEDIA_PARENTAL_RATING = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 9)
        
        /// [ VT_UI4 ] Further qualifies a piece of media in a contextual way.
        let WPD_MEDIA_META_GENRE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 10)
        
        /// [ VT_LPWSTR ] Identifies the composer when the composer is not the artist who performed it.
        let WPD_MEDIA_COMPOSER = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 11)
        
        /// [ VT_UI4 ] Contains an assigned rating for media not set by the user, but is generated based upon usage statistics.
        let WPD_MEDIA_EFFECTIVE_RATING = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 12)
        
        /// [ VT_LPWSTR ] Further qualifies the title when the title is ambiguous or general.
        let WPD_MEDIA_SUB_TITLE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 13)
        
        /// [ VT_DATE ] Indicates when the media was released.
        let WPD_MEDIA_RELEASE_DATE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 14)
        
        /// [ VT_UI4 ] Indicates the number of times media selection was sampled per second during encoding.
        let WPD_MEDIA_SAMPLE_RATE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 15)
        
        /// [ VT_UI4 ] Indicates the star rating for this media.
        let WPD_MEDIA_STAR_RATING = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 16)
        
        /// [ VT_UI4 ] Indicates the rating for this media.
        let WPD_MEDIA_USER_EFFECTIVE_RATING = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 17)
        
        /// [ VT_LPWSTR ] Indicates the title of this media.
        let WPD_MEDIA_TITLE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 18)
        
        /// [ VT_UI8 ] Indicates the duration of this media in milliseconds.
        let WPD_MEDIA_DURATION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 19)
        
        /// [ VT_BOOL ] TBD
        let WPD_MEDIA_BUY_NOW = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 20)
        
        /// [ VT_LPWSTR ] Media codecs may be encoded in accordance with a profile, which defines a particular encoding algorithm or optimization process.
        let WPD_MEDIA_ENCODING_PROFILE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 21)
        
        /// [ VT_UI4 ] Indicates the width of an object in pixels
        let WPD_MEDIA_WIDTH = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 22)
        
        /// [ VT_UI4 ] Indicates the height of an object in pixels
        let WPD_MEDIA_HEIGHT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 23)
        
        /// [ VT_LPWSTR ] Indicates the artist for this media.
        let WPD_MEDIA_ARTIST = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 24)
        
        /// [ VT_LPWSTR ] Indicates the artist of the entire album rather than for a particular track.
        let WPD_MEDIA_ALBUM_ARTIST = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 25)
        
        /// [ VT_LPWSTR ] Indicates the e-mail address of the owner for this media.
        let WPD_MEDIA_OWNER = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 26)
        
        /// [ VT_LPWSTR ] Indicates the e-mail address of the managing editor for this media.
        let WPD_MEDIA_MANAGING_EDITOR = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 27)
        
        /// [ VT_LPWSTR ] Indicates the e-mail address of the Webmaster for this media.
        let WPD_MEDIA_WEBMASTER = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 28)
        
        /// [ VT_LPWSTR ] Identifies the source URL for this object.
        let WPD_MEDIA_SOURCE_URL = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 29)
        
        /// [ VT_LPWSTR ] Identifies the URL that an object is linked to if a user clicks on it.
        let WPD_MEDIA_DESTINATION_URL = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 30)
        
        /// [ VT_LPWSTR ] Contains a description of the media content for this object.
        let WPD_MEDIA_DESCRIPTION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 31)
        
        /// [ VT_LPWSTR ] A text field indicating the genre this media belongs to.
        let WPD_MEDIA_GENRE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 32)
        
        /// [ VT_UI8 ] Indicates a bookmark (in milliseconds) of the last position played or viewed on media that have duration.
        let WPD_MEDIA_TIME_BOOKMARK = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 33)
        
        /// [ VT_LPWSTR ] Indicates a WPD_OBJECT_ID of the last object viewed or played for those objects that refer to a list of objects (such as playlists or media casts).
        let WPD_MEDIA_OBJECT_BOOKMARK = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 34)
        
        /// [ VT_DATE ] Indicates the last time a series in a media cast was changed or edited.
        let WPD_MEDIA_LAST_BUILD_DATE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 35)
        
        /// [ VT_UI8 ] Indicates a bookmark (as a zero-based byte offset) of the last position played or viewed on this media object.
        let WPD_MEDIA_BYTE_BOOKMARK = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 36)
        
        /// [ VT_UI8 ] It is the number of minutes that indicates how long a channel can be cached before refreshing from the source. Applies to WPD_CONTENT_TYPE_MEDIA_CAST objects.
        let WPD_MEDIA_TIME_TO_LIVE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 37)
        
        /// [ VT_LPWSTR ] A text field indicating the GUID of this media.
        let WPD_MEDIA_GUID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 38)
        
        /// [ VT_LPWSTR ] Contains a sub description of the media content for this object.
        let WPD_MEDIA_SUB_DESCRIPTION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 39)
        
        /// [ VT_LPWSTR ] Media codecs may be encoded in accordance with a profile, which defines a particular encoding algorithm or optimization process.
        let WPD_MEDIA_AUDIO_ENCODING_PROFILE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x2ED8BA05, int16 0x0AD3, 
                                                                                 int16 0x42DC, byte 0xB0, byte 0xD0, 
                                                                                 byte 0xBC, byte 0x95, byte 0xAC, 
                                                                                 byte 0x39, byte 0x6A, byte 0xC8), 
                                                         pid = uint32 49)
    
    /// The properties in this category describe method attributes.
    module WPD_METHOD_ATTRIBUTES_V1 = 
        /// [ VT_LPWSTR ] Contains the name of the method.
        let WPD_METHOD_ATTRIBUTE_NAME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF17A5071, int16 0xF039, 
                                                                                 int16 0x44AF, byte 0x8E, byte 0xFE, 
                                                                                 byte 0x43, byte 0x2C, byte 0xF3, 
                                                                                 byte 0x2E, byte 0x43, byte 0x2A), 
                                                         pid = uint32 2)
        
        /// [ VT_CLSID ] Contains the format this method applies to. This is GUID_NULL if the method does not apply to a format.
        let WPD_METHOD_ATTRIBUTE_ASSOCIATED_FORMAT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF17A5071, int16 0xF039, 
                                                                                 int16 0x44AF, byte 0x8E, byte 0xFE, 
                                                                                 byte 0x43, byte 0x2C, byte 0xF3, 
                                                                                 byte 0x2E, byte 0x43, byte 0x2A), 
                                                         pid = uint32 3)
        
        /// [ VT_UI4 ] Indicates the required access for a method.
        let WPD_METHOD_ATTRIBUTE_ACCESS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF17A5071, int16 0xF039, 
                                                                                 int16 0x44AF, byte 0x8E, byte 0xFE, 
                                                                                 byte 0x43, byte 0x2C, byte 0xF3, 
                                                                                 byte 0x2E, byte 0x43, byte 0x2A), 
                                                         pid = uint32 4)
        
        /// [ VT_UNKNOWN ] This is an IPortableDeviceKeyCollection containing the method parameters.
        let WPD_METHOD_ATTRIBUTE_PARAMETERS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xF17A5071, int16 0xF039, 
                                                                                 int16 0x44AF, byte 0x8E, byte 0xFE, 
                                                                                 byte 0x43, byte 0x2C, byte 0xF3, 
                                                                                 byte 0x2E, byte 0x43, byte 0x2A), 
                                                         pid = uint32 5)
    
    /// This category is for properties common to all music objects.
    module WPD_MUSIC_OBJECT_PROPERTIES_V1 = 
        /// [ VT_LPWSTR ] Indicates the album of the music file.
        let WPD_MUSIC_ALBUM = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB324F56A, int16 0xDC5D, 
                                                                                 int16 0x46E5, byte 0xB6, byte 0xDF, 
                                                                                 byte 0xD2, byte 0xEA, byte 0x41, 
                                                                                 byte 0x48, byte 0x88, byte 0xC6), 
                                                         pid = uint32 3)
        
        /// [ VT_UI4 ] Indicates the track number for the music file.
        let WPD_MUSIC_TRACK = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB324F56A, int16 0xDC5D, 
                                                                                 int16 0x46E5, byte 0xB6, byte 0xDF, 
                                                                                 byte 0xD2, byte 0xEA, byte 0x41, 
                                                                                 byte 0x48, byte 0x88, byte 0xC6), 
                                                         pid = uint32 4)
        
        /// [ VT_LPWSTR ] Indicates the lyrics for the music file.
        let WPD_MUSIC_LYRICS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB324F56A, int16 0xDC5D, 
                                                                                 int16 0x46E5, byte 0xB6, byte 0xDF, 
                                                                                 byte 0xD2, byte 0xEA, byte 0x41, 
                                                                                 byte 0x48, byte 0x88, byte 0xC6), 
                                                         pid = uint32 6)
        
        /// [ VT_LPWSTR ] Indicates the mood for the music file.
        let WPD_MUSIC_MOOD = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB324F56A, int16 0xDC5D, 
                                                                                 int16 0x46E5, byte 0xB6, byte 0xDF, 
                                                                                 byte 0xD2, byte 0xEA, byte 0x41, 
                                                                                 byte 0x48, byte 0x88, byte 0xC6), 
                                                         pid = uint32 8)
        
        /// [ VT_UI4 ] Indicates the bit rate for the audio data, specified in bits per second.
        let WPD_AUDIO_BITRATE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB324F56A, int16 0xDC5D, 
                                                                                 int16 0x46E5, byte 0xB6, byte 0xDF, 
                                                                                 byte 0xD2, byte 0xEA, byte 0x41, 
                                                                                 byte 0x48, byte 0x88, byte 0xC6), 
                                                         pid = uint32 9)
        
        /// [ VT_R4 ] Indicates the number of channels in this audio file e.g. 1, 2, 5.1 etc.
        let WPD_AUDIO_CHANNEL_COUNT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB324F56A, int16 0xDC5D, 
                                                                                 int16 0x46E5, byte 0xB6, byte 0xDF, 
                                                                                 byte 0xD2, byte 0xEA, byte 0x41, 
                                                                                 byte 0x48, byte 0x88, byte 0xC6), 
                                                         pid = uint32 10)
        
        /// [ VT_UI4 ] Indicates the registered WAVE format code.
        let WPD_AUDIO_FORMAT_CODE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB324F56A, int16 0xDC5D, 
                                                                                 int16 0x46E5, byte 0xB6, byte 0xDF, 
                                                                                 byte 0xD2, byte 0xEA, byte 0x41, 
                                                                                 byte 0x48, byte 0x88, byte 0xC6), 
                                                         pid = uint32 11)
        
        /// [ VT_UI4 ] This property identifies the bit-depth of the audio.
        let WPD_AUDIO_BIT_DEPTH = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB324F56A, int16 0xDC5D, 
                                                                                 int16 0x46E5, byte 0xB6, byte 0xDF, 
                                                                                 byte 0xD2, byte 0xEA, byte 0x41, 
                                                                                 byte 0x48, byte 0x88, byte 0xC6), 
                                                         pid = uint32 12)
        
        /// [ VT_UI4 ] This property identifies the audio block alignment
        let WPD_AUDIO_BLOCK_ALIGNMENT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xB324F56A, int16 0xDC5D, 
                                                                                 int16 0x46E5, byte 0xB6, byte 0xDF, 
                                                                                 byte 0xD2, byte 0xEA, byte 0x41, 
                                                                                 byte 0x48, byte 0x88, byte 0xC6), 
                                                         pid = uint32 13)
    
    /// This category is for properties common to all network association objects.
    module WPD_NETWORK_ASSOCIATION_PROPERTIES_V1 = 
        /// [ VT_VECTOR | VT_UI1 ] The list of EUI-64 host identifiers valid for this association.
        let WPD_NETWORK_ASSOCIATION_HOST_NETWORK_IDENTIFIERS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xE4C93C1F, int16 0xB203, 
                                                                                 int16 0x43F1, byte 0xA1, byte 0x00, 
                                                                                 byte 0x5A, byte 0x07, byte 0xD1, 
                                                                                 byte 0x1B, byte 0x02, byte 0x74), 
                                                         pid = uint32 2)
        
        /// [ VT_VECTOR | VT_UI1 ] The sequence of X.509 v3 certificates to be provided for TLS server authentication.
        let WPD_NETWORK_ASSOCIATION_X509V3SEQUENCE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xE4C93C1F, int16 0xB203, 
                                                                                 int16 0x43F1, byte 0xA1, byte 0x00, 
                                                                                 byte 0x5A, byte 0x07, byte 0xD1, 
                                                                                 byte 0x1B, byte 0x02, byte 0x74), 
                                                         pid = uint32 3)
    
    /// This category is for all common object properties.
    module WPD_OBJECT_PROPERTIES_V1 = 
        /// [ VT_CLSID ] The abstract type for the object content, indicating the kinds of properties and data that may be supported on the object.
        let WPD_OBJECT_CONTENT_TYPE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 7)
        
        /// [ VT_UNKNOWN ] IPortableDevicePropVariantCollection of type VT_LPWSTR indicating a list of ObjectIDs.
        let WPD_OBJECT_REFERENCES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 14)
        
        /// [ VT_LPWSTR ] Indicates the Object ID of the closest functional object ancestor. For example, objects that represent files/folders under a Storage functional object, will have this property set to the object ID of the storage functional object.
        let WPD_OBJECT_CONTAINER_FUNCTIONAL_OBJECT_ID = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 23)
        
        /// [ VT_BOOL ] Indicates whether the thumbnail for this object should be generated from the default resource.
        let WPD_OBJECT_GENERATE_THUMBNAIL_FROM_RESOURCE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 24)
        
        /// [ VT_LPWSTR ] If this object appears as a hint location, this property indicates the hint-specific name to display instead of the object name.
        let WPD_OBJECT_HINT_LOCATION_DISPLAY_NAME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xEF6B490D, int16 0x5CD8, 
                                                                                 int16 0x437A, byte 0xAF, byte 0xFC, 
                                                                                 byte 0xDA, byte 0x8B, byte 0x60, 
                                                                                 byte 0xEE, byte 0x4A, byte 0x3C), 
                                                         pid = uint32 25)
    
    /// This category is for all common object properties.
    module WPD_OBJECT_PROPERTIES_V2 = 
        /// [ VT_UI4 ] Indicates the units supported on this object.
        let WPD_OBJECT_SUPPORTED_UNITS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x0373CD3D, int16 0x4A46, 
                                                                                 int16 0x40D7, byte 0xB4, byte 0xD8, 
                                                                                 byte 0x73, byte 0xE8, byte 0xDA, 
                                                                                 byte 0x74, byte 0xE7, byte 0x75), 
                                                         pid = uint32 2)
    
    /// The properties in this category describe parameter attributes.
    module WPD_PARAMETER_ATTRIBUTES_V1 = 
        /// [ VT_UI4 ] The order (starting from 0) of a method parameter.
        let WPD_PARAMETER_ATTRIBUTE_ORDER = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xE6864DD7, int16 0xF325, 
                                                                                 int16 0x45EA, byte 0xA1, byte 0xD5, 
                                                                                 byte 0x97, byte 0xCF, byte 0x73, 
                                                                                 byte 0xB6, byte 0xCA, byte 0x58), 
                                                         pid = uint32 2)
        
        /// [ VT_UI4 ] The usage of the method parameter.
        let WPD_PARAMETER_ATTRIBUTE_USAGE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xE6864DD7, int16 0xF325, 
                                                                                 int16 0x45EA, byte 0xA1, byte 0xD5, 
                                                                                 byte 0x97, byte 0xCF, byte 0x73, 
                                                                                 byte 0xB6, byte 0xCA, byte 0x58), 
                                                         pid = uint32 3)
        
        /// [ VT_UI4 ] Specifies the form of the valid values allowed for this parameter.
        let WPD_PARAMETER_ATTRIBUTE_FORM = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xE6864DD7, int16 0xF325, 
                                                                                 int16 0x45EA, byte 0xA1, byte 0xD5, 
                                                                                 byte 0x97, byte 0xCF, byte 0x73, 
                                                                                 byte 0xB6, byte 0xCA, byte 0x58), 
                                                         pid = uint32 4)
        
        /// [ VT_XXXX ] Specifies the default value for this parameter.
        let WPD_PARAMETER_ATTRIBUTE_DEFAULT_VALUE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xE6864DD7, int16 0xF325, 
                                                                                 int16 0x45EA, byte 0xA1, byte 0xD5, 
                                                                                 byte 0x97, byte 0xCF, byte 0x73, 
                                                                                 byte 0xB6, byte 0xCA, byte 0x58), 
                                                         pid = uint32 5)
        
        /// [ VT_XXXX ] The minimum value for a parameter whose form is of WPD_PARAMETER_ATTRIBUTE_FORM_RANGE.
        let WPD_PARAMETER_ATTRIBUTE_RANGE_MIN = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xE6864DD7, int16 0xF325, 
                                                                                 int16 0x45EA, byte 0xA1, byte 0xD5, 
                                                                                 byte 0x97, byte 0xCF, byte 0x73, 
                                                                                 byte 0xB6, byte 0xCA, byte 0x58), 
                                                         pid = uint32 6)
        
        /// [ VT_XXXX ] The maximum value for a parameter whose form is of WPD_PARAMETER_ATTRIBUTE_FORM_RANGE.
        let WPD_PARAMETER_ATTRIBUTE_RANGE_MAX = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xE6864DD7, int16 0xF325, 
                                                                                 int16 0x45EA, byte 0xA1, byte 0xD5, 
                                                                                 byte 0x97, byte 0xCF, byte 0x73, 
                                                                                 byte 0xB6, byte 0xCA, byte 0x58), 
                                                         pid = uint32 7)
        
        /// [ VT_XXXX ] The step value for a parameter whose form is of WPD_PARAMETER_ATTRIBUTE_FORM_RANGE.
        let WPD_PARAMETER_ATTRIBUTE_RANGE_STEP = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xE6864DD7, int16 0xF325, 
                                                                                 int16 0x45EA, byte 0xA1, byte 0xD5, 
                                                                                 byte 0x97, byte 0xCF, byte 0x73, 
                                                                                 byte 0xB6, byte 0xCA, byte 0x58), 
                                                         pid = uint32 8)
        
        /// [ VT_UNKNOWN ] An IPortableDevicePropVariantCollection containing the enumeration values.
        let WPD_PARAMETER_ATTRIBUTE_ENUMERATION_ELEMENTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xE6864DD7, int16 0xF325, 
                                                                                 int16 0x45EA, byte 0xA1, byte 0xD5, 
                                                                                 byte 0x97, byte 0xCF, byte 0x73, 
                                                                                 byte 0xB6, byte 0xCA, byte 0x58), 
                                                         pid = uint32 9)
        
        /// [ VT_LPWSTR ] A regular expression string indicating acceptable values for parameters whose form is WPD_PARAMETER_ATTRIBUTE_FORM_REGULAR_EXPRESSION.
        let WPD_PARAMETER_ATTRIBUTE_REGULAR_EXPRESSION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xE6864DD7, int16 0xF325, 
                                                                                 int16 0x45EA, byte 0xA1, byte 0xD5, 
                                                                                 byte 0x97, byte 0xCF, byte 0x73, 
                                                                                 byte 0xB6, byte 0xCA, byte 0x58), 
                                                         pid = uint32 10)
        
        /// [ VT_UI8 ] This indicates the maximum size (in bytes) for the value of this parameter.
        let WPD_PARAMETER_ATTRIBUTE_MAX_SIZE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xE6864DD7, int16 0xF325, 
                                                                                 int16 0x45EA, byte 0xA1, byte 0xD5, 
                                                                                 byte 0x97, byte 0xCF, byte 0x73, 
                                                                                 byte 0xB6, byte 0xCA, byte 0x58), 
                                                         pid = uint32 11)
        
        /// [ VT_UI4 ] Contains the VARTYPE of the parameter.
        let WPD_PARAMETER_ATTRIBUTE_VARTYPE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xE6864DD7, int16 0xF325, 
                                                                                 int16 0x45EA, byte 0xA1, byte 0xD5, 
                                                                                 byte 0x97, byte 0xCF, byte 0x73, 
                                                                                 byte 0xB6, byte 0xCA, byte 0x58), 
                                                         pid = uint32 12)
        
        /// [ VT_LPWSTR ] Contains the parameter name.
        let WPD_PARAMETER_ATTRIBUTE_NAME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xE6864DD7, int16 0xF325, 
                                                                                 int16 0x45EA, byte 0xA1, byte 0xD5, 
                                                                                 byte 0x97, byte 0xCF, byte 0x73, 
                                                                                 byte 0xB6, byte 0xCA, byte 0x58), 
                                                         pid = uint32 13)
    
    /// 
    module WPD_PROPERTY_ATTRIBUTES_V1 = 
        /// [ VT_UI4 ] Specifies the form of the valid values allowed for this property.
        let WPD_PROPERTY_ATTRIBUTE_FORM = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xAB7943D8, int16 0x6332, 
                                                                                 int16 0x445F, byte 0xA0, byte 0x0D, 
                                                                                 byte 0x8D, byte 0x5E, byte 0xF1, 
                                                                                 byte 0xE9, byte 0x6F, byte 0x37), 
                                                         pid = uint32 2)
        
        /// [ VT_BOOL ] Indicates whether client applications have permission to Read the property.
        let WPD_PROPERTY_ATTRIBUTE_CAN_READ = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xAB7943D8, int16 0x6332, 
                                                                                 int16 0x445F, byte 0xA0, byte 0x0D, 
                                                                                 byte 0x8D, byte 0x5E, byte 0xF1, 
                                                                                 byte 0xE9, byte 0x6F, byte 0x37), 
                                                         pid = uint32 3)
        
        /// [ VT_BOOL ] Indicates whether client applications have permission to Write the property.
        let WPD_PROPERTY_ATTRIBUTE_CAN_WRITE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xAB7943D8, int16 0x6332, 
                                                                                 int16 0x445F, byte 0xA0, byte 0x0D, 
                                                                                 byte 0x8D, byte 0x5E, byte 0xF1, 
                                                                                 byte 0xE9, byte 0x6F, byte 0x37), 
                                                         pid = uint32 4)
        
        /// [ VT_BOOL ] Indicates whether client applications have permission to Delete the property.
        let WPD_PROPERTY_ATTRIBUTE_CAN_DELETE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xAB7943D8, int16 0x6332, 
                                                                                 int16 0x445F, byte 0xA0, byte 0x0D, 
                                                                                 byte 0x8D, byte 0x5E, byte 0xF1, 
                                                                                 byte 0xE9, byte 0x6F, byte 0x37), 
                                                         pid = uint32 5)
        
        /// [ VT_XXXX ] Specifies the default value for a write-able property.
        let WPD_PROPERTY_ATTRIBUTE_DEFAULT_VALUE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xAB7943D8, int16 0x6332, 
                                                                                 int16 0x445F, byte 0xA0, byte 0x0D, 
                                                                                 byte 0x8D, byte 0x5E, byte 0xF1, 
                                                                                 byte 0xE9, byte 0x6F, byte 0x37), 
                                                         pid = uint32 6)
        
        /// [ VT_BOOL ] If True, then this property belongs to the PORTABLE_DEVICE_FAST_PROPERTIES group.
        let WPD_PROPERTY_ATTRIBUTE_FAST_PROPERTY = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xAB7943D8, int16 0x6332, 
                                                                                 int16 0x445F, byte 0xA0, byte 0x0D, 
                                                                                 byte 0x8D, byte 0x5E, byte 0xF1, 
                                                                                 byte 0xE9, byte 0x6F, byte 0x37), 
                                                         pid = uint32 7)
        
        /// [ VT_XXXX ] The minimum value for a property whose form is of WPD_PROPERTY_ATTRIBUTE_FORM_RANGE.
        let WPD_PROPERTY_ATTRIBUTE_RANGE_MIN = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xAB7943D8, int16 0x6332, 
                                                                                 int16 0x445F, byte 0xA0, byte 0x0D, 
                                                                                 byte 0x8D, byte 0x5E, byte 0xF1, 
                                                                                 byte 0xE9, byte 0x6F, byte 0x37), 
                                                         pid = uint32 8)
        
        /// [ VT_XXXX ] The maximum value for a property whose form is of WPD_PROPERTY_ATTRIBUTE_FORM_RANGE.
        let WPD_PROPERTY_ATTRIBUTE_RANGE_MAX = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xAB7943D8, int16 0x6332, 
                                                                                 int16 0x445F, byte 0xA0, byte 0x0D, 
                                                                                 byte 0x8D, byte 0x5E, byte 0xF1, 
                                                                                 byte 0xE9, byte 0x6F, byte 0x37), 
                                                         pid = uint32 9)
        
        /// [ VT_XXXX ] The step value for a property whose form is of WPD_PROPERTY_ATTRIBUTE_FORM_RANGE.
        let WPD_PROPERTY_ATTRIBUTE_RANGE_STEP = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xAB7943D8, int16 0x6332, 
                                                                                 int16 0x445F, byte 0xA0, byte 0x0D, 
                                                                                 byte 0x8D, byte 0x5E, byte 0xF1, 
                                                                                 byte 0xE9, byte 0x6F, byte 0x37), 
                                                         pid = uint32 10)
        
        /// [ VT_UNKNOWN ] An IPortableDevicePropVariantCollection containing the enumeration values.
        let WPD_PROPERTY_ATTRIBUTE_ENUMERATION_ELEMENTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xAB7943D8, int16 0x6332, 
                                                                                 int16 0x445F, byte 0xA0, byte 0x0D, 
                                                                                 byte 0x8D, byte 0x5E, byte 0xF1, 
                                                                                 byte 0xE9, byte 0x6F, byte 0x37), 
                                                         pid = uint32 11)
        
        /// [ VT_LPWSTR ] A regular expression string indicating acceptable values for properties whose form is WPD_PROPERTY_ATTRIBUTE_FORM_REGULAR_EXPRESSION.
        let WPD_PROPERTY_ATTRIBUTE_REGULAR_EXPRESSION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xAB7943D8, int16 0x6332, 
                                                                                 int16 0x445F, byte 0xA0, byte 0x0D, 
                                                                                 byte 0x8D, byte 0x5E, byte 0xF1, 
                                                                                 byte 0xE9, byte 0x6F, byte 0x37), 
                                                         pid = uint32 12)
        
        /// [ VT_UI8 ] This indicates the maximum size (in bytes) for the value of this property.
        let WPD_PROPERTY_ATTRIBUTE_MAX_SIZE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xAB7943D8, int16 0x6332, 
                                                                                 int16 0x445F, byte 0xA0, byte 0x0D, 
                                                                                 byte 0x8D, byte 0x5E, byte 0xF1, 
                                                                                 byte 0xE9, byte 0x6F, byte 0x37), 
                                                         pid = uint32 13)
    
    /// This category defines additional property attributes used by device services.
    module WPD_PROPERTY_ATTRIBUTES_V2 = 
        /// [ VT_LPWSTR ] Contains the name of the property.
        let WPD_PROPERTY_ATTRIBUTE_NAME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x5D9DA160, int16 0x74AE, 
                                                                                 int16 0x43CC, byte 0x85, byte 0xA9, 
                                                                                 byte 0xFE, byte 0x55, byte 0x5A, 
                                                                                 byte 0x80, byte 0x79, byte 0x8E), 
                                                         pid = uint32 2)
        
        /// [ VT_UI4 ] Contains the VARTYPE of the property.
        let WPD_PROPERTY_ATTRIBUTE_VARTYPE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x5D9DA160, int16 0x74AE, 
                                                                                 int16 0x43CC, byte 0x85, byte 0xA9, 
                                                                                 byte 0xFE, byte 0x55, byte 0x5A, 
                                                                                 byte 0x80, byte 0x79, byte 0x8E), 
                                                         pid = uint32 3)
    
    /// This category is for properties common to all objects whose functional category is WPD_FUNCTIONAL_CATEGORY_AUDIO_RENDERING_INFORMATION
    module WPD_RENDERING_INFORMATION_OBJECT_PROPERTIES_V1 = 
        /// [ VT_UNKNOWN ] IPortableDeviceValuesCollection, where each element indicates the property settings for a supported profile.
        let WPD_RENDERING_INFORMATION_PROFILES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xC53D039F, int16 0xEE23, 
                                                                                 int16 0x4A31, byte 0x85, byte 0x90, 
                                                                                 byte 0x76, byte 0x39, byte 0x87, 
                                                                                 byte 0x98, byte 0x70, byte 0xB4), 
                                                         pid = uint32 2)
        
        /// [ VT_UI4 ] Indicates whether a given entry (i.e. an IPortableDeviceValues) in WPD_RENDERING_INFORMATION_PROFILES relates to an Object or a Resource.
        let WPD_RENDERING_INFORMATION_PROFILE_ENTRY_TYPE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xC53D039F, int16 0xEE23, 
                                                                                 int16 0x4A31, byte 0x85, byte 0x90, 
                                                                                 byte 0x76, byte 0x39, byte 0x87, 
                                                                                 byte 0x98, byte 0x70, byte 0xB4), 
                                                         pid = uint32 3)
        
        /// [ VT_UNKNOWN ] This is an IPortableDeviceKeyCollection identifying the resources that can be created on an object with this rendering profile.
        let WPD_RENDERING_INFORMATION_PROFILE_ENTRY_CREATABLE_RESOURCES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xC53D039F, int16 0xEE23, 
                                                                                 int16 0x4A31, byte 0x85, byte 0x90, 
                                                                                 byte 0x76, byte 0x39, byte 0x87, 
                                                                                 byte 0x98, byte 0x70, byte 0xB4), 
                                                         pid = uint32 4)
    
    /// 
    module WPD_RESOURCE_ATTRIBUTES_V1 = 
        /// [ VT_UI8 ] Total size in bytes of the resource data.
        let WPD_RESOURCE_ATTRIBUTE_TOTAL_SIZE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x1EB6F604, int16 0x9278, 
                                                                                 int16 0x429F, byte 0x93, byte 0xCC, 
                                                                                 byte 0x5B, byte 0xB8, byte 0xC0, 
                                                                                 byte 0x66, byte 0x56, byte 0xB6), 
                                                         pid = uint32 2)
        
        /// [ VT_BOOL ] Indicates whether client applications have permission to open the resource for Read access.
        let WPD_RESOURCE_ATTRIBUTE_CAN_READ = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x1EB6F604, int16 0x9278, 
                                                                                 int16 0x429F, byte 0x93, byte 0xCC, 
                                                                                 byte 0x5B, byte 0xB8, byte 0xC0, 
                                                                                 byte 0x66, byte 0x56, byte 0xB6), 
                                                         pid = uint32 3)
        
        /// [ VT_BOOL ] Indicates whether client applications have permission to open the resource for Write access.
        let WPD_RESOURCE_ATTRIBUTE_CAN_WRITE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x1EB6F604, int16 0x9278, 
                                                                                 int16 0x429F, byte 0x93, byte 0xCC, 
                                                                                 byte 0x5B, byte 0xB8, byte 0xC0, 
                                                                                 byte 0x66, byte 0x56, byte 0xB6), 
                                                         pid = uint32 4)
        
        /// [ VT_BOOL ] Indicates whether client applications have permission to Delete a resource from the device.
        let WPD_RESOURCE_ATTRIBUTE_CAN_DELETE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x1EB6F604, int16 0x9278, 
                                                                                 int16 0x429F, byte 0x93, byte 0xCC, 
                                                                                 byte 0x5B, byte 0xB8, byte 0xC0, 
                                                                                 byte 0x66, byte 0x56, byte 0xB6), 
                                                         pid = uint32 5)
        
        /// [ VT_UI4 ] The recommended buffer size a caller should use when doing buffered reads on the resource.
        let WPD_RESOURCE_ATTRIBUTE_OPTIMAL_READ_BUFFER_SIZE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x1EB6F604, int16 0x9278, 
                                                                                 int16 0x429F, byte 0x93, byte 0xCC, 
                                                                                 byte 0x5B, byte 0xB8, byte 0xC0, 
                                                                                 byte 0x66, byte 0x56, byte 0xB6), 
                                                         pid = uint32 6)
        
        /// [ VT_UI4 ] The recommended buffer size a caller should use when doing buffered writes on the resource.
        let WPD_RESOURCE_ATTRIBUTE_OPTIMAL_WRITE_BUFFER_SIZE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x1EB6F604, int16 0x9278, 
                                                                                 int16 0x429F, byte 0x93, byte 0xCC, 
                                                                                 byte 0x5B, byte 0xB8, byte 0xC0, 
                                                                                 byte 0x66, byte 0x56, byte 0xB6), 
                                                         pid = uint32 7)
        
        /// [ VT_CLSID ] Indicates the format of the resource data.
        let WPD_RESOURCE_ATTRIBUTE_FORMAT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x1EB6F604, int16 0x9278, 
                                                                                 int16 0x429F, byte 0x93, byte 0xCC, 
                                                                                 byte 0x5B, byte 0xB8, byte 0xC0, 
                                                                                 byte 0x66, byte 0x56, byte 0xB6), 
                                                         pid = uint32 8)
        
        /// [ VT_UNKNOWN ] This is an IPortableDeviceKeyCollection containing a single value, which is the key identifying the resource.
        let WPD_RESOURCE_ATTRIBUTE_RESOURCE_KEY = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x1EB6F604, int16 0x9278, 
                                                                                 int16 0x429F, byte 0x93, byte 0xCC, 
                                                                                 byte 0x5B, byte 0xB8, byte 0xC0, 
                                                                                 byte 0x66, byte 0x56, byte 0xB6), 
                                                         pid = uint32 9)
    
    /// This category is for properties common to all objects whose content type is WPD_CONTENT_TYPE_SECTION
    module WPD_SECTION_OBJECT_PROPERTIES_V1 = 
        /// [ VT_UI8 ] Indicates the zero-based offset of the data for the referenced object.
        let WPD_SECTION_DATA_OFFSET = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x516AFD2B, int16 0xC64E, 
                                                                                 int16 0x44F0, byte 0x98, byte 0xDC, 
                                                                                 byte 0xBE, byte 0xE1, byte 0xC8, 
                                                                                 byte 0x8F, byte 0x7D, byte 0x66), 
                                                         pid = uint32 2)
        
        /// [ VT_UI8 ] Indicates the length of data for the referenced object.
        let WPD_SECTION_DATA_LENGTH = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x516AFD2B, int16 0xC64E, 
                                                                                 int16 0x44F0, byte 0x98, byte 0xDC, 
                                                                                 byte 0xBE, byte 0xE1, byte 0xC8, 
                                                                                 byte 0x8F, byte 0x7D, byte 0x66), 
                                                         pid = uint32 3)
        
        /// [ VT_UI4 ] Indicates the units for WPD_SECTION_DATA_OFFSET and WPD_SECTION_DATA_LENGTH properties on this object (e.g. offset in bytes, offset in milliseconds etc.).
        let WPD_SECTION_DATA_UNITS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x516AFD2B, int16 0xC64E, 
                                                                                 int16 0x44F0, byte 0x98, byte 0xDC, 
                                                                                 byte 0xBE, byte 0xE1, byte 0xC8, 
                                                                                 byte 0x8F, byte 0x7D, byte 0x66), 
                                                         pid = uint32 4)
        
        /// [ VT_UNKNOWN ] This is an IPortableDeviceKeyCollection containing a single value, which is the key identifying the resource on the referenced object which the WPD_SECTION_DATA_OFFSET and WPD_SECTION_DATA_LENGTH apply to.
        let WPD_SECTION_DATA_REFERENCED_OBJECT_RESOURCE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x516AFD2B, int16 0xC64E, 
                                                                                 int16 0x44F0, byte 0x98, byte 0xDC, 
                                                                                 byte 0xBE, byte 0xE1, byte 0xC8, 
                                                                                 byte 0x8F, byte 0x7D, byte 0x66), 
                                                         pid = uint32 5)
    
    /// 
    module WPD_SERVICE_PROPERTIES_V1 = 
        /// [ VT_LPWSTR ] Indicates the implementation version of a service.
        let WPD_SERVICE_VERSION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x7510698A, int16 0xCB54, 
                                                                                 int16 0x481C, byte 0xB8, byte 0xDB, 
                                                                                 byte 0x0D, byte 0x75, byte 0xC9, 
                                                                                 byte 0x3F, byte 0x1C, byte 0x06), 
                                                         pid = uint32 2)
    
    /// This category is for properties common to all objects whose functional category is WPD_FUNCTIONAL_CATEGORY_SMS
    module WPD_SMS_OBJECT_PROPERTIES_V1 = 
        /// [ VT_LPWSTR ] Indicates the service provider name.
        let WPD_SMS_PROVIDER = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x7E1074CC, int16 0x50FF, 
                                                                                 int16 0x4DD1, byte 0xA7, byte 0x42, 
                                                                                 byte 0x53, byte 0xBE, byte 0x6F, 
                                                                                 byte 0x09, byte 0x3A, byte 0x0D), 
                                                         pid = uint32 2)
        
        /// [ VT_UI4 ] Indicates the number of milliseconds until a timeout is returned.
        let WPD_SMS_TIMEOUT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x7E1074CC, int16 0x50FF, 
                                                                                 int16 0x4DD1, byte 0xA7, byte 0x42, 
                                                                                 byte 0x53, byte 0xBE, byte 0x6F, 
                                                                                 byte 0x09, byte 0x3A, byte 0x0D), 
                                                         pid = uint32 3)
        
        /// [ VT_UI4 ] Indicates the maximum number of bytes that can be contained in a message.
        let WPD_SMS_MAX_PAYLOAD = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x7E1074CC, int16 0x50FF, 
                                                                                 int16 0x4DD1, byte 0xA7, byte 0x42, 
                                                                                 byte 0x53, byte 0xBE, byte 0x6F, 
                                                                                 byte 0x09, byte 0x3A, byte 0x0D), 
                                                         pid = uint32 4)
        
        /// [ VT_UI4 ] Indicates how the driver will encode the text message sent by the client.
        let WPD_SMS_ENCODING = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x7E1074CC, int16 0x50FF, 
                                                                                 int16 0x4DD1, byte 0xA7, byte 0x42, 
                                                                                 byte 0x53, byte 0xBE, byte 0x6F, 
                                                                                 byte 0x09, byte 0x3A, byte 0x0D), 
                                                         pid = uint32 5)
    
    /// This category is for properties common to all objects whose functional category is WPD_FUNCTIONAL_CATEGORY_STILL_IMAGE_CAPTURE
    module WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1 = 
        /// [ VT_LPWSTR ] Controls the size of the image dimensions to capture in pixel width and height.
        let WPD_STILL_IMAGE_CAPTURE_RESOLUTION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 2)
        
        /// [ VT_CLSID ] Controls the format of the image to capture.
        let WPD_STILL_IMAGE_CAPTURE_FORMAT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 3)
        
        /// [ VT_UI8 ] Controls the device-specific quality setting.
        let WPD_STILL_IMAGE_COMPRESSION_SETTING = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 4)
        
        /// [ VT_UI4 ] Controls how the device weights color channels.
        let WPD_STILL_IMAGE_WHITE_BALANCE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 5)
        
        /// [ VT_LPWSTR ] Controls the RGB gain.
        let WPD_STILL_IMAGE_RGB_GAIN = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 6)
        
        /// [ VT_UI4 ] Controls the aperture of the lens.
        let WPD_STILL_IMAGE_FNUMBER = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 7)
        
        /// [ VT_UI4 ] Controls the 35mm equivalent focal length.
        let WPD_STILL_IMAGE_FOCAL_LENGTH = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 8)
        
        /// [ VT_UI4 ] This property corresponds to the focus distance in millimeters
        let WPD_STILL_IMAGE_FOCUS_DISTANCE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 9)
        
        /// [ VT_UI4 ] Identifies the focusing mode used by the device for image capture.
        let WPD_STILL_IMAGE_FOCUS_MODE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 10)
        
        /// [ VT_UI4 ] Identifies the exposure metering mode used by the device for image capture.
        let WPD_STILL_IMAGE_EXPOSURE_METERING_MODE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 11)
        
        /// [ VT_UI4 ] 
        let WPD_STILL_IMAGE_FLASH_MODE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 12)
        
        /// [ VT_UI4 ] Controls the shutter speed of the device.
        let WPD_STILL_IMAGE_EXPOSURE_TIME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 13)
        
        /// [ VT_UI4 ] Controls the exposure program mode of the device.
        let WPD_STILL_IMAGE_EXPOSURE_PROGRAM_MODE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 14)
        
        /// [ VT_UI4 ] Controls the emulation of film speed settings.
        let WPD_STILL_IMAGE_EXPOSURE_INDEX = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 15)
        
        /// [ VT_I4 ] Controls the adjustment of the auto exposure control.
        let WPD_STILL_IMAGE_EXPOSURE_BIAS_COMPENSATION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 16)
        
        /// [ VT_UI4 ] Controls the amount of time delay between the capture trigger and the actual data capture (in milliseconds).
        let WPD_STILL_IMAGE_CAPTURE_DELAY = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 17)
        
        /// [ VT_UI4 ] Controls the type of still image capture.
        let WPD_STILL_IMAGE_CAPTURE_MODE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 18)
        
        /// [ VT_UI4 ] Controls the perceived contrast of captured images.
        let WPD_STILL_IMAGE_CONTRAST = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 19)
        
        /// [ VT_UI4 ] Controls the perceived sharpness of the captured image.
        let WPD_STILL_IMAGE_SHARPNESS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 20)
        
        /// [ VT_UI4 ] Controls the effective zoom ratio of a digital camera's acquired image scaled by a factor of 10.
        let WPD_STILL_IMAGE_DIGITAL_ZOOM = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 21)
        
        /// [ VT_UI4 ] Controls the special effect mode of the capture.
        let WPD_STILL_IMAGE_EFFECT_MODE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 22)
        
        /// [ VT_UI4 ] Controls the number of images that the device will attempt to capture upon initiation of a burst operation.
        let WPD_STILL_IMAGE_BURST_NUMBER = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 23)
        
        /// [ VT_UI4 ] Controls the time delay between captures upon initiation of a burst operation.
        let WPD_STILL_IMAGE_BURST_INTERVAL = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 24)
        
        /// [ VT_UI4 ] Controls the number of images that the device will attempt to capture upon initiation of a time-lapse capture.
        let WPD_STILL_IMAGE_TIMELAPSE_NUMBER = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 25)
        
        /// [ VT_UI4 ] Controls the time delay between captures upon initiation of a time-lapse operation.
        let WPD_STILL_IMAGE_TIMELAPSE_INTERVAL = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 26)
        
        /// [ VT_UI4 ] Controls which automatic focus mechanism is used by the device.
        let WPD_STILL_IMAGE_FOCUS_METERING_MODE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 27)
        
        /// [ VT_LPWSTR ] Used to describe the URL that the device may use to upload images upon capture.
        let WPD_STILL_IMAGE_UPLOAD_URL = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 28)
        
        /// [ VT_LPWSTR ] Contains the owner/user of the device, which may be inserted as meta-data into any images that are captured.
        let WPD_STILL_IMAGE_ARTIST = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 29)
        
        /// [ VT_LPWSTR ] Contains the model of the device
        let WPD_STILL_IMAGE_CAMERA_MODEL = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 30)
        
        /// [ VT_LPWSTR ] Contains the manufacturer of the device
        let WPD_STILL_IMAGE_CAMERA_MANUFACTURER = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x58C571EC, int16 0x1BCB, 
                                                                                 int16 0x42A7, byte 0x8A, byte 0xC5, 
                                                                                 byte 0xBB, byte 0x29, byte 0x15, 
                                                                                 byte 0x73, byte 0xA2, byte 0x60), 
                                                         pid = uint32 31)
    
    /// This category is for properties common to all objects whose functional category is WPD_FUNCTIONAL_CATEGORY_STORAGE.
    module WPD_STORAGE_OBJECT_PROPERTIES_V1 = 
        /// [ VT_UI4 ] Indicates the type of storage e.g. fixed, removable etc.
        let WPD_STORAGE_TYPE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x01A3057A, int16 0x74D6, 
                                                                                 int16 0x4E80, byte 0xBE, byte 0xA7, 
                                                                                 byte 0xDC, byte 0x4C, byte 0x21, 
                                                                                 byte 0x2C, byte 0xE5, byte 0x0A), 
                                                         pid = uint32 2)
        
        /// [ VT_LPWSTR ] Indicates the file system type e.g. "FAT32" or "NTFS" or "My Special File System"
        let WPD_STORAGE_FILE_SYSTEM_TYPE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x01A3057A, int16 0x74D6, 
                                                                                 int16 0x4E80, byte 0xBE, byte 0xA7, 
                                                                                 byte 0xDC, byte 0x4C, byte 0x21, 
                                                                                 byte 0x2C, byte 0xE5, byte 0x0A), 
                                                         pid = uint32 3)
        
        /// [ VT_UI8 ] Indicates the total storage capacity in bytes.
        let WPD_STORAGE_CAPACITY = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x01A3057A, int16 0x74D6, 
                                                                                 int16 0x4E80, byte 0xBE, byte 0xA7, 
                                                                                 byte 0xDC, byte 0x4C, byte 0x21, 
                                                                                 byte 0x2C, byte 0xE5, byte 0x0A), 
                                                         pid = uint32 4)
        
        /// [ VT_UI8 ] Indicates the available space in bytes.
        let WPD_STORAGE_FREE_SPACE_IN_BYTES = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x01A3057A, int16 0x74D6, 
                                                                                 int16 0x4E80, byte 0xBE, byte 0xA7, 
                                                                                 byte 0xDC, byte 0x4C, byte 0x21, 
                                                                                 byte 0x2C, byte 0xE5, byte 0x0A), 
                                                         pid = uint32 5)
        
        /// [ VT_UI8 ] Indicates the available space in objects e.g. available slots on a SIM card.
        let WPD_STORAGE_FREE_SPACE_IN_OBJECTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x01A3057A, int16 0x74D6, 
                                                                                 int16 0x4E80, byte 0xBE, byte 0xA7, 
                                                                                 byte 0xDC, byte 0x4C, byte 0x21, 
                                                                                 byte 0x2C, byte 0xE5, byte 0x0A), 
                                                         pid = uint32 6)
        
        /// [ VT_LPWSTR ] Contains a description of the storage.
        let WPD_STORAGE_DESCRIPTION = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x01A3057A, int16 0x74D6, 
                                                                                 int16 0x4E80, byte 0xBE, byte 0xA7, 
                                                                                 byte 0xDC, byte 0x4C, byte 0x21, 
                                                                                 byte 0x2C, byte 0xE5, byte 0x0A), 
                                                         pid = uint32 7)
        
        /// [ VT_LPWSTR ] Contains the serial number of the storage.
        let WPD_STORAGE_SERIAL_NUMBER = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x01A3057A, int16 0x74D6, 
                                                                                 int16 0x4E80, byte 0xBE, byte 0xA7, 
                                                                                 byte 0xDC, byte 0x4C, byte 0x21, 
                                                                                 byte 0x2C, byte 0xE5, byte 0x0A), 
                                                         pid = uint32 8)
        
        /// [ VT_UI8 ] Specifies the maximum size of a single object (in bytes) that can be placed on this storage.
        let WPD_STORAGE_MAX_OBJECT_SIZE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x01A3057A, int16 0x74D6, 
                                                                                 int16 0x4E80, byte 0xBE, byte 0xA7, 
                                                                                 byte 0xDC, byte 0x4C, byte 0x21, 
                                                                                 byte 0x2C, byte 0xE5, byte 0x0A), 
                                                         pid = uint32 9)
        
        /// [ VT_UI8 ] Indicates the total storage capacity in objects e.g. available slots on a SIM card.
        let WPD_STORAGE_CAPACITY_IN_OBJECTS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x01A3057A, int16 0x74D6, 
                                                                                 int16 0x4E80, byte 0xBE, byte 0xA7, 
                                                                                 byte 0xDC, byte 0x4C, byte 0x21, 
                                                                                 byte 0x2C, byte 0xE5, byte 0x0A), 
                                                         pid = uint32 10)
        
        /// [ VT_UI4 ] This property identifies any write-protection that globally affects this storage. This takes precedence over access specified on individual objects.
        let WPD_STORAGE_ACCESS_CAPABILITY = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x01A3057A, int16 0x74D6, 
                                                                                 int16 0x4E80, byte 0xBE, byte 0xA7, 
                                                                                 byte 0xDC, byte 0x4C, byte 0x21, 
                                                                                 byte 0x2C, byte 0xE5, byte 0x0A), 
                                                         pid = uint32 11)
    
    /// This category is for properties common to all task objects.
    module WPD_TASK_OBJECT_PROPERTIES_V1 = 
        /// [ VT_LPWSTR ] Indicates the status of the task e.g. "In Progress".
        let WPD_TASK_STATUS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xE354E95E, int16 0xD8A0, 
                                                                                 int16 0x4637, byte 0xA0, byte 0x3A, 
                                                                                 byte 0x0C, byte 0xB2, byte 0x68, 
                                                                                 byte 0x38, byte 0xDB, byte 0xC7), 
                                                         pid = uint32 6)
        
        /// [ VT_UI4 ] Indicates how much of the task has been completed.
        let WPD_TASK_PERCENT_COMPLETE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xE354E95E, int16 0xD8A0, 
                                                                                 int16 0x4637, byte 0xA0, byte 0x3A, 
                                                                                 byte 0x0C, byte 0xB2, byte 0x68, 
                                                                                 byte 0x38, byte 0xDB, byte 0xC7), 
                                                         pid = uint32 8)
        
        /// [ VT_DATE ] Indicates the date and time set for the reminder. If this value is 0, then it is assumed that this task has no reminder.
        let WPD_TASK_REMINDER_DATE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xE354E95E, int16 0xD8A0, 
                                                                                 int16 0x4637, byte 0xA0, byte 0x3A, 
                                                                                 byte 0x0C, byte 0xB2, byte 0x68, 
                                                                                 byte 0x38, byte 0xDB, byte 0xC7), 
                                                         pid = uint32 10)
        
        /// [ VT_LPWSTR ] Indicates the owner of the task.
        let WPD_TASK_OWNER = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0xE354E95E, int16 0xD8A0, 
                                                                                 int16 0x4637, byte 0xA0, byte 0x3A, 
                                                                                 byte 0x0C, byte 0xB2, byte 0x68, 
                                                                                 byte 0x38, byte 0xDB, byte 0xC7), 
                                                         pid = uint32 11)
    
    /// This category is for properties common to all video objects.
    module WPD_VIDEO_OBJECT_PROPERTIES_V1 = 
        /// [ VT_LPWSTR ] Indicates the author of the video file.
        let WPD_VIDEO_AUTHOR = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x346F2163, int16 0xF998, 
                                                                                 int16 0x4146, byte 0x8B, byte 0x01, 
                                                                                 byte 0xD1, byte 0x9B, byte 0x4C, 
                                                                                 byte 0x00, byte 0xDE, byte 0x9A), 
                                                         pid = uint32 2)
        
        /// [ VT_LPWSTR ] Indicates the TV station the video was recorded from.
        let WPD_VIDEO_RECORDEDTV_STATION_NAME = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x346F2163, int16 0xF998, 
                                                                                 int16 0x4146, byte 0x8B, byte 0x01, 
                                                                                 byte 0xD1, byte 0x9B, byte 0x4C, 
                                                                                 byte 0x00, byte 0xDE, byte 0x9A), 
                                                         pid = uint32 4)
        
        /// [ VT_UI4 ] Indicates the TV channel number the video was recorded from.
        let WPD_VIDEO_RECORDEDTV_CHANNEL_NUMBER = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x346F2163, int16 0xF998, 
                                                                                 int16 0x4146, byte 0x8B, byte 0x01, 
                                                                                 byte 0xD1, byte 0x9B, byte 0x4C, 
                                                                                 byte 0x00, byte 0xDE, byte 0x9A), 
                                                         pid = uint32 5)
        
        /// [ VT_BOOL ] Indicates whether the recorded TV program was a repeat showing.
        let WPD_VIDEO_RECORDEDTV_REPEAT = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x346F2163, int16 0xF998, 
                                                                                 int16 0x4146, byte 0x8B, byte 0x01, 
                                                                                 byte 0xD1, byte 0x9B, byte 0x4C, 
                                                                                 byte 0x00, byte 0xDE, byte 0x9A), 
                                                         pid = uint32 7)
        
        /// [ VT_UI4 ] Indicates the video buffer size.
        let WPD_VIDEO_BUFFER_SIZE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x346F2163, int16 0xF998, 
                                                                                 int16 0x4146, byte 0x8B, byte 0x01, 
                                                                                 byte 0xD1, byte 0x9B, byte 0x4C, 
                                                                                 byte 0x00, byte 0xDE, byte 0x9A), 
                                                         pid = uint32 8)
        
        /// [ VT_LPWSTR ] Indicates the credit text for the video file.
        let WPD_VIDEO_CREDITS = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x346F2163, int16 0xF998, 
                                                                                 int16 0x4146, byte 0x8B, byte 0x01, 
                                                                                 byte 0xD1, byte 0x9B, byte 0x4C, 
                                                                                 byte 0x00, byte 0xDE, byte 0x9A), 
                                                         pid = uint32 9)
        
        /// [ VT_UI4 ] Indicates the interval between key frames in milliseconds.
        let WPD_VIDEO_KEY_FRAME_DISTANCE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x346F2163, int16 0xF998, 
                                                                                 int16 0x4146, byte 0x8B, byte 0x01, 
                                                                                 byte 0xD1, byte 0x9B, byte 0x4C, 
                                                                                 byte 0x00, byte 0xDE, byte 0x9A), 
                                                         pid = uint32 10)
        
        /// [ VT_UI4 ] Indicates the quality setting for the video file.
        let WPD_VIDEO_QUALITY_SETTING = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x346F2163, int16 0xF998, 
                                                                                 int16 0x4146, byte 0x8B, byte 0x01, 
                                                                                 byte 0xD1, byte 0x9B, byte 0x4C, 
                                                                                 byte 0x00, byte 0xDE, byte 0x9A), 
                                                         pid = uint32 11)
        
        /// [ VT_UI4 ] This property identifies the video scan information.
        let WPD_VIDEO_SCAN_TYPE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x346F2163, int16 0xF998, 
                                                                                 int16 0x4146, byte 0x8B, byte 0x01, 
                                                                                 byte 0xD1, byte 0x9B, byte 0x4C, 
                                                                                 byte 0x00, byte 0xDE, byte 0x9A), 
                                                         pid = uint32 12)
        
        /// [ VT_UI4 ] Indicates the bitrate for the video data.
        let WPD_VIDEO_BITRATE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x346F2163, int16 0xF998, 
                                                                                 int16 0x4146, byte 0x8B, byte 0x01, 
                                                                                 byte 0xD1, byte 0x9B, byte 0x4C, 
                                                                                 byte 0x00, byte 0xDE, byte 0x9A), 
                                                         pid = uint32 13)
        
        /// [ VT_UI4 ] The registered FourCC code indicating the codec used for the video file.
        let WPD_VIDEO_FOURCC_CODE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x346F2163, int16 0xF998, 
                                                                                 int16 0x4146, byte 0x8B, byte 0x01, 
                                                                                 byte 0xD1, byte 0x9B, byte 0x4C, 
                                                                                 byte 0x00, byte 0xDE, byte 0x9A), 
                                                         pid = uint32 14)
        
        /// [ VT_UI4 ] Indicates the frame rate for the video data.
        let WPD_VIDEO_FRAMERATE = 
            fun () -> 
                new PortableDeviceApiLib._tagpropertykey(fmtid = new System.Guid(int32 0x346F2163, int16 0xF998, 
                                                                                 int16 0x4146, byte 0x8B, byte 0x01, 
                                                                                 byte 0xD1, byte 0x9B, byte 0x4C, 
                                                                                 byte 0x00, byte 0xDE, byte 0x9A), 
                                                         pid = uint32 15)
