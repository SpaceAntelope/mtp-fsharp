namespace PortableDevices

module PDHeader = 
    ////
    /// This section declares WPD guids used in PnP
    ///
    ///
    /// GUID_DEVINTERFACE_WPD
    ///   This GUID is used to identify devices / drivers that support the WPD DDI.
    ///   The WPD Class Extension component enables this device interface for WPD Drivers that use it. Clients use this PnP interface when registering for PnP device arrival messages for WPD devices.
    let GUID_DEVINTERFACE_WPD = new System.Guid(0x6AC27878u, 0xA6FAus, 0x4155us, 0xBAuy, 0x85uy, 0xF9uy, 0x8Fuy, 0x49uy, 0x1Duy, 0x4Fuy, 0x33uy)
    
    ///
    /// GUID_DEVINTERFACE_WPD_PRIVATE
    ///   This GUID is used to identify devices / drivers that can be used only by a specialized WPD client and will not show up in normal WPD enumeration.
    ///   Devices identified with this interface cannot be used with normal WPD applications. Generic WPD drivers and clients should not use this interface.
    let GUID_DEVINTERFACE_WPD_PRIVATE = new System.Guid(0xBA0C718Fu, 0x4DEDus, 0x49B7us, 0xBDuy, 0xD3uy, 0xFAuy, 0xBEuy, 0x28uy, 0x66uy, 0x12uy, 0x11uy)
    
    ///
    /// GUID_DEVINTERFACE_WPD_SERVICE
    ///   This GUID is used to identify services that support the WPD Services DDI.
    ///   The WPD Class Extension component enables this device interface for WPD Services that use it. Clients use this PnP interface when registering for PnP device arrival messages for ALL WPD services. To register for specific categories of services, client should use the service category or service implements GUID.
    let GUID_DEVINTERFACE_WPD_SERVICE = new System.Guid(0x9EF44F80u, 0x3D64us, 0x4246us, 0xA6uy, 0xAAuy, 0x20uy, 0x6Fuy, 0x32uy, 0x8Duy, 0x1Euy, 0xDCuy)
    
    //// 
    /// This section defines all WPD Events
    ///
    ///
    /// WPD_EVENT_NOTIFICATION
    ///   This GUID is used to identify all WPD driver events to the event sub-system. The driver uses this as the GUID identifier when it queues an event with IWdfDevice::PostEvent(). Applications never use this value.
    let WPD_EVENT_NOTIFICATION = new System.Guid(0x2BA2E40Au, 0x6B4Cus, 0x4295us, 0xBBuy, 0x43uy, 0x26uy, 0x32uy, 0x2Buy, 0x99uy, 0xAEuy, 0xB2uy)
    
    ///
    /// WPD_EVENT_OBJECT_ADDED
    ///   This event is sent after a new object is available on the device.
    let WPD_EVENT_OBJECT_ADDED = new System.Guid(0xA726DA95u, 0xE207us, 0x4B02us, 0x8Duy, 0x44uy, 0xBEuy, 0xF2uy, 0xE8uy, 0x6Cuy, 0xBFuy, 0xFCuy)
    
    ///
    /// WPD_EVENT_OBJECT_REMOVED
    ///   This event is sent after a previously existing object has been removed from the device.
    let WPD_EVENT_OBJECT_REMOVED = new System.Guid(0xBE82AB88u, 0xA52Cus, 0x4823us, 0x96uy, 0xE5uy, 0xD0uy, 0x27uy, 0x26uy, 0x71uy, 0xFCuy, 0x38uy)
    
    ///
    /// WPD_EVENT_OBJECT_UPDATED
    ///   This event is sent after an object has been updated such that any connected client should refresh its view of that object.
    let WPD_EVENT_OBJECT_UPDATED = new System.Guid(0x1445A759u, 0x2E01us, 0x485Dus, 0x9Fuy, 0x27uy, 0xFFuy, 0x07uy, 0xDAuy, 0xE6uy, 0x97uy, 0xABuy)
    
    ///
    /// WPD_EVENT_DEVICE_RESET
    ///   This event indicates that the device is about to be reset, and all connected clients should close their connection to the device.
    let WPD_EVENT_DEVICE_RESET = new System.Guid(0x7755CF53u, 0xC1EDus, 0x44F3us, 0xB5uy, 0xA2uy, 0x45uy, 0x1Euy, 0x2Cuy, 0x37uy, 0x6Buy, 0x27uy)
    
    ///
    /// WPD_EVENT_DEVICE_CAPABILITIES_UPDATED
    ///   This event indicates that the device capabilities have changed. Clients should re-query the device if they have made any decisions based on device capabilities.
    let WPD_EVENT_DEVICE_CAPABILITIES_UPDATED = new System.Guid(0x36885AA1u, 0xCD54us, 0x4DAAus, 0xB3uy, 0xD0uy, 0xAFuy, 0xB3uy, 0xE0uy, 0x3Fuy, 0x59uy, 0x99uy)
    
    ///
    /// WPD_EVENT_STORAGE_FORMAT
    ///   This event indicates the progress of a format operation on a storage object.
    let WPD_EVENT_STORAGE_FORMAT = new System.Guid(0x3782616Bu, 0x22BCus, 0x4474us, 0xA2uy, 0x51uy, 0x30uy, 0x70uy, 0xF8uy, 0xD3uy, 0x88uy, 0x57uy)
    
    ///
    /// WPD_EVENT_OBJECT_TRANSFER_REQUESTED
    ///   This event is sent to request an application to transfer a particular object from the device.
    let WPD_EVENT_OBJECT_TRANSFER_REQUESTED = new System.Guid(0x8D16A0A1u, 0xF2C6us, 0x41DAus, 0x8Fuy, 0x19uy, 0x5Euy, 0x53uy, 0x72uy, 0x1Auy, 0xDBuy, 0xF2uy)
    
    ///
    /// WPD_EVENT_DEVICE_REMOVED
    ///   This event is sent when a driver for a device is being unloaded. This is typically a result of the device being unplugged.
    let WPD_EVENT_DEVICE_REMOVED = new System.Guid(0xE4CBCA1Bu, 0x6918us, 0x48B9us, 0x85uy, 0xEEuy, 0x02uy, 0xBEuy, 0x7Cuy, 0x85uy, 0x0Auy, 0xF9uy)
    
    ///
    /// WPD_EVENT_SERVICE_METHOD_COMPLETE
    ///   This event is sent when a driver has completed invoking a service method. This event must be sent even when the method fails.
    let WPD_EVENT_SERVICE_METHOD_COMPLETE = new System.Guid(0x8A33F5F8u, 0x0ACCus, 0x4D9Bus, 0x9Cuy, 0xC4uy, 0x11uy, 0x2Duy, 0x35uy, 0x3Buy, 0x86uy, 0xCAuy)
    
    ////
    /// This section defines all WPD content types
    ///
    ///
    /// WPD_CONTENT_TYPE_FUNCTIONAL_OBJECT
    ///   Indicates this object represents a functional object, not content data on the device.
    let WPD_CONTENT_TYPE_FUNCTIONAL_OBJECT = new System.Guid(0x99ED0160u, 0x17FFus, 0x4C44us, 0x9Duy, 0x98uy, 0x1Duy, 0x7Auy, 0x6Fuy, 0x94uy, 0x19uy, 0x21uy)
    
    ///
    /// WPD_CONTENT_TYPE_FOLDER
    ///   Indicates this object is a folder.
    let WPD_CONTENT_TYPE_FOLDER = new System.Guid(0x27E2E392u, 0xA111us, 0x48E0us, 0xABuy, 0x0Cuy, 0xE1uy, 0x77uy, 0x05uy, 0xA0uy, 0x5Fuy, 0x85uy)
    
    ///
    /// WPD_CONTENT_TYPE_IMAGE
    ///   Indicates this object represents image data (e.g. a JPEG file)
    let WPD_CONTENT_TYPE_IMAGE = new System.Guid(0xef2107d5u, 0xa52aus, 0x4243us, 0xa2uy, 0x6buy, 0x62uy, 0xd4uy, 0x17uy, 0x6duy, 0x76uy, 0x03uy)
    
    ///
    /// WPD_CONTENT_TYPE_DOCUMENT
    ///   Indicates this object represents document data (e.g. a MS WORD file, TEXT file, etc.)
    let WPD_CONTENT_TYPE_DOCUMENT = new System.Guid(0x680ADF52u, 0x950Aus, 0x4041us, 0x9Buy, 0x41uy, 0x65uy, 0xE3uy, 0x93uy, 0x64uy, 0x81uy, 0x55uy)
    
    ///
    /// WPD_CONTENT_TYPE_CONTACT
    ///   Indicates this object represents contact data (e.g. name/number, or a VCARD file)
    let WPD_CONTENT_TYPE_CONTACT = new System.Guid(0xEABA8313u, 0x4525us, 0x4707us, 0x9Fuy, 0x0Euy, 0x87uy, 0xC6uy, 0x80uy, 0x8Euy, 0x94uy, 0x35uy)
    
    ///
    /// WPD_CONTENT_TYPE_CONTACT_GROUP
    ///   Indicates this object represents a group of contacts.
    let WPD_CONTENT_TYPE_CONTACT_GROUP = new System.Guid(0x346B8932u, 0x4C36us, 0x40D8us, 0x94uy, 0x15uy, 0x18uy, 0x28uy, 0x29uy, 0x1Fuy, 0x9Duy, 0xE9uy)
    
    ///
    /// WPD_CONTENT_TYPE_AUDIO
    ///   Indicates this object represents audio data (e.g. a WMA or MP3 file)
    let WPD_CONTENT_TYPE_AUDIO = new System.Guid(0x4AD2C85Eu, 0x5E2Dus, 0x45E5us, 0x88uy, 0x64uy, 0x4Fuy, 0x22uy, 0x9Euy, 0x3Cuy, 0x6Cuy, 0xF0uy)
    
    ///
    /// WPD_CONTENT_TYPE_VIDEO
    ///   Indicates this object represents video data (e.g. a WMV or AVI file)
    let WPD_CONTENT_TYPE_VIDEO = new System.Guid(0x9261B03Cu, 0x3D78us, 0x4519us, 0x85uy, 0xE3uy, 0x02uy, 0xC5uy, 0xE1uy, 0xF5uy, 0x0Buy, 0xB9uy)
    
    ///
    /// WPD_CONTENT_TYPE_TELEVISION
    ///   Indicates this object represents a television recording.
    let WPD_CONTENT_TYPE_TELEVISION = new System.Guid(0x60A169CFu, 0xF2AEus, 0x4E21us, 0x93uy, 0x75uy, 0x96uy, 0x77uy, 0xF1uy, 0x1Cuy, 0x1Cuy, 0x6Euy)
    
    ///
    /// WPD_CONTENT_TYPE_PLAYLIST
    ///   Indicates this object represents a playlist.
    let WPD_CONTENT_TYPE_PLAYLIST = new System.Guid(0x1A33F7E4u, 0xAF13us, 0x48F5us, 0x99uy, 0x4Euy, 0x77uy, 0x36uy, 0x9Duy, 0xFEuy, 0x04uy, 0xA3uy)
    
    ///
    /// WPD_CONTENT_TYPE_MIXED_CONTENT_ALBUM
    ///   Indicates this object represents an album, which may contain objects of different content types (typically, MUSIC, IMAGE and VIDEO).
    let WPD_CONTENT_TYPE_MIXED_CONTENT_ALBUM = new System.Guid(0x00F0C3ACu, 0xA593us, 0x49ACus, 0x92uy, 0x19uy, 0x24uy, 0xABuy, 0xCAuy, 0x5Auy, 0x25uy, 0x63uy)
    
    ///
    /// WPD_CONTENT_TYPE_AUDIO_ALBUM
    ///   Indicates this object represents an audio album.
    let WPD_CONTENT_TYPE_AUDIO_ALBUM = new System.Guid(0xAA18737Eu, 0x5009us, 0x48FAus, 0xAEuy, 0x21uy, 0x85uy, 0xF2uy, 0x43uy, 0x83uy, 0xB4uy, 0xE6uy)
    
    ///
    /// WPD_CONTENT_TYPE_IMAGE_ALBUM
    ///   Indicates this object represents an image album.
    let WPD_CONTENT_TYPE_IMAGE_ALBUM = new System.Guid(0x75793148u, 0x15F5us, 0x4A30us, 0xA8uy, 0x13uy, 0x54uy, 0xEDuy, 0x8Auy, 0x37uy, 0xE2uy, 0x26uy)
    
    ///
    /// WPD_CONTENT_TYPE_VIDEO_ALBUM
    ///   Indicates this object represents a video album.
    let WPD_CONTENT_TYPE_VIDEO_ALBUM = new System.Guid(0x012B0DB7u, 0xD4C1us, 0x45D6us, 0xB0uy, 0x81uy, 0x94uy, 0xB8uy, 0x77uy, 0x79uy, 0x61uy, 0x4Fuy)
    
    ///
    /// WPD_CONTENT_TYPE_MEMO
    ///   Indicates this object represents memo data
    let WPD_CONTENT_TYPE_MEMO = new System.Guid(0x9CD20ECFu, 0x3B50us, 0x414Fus, 0xA6uy, 0x41uy, 0xE4uy, 0x73uy, 0xFFuy, 0xE4uy, 0x57uy, 0x51uy)
    
    ///
    /// WPD_CONTENT_TYPE_EMAIL
    ///   Indicates this object represents e-mail data
    let WPD_CONTENT_TYPE_EMAIL = new System.Guid(0x8038044Au, 0x7E51us, 0x4F8Fus, 0x88uy, 0x3Duy, 0x1Duy, 0x06uy, 0x23uy, 0xD1uy, 0x45uy, 0x33uy)
    
    ///
    /// WPD_CONTENT_TYPE_APPOINTMENT
    ///   Indicates this object represents an appointment in a calendar
    let WPD_CONTENT_TYPE_APPOINTMENT = new System.Guid(0x0FED060Eu, 0x8793us, 0x4B1Eus, 0x90uy, 0xC9uy, 0x48uy, 0xACuy, 0x38uy, 0x9Auy, 0xC6uy, 0x31uy)
    
    ///
    /// WPD_CONTENT_TYPE_TASK
    ///   Indicates this object represents a task for tracking (e.g. a TODO list)
    let WPD_CONTENT_TYPE_TASK = new System.Guid(0x63252F2Cu, 0x887Fus, 0x4CB6us, 0xB1uy, 0xACuy, 0xD2uy, 0x98uy, 0x55uy, 0xDCuy, 0xEFuy, 0x6Cuy)
    
    ///
    /// WPD_CONTENT_TYPE_PROGRAM
    ///   Indicates this object represents a file that can be run. This could be a script, executable and so on.
    let WPD_CONTENT_TYPE_PROGRAM = new System.Guid(0xD269F96Au, 0x247Cus, 0x4BFFus, 0x98uy, 0xFBuy, 0x97uy, 0xF3uy, 0xC4uy, 0x92uy, 0x20uy, 0xE6uy)
    
    ///
    /// WPD_CONTENT_TYPE_GENERIC_FILE
    ///   Indicates this object represents a file that does not fall into any of the other predefined WPD types for files.
    let WPD_CONTENT_TYPE_GENERIC_FILE = new System.Guid(0x0085E0A6u, 0x8D34us, 0x45D7us, 0xBCuy, 0x5Cuy, 0x44uy, 0x7Euy, 0x59uy, 0xC7uy, 0x3Duy, 0x48uy)
    
    ///
    /// WPD_CONTENT_TYPE_CALENDAR
    ///   Indicates this object represents a calender
    let WPD_CONTENT_TYPE_CALENDAR = new System.Guid(0xA1FD5967u, 0x6023us, 0x49A0us, 0x9Duy, 0xF1uy, 0xF8uy, 0x06uy, 0x0Buy, 0xE7uy, 0x51uy, 0xB0uy)
    
    ///
    /// WPD_CONTENT_TYPE_GENERIC_MESSAGE
    ///   Indicates this object represents a message (e.g. SMS message, E-Mail message, etc.)
    let WPD_CONTENT_TYPE_GENERIC_MESSAGE = new System.Guid(0xE80EAAF8u, 0xB2DBus, 0x4133us, 0xB6uy, 0x7Euy, 0x1Buy, 0xEFuy, 0x4Buy, 0x4Auy, 0x6Euy, 0x5Fuy)
    
    ///
    /// WPD_CONTENT_TYPE_NETWORK_ASSOCIATION
    ///   Indicates this object represents an association between a host and a device.
    let WPD_CONTENT_TYPE_NETWORK_ASSOCIATION = new System.Guid(0x031DA7EEu, 0x18C8us, 0x4205us, 0x84uy, 0x7Euy, 0x89uy, 0xA1uy, 0x12uy, 0x61uy, 0xD0uy, 0xF3uy)
    
    ///
    /// WPD_CONTENT_TYPE_CERTIFICATE
    ///   Indicates this object represents certificate used for authentication.
    let WPD_CONTENT_TYPE_CERTIFICATE = new System.Guid(0xDC3876E8u, 0xA948us, 0x4060us, 0x90uy, 0x50uy, 0xCBuy, 0xD7uy, 0x7Euy, 0x8Auy, 0x3Duy, 0x87uy)
    
    ///
    /// WPD_CONTENT_TYPE_WIRELESS_PROFILE
    ///   Indicates this object represents wireless network access information.
    let WPD_CONTENT_TYPE_WIRELESS_PROFILE = new System.Guid(0x0BAC070Au, 0x9F5Fus, 0x4DA4us, 0xA8uy, 0xF6uy, 0x3Duy, 0xE4uy, 0x4Duy, 0x68uy, 0xFDuy, 0x6Cuy)
    
    ///
    /// WPD_CONTENT_TYPE_MEDIA_CAST
    ///   Indicates this object represents a media cast. A media cast object can be though of as a container object that groups related content, similar to how a playlist groups songs to play. Often, a media cast object is used to group media content originally published online.
    let WPD_CONTENT_TYPE_MEDIA_CAST = new System.Guid(0x5E88B3CCu, 0x3E65us, 0x4E62us, 0xBFuy, 0xFFuy, 0x22uy, 0x94uy, 0x95uy, 0x25uy, 0x3Auy, 0xB0uy)
    
    ///
    /// WPD_CONTENT_TYPE_SECTION
    ///   Indicates this object describes a section of data contained in another object. The WPD_OBJECT_REFERENCES property indicates which object contains the actual data.
    let WPD_CONTENT_TYPE_SECTION = new System.Guid(0x821089F5u, 0x1D91us, 0x4DC9us, 0xBEuy, 0x3Cuy, 0xBBuy, 0xB1uy, 0xB3uy, 0x5Buy, 0x18uy, 0xCEuy)
    
    ///
    /// WPD_CONTENT_TYPE_UNSPECIFIED
    ///   Indicates this object doesn't fall into the predefined WPD content types
    let WPD_CONTENT_TYPE_UNSPECIFIED = new System.Guid(0x28D8D31Eu, 0x249Cus, 0x454Eus, 0xAAuy, 0xBCuy, 0x34uy, 0x88uy, 0x31uy, 0x68uy, 0xE6uy, 0x34uy)
    
    ///
    /// WPD_CONTENT_TYPE_ALL
    ///   This content type is only valid as a parameter to API functions and driver commands. It should not be reported as a supported content type by the driver.
    let WPD_CONTENT_TYPE_ALL = new System.Guid(0x80E170D2u, 0x1055us, 0x4A3Eus, 0xB9uy, 0x52uy, 0x82uy, 0xCCuy, 0x4Fuy, 0x8Auy, 0x86uy, 0x89uy)
    
    //// 
    /// This section defines all WPD Functional Categories
    ///
    ///
    /// WPD_FUNCTIONAL_CATEGORY_DEVICE
    /// Used for the device object, which is always the top-most object of the device.
    let WPD_FUNCTIONAL_CATEGORY_DEVICE = new System.Guid(0x08EA466Bu, 0xE3A4us, 0x4336us, 0xA1uy, 0xF3uy, 0xA4uy, 0x4Duy, 0x2Buy, 0x5Cuy, 0x43uy, 0x8Cuy)
    
    ///
    /// WPD_FUNCTIONAL_CATEGORY_STORAGE
    /// Indicates this object encapsulates storage functionality on the device (e.g. memory cards, internal memory)
    let WPD_FUNCTIONAL_CATEGORY_STORAGE = new System.Guid(0x23F05BBCu, 0x15DEus, 0x4C2Aus, 0xA5uy, 0x5Buy, 0xA9uy, 0xAFuy, 0x5Cuy, 0xE4uy, 0x12uy, 0xEFuy)
    
    ///
    /// WPD_FUNCTIONAL_CATEGORY_STILL_IMAGE_CAPTURE
    /// Indicates this object encapsulates still image capture functionality on the device (e.g. camera or camera attachment)
    let WPD_FUNCTIONAL_CATEGORY_STILL_IMAGE_CAPTURE = new System.Guid(0x613CA327u, 0xAB93us, 0x4900us, 0xB4uy, 0xFAuy, 0x89uy, 0x5Buy, 0xB5uy, 0x87uy, 0x4Buy, 0x79uy)
    
    ///
    /// WPD_FUNCTIONAL_CATEGORY_AUDIO_CAPTURE
    /// Indicates this object encapsulates audio capture functionality on the device (e.g. voice recorder or other audio recording component)
    let WPD_FUNCTIONAL_CATEGORY_AUDIO_CAPTURE = new System.Guid(0x3F2A1919u, 0xC7C2us, 0x4A00us, 0x85uy, 0x5Duy, 0xF5uy, 0x7Cuy, 0xF0uy, 0x6Duy, 0xEBuy, 0xBBuy)
    
    ///
    /// WPD_FUNCTIONAL_CATEGORY_VIDEO_CAPTURE
    /// Indicates this object encapsulates video capture functionality on the device (e.g. video recorder or video recording component)
    let WPD_FUNCTIONAL_CATEGORY_VIDEO_CAPTURE = new System.Guid(0xE23E5F6Bu, 0x7243us, 0x43AAus, 0x8Duy, 0xF1uy, 0x0Euy, 0xB3uy, 0xD9uy, 0x68uy, 0xA9uy, 0x18uy)
    
    ///
    /// WPD_FUNCTIONAL_CATEGORY_SMS
    /// Indicates this object encapsulates SMS sending functionality on the device (not the receiving or saved SMS messages since those are represented as content objects on the device)
    let WPD_FUNCTIONAL_CATEGORY_SMS = new System.Guid(0x0044A0B1u, 0xC1E9us, 0x4AFDus, 0xB3uy, 0x58uy, 0xA6uy, 0x2Cuy, 0x61uy, 0x17uy, 0xC9uy, 0xCFuy)
    
    ///
    /// WPD_FUNCTIONAL_CATEGORY_RENDERING_INFORMATION
    /// Indicates this object provides information about the rendering characteristics of the device.
    let WPD_FUNCTIONAL_CATEGORY_RENDERING_INFORMATION = new System.Guid(0x08600BA4u, 0xA7BAus, 0x4A01us, 0xABuy, 0x0Euy, 0x00uy, 0x65uy, 0xD0uy, 0xA3uy, 0x56uy, 0xD3uy)
    
    ///
    /// WPD_FUNCTIONAL_CATEGORY_NETWORK_CONFIGURATION
    /// Indicates this object encapsulates network configuration functionality on the device (e.g. WiFi Profiles, Partnerships).
    let WPD_FUNCTIONAL_CATEGORY_NETWORK_CONFIGURATION = new System.Guid(0x48F4DB72u, 0x7C6Aus, 0x4AB0us, 0x9Euy, 0x1Auy, 0x47uy, 0x0Euy, 0x3Cuy, 0xDBuy, 0xF2uy, 0x6Auy)
    
    ///
    /// WPD_FUNCTIONAL_CATEGORY_ALL
    /// This functional category is only valid as a parameter to API functions and driver commands. It should not be reported as a supported functional category by the driver.
    let WPD_FUNCTIONAL_CATEGORY_ALL = new System.Guid(0x2D8A6512u, 0xA74Cus, 0x448Eus, 0xBAuy, 0x8Auy, 0xF4uy, 0xACuy, 0x07uy, 0xC4uy, 0x93uy, 0x99uy)
    
    //// 
    /// This section defines all WPD Formats
    ///
    ///
    /// WPD_OBJECT_FORMAT_ICON
    ///   Standard Windows ICON format
    let WPD_OBJECT_FORMAT_ICON = new System.Guid(0x077232EDu, 0x102Cus, 0x4638us, 0x9Cuy, 0x22uy, 0x83uy, 0xF1uy, 0x42uy, 0xBFuy, 0xC8uy, 0x22uy)
    
    ///
    /// WPD_OBJECT_FORMAT_M4A
    ///   Audio file format
    let WPD_OBJECT_FORMAT_M4A = new System.Guid(0x30ABA7ACu, 0x6FFDus, 0x4C23us, 0xA3uy, 0x59uy, 0x3Euy, 0x9Buy, 0x52uy, 0xF3uy, 0xF1uy, 0xC8uy)
    
    ///
    /// WPD_OBJECT_FORMAT_NETWORK_ASSOCIATION
    ///   Network Association file format.
    let WPD_OBJECT_FORMAT_NETWORK_ASSOCIATION = new System.Guid(0xB1020000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_X509V3CERTIFICATE
    ///   X.509 V3 Certificate file format.
    let WPD_OBJECT_FORMAT_X509V3CERTIFICATE = new System.Guid(0xB1030000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_MICROSOFT_WFC
    ///   Windows Connect Now file format.
    let WPD_OBJECT_FORMAT_MICROSOFT_WFC = new System.Guid(0xB1040000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_3GPA
    ///   Audio file format
    let WPD_OBJECT_FORMAT_3GPA = new System.Guid(0xE5172730u, 0xF971us, 0x41EFus, 0xA1uy, 0x0Buy, 0x22uy, 0x71uy, 0xA0uy, 0x01uy, 0x9Duy, 0x7Auy)
    
    ///
    /// WPD_OBJECT_FORMAT_3G2A
    ///   Audio file format
    let WPD_OBJECT_FORMAT_3G2A = new System.Guid(0x1A11202Du, 0x8759us, 0x4E34us, 0xBAuy, 0x5Euy, 0xB1uy, 0x21uy, 0x10uy, 0x87uy, 0xEEuy, 0xE4uy)
    
    ///
    /// WPD_OBJECT_FORMAT_ALL
    ///   This format is only valid as a parameter to API functions and driver commands. It should not be reported as a supported format by the driver.
    let WPD_OBJECT_FORMAT_ALL = new System.Guid(0xC1F62EB2u, 0x4BB3us, 0x479Cus, 0x9Cuy, 0xFAuy, 0x05uy, 0xB5uy, 0xF3uy, 0xA5uy, 0x7Buy, 0x22uy)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CATEGORY_NULL 
    ///
    /// This category is used exclusively for the NULL property key define.
    ///
    let WPD_CATEGORY_NULL = new System.Guid(0x00000000u, 0x0000us, 0x0000us, 0x00uy, 0x00uy, 0x00uy, 0x00uy, 0x00uy, 0x00uy, 0x00uy, 0x00uy)
    
    ///
    /// WPD_PROPERTY_NULL  
    ///   [ VT_EMPTY ] A NULL property key.
    let WPD_PROPERTY_NULL = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_NULL, pid = 0u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_OBJECT_PROPERTIES_V1 
    ///
    /// This category is for all common object properties.
    ///
    let WPD_OBJECT_PROPERTIES_V1 = new System.Guid(0xEF6B490Du, 0x5CD8us, 0x437Aus, 0xAFuy, 0xFCuy, 0xDAuy, 0x8Buy, 0x60uy, 0xEEuy, 0x4Auy, 0x3Cuy)
    
    ///
    /// WPD_OBJECT_CONTENT_TYPE  
    ///   [ VT_CLSID ] The abstract type for the object content, indicating the kinds of properties and data that may be supported on the object.
    let WPD_OBJECT_CONTENT_TYPE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 7u)
    
    ///
    /// WPD_OBJECT_REFERENCES  
    ///   [ VT_UNKNOWN ] IPortableDevicePropVariantCollection of type VT_LPWSTR indicating a list of ObjectIDs.
    let WPD_OBJECT_REFERENCES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 14u)
    
    ///
    /// WPD_OBJECT_CONTAINER_FUNCTIONAL_OBJECT_ID  
    ///   [ VT_LPWSTR ] Indicates the Object ID of the closest functional object ancestor. For example, objects that represent files/folders under a Storage functional object, will have this property set to the object ID of the storage functional object.
    let WPD_OBJECT_CONTAINER_FUNCTIONAL_OBJECT_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 23u)
    
    ///
    /// WPD_OBJECT_GENERATE_THUMBNAIL_FROM_RESOURCE  
    ///   [ VT_BOOL ] Indicates whether the thumbnail for this object should be generated from the default resource.
    let WPD_OBJECT_GENERATE_THUMBNAIL_FROM_RESOURCE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 24u)
    
    ///
    /// WPD_OBJECT_HINT_LOCATION_DISPLAY_NAME  
    ///   [ VT_LPWSTR ] If this object appears as a hint location, this property indicates the hint-specific name to display instead of the object name.
    let WPD_OBJECT_HINT_LOCATION_DISPLAY_NAME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 25u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_OBJECT_PROPERTIES_V2 
    ///
    /// This category is for all common object properties.
    ///
    let WPD_OBJECT_PROPERTIES_V2 = new System.Guid(0x0373CD3Du, 0x4A46us, 0x40D7us, 0xB4uy, 0xD8uy, 0x73uy, 0xE8uy, 0xDAuy, 0x74uy, 0xE7uy, 0x75uy)
    
    ///
    /// WPD_OBJECT_SUPPORTED_UNITS  
    ///   [ VT_UI4 ] Indicates the units supported on this object.
    let WPD_OBJECT_SUPPORTED_UNITS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V2, pid = 2u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_FUNCTIONAL_OBJECT_PROPERTIES_V1 
    ///
    /// This category is for properties common to all functional objects.
    ///
    let WPD_FUNCTIONAL_OBJECT_PROPERTIES_V1 = new System.Guid(0x8F052D93u, 0xABCAus, 0x4FC5us, 0xA5uy, 0xACuy, 0xB0uy, 0x1Duy, 0xF4uy, 0xDBuy, 0xE5uy, 0x98uy)
    
    ///
    /// WPD_FUNCTIONAL_OBJECT_CATEGORY  
    ///   [ VT_CLSID ] Indicates the object's functional category.
    let WPD_FUNCTIONAL_OBJECT_CATEGORY = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_FUNCTIONAL_OBJECT_PROPERTIES_V1, pid = 2u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_STORAGE_OBJECT_PROPERTIES_V1 
    ///
    /// This category is for properties common to all objects whose functional category is WPD_FUNCTIONAL_CATEGORY_STORAGE.
    ///
    let WPD_STORAGE_OBJECT_PROPERTIES_V1 = new System.Guid(0x01A3057Au, 0x74D6us, 0x4E80us, 0xBEuy, 0xA7uy, 0xDCuy, 0x4Cuy, 0x21uy, 0x2Cuy, 0xE5uy, 0x0Auy)
    
    ///
    /// WPD_STORAGE_TYPE  
    ///   [ VT_UI4 ] Indicates the type of storage e.g. fixed, removable etc.
    let WPD_STORAGE_TYPE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STORAGE_OBJECT_PROPERTIES_V1, pid = 2u)
    
    ///
    /// WPD_STORAGE_FILE_SYSTEM_TYPE  
    ///   [ VT_LPWSTR ] Indicates the file system type e.g. "FAT32" or "NTFS" or "My Special File System"
    let WPD_STORAGE_FILE_SYSTEM_TYPE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STORAGE_OBJECT_PROPERTIES_V1, pid = 3u)
    
    ///
    /// WPD_STORAGE_CAPACITY  
    ///   [ VT_UI8 ] Indicates the total storage capacity in bytes.
    let WPD_STORAGE_CAPACITY = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STORAGE_OBJECT_PROPERTIES_V1, pid = 4u)
    
    ///
    /// WPD_STORAGE_FREE_SPACE_IN_BYTES  
    ///   [ VT_UI8 ] Indicates the available space in bytes.
    let WPD_STORAGE_FREE_SPACE_IN_BYTES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STORAGE_OBJECT_PROPERTIES_V1, pid = 5u)
    
    ///
    /// WPD_STORAGE_FREE_SPACE_IN_OBJECTS  
    ///   [ VT_UI8 ] Indicates the available space in objects e.g. available slots on a SIM card.
    let WPD_STORAGE_FREE_SPACE_IN_OBJECTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STORAGE_OBJECT_PROPERTIES_V1, pid = 6u)
    
    ///
    /// WPD_STORAGE_DESCRIPTION  
    ///   [ VT_LPWSTR ] Contains a description of the storage.
    let WPD_STORAGE_DESCRIPTION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STORAGE_OBJECT_PROPERTIES_V1, pid = 7u)
    
    ///
    /// WPD_STORAGE_SERIAL_NUMBER  
    ///   [ VT_LPWSTR ] Contains the serial number of the storage.
    let WPD_STORAGE_SERIAL_NUMBER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STORAGE_OBJECT_PROPERTIES_V1, pid = 8u)
    
    ///
    /// WPD_STORAGE_MAX_OBJECT_SIZE  
    ///   [ VT_UI8 ] Specifies the maximum size of a single object (in bytes) that can be placed on this storage.
    let WPD_STORAGE_MAX_OBJECT_SIZE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STORAGE_OBJECT_PROPERTIES_V1, pid = 9u)
    
    ///
    /// WPD_STORAGE_CAPACITY_IN_OBJECTS  
    ///   [ VT_UI8 ] Indicates the total storage capacity in objects e.g. available slots on a SIM card.
    let WPD_STORAGE_CAPACITY_IN_OBJECTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STORAGE_OBJECT_PROPERTIES_V1, pid = 10u)
    
    ///
    /// WPD_STORAGE_ACCESS_CAPABILITY  
    ///   [ VT_UI4 ] This property identifies any write-protection that globally affects this storage. This takes precedence over access specified on individual objects.
    let WPD_STORAGE_ACCESS_CAPABILITY = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STORAGE_OBJECT_PROPERTIES_V1, pid = 11u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_NETWORK_ASSOCIATION_PROPERTIES_V1 
    ///
    /// This category is for properties common to all network association objects.
    ///
    let WPD_NETWORK_ASSOCIATION_PROPERTIES_V1 = new System.Guid(0xE4C93C1Fu, 0xB203us, 0x43F1us, 0xA1uy, 0x00uy, 0x5Auy, 0x07uy, 0xD1uy, 0x1Buy, 0x02uy, 0x74uy)
    
    ///
    /// WPD_NETWORK_ASSOCIATION_HOST_NETWORK_IDENTIFIERS  
    ///   [ VT_VECTOR | VT_UI1 ] The list of EUI-64 host identifiers valid for this association.
    let WPD_NETWORK_ASSOCIATION_HOST_NETWORK_IDENTIFIERS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_NETWORK_ASSOCIATION_PROPERTIES_V1, pid = 2u)
    
    ///
    /// WPD_NETWORK_ASSOCIATION_X509V3SEQUENCE  
    ///   [ VT_VECTOR | VT_UI1 ] The sequence of X.509 v3 certificates to be provided for TLS server authentication.
    let WPD_NETWORK_ASSOCIATION_X509V3SEQUENCE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_NETWORK_ASSOCIATION_PROPERTIES_V1, pid = 3u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1 
    ///
    /// This category is for properties common to all objects whose functional category is WPD_FUNCTIONAL_CATEGORY_STILL_IMAGE_CAPTURE
    ///
    let WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1 = new System.Guid(0x58C571ECu, 0x1BCBus, 0x42A7us, 0x8Auy, 0xC5uy, 0xBBuy, 0x29uy, 0x15uy, 0x73uy, 0xA2uy, 0x60uy)
    
    ///
    /// WPD_STILL_IMAGE_CAPTURE_RESOLUTION  
    ///   [ VT_LPWSTR ] Controls the size of the image dimensions to capture in pixel width and height.
    let WPD_STILL_IMAGE_CAPTURE_RESOLUTION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 2u)
    
    ///
    /// WPD_STILL_IMAGE_CAPTURE_FORMAT  
    ///   [ VT_CLSID ] Controls the format of the image to capture.
    let WPD_STILL_IMAGE_CAPTURE_FORMAT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 3u)
    
    ///
    /// WPD_STILL_IMAGE_COMPRESSION_SETTING  
    ///   [ VT_UI8 ] Controls the device-specific quality setting.
    let WPD_STILL_IMAGE_COMPRESSION_SETTING = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 4u)
    
    ///
    /// WPD_STILL_IMAGE_WHITE_BALANCE  
    ///   [ VT_UI4 ] Controls how the device weights color channels.
    let WPD_STILL_IMAGE_WHITE_BALANCE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 5u)
    
    ///
    /// WPD_STILL_IMAGE_RGB_GAIN  
    ///   [ VT_LPWSTR ] Controls the RGB gain.
    let WPD_STILL_IMAGE_RGB_GAIN = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 6u)
    
    ///
    /// WPD_STILL_IMAGE_FNUMBER  
    ///   [ VT_UI4 ] Controls the aperture of the lens.
    let WPD_STILL_IMAGE_FNUMBER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 7u)
    
    ///
    /// WPD_STILL_IMAGE_FOCAL_LENGTH  
    ///   [ VT_UI4 ] Controls the 35mm equivalent focal length.
    let WPD_STILL_IMAGE_FOCAL_LENGTH = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 8u)
    
    ///
    /// WPD_STILL_IMAGE_FOCUS_DISTANCE  
    ///   [ VT_UI4 ] This property corresponds to the focus distance in millimeters
    let WPD_STILL_IMAGE_FOCUS_DISTANCE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 9u)
    
    ///
    /// WPD_STILL_IMAGE_FOCUS_MODE  
    ///   [ VT_UI4 ] Identifies the focusing mode used by the device for image capture.
    let WPD_STILL_IMAGE_FOCUS_MODE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 10u)
    
    ///
    /// WPD_STILL_IMAGE_EXPOSURE_METERING_MODE  
    ///   [ VT_UI4 ] Identifies the exposure metering mode used by the device for image capture.
    let WPD_STILL_IMAGE_EXPOSURE_METERING_MODE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 11u)
    
    ///
    /// WPD_STILL_IMAGE_FLASH_MODE  
    ///   [ VT_UI4 ]
    let WPD_STILL_IMAGE_FLASH_MODE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 12u)
    
    ///
    /// WPD_STILL_IMAGE_EXPOSURE_TIME  
    ///   [ VT_UI4 ] Controls the shutter speed of the device.
    let WPD_STILL_IMAGE_EXPOSURE_TIME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 13u)
    
    ///
    /// WPD_STILL_IMAGE_EXPOSURE_PROGRAM_MODE  
    ///   [ VT_UI4 ] Controls the exposure program mode of the device.
    let WPD_STILL_IMAGE_EXPOSURE_PROGRAM_MODE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 14u)
    
    ///
    /// WPD_STILL_IMAGE_EXPOSURE_INDEX  
    ///   [ VT_UI4 ] Controls the emulation of film speed settings.
    let WPD_STILL_IMAGE_EXPOSURE_INDEX = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 15u)
    
    ///
    /// WPD_STILL_IMAGE_EXPOSURE_BIAS_COMPENSATION  
    ///   [ VT_I4 ] Controls the adjustment of the auto exposure control.
    let WPD_STILL_IMAGE_EXPOSURE_BIAS_COMPENSATION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 16u)
    
    ///
    /// WPD_STILL_IMAGE_CAPTURE_DELAY  
    ///   [ VT_UI4 ] Controls the amount of time delay between the capture trigger and the actual data capture (in milliseconds).
    let WPD_STILL_IMAGE_CAPTURE_DELAY = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 17u)
    
    ///
    /// WPD_STILL_IMAGE_CAPTURE_MODE  
    ///   [ VT_UI4 ] Controls the type of still image capture.
    let WPD_STILL_IMAGE_CAPTURE_MODE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 18u)
    
    ///
    /// WPD_STILL_IMAGE_CONTRAST  
    ///   [ VT_UI4 ] Controls the perceived contrast of captured images.
    let WPD_STILL_IMAGE_CONTRAST = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 19u)
    
    ///
    /// WPD_STILL_IMAGE_SHARPNESS  
    ///   [ VT_UI4 ] Controls the perceived sharpness of the captured image.
    let WPD_STILL_IMAGE_SHARPNESS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 20u)
    
    ///
    /// WPD_STILL_IMAGE_DIGITAL_ZOOM  
    ///   [ VT_UI4 ] Controls the effective zoom ratio of a digital camera's acquired image scaled by a factor of 10.
    let WPD_STILL_IMAGE_DIGITAL_ZOOM = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 21u)
    
    ///
    /// WPD_STILL_IMAGE_EFFECT_MODE  
    ///   [ VT_UI4 ] Controls the special effect mode of the capture.
    let WPD_STILL_IMAGE_EFFECT_MODE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 22u)
    
    ///
    /// WPD_STILL_IMAGE_BURST_NUMBER  
    ///   [ VT_UI4 ] Controls the number of images that the device will attempt to capture upon initiation of a burst operation.
    let WPD_STILL_IMAGE_BURST_NUMBER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 23u)
    
    ///
    /// WPD_STILL_IMAGE_BURST_INTERVAL  
    ///   [ VT_UI4 ] Controls the time delay between captures upon initiation of a burst operation.
    let WPD_STILL_IMAGE_BURST_INTERVAL = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 24u)
    
    ///
    /// WPD_STILL_IMAGE_TIMELAPSE_NUMBER  
    ///   [ VT_UI4 ] Controls the number of images that the device will attempt to capture upon initiation of a time-lapse capture.
    let WPD_STILL_IMAGE_TIMELAPSE_NUMBER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 25u)
    
    ///
    /// WPD_STILL_IMAGE_TIMELAPSE_INTERVAL  
    ///   [ VT_UI4 ] Controls the time delay between captures upon initiation of a time-lapse operation.
    let WPD_STILL_IMAGE_TIMELAPSE_INTERVAL = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 26u)
    
    ///
    /// WPD_STILL_IMAGE_FOCUS_METERING_MODE  
    ///   [ VT_UI4 ] Controls which automatic focus mechanism is used by the device.
    let WPD_STILL_IMAGE_FOCUS_METERING_MODE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 27u)
    
    ///
    /// WPD_STILL_IMAGE_UPLOAD_URL  
    ///   [ VT_LPWSTR ] Used to describe the URL that the device may use to upload images upon capture.
    let WPD_STILL_IMAGE_UPLOAD_URL = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 28u)
    
    ///
    /// WPD_STILL_IMAGE_ARTIST  
    ///   [ VT_LPWSTR ] Contains the owner/user of the device, which may be inserted as meta-data into any images that are captured.
    let WPD_STILL_IMAGE_ARTIST = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 29u)
    
    ///
    /// WPD_STILL_IMAGE_CAMERA_MODEL  
    ///   [ VT_LPWSTR ] Contains the model of the device
    let WPD_STILL_IMAGE_CAMERA_MODEL = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 30u)
    
    ///
    /// WPD_STILL_IMAGE_CAMERA_MANUFACTURER  
    ///   [ VT_LPWSTR ] Contains the manufacturer of the device
    let WPD_STILL_IMAGE_CAMERA_MANUFACTURER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1, pid = 31u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_RENDERING_INFORMATION_OBJECT_PROPERTIES_V1 
    ///
    /// This category is for properties common to all objects whose functional category is WPD_FUNCTIONAL_CATEGORY_AUDIO_RENDERING_INFORMATION
    ///
    let WPD_RENDERING_INFORMATION_OBJECT_PROPERTIES_V1 = new System.Guid(0xC53D039Fu, 0xEE23us, 0x4A31us, 0x85uy, 0x90uy, 0x76uy, 0x39uy, 0x87uy, 0x98uy, 0x70uy, 0xB4uy)
    
    ///
    /// WPD_RENDERING_INFORMATION_PROFILES  
    ///   [ VT_UNKNOWN ] IPortableDeviceValuesCollection, where each element indicates the property settings for a supported profile.
    let WPD_RENDERING_INFORMATION_PROFILES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_RENDERING_INFORMATION_OBJECT_PROPERTIES_V1, pid = 2u)
    
    ///
    /// WPD_RENDERING_INFORMATION_PROFILE_ENTRY_TYPE  
    ///   [ VT_UI4 ] Indicates whether a given entry (i.e. an IPortableDeviceValues) in WPD_RENDERING_INFORMATION_PROFILES relates to an Object or a Resource.
    let WPD_RENDERING_INFORMATION_PROFILE_ENTRY_TYPE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_RENDERING_INFORMATION_OBJECT_PROPERTIES_V1, pid = 3u)
    
    ///
    /// WPD_RENDERING_INFORMATION_PROFILE_ENTRY_CREATABLE_RESOURCES  
    ///   [ VT_UNKNOWN ] This is an IPortableDeviceKeyCollection identifying the resources that can be created on an object with this rendering profile.
    let WPD_RENDERING_INFORMATION_PROFILE_ENTRY_CREATABLE_RESOURCES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_RENDERING_INFORMATION_OBJECT_PROPERTIES_V1, pid = 4u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CLIENT_INFORMATION_PROPERTIES_V1 
    ///
    /// 
    ///
    let WPD_CLIENT_INFORMATION_PROPERTIES_V1 = new System.Guid(0x204D9F0Cu, 0x2292us, 0x4080us, 0x9Fuy, 0x42uy, 0x40uy, 0x66uy, 0x4Euy, 0x70uy, 0xF8uy, 0x59uy)
    
    ///
    /// WPD_CLIENT_NAME  
    ///   [ VT_LPWSTR ] Specifies the name the client uses to identify itself.
    let WPD_CLIENT_NAME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLIENT_INFORMATION_PROPERTIES_V1, pid = 2u)
    
    ///
    /// WPD_CLIENT_MAJOR_VERSION  
    ///   [ VT_UI4 ] Specifies the major version of the client.
    let WPD_CLIENT_MAJOR_VERSION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLIENT_INFORMATION_PROPERTIES_V1, pid = 3u)
    
    ///
    /// WPD_CLIENT_MINOR_VERSION  
    ///   [ VT_UI4 ] Specifies the major version of the client.
    let WPD_CLIENT_MINOR_VERSION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLIENT_INFORMATION_PROPERTIES_V1, pid = 4u)
    
    ///
    /// WPD_CLIENT_REVISION  
    ///   [ VT_UI4 ] Specifies the revision (or build number) of the client.
    let WPD_CLIENT_REVISION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLIENT_INFORMATION_PROPERTIES_V1, pid = 5u)
    
    ///
    /// WPD_CLIENT_WMDRM_APPLICATION_PRIVATE_KEY  
    ///   [ VT_VECTOR | VT_UI1 ] Specifies the Windows Media DRM application private key of the client.
    let WPD_CLIENT_WMDRM_APPLICATION_PRIVATE_KEY = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLIENT_INFORMATION_PROPERTIES_V1, pid = 6u)
    
    ///
    /// WPD_CLIENT_WMDRM_APPLICATION_CERTIFICATE  
    ///   [ VT_VECTOR | VT_UI1 ] Specifies the Windows Media DRM application certificate of the client.
    let WPD_CLIENT_WMDRM_APPLICATION_CERTIFICATE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLIENT_INFORMATION_PROPERTIES_V1, pid = 7u)
    
    ///
    /// WPD_CLIENT_SECURITY_QUALITY_OF_SERVICE  
    ///   [ VT_UI4 ] Specifies the Security Quality of Service for the connection to the driver. This relates to the Security Quality of Service flags for CreateFile. For example, these allow or disallow a driver to impersonate the client.
    let WPD_CLIENT_SECURITY_QUALITY_OF_SERVICE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLIENT_INFORMATION_PROPERTIES_V1, pid = 8u)
    
    ///
    /// WPD_CLIENT_DESIRED_ACCESS  
    ///   [ VT_UI4 ] Specifies the desired access the client is requesting to this driver. The possible values are the same as for CreateFile (e.g. GENERIC_READ, GENERIC_WRITE etc.).
    let WPD_CLIENT_DESIRED_ACCESS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLIENT_INFORMATION_PROPERTIES_V1, pid = 9u)
    
    ///
    /// WPD_CLIENT_SHARE_MODE  
    ///   [ VT_UI4 ] Specifies the share mode the client is requesting to this driver. The possible values are the same as for CreateFile (e.g. FILE_SHARE_READ, FILE_SHARE_WRITE etc.).
    let WPD_CLIENT_SHARE_MODE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLIENT_INFORMATION_PROPERTIES_V1, pid = 10u)
    
    ///
    /// WPD_CLIENT_EVENT_COOKIE  
    ///   [ VT_LPWSTR ] Client supplied cookie returned by the driver in events posted as a direct result of operations issued by this client.
    let WPD_CLIENT_EVENT_COOKIE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLIENT_INFORMATION_PROPERTIES_V1, pid = 11u)
    
    ///
    /// WPD_CLIENT_MINIMUM_RESULTS_BUFFER_SIZE  
    ///   [ VT_UI4 ] Specifies the minimum buffer size (in bytes) used for sending commands to the driver.
    let WPD_CLIENT_MINIMUM_RESULTS_BUFFER_SIZE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLIENT_INFORMATION_PROPERTIES_V1, pid = 12u)
    
    ///
    /// WPD_CLIENT_MANUAL_CLOSE_ON_DISCONNECT  
    ///   [ VT_BOOL ] An advanced option for clients that wish to manually call IPortableDevice::Close or IPortableDeviceService::Close for each object on device disconnect, instead of relying on the API to call Close on its behalf.
    let WPD_CLIENT_MANUAL_CLOSE_ON_DISCONNECT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLIENT_INFORMATION_PROPERTIES_V1, pid = 13u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_PROPERTY_ATTRIBUTES_V1 
    ///
    /// 
    ///
    let WPD_PROPERTY_ATTRIBUTES_V1 = new System.Guid(0xAB7943D8u, 0x6332us, 0x445Fus, 0xA0uy, 0x0Duy, 0x8Duy, 0x5Euy, 0xF1uy, 0xE9uy, 0x6Fuy, 0x37uy)
    
    ///
    /// WPD_PROPERTY_ATTRIBUTE_FORM  
    ///   [ VT_UI4 ] Specifies the form of the valid values allowed for this property.
    let WPD_PROPERTY_ATTRIBUTE_FORM = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PROPERTY_ATTRIBUTES_V1, pid = 2u)
    
    ///
    /// WPD_PROPERTY_ATTRIBUTE_CAN_READ  
    ///   [ VT_BOOL ] Indicates whether client applications have permission to Read the property.
    let WPD_PROPERTY_ATTRIBUTE_CAN_READ = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PROPERTY_ATTRIBUTES_V1, pid = 3u)
    
    ///
    /// WPD_PROPERTY_ATTRIBUTE_CAN_WRITE  
    ///   [ VT_BOOL ] Indicates whether client applications have permission to Write the property.
    let WPD_PROPERTY_ATTRIBUTE_CAN_WRITE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PROPERTY_ATTRIBUTES_V1, pid = 4u)
    
    ///
    /// WPD_PROPERTY_ATTRIBUTE_CAN_DELETE  
    ///   [ VT_BOOL ] Indicates whether client applications have permission to Delete the property.
    let WPD_PROPERTY_ATTRIBUTE_CAN_DELETE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PROPERTY_ATTRIBUTES_V1, pid = 5u)
    
    ///
    /// WPD_PROPERTY_ATTRIBUTE_DEFAULT_VALUE  
    ///   [ VT_XXXX ] Specifies the default value for a write-able property.
    let WPD_PROPERTY_ATTRIBUTE_DEFAULT_VALUE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PROPERTY_ATTRIBUTES_V1, pid = 6u)
    
    ///
    /// WPD_PROPERTY_ATTRIBUTE_FAST_PROPERTY  
    ///   [ VT_BOOL ] If True, then this property belongs to the PORTABLE_DEVICE_FAST_PROPERTIES group.
    let WPD_PROPERTY_ATTRIBUTE_FAST_PROPERTY = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PROPERTY_ATTRIBUTES_V1, pid = 7u)
    
    ///
    /// WPD_PROPERTY_ATTRIBUTE_RANGE_MIN  
    ///   [ VT_XXXX ] The minimum value for a property whose form is of WPD_PROPERTY_ATTRIBUTE_FORM_RANGE.
    let WPD_PROPERTY_ATTRIBUTE_RANGE_MIN = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PROPERTY_ATTRIBUTES_V1, pid = 8u)
    
    ///
    /// WPD_PROPERTY_ATTRIBUTE_RANGE_MAX  
    ///   [ VT_XXXX ] The maximum value for a property whose form is of WPD_PROPERTY_ATTRIBUTE_FORM_RANGE.
    let WPD_PROPERTY_ATTRIBUTE_RANGE_MAX = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PROPERTY_ATTRIBUTES_V1, pid = 9u)
    
    ///
    /// WPD_PROPERTY_ATTRIBUTE_RANGE_STEP  
    ///   [ VT_XXXX ] The step value for a property whose form is of WPD_PROPERTY_ATTRIBUTE_FORM_RANGE.
    let WPD_PROPERTY_ATTRIBUTE_RANGE_STEP = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PROPERTY_ATTRIBUTES_V1, pid = 10u)
    
    ///
    /// WPD_PROPERTY_ATTRIBUTE_ENUMERATION_ELEMENTS  
    ///   [ VT_UNKNOWN ] An IPortableDevicePropVariantCollection containing the enumeration values.
    let WPD_PROPERTY_ATTRIBUTE_ENUMERATION_ELEMENTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PROPERTY_ATTRIBUTES_V1, pid = 11u)
    
    ///
    /// WPD_PROPERTY_ATTRIBUTE_REGULAR_EXPRESSION  
    ///   [ VT_LPWSTR ] A regular expression string indicating acceptable values for properties whose form is WPD_PROPERTY_ATTRIBUTE_FORM_REGULAR_EXPRESSION.
    let WPD_PROPERTY_ATTRIBUTE_REGULAR_EXPRESSION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PROPERTY_ATTRIBUTES_V1, pid = 12u)
    
    ///
    /// WPD_PROPERTY_ATTRIBUTE_MAX_SIZE  
    ///   [ VT_UI8 ] This indicates the maximum size (in bytes) for the value of this property.
    let WPD_PROPERTY_ATTRIBUTE_MAX_SIZE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PROPERTY_ATTRIBUTES_V1, pid = 13u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_PROPERTY_ATTRIBUTES_V2 
    ///
    /// This category defines additional property attributes used by device services.
    ///
    let WPD_PROPERTY_ATTRIBUTES_V2 = new System.Guid(0x5D9DA160u, 0x74AEus, 0x43CCus, 0x85uy, 0xA9uy, 0xFEuy, 0x55uy, 0x5Auy, 0x80uy, 0x79uy, 0x8Euy)
    
    ///
    /// WPD_PROPERTY_ATTRIBUTE_NAME  
    ///   [ VT_LPWSTR ] Contains the name of the property.
    let WPD_PROPERTY_ATTRIBUTE_NAME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PROPERTY_ATTRIBUTES_V2, pid = 2u)
    
    ///
    /// WPD_PROPERTY_ATTRIBUTE_VARTYPE  
    ///   [ VT_UI4 ] Contains the VARTYPE of the property.
    let WPD_PROPERTY_ATTRIBUTE_VARTYPE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PROPERTY_ATTRIBUTES_V2, pid = 3u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CLASS_EXTENSION_OPTIONS_V1 
    ///
    /// This category of properties relates to options used for the WPD device class extension
    ///
    let WPD_CLASS_EXTENSION_OPTIONS_V1 = new System.Guid(0x6309FFEFu, 0xA87Cus, 0x4CA7us, 0x84uy, 0x34uy, 0x79uy, 0x75uy, 0x76uy, 0xE4uy, 0x0Auy, 0x96uy)
    
    ///
    /// WPD_CLASS_EXTENSION_OPTIONS_SUPPORTED_CONTENT_TYPES  
    ///   [ VT_UNKNOWN ] Indicates the (super-set) list of content types supported by the driver (similar to calling WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_CONTENT_TYPES on WPD_FUNCTIONAL_CATEGORY_ALL).
    let WPD_CLASS_EXTENSION_OPTIONS_SUPPORTED_CONTENT_TYPES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLASS_EXTENSION_OPTIONS_V1, pid = 2u)
    
    ///
    /// WPD_CLASS_EXTENSION_OPTIONS_DONT_REGISTER_WPD_DEVICE_INTERFACE  
    ///   [ VT_BOOL ] Indicates that the caller does not want the WPD class extension library to register the WPD Device Class interface. The caller will take responsibility for doing it.
    let WPD_CLASS_EXTENSION_OPTIONS_DONT_REGISTER_WPD_DEVICE_INTERFACE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLASS_EXTENSION_OPTIONS_V1, pid = 3u)
    
    ///
    /// WPD_CLASS_EXTENSION_OPTIONS_REGISTER_WPD_PRIVATE_DEVICE_INTERFACE  
    ///   [ VT_BOOL ] Indicates that the caller wants the WPD class extension library to register the private WPD Device Class interface.
    let WPD_CLASS_EXTENSION_OPTIONS_REGISTER_WPD_PRIVATE_DEVICE_INTERFACE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLASS_EXTENSION_OPTIONS_V1, pid = 4u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CLASS_EXTENSION_OPTIONS_V2 
    ///
    /// This category of properties relates to options used for the WPD device class extension
    ///
    let WPD_CLASS_EXTENSION_OPTIONS_V2 = new System.Guid(0x3E3595DAu, 0x4D71us, 0x49FEus, 0xA0uy, 0xB4uy, 0xD4uy, 0x40uy, 0x6Cuy, 0x3Auy, 0xE9uy, 0x3Fuy)
    
    ///
    /// WPD_CLASS_EXTENSION_OPTIONS_MULTITRANSPORT_MODE  
    ///   [ VT_BOOL ] Indicates that the caller wants the WPD class extension library to go into Multi-Transport mode (if TRUE).
    let WPD_CLASS_EXTENSION_OPTIONS_MULTITRANSPORT_MODE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLASS_EXTENSION_OPTIONS_V2, pid = 2u)
    
    ///
    /// WPD_CLASS_EXTENSION_OPTIONS_DEVICE_IDENTIFICATION_VALUES  
    ///   [ VT_UNKNOWN ] This is an IPortableDeviceValues which contains the device identification values (WPD_DEVICE_MANUFACTURER, WPD_DEVICE_MODEL, WPD_DEVICE_FIRMWARE_VERSION and WPD_DEVICE_FUNCTIONAL_UNIQUE_ID). Include this with other Class Extension options when initializing.
    let WPD_CLASS_EXTENSION_OPTIONS_DEVICE_IDENTIFICATION_VALUES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLASS_EXTENSION_OPTIONS_V2, pid = 3u)
    
    ///
    /// WPD_CLASS_EXTENSION_OPTIONS_TRANSPORT_BANDWIDTH  
    ///   [ VT_UI4 ] Indicates the theoretical maximum bandwidth of the transport in kilobits per second.
    let WPD_CLASS_EXTENSION_OPTIONS_TRANSPORT_BANDWIDTH = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLASS_EXTENSION_OPTIONS_V2, pid = 4u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CLASS_EXTENSION_OPTIONS_V3 
    ///
    /// This category of properties relates to options used for the WPD device class extension
    ///
    let WPD_CLASS_EXTENSION_OPTIONS_V3 = new System.Guid(0x65C160F8u, 0x1367us, 0x4CE2us, 0x93uy, 0x9Duy, 0x83uy, 0x10uy, 0x83uy, 0x9Fuy, 0x0Duy, 0x30uy)
    
    ///
    /// WPD_CLASS_EXTENSION_OPTIONS_SILENCE_AUTOPLAY  
    ///   [ VT_BOOL ] Indicates that the caller wants Autoplay to be silent when the device is connected (if TRUE).
    let WPD_CLASS_EXTENSION_OPTIONS_SILENCE_AUTOPLAY = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLASS_EXTENSION_OPTIONS_V3, pid = 2u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_RESOURCE_ATTRIBUTES_V1 
    ///
    /// 
    ///
    let WPD_RESOURCE_ATTRIBUTES_V1 = new System.Guid(0x1EB6F604u, 0x9278us, 0x429Fus, 0x93uy, 0xCCuy, 0x5Buy, 0xB8uy, 0xC0uy, 0x66uy, 0x56uy, 0xB6uy)
    
    ///
    /// WPD_RESOURCE_ATTRIBUTE_TOTAL_SIZE  
    ///   [ VT_UI8 ] Total size in bytes of the resource data.
    let WPD_RESOURCE_ATTRIBUTE_TOTAL_SIZE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_RESOURCE_ATTRIBUTES_V1, pid = 2u)
    
    ///
    /// WPD_RESOURCE_ATTRIBUTE_CAN_READ  
    ///   [ VT_BOOL ] Indicates whether client applications have permission to open the resource for Read access.
    let WPD_RESOURCE_ATTRIBUTE_CAN_READ = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_RESOURCE_ATTRIBUTES_V1, pid = 3u)
    
    ///
    /// WPD_RESOURCE_ATTRIBUTE_CAN_WRITE  
    ///   [ VT_BOOL ] Indicates whether client applications have permission to open the resource for Write access.
    let WPD_RESOURCE_ATTRIBUTE_CAN_WRITE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_RESOURCE_ATTRIBUTES_V1, pid = 4u)
    
    ///
    /// WPD_RESOURCE_ATTRIBUTE_CAN_DELETE  
    ///   [ VT_BOOL ] Indicates whether client applications have permission to Delete a resource from the device.
    let WPD_RESOURCE_ATTRIBUTE_CAN_DELETE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_RESOURCE_ATTRIBUTES_V1, pid = 5u)
    
    ///
    /// WPD_RESOURCE_ATTRIBUTE_OPTIMAL_READ_BUFFER_SIZE  
    ///   [ VT_UI4 ] The recommended buffer size a caller should use when doing buffered reads on the resource.
    let WPD_RESOURCE_ATTRIBUTE_OPTIMAL_READ_BUFFER_SIZE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_RESOURCE_ATTRIBUTES_V1, pid = 6u)
    
    ///
    /// WPD_RESOURCE_ATTRIBUTE_OPTIMAL_WRITE_BUFFER_SIZE  
    ///   [ VT_UI4 ] The recommended buffer size a caller should use when doing buffered writes on the resource.
    let WPD_RESOURCE_ATTRIBUTE_OPTIMAL_WRITE_BUFFER_SIZE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_RESOURCE_ATTRIBUTES_V1, pid = 7u)
    
    ///
    /// WPD_RESOURCE_ATTRIBUTE_FORMAT  
    ///   [ VT_CLSID ] Indicates the format of the resource data.
    let WPD_RESOURCE_ATTRIBUTE_FORMAT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_RESOURCE_ATTRIBUTES_V1, pid = 8u)
    
    ///
    /// WPD_RESOURCE_ATTRIBUTE_RESOURCE_KEY  
    ///   [ VT_UNKNOWN ] This is an IPortableDeviceKeyCollection containing a single value, which is the key identifying the resource.
    let WPD_RESOURCE_ATTRIBUTE_RESOURCE_KEY = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_RESOURCE_ATTRIBUTES_V1, pid = 9u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_DEVICE_PROPERTIES_V1 
    ///
    /// 
    ///
    let WPD_DEVICE_PROPERTIES_V1 = new System.Guid(0x26D4979Au, 0xE643us, 0x4626us, 0x9Euy, 0x2Buy, 0x73uy, 0x6Duy, 0xC0uy, 0xC9uy, 0x2Fuy, 0xDCuy)
    
    ///
    /// WPD_DEVICE_SYNC_PARTNER  
    ///   [ VT_LPWSTR ] Indicates a human-readable description of a synchronization partner for the device.
    let WPD_DEVICE_SYNC_PARTNER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_DEVICE_PROPERTIES_V1, pid = 2u)
    
    ///
    /// WPD_DEVICE_FIRMWARE_VERSION  
    ///   [ VT_LPWSTR ] Indicates the firmware version for the device.
    let WPD_DEVICE_FIRMWARE_VERSION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_DEVICE_PROPERTIES_V1, pid = 3u)
    
    ///
    /// WPD_DEVICE_POWER_LEVEL  
    ///   [ VT_UI4 ] Indicates the power level of the device's battery.
    let WPD_DEVICE_POWER_LEVEL = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_DEVICE_PROPERTIES_V1, pid = 4u)
    
    ///
    /// WPD_DEVICE_POWER_SOURCE  
    ///   [ VT_UI4 ] Indicates the power source of the device e.g. whether it is battery or external.
    let WPD_DEVICE_POWER_SOURCE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_DEVICE_PROPERTIES_V1, pid = 5u)
    
    ///
    /// WPD_DEVICE_PROTOCOL  
    ///   [ VT_LPWSTR ] Identifies the device protocol being used.
    let WPD_DEVICE_PROTOCOL = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_DEVICE_PROPERTIES_V1, pid = 6u)
    
    ///
    /// WPD_DEVICE_MANUFACTURER  
    ///   [ VT_LPWSTR ] Identifies the device manufacturer.
    let WPD_DEVICE_MANUFACTURER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_DEVICE_PROPERTIES_V1, pid = 7u)
    
    ///
    /// WPD_DEVICE_MODEL  
    ///   [ VT_LPWSTR ] Identifies the device model.
    let WPD_DEVICE_MODEL = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_DEVICE_PROPERTIES_V1, pid = 8u)
    
    ///
    /// WPD_DEVICE_SERIAL_NUMBER  
    ///   [ VT_LPWSTR ] Identifies the serial number of the device.
    let WPD_DEVICE_SERIAL_NUMBER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_DEVICE_PROPERTIES_V1, pid = 9u)
    
    ///
    /// WPD_DEVICE_SUPPORTS_NON_CONSUMABLE  
    ///   [ VT_BOOL ] Indicates whether the device supports non-consumable objects.
    let WPD_DEVICE_SUPPORTS_NON_CONSUMABLE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_DEVICE_PROPERTIES_V1, pid = 10u)
    
    ///
    /// WPD_DEVICE_DATETIME  
    ///   [ VT_DATE ] Represents the current date and time settings of the device.
    let WPD_DEVICE_DATETIME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_DEVICE_PROPERTIES_V1, pid = 11u)
    
    ///
    /// WPD_DEVICE_FRIENDLY_NAME  
    ///   [ VT_LPWSTR ] Represents the friendly name set by the user on the device.
    let WPD_DEVICE_FRIENDLY_NAME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_DEVICE_PROPERTIES_V1, pid = 12u)
    
    ///
    /// WPD_DEVICE_SUPPORTED_DRM_SCHEMES  
    ///   [ VT_UNKNOWN ] An IPortableDevicePropVariantCollection of VT_LPWSTR values indicating the Digital Rights Management schemes supported by the driver.
    let WPD_DEVICE_SUPPORTED_DRM_SCHEMES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_DEVICE_PROPERTIES_V1, pid = 13u)
    
    ///
    /// WPD_DEVICE_SUPPORTED_FORMATS_ARE_ORDERED  
    ///   [ VT_BOOL ] Indicates whether the supported formats returned from the device are in a preferred order. (First format in the list is most preferred by the device, while the last is the least preferred.)
    let WPD_DEVICE_SUPPORTED_FORMATS_ARE_ORDERED = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_DEVICE_PROPERTIES_V1, pid = 14u)
    
    ///
    /// WPD_DEVICE_TYPE  
    ///   [ VT_UI4 ] Indicates the device type, used for representation purposes only. Functional characteristics of the device are decided through functional objects.
    let WPD_DEVICE_TYPE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_DEVICE_PROPERTIES_V1, pid = 15u)
    
    ///
    /// WPD_DEVICE_NETWORK_IDENTIFIER  
    ///   [ VT_UI8 ] Indicates the EUI-64 network identifier of the device, used for out-of-band Network Association operations.
    let WPD_DEVICE_NETWORK_IDENTIFIER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_DEVICE_PROPERTIES_V1, pid = 16u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_DEVICE_PROPERTIES_V2 
    ///
    /// 
    ///
    let WPD_DEVICE_PROPERTIES_V2 = new System.Guid(0x463DD662u, 0x7FC4us, 0x4291us, 0x91uy, 0x1Cuy, 0x7Fuy, 0x4Cuy, 0x9Cuy, 0xCAuy, 0x97uy, 0x99uy)
    
    ///
    /// WPD_DEVICE_FUNCTIONAL_UNIQUE_ID  
    ///   [ VT_VECTOR | VT_UI1 ] Indicates a unique 16 byte identifier common across multiple transports supported by the device.
    let WPD_DEVICE_FUNCTIONAL_UNIQUE_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_DEVICE_PROPERTIES_V2, pid = 2u)
    
    ///
    /// WPD_DEVICE_MODEL_UNIQUE_ID  
    ///   [ VT_VECTOR | VT_UI1 ] Indicates a unique 16 byte identifier for cosmetic differentiation among different models of the device.
    let WPD_DEVICE_MODEL_UNIQUE_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_DEVICE_PROPERTIES_V2, pid = 3u)
    
    ///
    /// WPD_DEVICE_TRANSPORT  
    ///   [ VT_UI4 ] Indicates the transport type (USB, IP, Bluetooth, etc.).
    let WPD_DEVICE_TRANSPORT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_DEVICE_PROPERTIES_V2, pid = 4u)
    
    ///
    /// WPD_DEVICE_USE_DEVICE_STAGE  
    ///   [ VT_BOOL ] If this property exists and is set to TRUE, the device can be used with Device Stage.
    let WPD_DEVICE_USE_DEVICE_STAGE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_DEVICE_PROPERTIES_V2, pid = 5u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_SERVICE_PROPERTIES_V1 
    ///
    /// 
    ///
    let WPD_SERVICE_PROPERTIES_V1 = new System.Guid(0x7510698Au, 0xCB54us, 0x481Cus, 0xB8uy, 0xDBuy, 0x0Duy, 0x75uy, 0xC9uy, 0x3Fuy, 0x1Cuy, 0x06uy)
    
    ///
    /// WPD_SERVICE_VERSION  
    ///   [ VT_LPWSTR ] Indicates the implementation version of a service.
    let WPD_SERVICE_VERSION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_SERVICE_PROPERTIES_V1, pid = 2u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_EVENT_PROPERTIES_V1 
    ///
    /// The properties in this category are for properties that may be needed for event processing, but do not have object property equivalents (i.e. they are not exposed as object properties, but rather, used only as event parameters).
    ///
    let WPD_EVENT_PROPERTIES_V1 = new System.Guid(0x15AB1953u, 0xF817us, 0x4FEFus, 0xA9uy, 0x21uy, 0x56uy, 0x76uy, 0xE8uy, 0x38uy, 0xF6uy, 0xE0uy)
    
    ///
    /// WPD_EVENT_PARAMETER_PNP_DEVICE_ID  
    ///   [ VT_LPWSTR ] Indicates the device that originated the event.
    let WPD_EVENT_PARAMETER_PNP_DEVICE_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_EVENT_PROPERTIES_V1, pid = 2u)
    
    ///
    /// WPD_EVENT_PARAMETER_EVENT_ID  
    ///   [ VT_CLSID ] Indicates the event sent.
    let WPD_EVENT_PARAMETER_EVENT_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_EVENT_PROPERTIES_V1, pid = 3u)
    
    ///
    /// WPD_EVENT_PARAMETER_OPERATION_STATE  
    ///   [ VT_UI4 ] Indicates the current state of the operation (e.g. started, running, stopped etc.).
    let WPD_EVENT_PARAMETER_OPERATION_STATE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_EVENT_PROPERTIES_V1, pid = 4u)
    
    ///
    /// WPD_EVENT_PARAMETER_OPERATION_PROGRESS  
    ///   [ VT_UI4 ] Indicates the progress of a currently executing operation. Value is from 0 to 100, with 100 indicating that the operation is complete.
    let WPD_EVENT_PARAMETER_OPERATION_PROGRESS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_EVENT_PROPERTIES_V1, pid = 5u)
    
    ///
    /// WPD_EVENT_PARAMETER_OBJECT_PARENT_PERSISTENT_UNIQUE_ID  
    ///   [ VT_LPWSTR ] Uniquely identifies the parent object, similar to WPD_OBJECT_PARENT_ID, but this ID will not change between sessions.
    let WPD_EVENT_PARAMETER_OBJECT_PARENT_PERSISTENT_UNIQUE_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_EVENT_PROPERTIES_V1, pid = 6u)
    
    ///
    /// WPD_EVENT_PARAMETER_OBJECT_CREATION_COOKIE  
    ///   [ VT_LPWSTR ] This is the cookie handed back to a client when it requested an object creation using the IPortableDeviceContent::CreateObjectWithPropertiesAndData method.
    let WPD_EVENT_PARAMETER_OBJECT_CREATION_COOKIE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_EVENT_PROPERTIES_V1, pid = 7u)
    
    ///
    /// WPD_EVENT_PARAMETER_CHILD_HIERARCHY_CHANGED  
    ///   [ VT_BOOL ] Indicates that the child hiearchy for the object has changed.
    let WPD_EVENT_PARAMETER_CHILD_HIERARCHY_CHANGED = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_EVENT_PROPERTIES_V1, pid = 8u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_EVENT_PROPERTIES_V2 
    ///
    /// The properties in this category are for properties that may be needed for event processing, but do not have object property equivalents (i.e. they are not exposed as object properties, but rather, used only as event parameters).
    ///
    let WPD_EVENT_PROPERTIES_V2 = new System.Guid(0x52807B8Au, 0x4914us, 0x4323us, 0x9Buy, 0x9Auy, 0x74uy, 0xF6uy, 0x54uy, 0xB2uy, 0xB8uy, 0x46uy)
    
    ///
    /// WPD_EVENT_PARAMETER_SERVICE_METHOD_CONTEXT  
    ///   [ VT_LPWSTR ] Indicates the service method invocation context.
    let WPD_EVENT_PARAMETER_SERVICE_METHOD_CONTEXT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_EVENT_PROPERTIES_V2, pid = 2u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_EVENT_OPTIONS_V1 
    ///
    /// The properties in this category describe event options.
    ///
    let WPD_EVENT_OPTIONS_V1 = new System.Guid(0xB3D8DAD7u, 0xA361us, 0x4B83us, 0x8Auy, 0x48uy, 0x5Buy, 0x02uy, 0xCEuy, 0x10uy, 0x71uy, 0x3Buy)
    
    ///
    /// WPD_EVENT_OPTION_IS_BROADCAST_EVENT  
    ///   [ VT_BOOL ] Indicates that the event is broadcast to all clients.
    let WPD_EVENT_OPTION_IS_BROADCAST_EVENT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_EVENT_OPTIONS_V1, pid = 2u)
    
    ///
    /// WPD_EVENT_OPTION_IS_AUTOPLAY_EVENT  
    ///   [ VT_BOOL ] Indicates that the event is sent to and handled by Autoplay.
    let WPD_EVENT_OPTION_IS_AUTOPLAY_EVENT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_EVENT_OPTIONS_V1, pid = 3u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_EVENT_ATTRIBUTES_V1 
    ///
    /// The properties in this category describe event attributes.
    ///
    let WPD_EVENT_ATTRIBUTES_V1 = new System.Guid(0x10C96578u, 0x2E81us, 0x4111us, 0xADuy, 0xDEuy, 0xE0uy, 0x8Cuy, 0xA6uy, 0x13uy, 0x8Fuy, 0x6Duy)
    
    ///
    /// WPD_EVENT_ATTRIBUTE_NAME  
    ///   [ VT_LPWSTR ] Contains the name of the event.
    let WPD_EVENT_ATTRIBUTE_NAME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_EVENT_ATTRIBUTES_V1, pid = 2u)
    
    ///
    /// WPD_EVENT_ATTRIBUTE_PARAMETERS  
    ///   [ VT_UNKNOWN ] IPortableDeviceKeyCollection containing the event parameters.
    let WPD_EVENT_ATTRIBUTE_PARAMETERS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_EVENT_ATTRIBUTES_V1, pid = 3u)
    
    ///
    /// WPD_EVENT_ATTRIBUTE_OPTIONS  
    ///   [ VT_UNKNOWN ] IPortableDeviceValues containing the event options.
    let WPD_EVENT_ATTRIBUTE_OPTIONS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_EVENT_ATTRIBUTES_V1, pid = 4u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_API_OPTIONS_V1 
    ///
    /// The properties in this category describe API options.
    ///
    let WPD_API_OPTIONS_V1 = new System.Guid(0x10E54A3Eu, 0x052Dus, 0x4777us, 0xA1uy, 0x3Cuy, 0xDEuy, 0x76uy, 0x14uy, 0xBEuy, 0x2Buy, 0xC4uy)
    
    ///
    /// WPD_API_OPTION_USE_CLEAR_DATA_STREAM  
    ///   [ VT_BOOL ] Indicates that the data stream created for data transfer will be clear only (i.e. No DRM will be involved).
    let WPD_API_OPTION_USE_CLEAR_DATA_STREAM = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_API_OPTIONS_V1, pid = 2u)
    
    ///
    /// WPD_API_OPTION_IOCTL_ACCESS  
    ///   [ VT_UI4 ] An optional property that clients can add to the IN parameter set of IPortableDevice::SendCommand to specify the access required for the command. The Portable Device API uses this to identify whether the IOCTL sent to the driver is sent with FILE_READ_ACCESS or (FILE_READ_ACCESS | FILE_WRITE_ACCESS) access flags.
    let WPD_API_OPTION_IOCTL_ACCESS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_API_OPTIONS_V1, pid = 3u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_FORMAT_ATTRIBUTES_V1 
    ///
    /// The properties in this category describe format attributes.
    ///
    let WPD_FORMAT_ATTRIBUTES_V1 = new System.Guid(0xA0A02000u, 0xBCAFus, 0x4BE8us, 0xB3uy, 0xF5uy, 0x23uy, 0x3Fuy, 0x23uy, 0x1Cuy, 0xF5uy, 0x8Fuy)
    
    ///
    /// WPD_FORMAT_ATTRIBUTE_NAME  
    ///   [ VT_LPWSTR ] Contains the name of the format.
    let WPD_FORMAT_ATTRIBUTE_NAME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_FORMAT_ATTRIBUTES_V1, pid = 2u)
    
    ///
    /// WPD_FORMAT_ATTRIBUTE_MIMETYPE  
    ///   [ VT_LPWSTR ] Contains the MIME type of the format.
    let WPD_FORMAT_ATTRIBUTE_MIMETYPE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_FORMAT_ATTRIBUTES_V1, pid = 3u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_METHOD_ATTRIBUTES_V1 
    ///
    /// The properties in this category describe method attributes.
    ///
    let WPD_METHOD_ATTRIBUTES_V1 = new System.Guid(0xF17A5071u, 0xF039us, 0x44AFus, 0x8Euy, 0xFEuy, 0x43uy, 0x2Cuy, 0xF3uy, 0x2Euy, 0x43uy, 0x2Auy)
    
    ///
    /// WPD_METHOD_ATTRIBUTE_NAME  
    ///   [ VT_LPWSTR ] Contains the name of the method.
    let WPD_METHOD_ATTRIBUTE_NAME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_METHOD_ATTRIBUTES_V1, pid = 2u)
    
    ///
    /// WPD_METHOD_ATTRIBUTE_ASSOCIATED_FORMAT  
    ///   [ VT_CLSID ] Contains the format this method applies to. This is GUID_NULL if the method does not apply to a format.
    let WPD_METHOD_ATTRIBUTE_ASSOCIATED_FORMAT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_METHOD_ATTRIBUTES_V1, pid = 3u)
    
    ///
    /// WPD_METHOD_ATTRIBUTE_ACCESS  
    ///   [ VT_UI4 ] Indicates the required access for a method.
    let WPD_METHOD_ATTRIBUTE_ACCESS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_METHOD_ATTRIBUTES_V1, pid = 4u)
    
    ///
    /// WPD_METHOD_ATTRIBUTE_PARAMETERS  
    ///   [ VT_UNKNOWN ] This is an IPortableDeviceKeyCollection containing the method parameters.
    let WPD_METHOD_ATTRIBUTE_PARAMETERS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_METHOD_ATTRIBUTES_V1, pid = 5u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_PARAMETER_ATTRIBUTES_V1 
    ///
    /// The properties in this category describe parameter attributes.
    ///
    let WPD_PARAMETER_ATTRIBUTES_V1 = new System.Guid(0xE6864DD7u, 0xF325us, 0x45EAus, 0xA1uy, 0xD5uy, 0x97uy, 0xCFuy, 0x73uy, 0xB6uy, 0xCAuy, 0x58uy)
    
    ///
    /// WPD_PARAMETER_ATTRIBUTE_ORDER  
    ///   [ VT_UI4 ] The order (starting from 0) of a method parameter.
    let WPD_PARAMETER_ATTRIBUTE_ORDER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PARAMETER_ATTRIBUTES_V1, pid = 2u)
    
    ///
    /// WPD_PARAMETER_ATTRIBUTE_USAGE  
    ///   [ VT_UI4 ] The usage of the method parameter.
    let WPD_PARAMETER_ATTRIBUTE_USAGE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PARAMETER_ATTRIBUTES_V1, pid = 3u)
    
    ///
    /// WPD_PARAMETER_ATTRIBUTE_FORM  
    ///   [ VT_UI4 ] Specifies the form of the valid values allowed for this parameter.
    let WPD_PARAMETER_ATTRIBUTE_FORM = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PARAMETER_ATTRIBUTES_V1, pid = 4u)
    
    ///
    /// WPD_PARAMETER_ATTRIBUTE_DEFAULT_VALUE  
    ///   [ VT_XXXX ] Specifies the default value for this parameter.
    let WPD_PARAMETER_ATTRIBUTE_DEFAULT_VALUE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PARAMETER_ATTRIBUTES_V1, pid = 5u)
    
    ///
    /// WPD_PARAMETER_ATTRIBUTE_RANGE_MIN  
    ///   [ VT_XXXX ] The minimum value for a parameter whose form is of WPD_PARAMETER_ATTRIBUTE_FORM_RANGE.
    let WPD_PARAMETER_ATTRIBUTE_RANGE_MIN = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PARAMETER_ATTRIBUTES_V1, pid = 6u)
    
    ///
    /// WPD_PARAMETER_ATTRIBUTE_RANGE_MAX  
    ///   [ VT_XXXX ] The maximum value for a parameter whose form is of WPD_PARAMETER_ATTRIBUTE_FORM_RANGE.
    let WPD_PARAMETER_ATTRIBUTE_RANGE_MAX = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PARAMETER_ATTRIBUTES_V1, pid = 7u)
    
    ///
    /// WPD_PARAMETER_ATTRIBUTE_RANGE_STEP  
    ///   [ VT_XXXX ] The step value for a parameter whose form is of WPD_PARAMETER_ATTRIBUTE_FORM_RANGE.
    let WPD_PARAMETER_ATTRIBUTE_RANGE_STEP = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PARAMETER_ATTRIBUTES_V1, pid = 8u)
    
    ///
    /// WPD_PARAMETER_ATTRIBUTE_ENUMERATION_ELEMENTS  
    ///   [ VT_UNKNOWN ] An IPortableDevicePropVariantCollection containing the enumeration values.
    let WPD_PARAMETER_ATTRIBUTE_ENUMERATION_ELEMENTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PARAMETER_ATTRIBUTES_V1, pid = 9u)
    
    ///
    /// WPD_PARAMETER_ATTRIBUTE_REGULAR_EXPRESSION  
    ///   [ VT_LPWSTR ] A regular expression string indicating acceptable values for parameters whose form is WPD_PARAMETER_ATTRIBUTE_FORM_REGULAR_EXPRESSION.
    let WPD_PARAMETER_ATTRIBUTE_REGULAR_EXPRESSION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PARAMETER_ATTRIBUTES_V1, pid = 10u)
    
    ///
    /// WPD_PARAMETER_ATTRIBUTE_MAX_SIZE  
    ///   [ VT_UI8 ] This indicates the maximum size (in bytes) for the value of this parameter.
    let WPD_PARAMETER_ATTRIBUTE_MAX_SIZE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PARAMETER_ATTRIBUTES_V1, pid = 11u)
    
    ///
    /// WPD_PARAMETER_ATTRIBUTE_VARTYPE  
    ///   [ VT_UI4 ] Contains the VARTYPE of the parameter.
    let WPD_PARAMETER_ATTRIBUTE_VARTYPE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PARAMETER_ATTRIBUTES_V1, pid = 12u)
    
    ///
    /// WPD_PARAMETER_ATTRIBUTE_NAME  
    ///   [ VT_LPWSTR ] Contains the parameter name.
    let WPD_PARAMETER_ATTRIBUTE_NAME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PARAMETER_ATTRIBUTES_V1, pid = 13u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CATEGORY_COMMON 
    ///
    /// 
    ///
    let WPD_CATEGORY_COMMON = new System.Guid(0xF0422A9Cu, 0x5DC8us, 0x4440us, 0xB5uy, 0xBDuy, 0x5Duy, 0xF2uy, 0x88uy, 0x35uy, 0x65uy, 0x8Auy)
    
    /// ======== Commands ========
    ///
    /// WPD_COMMAND_COMMON_RESET_DEVICE 
    ///    This command is sent by clients to reset the device. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     None
    /// Results:
    ///     None
    let WPD_COMMAND_COMMON_RESET_DEVICE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_COMMON, pid = 2u)
    
    ///
    /// WPD_COMMAND_COMMON_GET_OBJECT_IDS_FROM_PERSISTENT_UNIQUE_IDS 
    ///    This command is sent when a client wants to get current ObjectIDs representing objects specified by previously acquired Persistent Unique IDs. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_COMMON_PERSISTENT_UNIQUE_IDS 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_COMMON_OBJECT_IDS
    let WPD_COMMAND_COMMON_GET_OBJECT_IDS_FROM_PERSISTENT_UNIQUE_IDS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_COMMON, pid = 3u)
    
    ///
    /// WPD_COMMAND_COMMON_SAVE_CLIENT_INFORMATION 
    ///    This command is sent when a client first connects to a device. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_COMMON_CLIENT_INFORMATION 
    /// Results:
    ///     [ Optional ]  WPD_PROPERTY_COMMON_CLIENT_INFORMATION_CONTEXT
    let WPD_COMMAND_COMMON_SAVE_CLIENT_INFORMATION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_COMMON, pid = 4u)
    
    ///
    /// WPD_PROPERTY_COMMON_COMMAND_CATEGORY  
    ///   [ VT_CLSID ] Specifies the command Category (i.e. the GUID portion of the PROPERTYKEY indicating the command).
    let WPD_PROPERTY_COMMON_COMMAND_CATEGORY = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_COMMON, pid = 1001u)
    
    ///
    /// WPD_PROPERTY_COMMON_COMMAND_ID  
    ///   [ VT_UI4 ] Specifies the command ID, which is the PID portion of the PROPERTYKEY indicating the command.
    let WPD_PROPERTY_COMMON_COMMAND_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_COMMON, pid = 1002u)
    
    ///
    /// WPD_PROPERTY_COMMON_HRESULT  
    ///   [ VT_ERROR ] The driver sets this to be the HRESULT of the requested operation.
    let WPD_PROPERTY_COMMON_HRESULT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_COMMON, pid = 1003u)
    
    ///
    /// WPD_PROPERTY_COMMON_DRIVER_ERROR_CODE  
    ///   [ VT_UI4 ] Special driver specific code which driver may return on error. Typically only for use with diagnostic tools or vertical solutions.
    let WPD_PROPERTY_COMMON_DRIVER_ERROR_CODE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_COMMON, pid = 1004u)
    
    ///
    /// WPD_PROPERTY_COMMON_COMMAND_TARGET  
    ///   [ VT_LPWSTR ] Identifies the object which the command is intended for.
    let WPD_PROPERTY_COMMON_COMMAND_TARGET = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_COMMON, pid = 1006u)
    
    ///
    /// WPD_PROPERTY_COMMON_PERSISTENT_UNIQUE_IDS  
    ///   [ VT_UNKNOWN ] IPortableDevicePropVariantCollection of type VT_LPWSTR specifying list of Persistent Unique IDs.
    let WPD_PROPERTY_COMMON_PERSISTENT_UNIQUE_IDS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_COMMON, pid = 1007u)
    
    ///
    /// WPD_PROPERTY_COMMON_OBJECT_IDS  
    ///   [ VT_UNKNOWN ] IPortableDevicePropVariantCollection of type VT_LPWSTR specifying list of Objects IDs.
    let WPD_PROPERTY_COMMON_OBJECT_IDS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_COMMON, pid = 1008u)
    
    ///
    /// WPD_PROPERTY_COMMON_CLIENT_INFORMATION  
    ///   [ VT_UNKNOWN ] IPortableDeviceValues used to identify itself to the driver.
    let WPD_PROPERTY_COMMON_CLIENT_INFORMATION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_COMMON, pid = 1009u)
    
    ///
    /// WPD_PROPERTY_COMMON_CLIENT_INFORMATION_CONTEXT  
    ///   [ VT_LPWSTR ] Driver specified context which will be sent for the particular client on all subsequent operations.
    let WPD_PROPERTY_COMMON_CLIENT_INFORMATION_CONTEXT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_COMMON, pid = 1010u)
    
    ///
    /// WPD_PROPERTY_COMMON_ACTIVITY_ID  
    ///   [ VT_CLSID ] An optional ActivityID set either by a client or by WPD API, when ETW tracing is enabled.
    let WPD_PROPERTY_COMMON_ACTIVITY_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_COMMON, pid = 1011u)
    
    /// ======== Command Options ========
    ///
    /// WPD_OPTION_VALID_OBJECT_IDS 
    ///   [ VT_UNKNOWN ]  IPortableDevicePropVariantCollection of type VT_LPWSTR specifying list of Objects IDs of the objects that support the command.
    let WPD_OPTION_VALID_OBJECT_IDS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_COMMON, pid = 5001u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CATEGORY_OBJECT_ENUMERATION 
    ///
    /// The commands in this category are used for basic object enumeration.
    ///
    let WPD_CATEGORY_OBJECT_ENUMERATION = new System.Guid(0xB7474E91u, 0xE7F8us, 0x4AD9us, 0xB4uy, 0x00uy, 0xADuy, 0x1Auy, 0x4Buy, 0x58uy, 0xEEuy, 0xECuy)
    
    /// ======== Commands ========
    ///
    /// WPD_COMMAND_OBJECT_ENUMERATION_START_FIND 
    ///    The driver receives this command when a client wishes to start enumeration. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_ENUMERATION_PARENT_ID 
    ///     [ Optional ]  WPD_PROPERTY_OBJECT_ENUMERATION_FILTER 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_ENUMERATION_CONTEXT
    let WPD_COMMAND_OBJECT_ENUMERATION_START_FIND = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_ENUMERATION, pid = 2u)
    
    ///
    /// WPD_COMMAND_OBJECT_ENUMERATION_FIND_NEXT 
    ///    This command is used when the client requests the next batch of ObjectIDs during enumeration. Only objects that match the constraints set up in WPD_COMMAND_OBJECT_ENUMERATION_START_FIND should be returned. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_ENUMERATION_CONTEXT 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_ENUMERATION_NUM_OBJECTS_REQUESTED 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_ENUMERATION_OBJECT_IDS
    let WPD_COMMAND_OBJECT_ENUMERATION_FIND_NEXT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_ENUMERATION, pid = 3u)
    
    ///
    /// WPD_COMMAND_OBJECT_ENUMERATION_END_FIND 
    ///    The driver should destroy any resources associated with this enumeration context. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_ENUMERATION_CONTEXT 
    /// Results:
    ///     None
    let WPD_COMMAND_OBJECT_ENUMERATION_END_FIND = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_ENUMERATION, pid = 4u)
    
    ///
    /// WPD_PROPERTY_OBJECT_ENUMERATION_PARENT_ID  
    ///   [ VT_LPWSTR ] The ObjectID specifying the parent object where enumeration should start.
    let WPD_PROPERTY_OBJECT_ENUMERATION_PARENT_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_ENUMERATION, pid = 1001u)
    
    ///
    /// WPD_PROPERTY_OBJECT_ENUMERATION_FILTER  
    ///   [ VT_UNKNOWN ] This is an IPortableDeviceValues which specifies the properties used to filter on. If the caller does not want filtering, then this value will not be set.
    let WPD_PROPERTY_OBJECT_ENUMERATION_FILTER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_ENUMERATION, pid = 1002u)
    
    ///
    /// WPD_PROPERTY_OBJECT_ENUMERATION_OBJECT_IDS  
    ///   [ VT_UNKNOWN ] This is an IPortableDevicePropVariantCollection of ObjectIDs (of type VT_LPWSTR). If 0 objects are returned, this should be an empty collection, not NULL.
    let WPD_PROPERTY_OBJECT_ENUMERATION_OBJECT_IDS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_ENUMERATION, pid = 1003u)
    
    ///
    /// WPD_PROPERTY_OBJECT_ENUMERATION_CONTEXT  
    ///   [ VT_LPWSTR ] This is a driver-specified identifier for the context associated with this enumeration.
    let WPD_PROPERTY_OBJECT_ENUMERATION_CONTEXT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_ENUMERATION, pid = 1004u)
    
    ///
    /// WPD_PROPERTY_OBJECT_ENUMERATION_NUM_OBJECTS_REQUESTED  
    ///   [ VT_UI4 ] The maximum number of ObjectIDs to return back to the client.
    let WPD_PROPERTY_OBJECT_ENUMERATION_NUM_OBJECTS_REQUESTED = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_ENUMERATION, pid = 1005u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CATEGORY_OBJECT_PROPERTIES 
    ///
    /// This category of commands is used to perform basic property operations such as Reading/Writing values, listing supported values and so on.
    ///
    let WPD_CATEGORY_OBJECT_PROPERTIES = new System.Guid(0x9E5582E4u, 0x0814us, 0x44E6us, 0x98uy, 0x1Auy, 0xB2uy, 0x99uy, 0x8Duy, 0x58uy, 0x38uy, 0x04uy)
    
    /// ======== Commands ========
    ///
    /// WPD_COMMAND_OBJECT_PROPERTIES_GET_SUPPORTED 
    ///    This command is used when the client requests the list of properties supported by the specified object. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_OBJECT_ID 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_KEYS
    let WPD_COMMAND_OBJECT_PROPERTIES_GET_SUPPORTED = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES, pid = 2u)
    
    ///
    /// WPD_COMMAND_OBJECT_PROPERTIES_GET_ATTRIBUTES 
    ///    This command is used when the client requests the property attributes for the specified object properties. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_OBJECT_ID 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_KEYS 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_ATTRIBUTES
    let WPD_COMMAND_OBJECT_PROPERTIES_GET_ATTRIBUTES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES, pid = 3u)
    
    ///
    /// WPD_COMMAND_OBJECT_PROPERTIES_GET 
    ///    This command is used when the client requests a set of property values for the specified object. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_OBJECT_ID 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_KEYS 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_VALUES
    let WPD_COMMAND_OBJECT_PROPERTIES_GET = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES, pid = 4u)
    
    ///
    /// WPD_COMMAND_OBJECT_PROPERTIES_SET 
    ///    This command is used when the client requests to write a set of property values on the specified object. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_OBJECT_ID 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_VALUES 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_WRITE_RESULTS
    let WPD_COMMAND_OBJECT_PROPERTIES_SET = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES, pid = 5u)
    
    ///
    /// WPD_COMMAND_OBJECT_PROPERTIES_GET_ALL 
    ///    This command is used when the client requests all property values for the specified object. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_OBJECT_ID 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_VALUES
    let WPD_COMMAND_OBJECT_PROPERTIES_GET_ALL = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES, pid = 6u)
    
    ///
    /// WPD_COMMAND_OBJECT_PROPERTIES_DELETE 
    ///    This command is sent when the caller wants to delete properties from the specified object. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_OBJECT_ID 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_KEYS 
    /// Results:
    ///     [ Optional ]  WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_DELETE_RESULTS
    let WPD_COMMAND_OBJECT_PROPERTIES_DELETE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES, pid = 7u)
    
    ///
    /// WPD_PROPERTY_OBJECT_PROPERTIES_OBJECT_ID  
    ///   [ VT_LPWSTR ] The ObjectID specifying the object whose properties are being queried/manipulated.
    let WPD_PROPERTY_OBJECT_PROPERTIES_OBJECT_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES, pid = 1001u)
    
    ///
    /// WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_KEYS  
    ///   [ VT_UNKNOWN ] An IPortableDeviceKeyCollection identifying which specific property values we are querying/manipulating.
    let WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_KEYS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES, pid = 1002u)
    
    ///
    /// WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_ATTRIBUTES  
    ///   [ VT_UNKNOWN ] This is an IPortableDeviceValues which contains the attributes for each property requested.
    let WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_ATTRIBUTES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES, pid = 1003u)
    
    ///
    /// WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_VALUES  
    ///   [ VT_UNKNOWN ] This is an IPortableDeviceValues which contains the values read. For any property whose value could not be read, the type must be set to VT_ERROR, and the 'scode' field must contain the failure HRESULT.
    let WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_VALUES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES, pid = 1004u)
    
    ///
    /// WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_WRITE_RESULTS  
    ///   [ VT_UNKNOWN ] This is an IPortableDeviceValues which contains the result of each property write operation.
    let WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_WRITE_RESULTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES, pid = 1005u)
    
    ///
    /// WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_DELETE_RESULTS  
    ///   [ VT_UNKNOWN ] This is an IPortableDeviceValues which contains the result of each property delete operation.
    let WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_DELETE_RESULTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES, pid = 1006u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CATEGORY_OBJECT_PROPERTIES_BULK 
    ///
    /// This category contains commands and properties for property operations across multiple objects.
    ///
    let WPD_CATEGORY_OBJECT_PROPERTIES_BULK = new System.Guid(0x11C824DDu, 0x04CDus, 0x4E4Eus, 0x8Cuy, 0x7Buy, 0xF6uy, 0xEFuy, 0xB7uy, 0x94uy, 0xD8uy, 0x4Euy)
    
    /// ======== Commands ========
    ///
    /// WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_LIST_START 
    ///    Initializes the operation to get the property values for all caller-specified objects. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_OBJECT_IDS 
    ///     [ Optional ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_PROPERTY_KEYS 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT
    let WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_LIST_START = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES_BULK, pid = 2u)
    
    ///
    /// WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_LIST_NEXT 
    ///    Get the next set of property values. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_VALUES
    let WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_LIST_NEXT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES_BULK, pid = 3u)
    
    ///
    /// WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_LIST_END 
    ///    Ends the bulk property operation for getting property values by object list. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT 
    /// Results:
    ///     None
    let WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_LIST_END = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES_BULK, pid = 4u)
    
    ///
    /// WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_FORMAT_START 
    ///    Initializes the operation to get the property values for objects of the specified format 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_OBJECT_FORMAT 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_PARENT_OBJECT_ID 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_DEPTH 
    ///     [ Optional ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_PROPERTY_KEYS 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT
    let WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_FORMAT_START = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES_BULK, pid = 5u)
    
    ///
    /// WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_FORMAT_NEXT 
    ///    Get the next set of property values. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_VALUES
    let WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_FORMAT_NEXT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES_BULK, pid = 6u)
    
    ///
    /// WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_FORMAT_END 
    ///    Ends the bulk property operation for getting property values by object format. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT 
    /// Results:
    ///     None
    let WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_FORMAT_END = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES_BULK, pid = 7u)
    
    ///
    /// WPD_COMMAND_OBJECT_PROPERTIES_BULK_SET_VALUES_BY_OBJECT_LIST_START 
    ///    Initializes the operation to set the property values for specified objects. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_VALUES 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT
    let WPD_COMMAND_OBJECT_PROPERTIES_BULK_SET_VALUES_BY_OBJECT_LIST_START = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES_BULK, pid = 8u)
    
    ///
    /// WPD_COMMAND_OBJECT_PROPERTIES_BULK_SET_VALUES_BY_OBJECT_LIST_NEXT 
    ///    Set the next set of property values. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_WRITE_RESULTS
    let WPD_COMMAND_OBJECT_PROPERTIES_BULK_SET_VALUES_BY_OBJECT_LIST_NEXT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES_BULK, pid = 9u)
    
    ///
    /// WPD_COMMAND_OBJECT_PROPERTIES_BULK_SET_VALUES_BY_OBJECT_LIST_END 
    ///    Ends the bulk property operation for setting property values by object list. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT 
    /// Results:
    ///     None
    let WPD_COMMAND_OBJECT_PROPERTIES_BULK_SET_VALUES_BY_OBJECT_LIST_END = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES_BULK, pid = 10u)
    
    ///
    /// WPD_PROPERTY_OBJECT_PROPERTIES_BULK_OBJECT_IDS  
    ///   [ VT_UNKNOWN ] A collection of ObjectIDs for which supported property list must be returned.
    let WPD_PROPERTY_OBJECT_PROPERTIES_BULK_OBJECT_IDS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES_BULK, pid = 1001u)
    
    ///
    /// WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT  
    ///   [ VT_LPWSTR ] The driver-specified context identifying this particular bulk operation.
    let WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES_BULK, pid = 1002u)
    
    ///
    /// WPD_PROPERTY_OBJECT_PROPERTIES_BULK_VALUES  
    ///   [ VT_UNKNOWN ] Contains an IPortableDeviceValuesCollection specifying the next set of IPortableDeviceValues elements.
    let WPD_PROPERTY_OBJECT_PROPERTIES_BULK_VALUES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES_BULK, pid = 1003u)
    
    ///
    /// WPD_PROPERTY_OBJECT_PROPERTIES_BULK_PROPERTY_KEYS  
    ///   [ VT_UNKNOWN ] Contains an IPortableDeviceKeyCollection specifying which properties the caller wants to return. May not exist, which indicates caller wants ALL properties.
    let WPD_PROPERTY_OBJECT_PROPERTIES_BULK_PROPERTY_KEYS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES_BULK, pid = 1004u)
    
    ///
    /// WPD_PROPERTY_OBJECT_PROPERTIES_BULK_DEPTH  
    ///   [ VT_UI4 ] Contains a value specifying the hierarchical depth from the parent to include in this operation.
    let WPD_PROPERTY_OBJECT_PROPERTIES_BULK_DEPTH = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES_BULK, pid = 1005u)
    
    ///
    /// WPD_PROPERTY_OBJECT_PROPERTIES_BULK_PARENT_OBJECT_ID  
    ///   [ VT_LPWSTR ] Contains the ObjectID of the object to start the operation from.
    let WPD_PROPERTY_OBJECT_PROPERTIES_BULK_PARENT_OBJECT_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES_BULK, pid = 1006u)
    
    ///
    /// WPD_PROPERTY_OBJECT_PROPERTIES_BULK_OBJECT_FORMAT  
    ///   [ VT_CLSID ] Specifies the object format the client is interested in.
    let WPD_PROPERTY_OBJECT_PROPERTIES_BULK_OBJECT_FORMAT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES_BULK, pid = 1007u)
    
    ///
    /// WPD_PROPERTY_OBJECT_PROPERTIES_BULK_WRITE_RESULTS  
    ///   [ VT_UNKNOWN ] Contains an IPortableDeviceValuesCollection specifying the set of IPortableDeviceValues elements indicating the write results for each property set.
    let WPD_PROPERTY_OBJECT_PROPERTIES_BULK_WRITE_RESULTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_PROPERTIES_BULK, pid = 1008u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CATEGORY_OBJECT_RESOURCES 
    ///
    /// The commands in this category are used for basic object resource enumeration and transfer.
    ///
    let WPD_CATEGORY_OBJECT_RESOURCES = new System.Guid(0xB3A2B22Du, 0xA595us, 0x4108us, 0xBEuy, 0x0Auy, 0xFCuy, 0x3Cuy, 0x96uy, 0x5Fuy, 0x3Duy, 0x4Auy)
    
    /// ======== Commands ========
    ///
    /// WPD_COMMAND_OBJECT_RESOURCES_GET_SUPPORTED 
    ///    This command is sent when a client wants to get the list of resources supported on a particular object. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_OBJECT_ID 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_KEYS
    let WPD_COMMAND_OBJECT_RESOURCES_GET_SUPPORTED = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 2u)
    
    ///
    /// WPD_COMMAND_OBJECT_RESOURCES_GET_ATTRIBUTES 
    ///    This command is used when the client requests the attributes for the specified object resource. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_OBJECT_ID 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_KEYS 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_ATTRIBUTES
    let WPD_COMMAND_OBJECT_RESOURCES_GET_ATTRIBUTES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 3u)
    
    ///
    /// WPD_COMMAND_OBJECT_RESOURCES_OPEN 
    ///    This command is sent when a client wants to use a particular resource on an object. 
    /// Access:
    ///     Dependent on the value of WPD_PROPERTY_OBJECT_RESOURCES_ACCESS_MODE.  STGM_READ will indicate FILE_READ_ACCESS for the command, anything else will indicate (FILE_READ_ACCESS | FILE_WRITE_ACCESS).
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_OBJECT_ID 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_KEYS 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_ACCESS_MODE 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_CONTEXT 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_OPTIMAL_TRANSFER_BUFFER_SIZE 
    ///     [ Optional ]  WPD_PROPERTY_OBJECT_RESOURCES_SUPPORTS_UNITS
    let WPD_COMMAND_OBJECT_RESOURCES_OPEN = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 4u)
    
    ///
    /// WPD_COMMAND_OBJECT_RESOURCES_READ 
    ///    This command is sent when a client wants to read the next band of data from a previously opened object resource. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_CONTEXT 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_TO_READ 
    ///     [ Required except when the driver returns TRUE for the WPD_OPTION_OBJECT_RESOURCES_NO_INPUT_BUFFER_ON_READ option. ]  WPD_PROPERTY_OBJECT_RESOURCES_DATA 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_READ 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_DATA
    let WPD_COMMAND_OBJECT_RESOURCES_READ = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 5u)
    
    ///
    /// WPD_COMMAND_OBJECT_RESOURCES_WRITE 
    ///    This command is sent when a client wants to write the next band of data to a previously opened object resource. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_CONTEXT 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_TO_WRITE 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_DATA 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_WRITTEN
    let WPD_COMMAND_OBJECT_RESOURCES_WRITE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 6u)
    
    ///
    /// WPD_COMMAND_OBJECT_RESOURCES_CLOSE 
    ///    This command is sent when a client is finished transferring data to a previously opened object resource. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_CONTEXT 
    /// Results:
    ///     None
    let WPD_COMMAND_OBJECT_RESOURCES_CLOSE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 7u)
    
    ///
    /// WPD_COMMAND_OBJECT_RESOURCES_DELETE 
    ///    This command is sent when the client wants to delete the data associated with the specified resources from the specified object. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_OBJECT_ID 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_KEYS 
    /// Results:
    ///     None
    let WPD_COMMAND_OBJECT_RESOURCES_DELETE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 8u)
    
    ///
    /// WPD_COMMAND_OBJECT_RESOURCES_CREATE_RESOURCE 
    ///    This command is sent when a client wants to create a new object resource on the device. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_ATTRIBUTES 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_CONTEXT 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_OPTIMAL_TRANSFER_BUFFER_SIZE
    let WPD_COMMAND_OBJECT_RESOURCES_CREATE_RESOURCE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 9u)
    
    ///
    /// WPD_COMMAND_OBJECT_RESOURCES_REVERT 
    ///    This command is sent when a client wants to cancel the resource creation request that is currently still in progress. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_CONTEXT 
    /// Results:
    ///     None
    let WPD_COMMAND_OBJECT_RESOURCES_REVERT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 10u)
    
    ///
    /// WPD_COMMAND_OBJECT_RESOURCES_SEEK 
    ///    This command is sent when a client wants to seek to a specific offset in the data stream. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_CONTEXT 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_SEEK_OFFSET 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_SEEK_ORIGIN_FLAG 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_POSITION_FROM_START
    let WPD_COMMAND_OBJECT_RESOURCES_SEEK = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 11u)
    
    ///
    /// WPD_COMMAND_OBJECT_RESOURCES_COMMIT 
    ///    This command is sent when a client wants to commit changes to a data stream. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_CONTEXT 
    /// Results:
    ///     None
    let WPD_COMMAND_OBJECT_RESOURCES_COMMIT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 12u)
    
    ///
    /// WPD_COMMAND_OBJECT_RESOURCES_SEEK_IN_UNITS 
    ///    This command is sent when a client wants to seek to a specific offset in the data stream using alternate units. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_CONTEXT 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_SEEK_OFFSET 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_STREAM_UNITS 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_SEEK_ORIGIN_FLAG 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_RESOURCES_POSITION_FROM_START
    let WPD_COMMAND_OBJECT_RESOURCES_SEEK_IN_UNITS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 13u)
    
    ///
    /// WPD_PROPERTY_OBJECT_RESOURCES_OBJECT_ID  
    ///   [ VT_LPWSTR ]
    let WPD_PROPERTY_OBJECT_RESOURCES_OBJECT_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 1001u)
    
    ///
    /// WPD_PROPERTY_OBJECT_RESOURCES_ACCESS_MODE  
    ///   [ VT_UI4 ] Specifies the type of access the client is requesting for the resource.
    let WPD_PROPERTY_OBJECT_RESOURCES_ACCESS_MODE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 1002u)
    
    ///
    /// WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_KEYS  
    ///   [ VT_UNKNOWN ]
    let WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_KEYS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 1003u)
    
    ///
    /// WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_ATTRIBUTES  
    ///   [ VT_UNKNOWN ] This is an IPortableDeviceValues which contains the attributes for the resource requested.
    let WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_ATTRIBUTES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 1004u)
    
    ///
    /// WPD_PROPERTY_OBJECT_RESOURCES_CONTEXT  
    ///   [ VT_LPWSTR ] This is a driver-specified identifier for the context associated with the resource operation.
    let WPD_PROPERTY_OBJECT_RESOURCES_CONTEXT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 1005u)
    
    ///
    /// WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_TO_READ  
    ///   [ VT_UI4 ] Specifies the number of bytes the client is requesting to read.
    let WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_TO_READ = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 1006u)
    
    ///
    /// WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_READ  
    ///   [ VT_UI4 ] Specifies the number of bytes actually read from the resource.
    let WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_READ = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 1007u)
    
    ///
    /// WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_TO_WRITE  
    ///   [ VT_UI4 ] Specifies the number of bytes the client is requesting to write.
    let WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_TO_WRITE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 1008u)
    
    ///
    /// WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_WRITTEN  
    ///   [ VT_UI4 ] Driver sets this to let caller know how many bytes were actually written.
    let WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_WRITTEN = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 1009u)
    
    ///
    /// WPD_PROPERTY_OBJECT_RESOURCES_DATA  
    ///   [ VT_VECTOR | VT_UI1 ]
    let WPD_PROPERTY_OBJECT_RESOURCES_DATA = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 1010u)
    
    ///
    /// WPD_PROPERTY_OBJECT_RESOURCES_OPTIMAL_TRANSFER_BUFFER_SIZE  
    ///   [ VT_UI4 ] Indicates the optimal transfer buffer size (in bytes) that clients should use when reading/writing this resource.
    let WPD_PROPERTY_OBJECT_RESOURCES_OPTIMAL_TRANSFER_BUFFER_SIZE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 1011u)
    
    ///
    /// WPD_PROPERTY_OBJECT_RESOURCES_SEEK_OFFSET  
    ///   [ VT_I8 ] Displacement to be added to the location indicated by the WPD_PROPERTY_OBJECT_RESOURCES_SEEK_ORIGIN_FLAG parameter.
    let WPD_PROPERTY_OBJECT_RESOURCES_SEEK_OFFSET = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 1012u)
    
    ///
    /// WPD_PROPERTY_OBJECT_RESOURCES_SEEK_ORIGIN_FLAG  
    ///   [ VT_UI4 ] Specifies the origin of the displacement for the seek operation.
    let WPD_PROPERTY_OBJECT_RESOURCES_SEEK_ORIGIN_FLAG = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 1013u)
    
    ///
    /// WPD_PROPERTY_OBJECT_RESOURCES_POSITION_FROM_START  
    ///   [ VT_UI8 ] Value of the new seek pointer from the beginning of the data stream.
    let WPD_PROPERTY_OBJECT_RESOURCES_POSITION_FROM_START = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 1014u)
    
    ///
    /// WPD_PROPERTY_OBJECT_RESOURCES_SUPPORTS_UNITS  
    ///   [ VT_BOOL ] A Boolean value that specifies whether this resource supports operations (such as seek) using alternate units. This occurs if the driver can understand WPD_COMMAND_OBJECT_RESOURCES_SEEK_IN_UNITS.
    let WPD_PROPERTY_OBJECT_RESOURCES_SUPPORTS_UNITS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 1015u)
    
    ///
    /// WPD_PROPERTY_OBJECT_RESOURCES_STREAM_UNITS  
    ///   [ VT_UI4 ] The units for the WPD_PROPERTY_OBJECT_SEEK_OFFSET parameter and the WPD_PROPERTY_OBJECT_RESOURCES_POSITION_FROM_START result.
    let WPD_PROPERTY_OBJECT_RESOURCES_STREAM_UNITS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 1016u)
    
    /// ======== Command Options ========
    ///
    /// WPD_OPTION_OBJECT_RESOURCES_SEEK_ON_READ_SUPPORTED 
    ///   [ VT_BOOL ]  Indicates whether the driver can Seek on a resource opened for Read access.
    let WPD_OPTION_OBJECT_RESOURCES_SEEK_ON_READ_SUPPORTED = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 5001u)
    
    ///
    /// WPD_OPTION_OBJECT_RESOURCES_SEEK_ON_WRITE_SUPPORTED 
    ///   [ VT_BOOL ]  Indicates whether the driver can Seek on a resource opened for Write access.
    let WPD_OPTION_OBJECT_RESOURCES_SEEK_ON_WRITE_SUPPORTED = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 5002u)
    
    ///
    /// WPD_OPTION_OBJECT_RESOURCES_NO_INPUT_BUFFER_ON_READ 
    ///   [ VT_BOOL ]  Indicates whether the driver requires an input buffer for WPD_COMMAND_OBJECT_RESOURCES_READ. If not set, defaults to False.
    let WPD_OPTION_OBJECT_RESOURCES_NO_INPUT_BUFFER_ON_READ = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_RESOURCES, pid = 5003u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CATEGORY_OBJECT_MANAGEMENT 
    ///
    /// The commands specified in this category are used to Create/Delete objects on the device.
    ///
    let WPD_CATEGORY_OBJECT_MANAGEMENT = new System.Guid(0xEF1E43DDu, 0xA9EDus, 0x4341us, 0x8Buy, 0xCCuy, 0x18uy, 0x61uy, 0x92uy, 0xAEuy, 0xA0uy, 0x89uy)
    
    /// ======== Commands ========
    ///
    /// WPD_COMMAND_OBJECT_MANAGEMENT_CREATE_OBJECT_WITH_PROPERTIES_ONLY 
    ///    This command is sent when a client wants to create a new object on the device, specified only by properties. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_CREATION_PROPERTIES 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_ID
    let WPD_COMMAND_OBJECT_MANAGEMENT_CREATE_OBJECT_WITH_PROPERTIES_ONLY = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 2u)
    
    ///
    /// WPD_COMMAND_OBJECT_MANAGEMENT_CREATE_OBJECT_WITH_PROPERTIES_AND_DATA 
    ///    This command is sent when a client wants to create a new object on the device, specified by properties and data. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_CREATION_PROPERTIES 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_CONTEXT
    let WPD_COMMAND_OBJECT_MANAGEMENT_CREATE_OBJECT_WITH_PROPERTIES_AND_DATA = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 3u)
    
    ///
    /// WPD_COMMAND_OBJECT_MANAGEMENT_WRITE_OBJECT_DATA 
    ///    This command is sent when a client wants to write the next band of data to a newly created object or an object being updated. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_CONTEXT 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_NUM_BYTES_TO_WRITE 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_DATA 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_NUM_BYTES_WRITTEN
    let WPD_COMMAND_OBJECT_MANAGEMENT_WRITE_OBJECT_DATA = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 4u)
    
    ///
    /// WPD_COMMAND_OBJECT_MANAGEMENT_COMMIT_OBJECT 
    ///    This command is sent when a client has finished sending all the data associated with an object creation or update request, and wishes to ensure that the object is saved to the device. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_CONTEXT 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_ID
    let WPD_COMMAND_OBJECT_MANAGEMENT_COMMIT_OBJECT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 5u)
    
    ///
    /// WPD_COMMAND_OBJECT_MANAGEMENT_REVERT_OBJECT 
    ///    This command is sent when a client wants to cancel the object creation or update request that is currently still in progress. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_CONTEXT 
    /// Results:
    ///     None
    let WPD_COMMAND_OBJECT_MANAGEMENT_REVERT_OBJECT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 6u)
    
    ///
    /// WPD_COMMAND_OBJECT_MANAGEMENT_DELETE_OBJECTS 
    ///    This command is sent when the client wishes to remove a set of objects from the device. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_DELETE_OPTIONS 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_IDS 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_DELETE_RESULTS
    let WPD_COMMAND_OBJECT_MANAGEMENT_DELETE_OBJECTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 7u)
    
    ///
    /// WPD_COMMAND_OBJECT_MANAGEMENT_MOVE_OBJECTS 
    ///    This command will move the specified objects to the destination folder. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_IDS 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_DESTINATION_FOLDER_OBJECT_ID 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_MOVE_RESULTS
    let WPD_COMMAND_OBJECT_MANAGEMENT_MOVE_OBJECTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 8u)
    
    ///
    /// WPD_COMMAND_OBJECT_MANAGEMENT_COPY_OBJECTS 
    ///    This command will copy the specified objects to the destination folder. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_IDS 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_DESTINATION_FOLDER_OBJECT_ID 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_COPY_RESULTS
    let WPD_COMMAND_OBJECT_MANAGEMENT_COPY_OBJECTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 9u)
    
    ///
    /// WPD_COMMAND_OBJECT_MANAGEMENT_UPDATE_OBJECT_WITH_PROPERTIES_AND_DATA 
    ///    This command is sent when a client wants to update the object's data and dependent properties simultaneously. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_ID 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_UPDATE_PROPERTIES 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_CONTEXT 
    ///     [ Required ]  WPD_PROPERTY_OBJECT_MANAGEMENT_OPTIMAL_TRANSFER_BUFFER_SIZE
    let WPD_COMMAND_OBJECT_MANAGEMENT_UPDATE_OBJECT_WITH_PROPERTIES_AND_DATA = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 10u)
    
    ///
    /// WPD_PROPERTY_OBJECT_MANAGEMENT_CREATION_PROPERTIES  
    ///   [ VT_UNKNOWN ] This is an IPortableDeviceValues which specifies the properties used to create the new object.
    let WPD_PROPERTY_OBJECT_MANAGEMENT_CREATION_PROPERTIES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 1001u)
    
    ///
    /// WPD_PROPERTY_OBJECT_MANAGEMENT_CONTEXT  
    ///   [ VT_LPWSTR ] This is a driver-specified identifier for the context associated with this 'create object' operation.
    let WPD_PROPERTY_OBJECT_MANAGEMENT_CONTEXT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 1002u)
    
    ///
    /// WPD_PROPERTY_OBJECT_MANAGEMENT_NUM_BYTES_TO_WRITE  
    ///   [ VT_UI4 ] Specifies the number of bytes the client is requesting to write.
    let WPD_PROPERTY_OBJECT_MANAGEMENT_NUM_BYTES_TO_WRITE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 1003u)
    
    ///
    /// WPD_PROPERTY_OBJECT_MANAGEMENT_NUM_BYTES_WRITTEN  
    ///   [ VT_UI4 ] Indicates the number of bytes written for the object.
    let WPD_PROPERTY_OBJECT_MANAGEMENT_NUM_BYTES_WRITTEN = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 1004u)
    
    ///
    /// WPD_PROPERTY_OBJECT_MANAGEMENT_DATA  
    ///   [ VT_VECTOR | VT_UI1 ] Indicates binary data of the object being created on the device.
    let WPD_PROPERTY_OBJECT_MANAGEMENT_DATA = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 1005u)
    
    ///
    /// WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_ID  
    ///   [ VT_LPWSTR ] Identifies a newly created object on the device.
    let WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 1006u)
    
    ///
    /// WPD_PROPERTY_OBJECT_MANAGEMENT_DELETE_OPTIONS  
    ///   [ VT_UI4 ] Indicates if the delete operation should be recursive or not.
    let WPD_PROPERTY_OBJECT_MANAGEMENT_DELETE_OPTIONS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 1007u)
    
    ///
    /// WPD_PROPERTY_OBJECT_MANAGEMENT_OPTIMAL_TRANSFER_BUFFER_SIZE  
    ///   [ VT_UI4 ] Indicates the optimal transfer buffer size (in bytes) that clients should use when writing this object's data.
    let WPD_PROPERTY_OBJECT_MANAGEMENT_OPTIMAL_TRANSFER_BUFFER_SIZE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 1008u)
    
    ///
    /// WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_IDS  
    ///   [ VT_UNKNOWN ] IPortableDevicePropVariantCollection of type VT_LPWSTR, containing the ObjectIDs to delete.
    let WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_IDS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 1009u)
    
    ///
    /// WPD_PROPERTY_OBJECT_MANAGEMENT_DELETE_RESULTS  
    ///   [ VT_UNKNOWN ] IPortableDevicePropVariantCollection of type VT_ERROR, where each element is the HRESULT indicating the success or failure of the operation.
    let WPD_PROPERTY_OBJECT_MANAGEMENT_DELETE_RESULTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 1010u)
    
    ///
    /// WPD_PROPERTY_OBJECT_MANAGEMENT_DESTINATION_FOLDER_OBJECT_ID  
    ///   [ VT_LPWSTR ] Indicates the destination folder for the move operation.
    let WPD_PROPERTY_OBJECT_MANAGEMENT_DESTINATION_FOLDER_OBJECT_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 1011u)
    
    ///
    /// WPD_PROPERTY_OBJECT_MANAGEMENT_MOVE_RESULTS  
    ///   [ VT_UNKNOWN ] IPortableDevicePropVariantCollection of type VT_ERROR, where each element is the HRESULT indicating the success or failure of the operation.
    let WPD_PROPERTY_OBJECT_MANAGEMENT_MOVE_RESULTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 1012u)
    
    ///
    /// WPD_PROPERTY_OBJECT_MANAGEMENT_COPY_RESULTS  
    ///   [ VT_UNKNOWN ] IPortableDevicePropVariantCollection of type VT_ERROR, where each element is the HRESULT indicating the success or failure of the operation.
    let WPD_PROPERTY_OBJECT_MANAGEMENT_COPY_RESULTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 1013u)
    
    ///
    /// WPD_PROPERTY_OBJECT_MANAGEMENT_UPDATE_PROPERTIES  
    ///   [ VT_UNKNOWN ] IPortableDeviceValues containing the object properties to update.
    let WPD_PROPERTY_OBJECT_MANAGEMENT_UPDATE_PROPERTIES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 1014u)
    
    ///
    /// WPD_PROPERTY_OBJECT_MANAGEMENT_PROPERTY_KEYS  
    ///   [ VT_UNKNOWN ] IPortableDeviceKeyCollection containing the property keys required to update this object.
    let WPD_PROPERTY_OBJECT_MANAGEMENT_PROPERTY_KEYS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 1015u)
    
    ///
    /// WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_FORMAT  
    ///   [ VT_CLSID ] Indicates the object format the caller is interested in.
    let WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_FORMAT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 1016u)
    
    /// ======== Command Options ========
    ///
    /// WPD_OPTION_OBJECT_MANAGEMENT_RECURSIVE_DELETE_SUPPORTED 
    ///   [ VT_BOOL ]  Indicates whether the driver supports recursive deletion.
    let WPD_OPTION_OBJECT_MANAGEMENT_RECURSIVE_DELETE_SUPPORTED = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_OBJECT_MANAGEMENT, pid = 5001u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CATEGORY_CAPABILITIES 
    ///
    /// This command category is used to query capabilities of the device.
    ///
    let WPD_CATEGORY_CAPABILITIES = new System.Guid(0x0CABEC78u, 0x6B74us, 0x41C6us, 0x92uy, 0x16uy, 0x26uy, 0x39uy, 0xD1uy, 0xFCuy, 0xE3uy, 0x56uy)
    
    /// ======== Commands ========
    ///
    /// WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_COMMANDS 
    ///    Return all commands supported by this driver. This includes custom commands, if any. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     None
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_CAPABILITIES_SUPPORTED_COMMANDS
    let WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_COMMANDS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 2u)
    
    ///
    /// WPD_COMMAND_CAPABILITIES_GET_COMMAND_OPTIONS 
    ///    Returns the supported options for the specified command. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_CAPABILITIES_COMMAND 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_CAPABILITIES_COMMAND_OPTIONS
    let WPD_COMMAND_CAPABILITIES_GET_COMMAND_OPTIONS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 3u)
    
    ///
    /// WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FUNCTIONAL_CATEGORIES 
    ///    This command is used by clients to query the functional categories supported by the driver. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     None
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_CATEGORIES
    let WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FUNCTIONAL_CATEGORIES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 4u)
    
    ///
    /// WPD_COMMAND_CAPABILITIES_GET_FUNCTIONAL_OBJECTS 
    ///    Retrieves the ObjectIDs of the objects belonging to the specified functional category. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_CATEGORY 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_OBJECTS
    let WPD_COMMAND_CAPABILITIES_GET_FUNCTIONAL_OBJECTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 5u)
    
    ///
    /// WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_CONTENT_TYPES 
    ///    Retrieves the list of content types supported by this driver for the specified functional category. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_CATEGORY 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_CAPABILITIES_CONTENT_TYPES
    let WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_CONTENT_TYPES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 6u)
    
    ///
    /// WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FORMATS 
    ///    This command is used to query the possible formats supported by the specified content type (e.g. for image objects, the driver may choose to support JPEG and BMP files). 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_CAPABILITIES_CONTENT_TYPE 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_CAPABILITIES_FORMATS
    let WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FORMATS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 7u)
    
    ///
    /// WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FORMAT_PROPERTIES 
    ///    Get the list of properties that an object of the given format supports. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_CAPABILITIES_FORMAT 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_CAPABILITIES_PROPERTY_KEYS
    let WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FORMAT_PROPERTIES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 8u)
    
    ///
    /// WPD_COMMAND_CAPABILITIES_GET_FIXED_PROPERTY_ATTRIBUTES 
    ///    Returns the property attributes that are the same for all objects of the given format. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_CAPABILITIES_FORMAT 
    ///     [ Required ]  WPD_PROPERTY_CAPABILITIES_PROPERTY_KEYS 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_CAPABILITIES_PROPERTY_ATTRIBUTES
    let WPD_COMMAND_CAPABILITIES_GET_FIXED_PROPERTY_ATTRIBUTES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 9u)
    
    ///
    /// WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_EVENTS 
    ///    Return all events supported by this driver. This includes custom events, if any. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     None
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_CAPABILITIES_SUPPORTED_EVENTS
    let WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_EVENTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 10u)
    
    ///
    /// WPD_COMMAND_CAPABILITIES_GET_EVENT_OPTIONS 
    ///    Return extra information about a specified event, such as whether the event is for notification or action purposes. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_CAPABILITIES_EVENT 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_CAPABILITIES_EVENT_OPTIONS
    let WPD_COMMAND_CAPABILITIES_GET_EVENT_OPTIONS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 11u)
    
    ///
    /// WPD_PROPERTY_CAPABILITIES_SUPPORTED_COMMANDS  
    ///   [ VT_UNKNOWN ] IPortableDeviceKeyCollection containing all commands a driver supports.
    let WPD_PROPERTY_CAPABILITIES_SUPPORTED_COMMANDS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 1001u)
    
    ///
    /// WPD_PROPERTY_CAPABILITIES_COMMAND  
    ///   [ VT_UNKNOWN ] Indicates the command whose options the caller is interested in.
    let WPD_PROPERTY_CAPABILITIES_COMMAND = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 1002u)
    
    ///
    /// WPD_PROPERTY_CAPABILITIES_COMMAND_OPTIONS  
    ///   [ VT_UNKNOWN ] Contains an IPortableDeviceValues with the relevant command options.
    let WPD_PROPERTY_CAPABILITIES_COMMAND_OPTIONS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 1003u)
    
    ///
    /// WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_CATEGORIES  
    ///   [ VT_UNKNOWN ] An IPortableDevicePropVariantCollection of type VT_CLSID which indicates the functional categories supported by the driver.
    let WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_CATEGORIES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 1004u)
    
    ///
    /// WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_CATEGORY  
    ///   [ VT_CLSID ] The category the caller is interested in.
    let WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_CATEGORY = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 1005u)
    
    ///
    /// WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_OBJECTS  
    ///   [ VT_UNKNOWN ] An IPortableDevicePropVariantCollection (of type VT_LPWSTR) containing the ObjectIDs of the functional objects who belong to the specified functional category.
    let WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_OBJECTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 1006u)
    
    ///
    /// WPD_PROPERTY_CAPABILITIES_CONTENT_TYPES  
    ///   [ VT_UNKNOWN ] Indicates list of content types supported for the specified functional category.
    let WPD_PROPERTY_CAPABILITIES_CONTENT_TYPES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 1007u)
    
    ///
    /// WPD_PROPERTY_CAPABILITIES_CONTENT_TYPE  
    ///   [ VT_CLSID ] Indicates the content type whose formats the caller is interested in.
    let WPD_PROPERTY_CAPABILITIES_CONTENT_TYPE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 1008u)
    
    ///
    /// WPD_PROPERTY_CAPABILITIES_FORMATS  
    ///   [ VT_UNKNOWN ] An IPortableDevicePropVariantCollection of VT_CLSID values indicating the formats supported for the specified content type.
    let WPD_PROPERTY_CAPABILITIES_FORMATS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 1009u)
    
    ///
    /// WPD_PROPERTY_CAPABILITIES_FORMAT  
    ///   [ VT_CLSID ] Specifies the format the caller is interested in.
    let WPD_PROPERTY_CAPABILITIES_FORMAT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 1010u)
    
    ///
    /// WPD_PROPERTY_CAPABILITIES_PROPERTY_KEYS  
    ///   [ VT_UNKNOWN ] An IPortableDeviceKeyCollection containing the property keys.
    let WPD_PROPERTY_CAPABILITIES_PROPERTY_KEYS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 1011u)
    
    ///
    /// WPD_PROPERTY_CAPABILITIES_PROPERTY_ATTRIBUTES  
    ///   [ VT_UNKNOWN ] An IPortableDeviceValues containing the property attributes.
    let WPD_PROPERTY_CAPABILITIES_PROPERTY_ATTRIBUTES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 1012u)
    
    ///
    /// WPD_PROPERTY_CAPABILITIES_SUPPORTED_EVENTS  
    ///   [ VT_UNKNOWN ] IPortableDevicePropVariantCollection of VT_CLSID values containing all events a driver supports.
    let WPD_PROPERTY_CAPABILITIES_SUPPORTED_EVENTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 1013u)
    
    ///
    /// WPD_PROPERTY_CAPABILITIES_EVENT  
    ///   [ VT_CLSID ] Indicates the event the caller is interested in.
    let WPD_PROPERTY_CAPABILITIES_EVENT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 1014u)
    
    ///
    /// WPD_PROPERTY_CAPABILITIES_EVENT_OPTIONS  
    ///   [ VT_UNKNOWN ] Contains an IPortableDeviceValues with the relevant event options.
    let WPD_PROPERTY_CAPABILITIES_EVENT_OPTIONS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_CAPABILITIES, pid = 1015u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CATEGORY_STORAGE 
    ///
    /// This category is for commands and parameters for storage functional objects.
    ///
    let WPD_CATEGORY_STORAGE = new System.Guid(0xD8F907A6u, 0x34CCus, 0x45FAus, 0x97uy, 0xFBuy, 0xD0uy, 0x07uy, 0xFAuy, 0x47uy, 0xECuy, 0x94uy)
    
    /// ======== Commands ========
    ///
    /// WPD_COMMAND_STORAGE_FORMAT 
    ///    This command will format the storage. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_STORAGE_OBJECT_ID 
    /// Results:
    ///     None
    let WPD_COMMAND_STORAGE_FORMAT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_STORAGE, pid = 2u)
    
    ///
    /// WPD_COMMAND_STORAGE_EJECT 
    ///    This will eject the storage, if it is a removable store and is capable of being ejected by the device. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_STORAGE_OBJECT_ID 
    /// Results:
    ///     None
    let WPD_COMMAND_STORAGE_EJECT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_STORAGE, pid = 4u)
    
    ///
    /// WPD_PROPERTY_STORAGE_OBJECT_ID  
    ///   [ VT_LPWSTR ] Indicates the object to format, move or eject.
    let WPD_PROPERTY_STORAGE_OBJECT_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_STORAGE, pid = 1001u)
    
    ///
    /// WPD_PROPERTY_STORAGE_DESTINATION_OBJECT_ID  
    ///   [ VT_LPWSTR ] Indicates the (folder) object destination for a move operation.
    let WPD_PROPERTY_STORAGE_DESTINATION_OBJECT_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_STORAGE, pid = 1002u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CATEGORY_SMS 
    ///
    /// The commands in this category relate to Short-Message-Service functionality, typically exposed on mobile phones.
    ///
    let WPD_CATEGORY_SMS = new System.Guid(0xAFC25D66u, 0xFE0Dus, 0x4114us, 0x90uy, 0x97uy, 0x97uy, 0x0Cuy, 0x93uy, 0xE9uy, 0x20uy, 0xD1uy)
    
    /// ======== Commands ========
    ///
    /// WPD_COMMAND_SMS_SEND 
    ///    This command is used to initiate the sending of an SMS message. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_COMMON_COMMAND_TARGET 
    ///     [ Required ]  WPD_PROPERTY_SMS_RECIPIENT 
    ///     [ Required ]  WPD_PROPERTY_SMS_MESSAGE_TYPE 
    ///     [ Optional ]  WPD_PROPERTY_SMS_TEXT_MESSAGE 
    ///     [ Optional ]  WPD_PROPERTY_SMS_BINARY_MESSAGE 
    /// Results:
    ///     None
    let WPD_COMMAND_SMS_SEND = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SMS, pid = 2u)
    
    ///
    /// WPD_PROPERTY_SMS_RECIPIENT  
    ///   [ VT_LPWSTR ] Indicates the recipient's address.
    let WPD_PROPERTY_SMS_RECIPIENT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SMS, pid = 1001u)
    
    ///
    /// WPD_PROPERTY_SMS_MESSAGE_TYPE  
    ///   [ VT_UI4 ] Indicates whether the message is binary or text.
    let WPD_PROPERTY_SMS_MESSAGE_TYPE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SMS, pid = 1002u)
    
    ///
    /// WPD_PROPERTY_SMS_TEXT_MESSAGE  
    ///   [ VT_LPWSTR ] if WPD_PROPERTY_SMS_MESSAGE_TYPE == SMS_TEXT_MESSAGE, then this will contain the message body.
    let WPD_PROPERTY_SMS_TEXT_MESSAGE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SMS, pid = 1003u)
    
    ///
    /// WPD_PROPERTY_SMS_BINARY_MESSAGE  
    ///   [ VT_VECTOR | VT_UI1 ] if WPD_PROPERTY_SMS_MESSAGE_TYPE == SMS_BINARY_MESSAGE, then this will contain the binary message body.
    let WPD_PROPERTY_SMS_BINARY_MESSAGE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SMS, pid = 1004u)
    
    /// ======== Command Options ========
    ///
    /// WPD_OPTION_SMS_BINARY_MESSAGE_SUPPORTED 
    ///   [ VT_BOOL ]  Indicates whether the driver can support binary messages as well as text messages.
    let WPD_OPTION_SMS_BINARY_MESSAGE_SUPPORTED = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SMS, pid = 5001u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CATEGORY_STILL_IMAGE_CAPTURE 
    ///
    /// 
    ///
    let WPD_CATEGORY_STILL_IMAGE_CAPTURE = new System.Guid(0x4FCD6982u, 0x22A2us, 0x4B05us, 0xA4uy, 0x8Buy, 0x62uy, 0xD3uy, 0x8Buy, 0xF2uy, 0x7Buy, 0x32uy)
    
    /// ======== Commands ========
    ///
    /// WPD_COMMAND_STILL_IMAGE_CAPTURE_INITIATE 
    ///    Initiates a still image capture. This is processed as a single command i.e. there is no start or stop required. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_COMMON_COMMAND_TARGET 
    /// Results:
    ///     None
    let WPD_COMMAND_STILL_IMAGE_CAPTURE_INITIATE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_STILL_IMAGE_CAPTURE, pid = 2u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CATEGORY_MEDIA_CAPTURE 
    ///
    /// 
    ///
    let WPD_CATEGORY_MEDIA_CAPTURE = new System.Guid(0x59B433BAu, 0xFE44us, 0x4D8Dus, 0x80uy, 0x8Cuy, 0x6Buy, 0xCBuy, 0x9Buy, 0x0Fuy, 0x15uy, 0xE8uy)
    
    /// ======== Commands ========
    ///
    /// WPD_COMMAND_MEDIA_CAPTURE_START 
    ///    Initiates a media capture operation that will only be ended by a subsequent WPD_COMMAND_MEDIA_CAPTURE_STOP command. Typically used to capture media streams such as audio and video. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_COMMON_COMMAND_TARGET 
    /// Results:
    ///     None
    let WPD_COMMAND_MEDIA_CAPTURE_START = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MEDIA_CAPTURE, pid = 2u)
    
    ///
    /// WPD_COMMAND_MEDIA_CAPTURE_STOP 
    ///    Ends a media capture operation started by a WPD_COMMAND_MEDIA_CAPTURE_START command. Typically used to end capture of media streams such as audio and video. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_COMMON_COMMAND_TARGET 
    /// Results:
    ///     None
    let WPD_COMMAND_MEDIA_CAPTURE_STOP = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MEDIA_CAPTURE, pid = 3u)
    
    ///
    /// WPD_COMMAND_MEDIA_CAPTURE_PAUSE 
    ///    Pauses a media capture operation started by a WPD_COMMAND_MEDIA_CAPTURE_START command. Typically used to pause capture of media streams such as audio and video. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_COMMON_COMMAND_TARGET 
    /// Results:
    ///     None
    let WPD_COMMAND_MEDIA_CAPTURE_PAUSE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MEDIA_CAPTURE, pid = 4u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CATEGORY_DEVICE_HINTS 
    ///
    /// The commands in this category relate to hints that a device can provide to improve end-user experience.
    ///
    let WPD_CATEGORY_DEVICE_HINTS = new System.Guid(0x0D5FB92Bu, 0xCB46us, 0x4C4Fus, 0x83uy, 0x43uy, 0x0Buy, 0xC3uy, 0xD3uy, 0xF1uy, 0x7Cuy, 0x84uy)
    
    /// ======== Commands ========
    ///
    /// WPD_COMMAND_DEVICE_HINTS_GET_CONTENT_LOCATION 
    ///    This command is used to retrieve the ObjectIDs of folders that contain the specified content type. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_DEVICE_HINTS_CONTENT_TYPE 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_DEVICE_HINTS_CONTENT_LOCATIONS
    let WPD_COMMAND_DEVICE_HINTS_GET_CONTENT_LOCATION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_DEVICE_HINTS, pid = 2u)
    
    ///
    /// WPD_PROPERTY_DEVICE_HINTS_CONTENT_TYPE  
    ///   [ VT_CLSID ] Indicates the WPD content type that the caller is looking for. For example, to get the top-level folder objects that contain images, this parameter would be WPD_CONTENT_TYPE_IMAGE.
    let WPD_PROPERTY_DEVICE_HINTS_CONTENT_TYPE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_DEVICE_HINTS, pid = 1001u)
    
    ///
    /// WPD_PROPERTY_DEVICE_HINTS_CONTENT_LOCATIONS  
    ///   [ VT_UNKNOWN ] IPortableDevicePropVariantCollection of type VT_LPWSTR indicating a list of folder ObjectIDs.
    let WPD_PROPERTY_DEVICE_HINTS_CONTENT_LOCATIONS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_DEVICE_HINTS, pid = 1002u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CLASS_EXTENSION_V1 
    ///
    /// The commands in this category relate to the WPD device class extension.
    ///
    let WPD_CLASS_EXTENSION_V1 = new System.Guid(0x33FB0D11u, 0x64A3us, 0x4FACus, 0xB4uy, 0xC7uy, 0x3Duy, 0xFEuy, 0xAAuy, 0x99uy, 0xB0uy, 0x51uy)
    
    /// ======== Commands ========
    ///
    /// WPD_COMMAND_CLASS_EXTENSION_WRITE_DEVICE_INFORMATION 
    ///    This command is used to update the a cache of device-specific information. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_CLASS_EXTENSION_DEVICE_INFORMATION_VALUES 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_CLASS_EXTENSION_DEVICE_INFORMATION_WRITE_RESULTS
    let WPD_COMMAND_CLASS_EXTENSION_WRITE_DEVICE_INFORMATION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLASS_EXTENSION_V1, pid = 2u)
    
    ///
    /// WPD_PROPERTY_CLASS_EXTENSION_DEVICE_INFORMATION_VALUES  
    ///   [ VT_UNKNOWN ] This is an IPortableDeviceValues which contains the values.
    let WPD_PROPERTY_CLASS_EXTENSION_DEVICE_INFORMATION_VALUES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLASS_EXTENSION_V1, pid = 1001u)
    
    ///
    /// WPD_PROPERTY_CLASS_EXTENSION_DEVICE_INFORMATION_WRITE_RESULTS  
    ///   [ VT_UNKNOWN ] This is an IPortableDeviceValues which contains the result of each value write operation.
    let WPD_PROPERTY_CLASS_EXTENSION_DEVICE_INFORMATION_WRITE_RESULTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLASS_EXTENSION_V1, pid = 1002u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CLASS_EXTENSION_V2 
    ///
    /// The commands in this category relate to the WPD device class extension.
    ///
    let WPD_CLASS_EXTENSION_V2 = new System.Guid(0x7F0779B5u, 0xFA2Bus, 0x4766us, 0x9Cuy, 0xB2uy, 0xF7uy, 0x3Buy, 0xA3uy, 0x0Buy, 0x67uy, 0x58uy)
    
    /// ======== Commands ========
    ///
    /// WPD_COMMAND_CLASS_EXTENSION_REGISTER_SERVICE_INTERFACES 
    ///    This command is used to register a service's Plug and Play interfaces. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_CLASS_EXTENSION_SERVICE_OBJECT_ID 
    ///     [ Required ]  WPD_PROPERTY_CLASS_EXTENSION_SERVICE_INTERFACES 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_CLASS_EXTENSION_SERVICE_REGISTRATION_RESULTS
    let WPD_COMMAND_CLASS_EXTENSION_REGISTER_SERVICE_INTERFACES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLASS_EXTENSION_V2, pid = 2u)
    
    ///
    /// WPD_COMMAND_CLASS_EXTENSION_UNREGISTER_SERVICE_INTERFACES 
    ///    This command is used to unregister a service's Plug and Play interfaces. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_CLASS_EXTENSION_SERVICE_OBJECT_ID 
    ///     [ Required ]  WPD_PROPERTY_CLASS_EXTENSION_SERVICE_INTERFACES 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_CLASS_EXTENSION_SERVICE_REGISTRATION_RESULTS
    let WPD_COMMAND_CLASS_EXTENSION_UNREGISTER_SERVICE_INTERFACES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLASS_EXTENSION_V2, pid = 3u)
    
    ///
    /// WPD_PROPERTY_CLASS_EXTENSION_SERVICE_OBJECT_ID  
    ///   [ VT_LPWSTR ] The Object ID of the service.
    let WPD_PROPERTY_CLASS_EXTENSION_SERVICE_OBJECT_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLASS_EXTENSION_V2, pid = 1001u)
    
    ///
    /// WPD_PROPERTY_CLASS_EXTENSION_SERVICE_INTERFACES  
    ///   [ VT_UNKNOWN ] This is an IPortablePropVariantCollection of type VT_CLSID which contains the interface GUIDs that this service implements, including the service type GUID.
    let WPD_PROPERTY_CLASS_EXTENSION_SERVICE_INTERFACES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLASS_EXTENSION_V2, pid = 1002u)
    
    ///
    /// WPD_PROPERTY_CLASS_EXTENSION_SERVICE_REGISTRATION_RESULTS  
    ///   [ VT_UNKNOWN ] This is an IPortablePropVariantCollection of type VT_ERROR, where each element is the HRESULT indicating the success or failure of the operation.
    let WPD_PROPERTY_CLASS_EXTENSION_SERVICE_REGISTRATION_RESULTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CLASS_EXTENSION_V2, pid = 1003u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CATEGORY_NETWORK_CONFIGURATION 
    ///
    /// The commands in this category are used for Network Association and WiFi Configuration.
    ///
    let WPD_CATEGORY_NETWORK_CONFIGURATION = new System.Guid(0x78F9C6FCu, 0x79B8us, 0x473Cus, 0x90uy, 0x60uy, 0x6Buy, 0xD2uy, 0x3Duy, 0xD0uy, 0x72uy, 0xC4uy)
    
    /// ======== Commands ========
    ///
    /// WPD_COMMAND_GENERATE_KEYPAIR 
    ///    Initiates the generation of a public/private key pair and returns the public key. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     None
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_PUBLIC_KEY
    let WPD_COMMAND_GENERATE_KEYPAIR = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_NETWORK_CONFIGURATION, pid = 2u)
    
    ///
    /// WPD_COMMAND_COMMIT_KEYPAIR 
    ///    Commits a public/private key pair. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     None
    /// Results:
    ///     None
    let WPD_COMMAND_COMMIT_KEYPAIR = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_NETWORK_CONFIGURATION, pid = 3u)
    
    ///
    /// WPD_COMMAND_PROCESS_WIRELESS_PROFILE 
    ///    Initiates the processing of a Wireless Profile file. 
    /// Access:
    ///     (FILE_READ_ACCESS | FILE_WRITE_ACCESS)
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_OBJECT_PROPERTIES_OBJECT_ID 
    /// Results:
    ///     None
    let WPD_COMMAND_PROCESS_WIRELESS_PROFILE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_NETWORK_CONFIGURATION, pid = 4u)
    
    ///
    /// WPD_PROPERTY_PUBLIC_KEY  
    ///   [ VT_VECTOR | VT_UI1 ] A public key generated for RSA key exchange.
    let WPD_PROPERTY_PUBLIC_KEY = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_NETWORK_CONFIGURATION, pid = 1001u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CATEGORY_SERVICE_COMMON 
    ///
    /// The commands in this category relate to a device service.
    ///
    let WPD_CATEGORY_SERVICE_COMMON = new System.Guid(0x322F071Du, 0x36EFus, 0x477Fus, 0xB4uy, 0xB5uy, 0x6Fuy, 0x52uy, 0xD7uy, 0x34uy, 0xBAuy, 0xEEuy)
    
    /// ======== Commands ========
    ///
    /// WPD_COMMAND_SERVICE_COMMON_GET_SERVICE_OBJECT_ID 
    ///    This command is used to get the service object identifier. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     None
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_OBJECT_ID
    let WPD_COMMAND_SERVICE_COMMON_GET_SERVICE_OBJECT_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_COMMON, pid = 2u)
    
    ///
    /// WPD_PROPERTY_SERVICE_OBJECT_ID  
    ///   [ VT_LPWSTR ] Contains the service object identifier.
    let WPD_PROPERTY_SERVICE_OBJECT_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_COMMON, pid = 1001u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CATEGORY_SERVICE_CAPABILITIES 
    ///
    /// The commands in this category relate to capabilities of a device service.
    ///
    let WPD_CATEGORY_SERVICE_CAPABILITIES = new System.Guid(0x24457E74u, 0x2E9Fus, 0x44F9us, 0x8Cuy, 0x57uy, 0x1Duy, 0x1Buy, 0xCBuy, 0x17uy, 0x0Buy, 0x89uy)
    
    /// ======== Commands ========
    ///
    /// WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_METHODS 
    ///    This command is used to get the methods that apply to a service. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     None
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_SUPPORTED_METHODS
    let WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_METHODS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 2u)
    
    ///
    /// WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_METHODS_BY_FORMAT 
    ///    This command is used to get the methods that apply to a format of a service. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_FORMAT 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_SUPPORTED_METHODS
    let WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_METHODS_BY_FORMAT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 3u)
    
    ///
    /// WPD_COMMAND_SERVICE_CAPABILITIES_GET_METHOD_ATTRIBUTES 
    ///    This command is used to get the attributes of a method. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_METHOD 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_METHOD_ATTRIBUTES
    let WPD_COMMAND_SERVICE_CAPABILITIES_GET_METHOD_ATTRIBUTES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 4u)
    
    ///
    /// WPD_COMMAND_SERVICE_CAPABILITIES_GET_METHOD_PARAMETER_ATTRIBUTES 
    ///    This command is used to get the attributes of a parameter used in a method. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_METHOD 
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_PARAMETER 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_PARAMETER_ATTRIBUTES
    let WPD_COMMAND_SERVICE_CAPABILITIES_GET_METHOD_PARAMETER_ATTRIBUTES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 5u)
    
    ///
    /// WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_FORMATS 
    ///    This command is used to get formats supported by this service. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     None
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_FORMATS
    let WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_FORMATS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 6u)
    
    ///
    /// WPD_COMMAND_SERVICE_CAPABILITIES_GET_FORMAT_ATTRIBUTES 
    ///    This command is used to get attributes of a format, such as the format name. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_FORMAT 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_FORMAT_ATTRIBUTES
    let WPD_COMMAND_SERVICE_CAPABILITIES_GET_FORMAT_ATTRIBUTES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 7u)
    
    ///
    /// WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_FORMAT_PROPERTIES 
    ///    This command is used to get supported properties of a format. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_FORMAT 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_PROPERTY_KEYS
    let WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_FORMAT_PROPERTIES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 8u)
    
    ///
    /// WPD_COMMAND_SERVICE_CAPABILITIES_GET_FORMAT_PROPERTY_ATTRIBUTES 
    ///    This command is used to get the property attributes that are same for all objects of a given format on the service. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_FORMAT 
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_PROPERTY_KEYS 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_PROPERTY_ATTRIBUTES
    let WPD_COMMAND_SERVICE_CAPABILITIES_GET_FORMAT_PROPERTY_ATTRIBUTES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 9u)
    
    ///
    /// WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_EVENTS 
    ///    This command is used to get the supported events of the service. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     None
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_SUPPORTED_EVENTS
    let WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_EVENTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 10u)
    
    ///
    /// WPD_COMMAND_SERVICE_CAPABILITIES_GET_EVENT_ATTRIBUTES 
    ///    This command is used to get the attributes of an event. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_EVENT 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_EVENT_ATTRIBUTES
    let WPD_COMMAND_SERVICE_CAPABILITIES_GET_EVENT_ATTRIBUTES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 11u)
    
    ///
    /// WPD_COMMAND_SERVICE_CAPABILITIES_GET_EVENT_PARAMETER_ATTRIBUTES 
    ///    This command is used to get the attributes of a parameter used in an event. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_EVENT 
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_PARAMETER 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_PARAMETER_ATTRIBUTES
    let WPD_COMMAND_SERVICE_CAPABILITIES_GET_EVENT_PARAMETER_ATTRIBUTES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 12u)
    
    ///
    /// WPD_COMMAND_SERVICE_CAPABILITIES_GET_INHERITED_SERVICES 
    ///    This command is used to get the inherited services. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_INHERITANCE_TYPE 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_INHERITED_SERVICES
    let WPD_COMMAND_SERVICE_CAPABILITIES_GET_INHERITED_SERVICES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 13u)
    
    ///
    /// WPD_COMMAND_SERVICE_CAPABILITIES_GET_FORMAT_RENDERING_PROFILES 
    ///    This command is used to get the resource rendering profiles for a format. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_FORMAT 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_RENDERING_PROFILES
    let WPD_COMMAND_SERVICE_CAPABILITIES_GET_FORMAT_RENDERING_PROFILES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 14u)
    
    ///
    /// WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_COMMANDS 
    ///    Return all commands supported by this driver for a service. This includes custom commands, if any. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     None
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_SUPPORTED_COMMANDS
    let WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_COMMANDS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 15u)
    
    ///
    /// WPD_COMMAND_SERVICE_CAPABILITIES_GET_COMMAND_OPTIONS 
    ///    Returns the supported options for the specified command. 
    /// Access:
    ///     FILE_READ_ACCESS
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_COMMAND 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_CAPABILITIES_COMMAND_OPTIONS
    let WPD_COMMAND_SERVICE_CAPABILITIES_GET_COMMAND_OPTIONS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 16u)
    
    ///
    /// WPD_PROPERTY_SERVICE_CAPABILITIES_SUPPORTED_METHODS  
    ///   [ VT_UNKNOWN ] IPortableDevicePropVariantCollection (of type VT_CLSID) containing methods that apply to a service.
    let WPD_PROPERTY_SERVICE_CAPABILITIES_SUPPORTED_METHODS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 1001u)
    
    ///
    /// WPD_PROPERTY_SERVICE_CAPABILITIES_FORMAT  
    ///   [ VT_CLSID ] Indicates the format the caller is interested in.
    let WPD_PROPERTY_SERVICE_CAPABILITIES_FORMAT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 1002u)
    
    ///
    /// WPD_PROPERTY_SERVICE_CAPABILITIES_METHOD  
    ///   [ VT_CLSID ] Indicates the method the caller is interested in.
    let WPD_PROPERTY_SERVICE_CAPABILITIES_METHOD = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 1003u)
    
    ///
    /// WPD_PROPERTY_SERVICE_CAPABILITIES_METHOD_ATTRIBUTES  
    ///   [ VT_UNKNOWN ] IPortableDeviceValues containing the method attributes.
    let WPD_PROPERTY_SERVICE_CAPABILITIES_METHOD_ATTRIBUTES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 1004u)
    
    ///
    /// WPD_PROPERTY_SERVICE_CAPABILITIES_PARAMETER  
    ///   [ VT_UNKNOWN ] IPortableDeviceKeyCollection containing the parameter the caller is interested in.
    let WPD_PROPERTY_SERVICE_CAPABILITIES_PARAMETER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 1005u)
    
    ///
    /// WPD_PROPERTY_SERVICE_CAPABILITIES_PARAMETER_ATTRIBUTES  
    ///   [ VT_UNKNOWN ] IPortableDeviceValues containing the parameter attributes.
    let WPD_PROPERTY_SERVICE_CAPABILITIES_PARAMETER_ATTRIBUTES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 1006u)
    
    ///
    /// WPD_PROPERTY_SERVICE_CAPABILITIES_FORMATS  
    ///   [ VT_UNKNOWN ] IPortableDevicePropVariantCollection (of type VT_CLSID) containing the formats.
    let WPD_PROPERTY_SERVICE_CAPABILITIES_FORMATS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 1007u)
    
    ///
    /// WPD_PROPERTY_SERVICE_CAPABILITIES_FORMAT_ATTRIBUTES  
    ///   [ VT_UNKNOWN ] IPortableDeviceValues containing the format attributes, such as the format name and MIME Type.
    let WPD_PROPERTY_SERVICE_CAPABILITIES_FORMAT_ATTRIBUTES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 1008u)
    
    ///
    /// WPD_PROPERTY_SERVICE_CAPABILITIES_PROPERTY_KEYS  
    ///   [ VT_UNKNOWN ] IPortableDeviceKeyCollection containing the supported property keys.
    let WPD_PROPERTY_SERVICE_CAPABILITIES_PROPERTY_KEYS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 1009u)
    
    ///
    /// WPD_PROPERTY_SERVICE_CAPABILITIES_PROPERTY_ATTRIBUTES  
    ///   [ VT_UNKNOWN ] IPortableDeviceValues containing the property attributes.
    let WPD_PROPERTY_SERVICE_CAPABILITIES_PROPERTY_ATTRIBUTES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 1010u)
    
    ///
    /// WPD_PROPERTY_SERVICE_CAPABILITIES_SUPPORTED_EVENTS  
    ///   [ VT_UNKNOWN ] IPortableDevicePropVariantCollection (of type VT_CLSID) containing all events supported by the service.
    let WPD_PROPERTY_SERVICE_CAPABILITIES_SUPPORTED_EVENTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 1011u)
    
    ///
    /// WPD_PROPERTY_SERVICE_CAPABILITIES_EVENT  
    ///   [ VT_CLSID ] Indicates the event the caller is interested in.
    let WPD_PROPERTY_SERVICE_CAPABILITIES_EVENT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 1012u)
    
    ///
    /// WPD_PROPERTY_SERVICE_CAPABILITIES_EVENT_ATTRIBUTES  
    ///   [ VT_UNKNOWN ] IPortableDeviceValues containing the event attributes.
    let WPD_PROPERTY_SERVICE_CAPABILITIES_EVENT_ATTRIBUTES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 1013u)
    
    ///
    /// WPD_PROPERTY_SERVICE_CAPABILITIES_INHERITANCE_TYPE  
    ///   [ VT_UI4 ] Indicates the inheritance type the caller is interested in.
    let WPD_PROPERTY_SERVICE_CAPABILITIES_INHERITANCE_TYPE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 1014u)
    
    ///
    /// WPD_PROPERTY_SERVICE_CAPABILITIES_INHERITED_SERVICES  
    ///   [ VT_UNKNOWN ] Contains the list of inherited services.
    let WPD_PROPERTY_SERVICE_CAPABILITIES_INHERITED_SERVICES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 1015u)
    
    ///
    /// WPD_PROPERTY_SERVICE_CAPABILITIES_RENDERING_PROFILES  
    ///   [ VT_UNKNOWN ] Contains the list of format rendering profiles.
    let WPD_PROPERTY_SERVICE_CAPABILITIES_RENDERING_PROFILES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 1016u)
    
    ///
    /// WPD_PROPERTY_SERVICE_CAPABILITIES_SUPPORTED_COMMANDS  
    ///   [ VT_UNKNOWN ] IPortableDeviceKeyCollection containing all commands a driver supports for a service.
    let WPD_PROPERTY_SERVICE_CAPABILITIES_SUPPORTED_COMMANDS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 1017u)
    
    ///
    /// WPD_PROPERTY_SERVICE_CAPABILITIES_COMMAND  
    ///   [ VT_UNKNOWN ] Indicates the command whose options the caller is interested in.
    let WPD_PROPERTY_SERVICE_CAPABILITIES_COMMAND = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 1018u)
    
    ///
    /// WPD_PROPERTY_SERVICE_CAPABILITIES_COMMAND_OPTIONS  
    ///   [ VT_UNKNOWN ] Contains an IPortableDeviceValues with the relevant command options.
    let WPD_PROPERTY_SERVICE_CAPABILITIES_COMMAND_OPTIONS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_CAPABILITIES, pid = 1019u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CATEGORY_SERVICE_METHODS 
    ///
    /// The commands in this category relate to methods of a device service.
    ///
    let WPD_CATEGORY_SERVICE_METHODS = new System.Guid(0x2D521CA8u, 0xC1B0us, 0x4268us, 0xA3uy, 0x42uy, 0xCFuy, 0x19uy, 0x32uy, 0x15uy, 0x69uy, 0xBCuy)
    
    /// ======== Commands ========
    ///
    /// WPD_COMMAND_SERVICE_METHODS_START_INVOKE 
    ///    Invokes a service method. 
    /// Access:
    ///     Dependent on the value of WPD_METHOD_ATTRIBUTE_ACCESS.
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_METHOD 
    ///     [ Required ]  WPD_PROPERTY_SERVICE_METHOD_PARAMETER_VALUES 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_METHOD_CONTEXT
    let WPD_COMMAND_SERVICE_METHODS_START_INVOKE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_METHODS, pid = 2u)
    
    ///
    /// WPD_COMMAND_SERVICE_METHODS_CANCEL_INVOKE 
    ///    This command is sent when a client wants to cancel a method that is currently still in progress. 
    /// Access:
    ///     Dependent on the value of WPD_METHOD_ATTRIBUTE_ACCESS.
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_METHOD_CONTEXT 
    /// Results:
    ///     None
    let WPD_COMMAND_SERVICE_METHODS_CANCEL_INVOKE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_METHODS, pid = 3u)
    
    ///
    /// WPD_COMMAND_SERVICE_METHODS_END_INVOKE 
    ///    This command is sent in response to a WPD_EVENT_SERVICE_METHOD_COMPLETE event from the driver to retrieve the method results. 
    /// Access:
    ///     Dependent on the value of WPD_METHOD_ATTRIBUTE_ACCESS.
    /// Parameters:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_METHOD_CONTEXT 
    /// Results:
    ///     [ Required ]  WPD_PROPERTY_SERVICE_METHOD_RESULT_VALUES 
    ///     [ Required ]  WPD_PROPERTY_SERVICE_METHOD_HRESULT
    let WPD_COMMAND_SERVICE_METHODS_END_INVOKE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_METHODS, pid = 4u)
    
    ///
    /// WPD_PROPERTY_SERVICE_METHOD  
    ///   [ VT_CLSID ] Indicates the method to invoke.
    let WPD_PROPERTY_SERVICE_METHOD = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_METHODS, pid = 1001u)
    
    ///
    /// WPD_PROPERTY_SERVICE_METHOD_PARAMETER_VALUES  
    ///   [ VT_UNKNOWN ] IPortableDeviceValues containing the method parameters.
    let WPD_PROPERTY_SERVICE_METHOD_PARAMETER_VALUES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_METHODS, pid = 1002u)
    
    ///
    /// WPD_PROPERTY_SERVICE_METHOD_RESULT_VALUES  
    ///   [ VT_UNKNOWN ] IPortableDeviceValues containing the method results.
    let WPD_PROPERTY_SERVICE_METHOD_RESULT_VALUES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_METHODS, pid = 1003u)
    
    ///
    /// WPD_PROPERTY_SERVICE_METHOD_CONTEXT  
    ///   [ VT_LPWSTR ] The unique context identifying this method operation.
    let WPD_PROPERTY_SERVICE_METHOD_CONTEXT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_METHODS, pid = 1004u)
    
    ///
    /// WPD_PROPERTY_SERVICE_METHOD_HRESULT  
    ///   [ VT_ERROR ] Contains the status HRESULT of this method invocation.
    let WPD_PROPERTY_SERVICE_METHOD_HRESULT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_SERVICE_METHODS, pid = 1005u)
    
    //// Category placeholder for WPD_RESOURCE_DEFAULT
    let WPD_RESOURCE_DEFAULT_Guid = new System.Guid(0xE81E79BEu, 0x34F0us, 0x41BFus, 0xB5uy, 0x3Fuy, 0xF1uy, 0xA0uy, 0x6Auy, 0xE8uy, 0x78uy, 0x42uy)
    
    ////
    /// This section defines all Resource keys.  Resources are place-holders for
    /// binary data.
    ///
    ///
    ///
    ///  WPD_RESOURCE_DEFAULT 
    /// Represents the entire object's data. There can be only one default resource on an object.
    let WPD_RESOURCE_DEFAULT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_RESOURCE_DEFAULT_Guid, pid = 0u)
    
    //// Category placeholder for WPD_RESOURCE_CONTACT_PHOTO
    let WPD_RESOURCE_CONTACT_PHOTO_Guid = new System.Guid(0x2C4D6803u, 0x80EAus, 0x4580us, 0xAFuy, 0x9Auy, 0x5Buy, 0xE1uy, 0xA2uy, 0x3Euy, 0xDDuy, 0xCBuy)
    
    ///
    ///  WPD_RESOURCE_CONTACT_PHOTO 
    /// Represents the contact's photo data.
    let WPD_RESOURCE_CONTACT_PHOTO = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_RESOURCE_CONTACT_PHOTO_Guid, pid = 0u)
    
    //// Category placeholder for WPD_RESOURCE_THUMBNAIL
    let WPD_RESOURCE_THUMBNAIL_Guid = new System.Guid(0xC7C407BAu, 0x98FAus, 0x46B5us, 0x99uy, 0x60uy, 0x23uy, 0xFEuy, 0xC1uy, 0x24uy, 0xCFuy, 0xDEuy)
    
    ///
    ///  WPD_RESOURCE_THUMBNAIL 
    /// Represents the thumbnail data for an object.
    let WPD_RESOURCE_THUMBNAIL = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_RESOURCE_THUMBNAIL_Guid, pid = 0u)
    
    //// Category placeholder for WPD_RESOURCE_ICON
    let WPD_RESOURCE_ICON_Guid = new System.Guid(0xF195FED8u, 0xAA28us, 0x4EE3us, 0xB1uy, 0x53uy, 0xE1uy, 0x82uy, 0xDDuy, 0x5Euy, 0xDCuy, 0x39uy)
    
    ///
    ///  WPD_RESOURCE_ICON 
    /// Represents the icon data for an object.
    let WPD_RESOURCE_ICON = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_RESOURCE_ICON_Guid, pid = 0u)
    
    //// Category placeholder for WPD_RESOURCE_AUDIO_CLIP
    let WPD_RESOURCE_AUDIO_CLIP_Guid = new System.Guid(0x3BC13982u, 0x85B1us, 0x48E0us, 0x95uy, 0xA6uy, 0x8Duy, 0x3Auy, 0xD0uy, 0x6Buy, 0xE1uy, 0x17uy)
    
    ///
    ///  WPD_RESOURCE_AUDIO_CLIP 
    /// Represents an audio sample data for an object.
    let WPD_RESOURCE_AUDIO_CLIP = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_RESOURCE_AUDIO_CLIP_Guid, pid = 0u)
    
    //// Category placeholder for WPD_RESOURCE_ALBUM_ART
    let WPD_RESOURCE_ALBUM_ART_Guid = new System.Guid(0xF02AA354u, 0x2300us, 0x4E2Dus, 0xA1uy, 0xB9uy, 0x3Buy, 0x67uy, 0x30uy, 0xF7uy, 0xFAuy, 0x21uy)
    
    ///
    ///  WPD_RESOURCE_ALBUM_ART 
    /// Represents the album artwork this media originated from.
    let WPD_RESOURCE_ALBUM_ART = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_RESOURCE_ALBUM_ART_Guid, pid = 0u)
    
    //// Category placeholder for WPD_RESOURCE_GENERIC
    let WPD_RESOURCE_GENERIC_Guid = new System.Guid(0xB9B9F515u, 0xBA70us, 0x4647us, 0x94uy, 0xDCuy, 0xFAuy, 0x49uy, 0x25uy, 0xE9uy, 0x5Auy, 0x07uy)
    
    ///
    ///  WPD_RESOURCE_GENERIC 
    /// Represents an arbitrary binary blob associated with this object.
    let WPD_RESOURCE_GENERIC = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_RESOURCE_GENERIC_Guid, pid = 0u)
    
    //// Category placeholder for WPD_RESOURCE_VIDEO_CLIP
    let WPD_RESOURCE_VIDEO_CLIP_Guid = new System.Guid(0xB566EE42u, 0x6368us, 0x4290us, 0x86uy, 0x62uy, 0x70uy, 0x18uy, 0x2Fuy, 0xB7uy, 0x9Fuy, 0x20uy)
    
    ///
    ///  WPD_RESOURCE_VIDEO_CLIP 
    /// Represents a video sample for an object.
    let WPD_RESOURCE_VIDEO_CLIP = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_RESOURCE_VIDEO_CLIP_Guid, pid = 0u)
    
    //// Category placeholder for WPD_RESOURCE_BRANDING_ART
    let WPD_RESOURCE_BRANDING_ART_Guid = new System.Guid(0xB633B1AEu, 0x6CAFus, 0x4A87us, 0x95uy, 0x89uy, 0x22uy, 0xDEuy, 0xD6uy, 0xDDuy, 0x58uy, 0x99uy)
    
    ///
    ///  WPD_RESOURCE_BRANDING_ART 
    /// Represents the product branding artwork or logo for an object. This resource is typically found on, but not limited to the device object.
    let WPD_RESOURCE_BRANDING_ART = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_RESOURCE_BRANDING_ART_Guid, pid = 0u)
    
    ////
    /// This section defines the legacy WPD Formats
    ///
    ///
    /// WPD_OBJECT_FORMAT_PROPERTIES_ONLY
    ///   This object has no data stream and is completely specified by properties only.
    ///   Device Services Format: FORMAT_Association
    let WPD_OBJECT_FORMAT_PROPERTIES_ONLY = new System.Guid(0x30010000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_UNSPECIFIED
    ///   An undefined object format on the device (e.g. objects that can not be classified by the other defined WPD format codes)
    ///   Device Services Format: FORMAT_Undefined
    let WPD_OBJECT_FORMAT_UNSPECIFIED = new System.Guid(0x30000000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_SCRIPT
    ///   A device model-specific script
    ///   Device Services Format: FORMAT_DeviceScript
    let WPD_OBJECT_FORMAT_SCRIPT = new System.Guid(0x30020000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_EXECUTABLE
    ///   A device model-specific binary executable
    ///   Device Services Format: FORMAT_DeviceExecutable
    let WPD_OBJECT_FORMAT_EXECUTABLE = new System.Guid(0x30030000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_TEXT
    ///   A text file
    ///   Device Services Format: FORMAT_TextDocument
    let WPD_OBJECT_FORMAT_TEXT = new System.Guid(0x30040000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_HTML
    ///   A HyperText Markup Language file (text)
    ///   Device Services Format: FORMAT_HTMLDocument
    let WPD_OBJECT_FORMAT_HTML = new System.Guid(0x30050000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_DPOF
    ///   A Digital Print Order File (text)
    ///   Device Services Format: FORMAT_DPOFDocument
    let WPD_OBJECT_FORMAT_DPOF = new System.Guid(0x30060000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_AIFF
    ///   Audio file format
    ///   Device Services Format: FORMAT_AIFFFile
    let WPD_OBJECT_FORMAT_AIFF = new System.Guid(0x30070000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_WAVE
    ///   Audio file format
    ///   Device Services Format: FORMAT_WAVFile
    let WPD_OBJECT_FORMAT_WAVE = new System.Guid(0x30080000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_MP3
    ///   Audio file format
    ///   Device Services Format: FORMAT_MP3File
    let WPD_OBJECT_FORMAT_MP3 = new System.Guid(0x30090000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_AVI
    ///   Video file format
    ///   Device Services Format: FORMAT_AVIFile
    let WPD_OBJECT_FORMAT_AVI = new System.Guid(0x300A0000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_MPEG
    ///   Video file format
    ///   Device Services Format: FORMAT_MPEGFile
    let WPD_OBJECT_FORMAT_MPEG = new System.Guid(0x300B0000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_ASF
    ///   Video file format (Microsoft Advanced Streaming Format)
    ///   Device Services Format: FORMAT_ASFFile
    let WPD_OBJECT_FORMAT_ASF = new System.Guid(0x300C0000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_EXIF
    ///   Image file format (Exchangeable File Format), JEIDA standard
    ///   Device Services Format: FORMAT_EXIFImage
    let WPD_OBJECT_FORMAT_EXIF = new System.Guid(0x38010000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_TIFFEP
    ///   Image file format (Tag Image File Format for Electronic Photography)
    ///   Device Services Format: FORMAT_TIFFEPImage
    let WPD_OBJECT_FORMAT_TIFFEP = new System.Guid(0x38020000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_FLASHPIX
    ///   Image file format (Structured Storage Image Format)
    ///   Device Services Format: FORMAT_FlashPixImage
    let WPD_OBJECT_FORMAT_FLASHPIX = new System.Guid(0x38030000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_BMP
    ///   Image file format (Microsoft Windows Bitmap file)
    ///   Device Services Format: FORMAT_BMPImage
    let WPD_OBJECT_FORMAT_BMP = new System.Guid(0x38040000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_CIFF
    ///   Image file format (Canon Camera Image File Format)
    ///   Device Services Format: FORMAT_CIFFImage
    let WPD_OBJECT_FORMAT_CIFF = new System.Guid(0x38050000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_GIF
    ///   Image file format (Graphics Interchange Format)
    ///   Device Services Format: FORMAT_GIFImage
    let WPD_OBJECT_FORMAT_GIF = new System.Guid(0x38070000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_JFIF
    ///   Image file format (JPEG Interchange Format)
    ///   Device Services Format: FORMAT_JFIFImage
    let WPD_OBJECT_FORMAT_JFIF = new System.Guid(0x38080000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_PCD
    ///   Image file format (PhotoCD Image Pac)
    ///   Device Services Format: FORMAT_PCDImage
    let WPD_OBJECT_FORMAT_PCD = new System.Guid(0x38090000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_PICT
    ///   Image file format (Quickdraw Image Format)
    ///   Device Services Format: FORMAT_PICTImage
    let WPD_OBJECT_FORMAT_PICT = new System.Guid(0x380A0000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_PNG
    ///   Image file format (Portable Network Graphics)
    ///   Device Services Format: FORMAT_PNGImage
    let WPD_OBJECT_FORMAT_PNG = new System.Guid(0x380B0000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_TIFF
    ///   Image file format (Tag Image File Format)
    ///   Device Services Format: FORMAT_TIFFImage
    let WPD_OBJECT_FORMAT_TIFF = new System.Guid(0x380D0000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_TIFFIT
    ///   Image file format (Tag Image File Format for Informational Technology) Graphic Arts
    ///   Device Services Format: FORMAT_TIFFITImage
    let WPD_OBJECT_FORMAT_TIFFIT = new System.Guid(0x380E0000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_JP2
    ///   Image file format (JPEG2000 Baseline File Format)
    ///   Device Services Format: FORMAT_JP2Image
    let WPD_OBJECT_FORMAT_JP2 = new System.Guid(0x380F0000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_JPX
    ///   Image file format (JPEG2000 Extended File Format)
    ///   Device Services Format: FORMAT_JPXImage
    let WPD_OBJECT_FORMAT_JPX = new System.Guid(0x38100000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_WBMP
    ///   Image file format (Wireless Application Protocol Bitmap Format)
    ///   Device Services Format: FORMAT_WBMPImage
    let WPD_OBJECT_FORMAT_WBMP = new System.Guid(0xB8030000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_JPEGXR
    ///   Image file format (JPEG XR, also known as HD Photo)
    ///   Device Services Format: FORMAT_JPEGXRImage
    let WPD_OBJECT_FORMAT_JPEGXR = new System.Guid(0xB8040000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_WINDOWSIMAGEFORMAT
    ///   Image file format
    ///   Device Services Format: FORMAT_HDPhotoImage
    let WPD_OBJECT_FORMAT_WINDOWSIMAGEFORMAT = new System.Guid(0xB8810000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_WMA
    ///   Audio file format (Windows Media Audio)
    ///   Device Services Format: FORMAT_WMAFile
    let WPD_OBJECT_FORMAT_WMA = new System.Guid(0xB9010000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_WMV
    ///   Video file format (Windows Media Video)
    ///   Device Services Format: FORMAT_WMVFile
    let WPD_OBJECT_FORMAT_WMV = new System.Guid(0xB9810000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_WPLPLAYLIST
    ///   Playlist file format
    ///   Device Services Format: FORMAT_WPLPlaylist
    let WPD_OBJECT_FORMAT_WPLPLAYLIST = new System.Guid(0xBA100000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_M3UPLAYLIST
    ///   Playlist file format
    ///   Device Services Format: FORMAT_M3UPlaylist
    let WPD_OBJECT_FORMAT_M3UPLAYLIST = new System.Guid(0xBA110000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_MPLPLAYLIST
    ///   Playlist file format
    ///   Device Services Format: FORMAT_MPLPlaylist
    let WPD_OBJECT_FORMAT_MPLPLAYLIST = new System.Guid(0xBA120000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_ASXPLAYLIST
    ///   Playlist file format
    ///   Device Services Format: FORMAT_ASXPlaylist
    let WPD_OBJECT_FORMAT_ASXPLAYLIST = new System.Guid(0xBA130000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_PLSPLAYLIST
    ///   Playlist file format
    ///   Device Services Format: FORMAT_PSLPlaylist
    let WPD_OBJECT_FORMAT_PLSPLAYLIST = new System.Guid(0xBA140000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_ABSTRACT_CONTACT_GROUP
    ///   Generic format for contact group objects
    ///   Device Services Format: FORMAT_AbstractContactGroup
    let WPD_OBJECT_FORMAT_ABSTRACT_CONTACT_GROUP = new System.Guid(0xBA060000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_ABSTRACT_MEDIA_CAST
    ///   MediaCast file format
    ///   Device Services Format: FORMAT_AbstractMediacast
    let WPD_OBJECT_FORMAT_ABSTRACT_MEDIA_CAST = new System.Guid(0xBA0B0000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_VCALENDAR1
    ///   VCALENDAR file format (VCALENDAR Version 1)
    ///   Device Services Format: FORMAT_VCalendar1
    let WPD_OBJECT_FORMAT_VCALENDAR1 = new System.Guid(0xBE020000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_ICALENDAR
    ///   ICALENDAR file format (VCALENDAR Version 2)
    ///   Device Services Format: FORMAT_ICalendar
    let WPD_OBJECT_FORMAT_ICALENDAR = new System.Guid(0xBE030000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_ABSTRACT_CONTACT
    ///   Abstract contact file format
    ///   Device Services Format: FORMAT_AbstractContact
    let WPD_OBJECT_FORMAT_ABSTRACT_CONTACT = new System.Guid(0xBB810000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_VCARD2
    ///   VCARD file format (VCARD Version 2)
    ///   Device Services Format: FORMAT_VCard2Contact
    let WPD_OBJECT_FORMAT_VCARD2 = new System.Guid(0xBB820000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_VCARD3
    ///   VCARD file format (VCARD Version 3)
    ///   Device Services Format: FORMAT_VCard3Contact
    let WPD_OBJECT_FORMAT_VCARD3 = new System.Guid(0xBB830000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_XML
    ///   XML file format.
    ///   Device Services Format: FORMAT_XMLDocument
    let WPD_OBJECT_FORMAT_XML = new System.Guid(0xBA820000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_AAC
    ///   Audio file format
    ///   Device Services Format: FORMAT_AACFile
    let WPD_OBJECT_FORMAT_AAC = new System.Guid(0xB9030000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_AUDIBLE
    ///   Audio file format
    ///   Device Services Format: FORMAT_AudibleFile
    let WPD_OBJECT_FORMAT_AUDIBLE = new System.Guid(0xB9040000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_FLAC
    ///   Audio file format
    ///   Device Services Format: FORMAT_FLACFile
    let WPD_OBJECT_FORMAT_FLAC = new System.Guid(0xB9060000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_QCELP
    ///   Audio file format (Qualcomm Code Excited Linear Prediction)
    ///   Device Services Format: FORMAT_QCELPFile
    let WPD_OBJECT_FORMAT_QCELP = new System.Guid(0xB9070000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_AMR
    ///   Audio file format (Adaptive Multi-Rate audio codec)
    ///   Device Services Format: FORMAT_AMRFile
    let WPD_OBJECT_FORMAT_AMR = new System.Guid(0xB9080000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_OGG
    ///   Audio file format
    ///   Device Services Format: FORMAT_OGGFile
    let WPD_OBJECT_FORMAT_OGG = new System.Guid(0xB9020000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_MP4
    ///   Audio or Video file format
    ///   Device Services Format: FORMAT_MPEG4File
    let WPD_OBJECT_FORMAT_MP4 = new System.Guid(0xB9820000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_MP2
    ///   Audio or Video file format
    ///   Device Services Format: FORMAT_MPEG2File
    let WPD_OBJECT_FORMAT_MP2 = new System.Guid(0xB9830000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_MICROSOFT_WORD
    ///   Microsoft Office Word Document file format.
    ///   Device Services Format: FORMAT_WordDocument
    let WPD_OBJECT_FORMAT_MICROSOFT_WORD = new System.Guid(0xBA830000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_MHT_COMPILED_HTML
    ///   MHT Compiled HTML Document file format.
    ///   Device Services Format: FORMAT_MHTDocument
    let WPD_OBJECT_FORMAT_MHT_COMPILED_HTML = new System.Guid(0xBA840000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_MICROSOFT_EXCEL
    ///   Microsoft Office Excel Document file format.
    ///   Device Services Format: FORMAT_ExcelDocument
    let WPD_OBJECT_FORMAT_MICROSOFT_EXCEL = new System.Guid(0xBA850000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_MICROSOFT_POWERPOINT
    ///   Microsoft Office PowerPoint Document file format.
    ///   Device Services Format: FORMAT_PowerPointDocument
    let WPD_OBJECT_FORMAT_MICROSOFT_POWERPOINT = new System.Guid(0xBA860000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_3GP
    ///   Audio or Video file format
    ///   Device Services Format: FORMAT_3GPPFile
    let WPD_OBJECT_FORMAT_3GP = new System.Guid(0xB9840000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_3G2
    ///   Audio or Video file format
    ///   Device Services Format: FORMAT_3GPP2File
    let WPD_OBJECT_FORMAT_3G2 = new System.Guid(0xB9850000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_AVCHD
    ///   Audio or Video file format
    ///   Device Services Format: FORMAT_AVCHDFile
    let WPD_OBJECT_FORMAT_AVCHD = new System.Guid(0xB9860000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_ATSCTS
    ///   Audio or Video file format
    ///   Device Services Format: FORMAT_ATSCTSFile
    let WPD_OBJECT_FORMAT_ATSCTS = new System.Guid(0xB9870000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_DVBTS
    ///   Audio or Video file format
    ///   Device Services Format: FORMAT_DVBTSFile
    let WPD_OBJECT_FORMAT_DVBTS = new System.Guid(0xB9880000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xC5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ///
    /// WPD_OBJECT_FORMAT_MKV
    ///   Audio or Video file format
    ///   Device Services Format: FORMAT_MKVFile
    let WPD_OBJECT_FORMAT_MKV = new System.Guid(0xB9900000u, 0xAE6Cus, 0x4804us, 0x98uy, 0xBAuy, 0xc5uy, 0x7Buy, 0x46uy, 0x96uy, 0x5Fuy, 0xE7uy)
    
    ////
    /// This section defines the legacy WPD Properties
    ///
    ///
    /// WPD_OBJECT_ID 
    ///   [ VT_LPWSTR ] Uniquely identifies object on the Portable Device.
    ///   Recommended Device Services Property: PKEY_GenericObj_ObjectID
    let WPD_OBJECT_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 2u)
    
    ///
    /// WPD_OBJECT_PARENT_ID 
    ///   [ VT_LPWSTR ] Object identifier indicating the parent object.
    ///   Recommended Device Services Property: PKEY_GenericObj_ParentID
    let WPD_OBJECT_PARENT_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 3u)
    
    ///
    /// WPD_OBJECT_NAME 
    ///   [ VT_LPWSTR ] The display name for this object.
    ///   Recommended Device Services Property: PKEY_GenericObj_Name
    let WPD_OBJECT_NAME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 4u)
    
    ///
    /// WPD_OBJECT_PERSISTENT_UNIQUE_ID 
    ///   [ VT_LPWSTR ] Uniquely identifies the object on the Portable Device, similar to WPD_OBJECT_ID, but this ID will not change between sessions.
    ///   Recommended Device Services Property: PKEY_GenericObj_PersistentUID
    let WPD_OBJECT_PERSISTENT_UNIQUE_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 5u)
    
    ///
    /// WPD_OBJECT_FORMAT 
    ///   [ VT_CLSID ] Indicates the format of the object's data.
    ///   Recommended Device Services Property: PKEY_GenericObj_ObjectFormat
    let WPD_OBJECT_FORMAT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 6u)
    
    ///
    /// WPD_OBJECT_ISHIDDEN 
    ///   [ VT_BOOL ] Indicates whether the object should be hidden.
    ///   Recommended Device Services Property: PKEY_GenericObj_Hidden
    let WPD_OBJECT_ISHIDDEN = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 9u)
    
    ///
    /// WPD_OBJECT_ISSYSTEM 
    ///   [ VT_BOOL ] Indicates whether the object represents system data.
    ///   Recommended Device Services Property: PKEY_GenericObj_SystemObject
    let WPD_OBJECT_ISSYSTEM = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 10u)
    
    ///
    /// WPD_OBJECT_SIZE 
    ///   [ VT_UI8 ] The size of the object data.
    ///   Recommended Device Services Property: PKEY_GenericObj_ObjectSize
    let WPD_OBJECT_SIZE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 11u)
    
    ///
    /// WPD_OBJECT_ORIGINAL_FILE_NAME 
    ///   [ VT_LPWSTR ] Contains the name of the file this object represents.
    ///   Recommended Device Services Property: PKEY_GenericObj_ObjectFileName
    let WPD_OBJECT_ORIGINAL_FILE_NAME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 12u)
    
    ///
    /// WPD_OBJECT_NON_CONSUMABLE 
    ///   [ VT_BOOL ] This property determines whether or not this object is intended to be understood by the device, or whether it has been placed on the device just for storage.
    ///   Recommended Device Services Property: PKEY_GenericObj_NonConsumable
    let WPD_OBJECT_NON_CONSUMABLE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 13u)
    
    ///
    /// WPD_OBJECT_KEYWORDS 
    ///   [ VT_LPWSTR ] String containing a list of keywords associated with this object.
    ///   Recommended Device Services Property: PKEY_GenericObj_Keywords
    let WPD_OBJECT_KEYWORDS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 15u)
    
    ///
    /// WPD_OBJECT_SYNC_ID 
    ///   [ VT_LPWSTR ] Opaque string set by client to retain state between sessions without retaining a catalogue of connected device content.
    ///   Recommended Device Services Property: PKEY_GenericObj_SyncID
    let WPD_OBJECT_SYNC_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 16u)
    
    ///
    /// WPD_OBJECT_IS_DRM_PROTECTED 
    ///   [ VT_BOOL ] Indicates whether the media data is DRM protected.
    ///   Recommended Device Services Property: PKEY_GenericObj_DRMStatus
    let WPD_OBJECT_IS_DRM_PROTECTED = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 17u)
    
    ///
    /// WPD_OBJECT_DATE_CREATED 
    ///   [ VT_DATE ] Indicates the date and time the object was created on the device.
    ///   Recommended Device Services Property: PKEY_GenericObj_DateCreated
    let WPD_OBJECT_DATE_CREATED = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 18u)
    
    ///
    /// WPD_OBJECT_DATE_MODIFIED 
    ///   [ VT_DATE ] Indicates the date and time the object was modified on the device.
    ///   Recommended Device Services Property: PKEY_GenericObj_DateModified
    let WPD_OBJECT_DATE_MODIFIED = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 19u)
    
    ///
    /// WPD_OBJECT_DATE_AUTHORED 
    ///   [ VT_DATE ] Indicates the date and time the object was authored (e.g. for music, this would be the date the music was recorded).
    ///   Recommended Device Services Property: PKEY_GenericObj_DateAuthored
    let WPD_OBJECT_DATE_AUTHORED = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 20u)
    
    ///
    /// WPD_OBJECT_BACK_REFERENCES 
    ///   [ VT_UNKNOWN ] IPortableDevicePropVariantCollection of type VT_LPWSTR indicating a list of ObjectIDs.
    ///   Recommended Device Services Property: PKEY_GenericObj_ReferenceParentID
    let WPD_OBJECT_BACK_REFERENCES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 21u)
    
    ///
    /// WPD_OBJECT_CAN_DELETE 
    ///   [ VT_BOOL ] Indicates whether the object can be deleted, or not.
    ///   Recommended Device Services Property: PKEY_GenericObj_ProtectionStatus
    let WPD_OBJECT_CAN_DELETE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 26u)
    
    ///
    /// WPD_OBJECT_LANGUAGE_LOCALE 
    ///   [ VT_LPWSTR ] Identifies the language of this object. If multiple languages are contained in this object, it should identify the primary language (if any).
    ///   Recommended Device Services Property: PKEY_GenericObj_LanguageLocale
    let WPD_OBJECT_LANGUAGE_LOCALE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_OBJECT_PROPERTIES_V1, pid = 27u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_FOLDER_OBJECT_PROPERTIES_V1 
    ///
    /// This category is for properties common to all folder objects.
    ///
    let WPD_FOLDER_OBJECT_PROPERTIES_V1 = new System.Guid(0x7E9A7ABFu, 0xE568us, 0x4B34us, 0xAAuy, 0x2Fuy, 0x13uy, 0xBBuy, 0x12uy, 0xABuy, 0x17uy, 0x7Duy)
    
    ///
    /// WPD_FOLDER_CONTENT_TYPES_ALLOWED 
    ///   [ VT_UNKNOWN ] Indicates the subset of content types that can be created in this folder directly (i.e. children may have different restrictions).
    ///   Recommended Device Services Property: None
    let WPD_FOLDER_CONTENT_TYPES_ALLOWED = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_FOLDER_OBJECT_PROPERTIES_V1, pid = 2u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_IMAGE_OBJECT_PROPERTIES_V1 
    ///
    /// This category is for properties common to all image objects.
    ///
    let WPD_IMAGE_OBJECT_PROPERTIES_V1 = new System.Guid(0x63D64908u, 0x9FA1us, 0x479Fus, 0x85uy, 0xBAuy, 0x99uy, 0x52uy, 0x21uy, 0x64uy, 0x47uy, 0xDBuy)
    
    ///
    /// WPD_IMAGE_BITDEPTH 
    ///   [ VT_UI4 ] Indicates the bitdepth of an image
    ///   Recommended Device Services Property: PKEY_ImageObj_ImageBitDepth
    let WPD_IMAGE_BITDEPTH = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_IMAGE_OBJECT_PROPERTIES_V1, pid = 3u)
    
    ///
    /// WPD_IMAGE_CROPPED_STATUS 
    ///   [ VT_UI4 ] Signals whether the file has been cropped.
    ///   Recommended Device Services Property: PKEY_ImageObj_IsCropped
    let WPD_IMAGE_CROPPED_STATUS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_IMAGE_OBJECT_PROPERTIES_V1, pid = 4u)
    
    ///
    /// WPD_IMAGE_COLOR_CORRECTED_STATUS 
    ///   [ VT_UI4 ] Signals whether the file has been color corrected.
    ///   Recommended Device Services Property: PKEY_ImageObj_IsColorCorrected
    let WPD_IMAGE_COLOR_CORRECTED_STATUS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_IMAGE_OBJECT_PROPERTIES_V1, pid = 5u)
    
    ///
    /// WPD_IMAGE_FNUMBER 
    ///   [ VT_UI4 ] Identifies the aperture setting of the lens when this image was captured.
    ///   Recommended Device Services Property: PKEY_ImageObj_Aperature
    let WPD_IMAGE_FNUMBER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_IMAGE_OBJECT_PROPERTIES_V1, pid = 6u)
    
    ///
    /// WPD_IMAGE_EXPOSURE_TIME 
    ///   [ VT_UI4 ] Identifies the shutter speed of the device when this image was captured.
    ///   Recommended Device Services Property: PKEY_ImageObj_Exposure
    let WPD_IMAGE_EXPOSURE_TIME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_IMAGE_OBJECT_PROPERTIES_V1, pid = 7u)
    
    ///
    /// WPD_IMAGE_EXPOSURE_INDEX 
    ///   [ VT_UI4 ] Identifies the emulation of film speed settings when this image was captured.
    ///   Recommended Device Services Property: PKEY_ImageObj_ISOSpeed
    let WPD_IMAGE_EXPOSURE_INDEX = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_IMAGE_OBJECT_PROPERTIES_V1, pid = 8u)
    
    ///
    /// WPD_IMAGE_HORIZONTAL_RESOLUTION 
    ///   [ VT_R8 ] Indicates the horizontal resolution (DPI) of an image
    ///   Recommended Device Services Property: None
    let WPD_IMAGE_HORIZONTAL_RESOLUTION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_IMAGE_OBJECT_PROPERTIES_V1, pid = 9u)
    
    ///
    /// WPD_IMAGE_VERTICAL_RESOLUTION 
    ///   [ VT_R8 ] Indicates the vertical resolution (DPI) of an image
    ///   Recommended Device Services Property: None
    let WPD_IMAGE_VERTICAL_RESOLUTION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_IMAGE_OBJECT_PROPERTIES_V1, pid = 10u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_DOCUMENT_OBJECT_PROPERTIES_V1 
    ///
    /// This category is for properties common to all document objects.
    ///
    let WPD_DOCUMENT_OBJECT_PROPERTIES_V1 = new System.Guid(0x0B110203u, 0xEB95us, 0x4F02us, 0x93uy, 0xE0uy, 0x97uy, 0xC6uy, 0x31uy, 0x49uy, 0x3Auy, 0xD5uy)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_MEDIA_PROPERTIES_V1 
    ///
    /// This category is for properties common to media objects (e.g. audio and video).
    ///
    let WPD_MEDIA_PROPERTIES_V1 = new System.Guid(0x2ED8BA05u, 0x0AD3us, 0x42DCus, 0xB0uy, 0xD0uy, 0xBCuy, 0x95uy, 0xACuy, 0x39uy, 0x6Auy, 0xC8uy)
    
    ///
    /// WPD_MEDIA_TOTAL_BITRATE 
    ///   [ VT_UI4 ] The total number of bits that one second will consume.
    ///   Recommended Device Services Property: PKEY_MediaObj_TotalBitRate
    let WPD_MEDIA_TOTAL_BITRATE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 2u)
    
    ///
    /// WPD_MEDIA_BITRATE_TYPE 
    ///   [ VT_UI4 ] Further qualifies the bitrate of audio or video data.
    ///   Recommended Device Services Property: PKEY_MediaObj_BitRateType
    let WPD_MEDIA_BITRATE_TYPE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 3u)
    
    ///
    /// WPD_MEDIA_COPYRIGHT 
    ///   [ VT_LPWSTR ] Indicates the copyright information.
    ///   Recommended Device Services Property: PKEY_GenericObj_Copyright
    let WPD_MEDIA_COPYRIGHT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 4u)
    
    ///
    /// WPD_MEDIA_SUBSCRIPTION_CONTENT_ID 
    ///   [ VT_LPWSTR ] Provides additional information to identify a piece of content relative to an online subscription service.
    ///   Recommended Device Services Property: PKEY_MediaObj_SubscriptionContentID
    let WPD_MEDIA_SUBSCRIPTION_CONTENT_ID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 5u)
    
    ///
    /// WPD_MEDIA_USE_COUNT 
    ///   [ VT_UI4 ] Indicates the total number of times this media has been played or viewed on the device.
    ///   Recommended Device Services Property: PKEY_MediaObj_UseCount
    let WPD_MEDIA_USE_COUNT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 6u)
    
    ///
    /// WPD_MEDIA_SKIP_COUNT 
    ///   [ VT_UI4 ] Indicates the total number of times this media was setup to be played or viewed but was manually skipped by the user.
    ///   Recommended Device Services Property: PKEY_MediaObj_SkipCount
    let WPD_MEDIA_SKIP_COUNT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 7u)
    
    ///
    /// WPD_MEDIA_LAST_ACCESSED_TIME 
    ///   [ VT_DATE ] Indicates the date and time the media was last accessed on the device.
    ///   Recommended Device Services Property: PKEY_GenericObj_DateAccessed
    let WPD_MEDIA_LAST_ACCESSED_TIME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 8u)
    
    ///
    /// WPD_MEDIA_PARENTAL_RATING 
    ///   [ VT_LPWSTR ] Indicates the parental rating of the media file.
    ///   Recommended Device Services Property: PKEY_MediaObj_ParentalRating
    let WPD_MEDIA_PARENTAL_RATING = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 9u)
    
    ///
    /// WPD_MEDIA_META_GENRE 
    ///   [ VT_UI4 ] Further qualifies a piece of media in a contextual way.
    ///   Recommended Device Services Property: PKEY_MediaObj_MediaType
    let WPD_MEDIA_META_GENRE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 10u)
    
    ///
    /// WPD_MEDIA_COMPOSER 
    ///   [ VT_LPWSTR ] Identifies the composer when the composer is not the artist who performed it.
    ///   Recommended Device Services Property: PKEY_MediaObj_Composer
    let WPD_MEDIA_COMPOSER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 11u)
    
    ///
    /// WPD_MEDIA_EFFECTIVE_RATING 
    ///   [ VT_UI4 ] Contains an assigned rating for media not set by the user, but is generated based upon usage statistics.
    ///   Recommended Device Services Property: PKEY_MediaObj_EffectiveRating
    let WPD_MEDIA_EFFECTIVE_RATING = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 12u)
    
    ///
    /// WPD_MEDIA_SUB_TITLE 
    ///   [ VT_LPWSTR ] Further qualifies the title when the title is ambiguous or general.
    ///   Recommended Device Services Property: PKEY_MediaObj_Subtitle
    let WPD_MEDIA_SUB_TITLE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 13u)
    
    ///
    /// WPD_MEDIA_RELEASE_DATE 
    ///   [ VT_DATE ] Indicates when the media was released.
    ///   Recommended Device Services Property: PKEY_MediaObj_DateOriginalRelease
    let WPD_MEDIA_RELEASE_DATE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 14u)
    
    ///
    /// WPD_MEDIA_SAMPLE_RATE 
    ///   [ VT_UI4 ] Indicates the number of times media selection was sampled per second during encoding.
    ///   Recommended Device Services Property: PKEY_MediaObj_SampleRate
    let WPD_MEDIA_SAMPLE_RATE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 15u)
    
    ///
    /// WPD_MEDIA_STAR_RATING 
    ///   [ VT_UI4 ] Indicates the star rating for this media.
    ///   Recommended Device Services Property: None
    let WPD_MEDIA_STAR_RATING = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 16u)
    
    ///
    /// WPD_MEDIA_USER_EFFECTIVE_RATING 
    ///   [ VT_UI4 ] Indicates the rating for this media.
    ///   Recommended Device Services Property: PKEY_MediaObj_UserRating
    let WPD_MEDIA_USER_EFFECTIVE_RATING = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 17u)
    
    ///
    /// WPD_MEDIA_TITLE 
    ///   [ VT_LPWSTR ] Indicates the title of this media.
    ///   Recommended Device Services Property: None
    let WPD_MEDIA_TITLE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 18u)
    
    ///
    /// WPD_MEDIA_DURATION 
    ///   [ VT_UI8 ] Indicates the duration of this media in milliseconds.
    ///   Recommended Device Services Property: PKEY_MediaObj_Duration
    let WPD_MEDIA_DURATION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 19u)
    
    ///
    /// WPD_MEDIA_BUY_NOW 
    ///   [ VT_BOOL ] TBD
    ///   Recommended Device Services Property: None
    let WPD_MEDIA_BUY_NOW = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 20u)
    
    ///
    /// WPD_MEDIA_ENCODING_PROFILE 
    ///   [ VT_LPWSTR ] Media codecs may be encoded in accordance with a profile, which defines a particular encoding algorithm or optimization process.
    ///   Recommended Device Services Property: PKEY_MediaObj_EncodingProfile
    let WPD_MEDIA_ENCODING_PROFILE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 21u)
    
    ///
    /// WPD_MEDIA_WIDTH 
    ///   [ VT_UI4 ] Indicates the width of an object in pixels
    ///   Recommended Device Services Property: PKEY_MediaObj_Width
    let WPD_MEDIA_WIDTH = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 22u)
    
    ///
    /// WPD_MEDIA_HEIGHT 
    ///   [ VT_UI4 ] Indicates the height of an object in pixels
    ///   Recommended Device Services Property: PKEY_MediaObj_Height
    let WPD_MEDIA_HEIGHT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 23u)
    
    ///
    /// WPD_MEDIA_ARTIST 
    ///   [ VT_LPWSTR ] Indicates the artist for this media.
    ///   Recommended Device Services Property: PKEY_MediaObj_Artist
    let WPD_MEDIA_ARTIST = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 24u)
    
    ///
    /// WPD_MEDIA_ALBUM_ARTIST 
    ///   [ VT_LPWSTR ] Indicates the artist of the entire album rather than for a particular track.
    ///   Recommended Device Services Property: PKEY_MediaObj_AlbumArtist
    let WPD_MEDIA_ALBUM_ARTIST = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 25u)
    
    ///
    /// WPD_MEDIA_OWNER 
    ///   [ VT_LPWSTR ] Indicates the e-mail address of the owner for this media.
    ///   Recommended Device Services Property: PKEY_MediaObj_Owner
    let WPD_MEDIA_OWNER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 26u)
    
    ///
    /// WPD_MEDIA_MANAGING_EDITOR 
    ///   [ VT_LPWSTR ] Indicates the e-mail address of the managing editor for this media.
    ///   Recommended Device Services Property: PKEY_MediaObj_Editor
    let WPD_MEDIA_MANAGING_EDITOR = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 27u)
    
    ///
    /// WPD_MEDIA_WEBMASTER 
    ///   [ VT_LPWSTR ] Indicates the e-mail address of the Webmaster for this media.
    ///   Recommended Device Services Property: PKEY_MediaObj_WebMaster
    let WPD_MEDIA_WEBMASTER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 28u)
    
    ///
    /// WPD_MEDIA_SOURCE_URL 
    ///   [ VT_LPWSTR ] Identifies the source URL for this object.
    ///   Recommended Device Services Property: PKEY_MediaObj_URLSource
    let WPD_MEDIA_SOURCE_URL = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 29u)
    
    ///
    /// WPD_MEDIA_DESTINATION_URL 
    ///   [ VT_LPWSTR ] Identifies the URL that an object is linked to if a user clicks on it.
    ///   Recommended Device Services Property: PKEY_MediaObj_URLLink
    let WPD_MEDIA_DESTINATION_URL = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 30u)
    
    ///
    /// WPD_MEDIA_DESCRIPTION 
    ///   [ VT_LPWSTR ] Contains a description of the media content for this object.
    ///   Recommended Device Services Property: PKEY_GenericObj_Description
    let WPD_MEDIA_DESCRIPTION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 31u)
    
    ///
    /// WPD_MEDIA_GENRE 
    ///   [ VT_LPWSTR ] A text field indicating the genre this media belongs to.
    ///   Recommended Device Services Property: PKEY_MediaObj_Genre
    let WPD_MEDIA_GENRE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 32u)
    
    ///
    /// WPD_MEDIA_TIME_BOOKMARK 
    ///   [ VT_UI8 ] Indicates a bookmark (in milliseconds) of the last position played or viewed on media that have duration.
    ///   Recommended Device Services Property: PKEY_MediaObj_BookmarkTime
    let WPD_MEDIA_TIME_BOOKMARK = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 33u)
    
    ///
    /// WPD_MEDIA_OBJECT_BOOKMARK 
    ///   [ VT_LPWSTR ] Indicates a WPD_OBJECT_ID of the last object viewed or played for those objects that refer to a list of objects (such as playlists or media casts).
    ///   Recommended Device Services Property: PKEY_MediaObj_BookmarkObject
    let WPD_MEDIA_OBJECT_BOOKMARK = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 34u)
    
    ///
    /// WPD_MEDIA_LAST_BUILD_DATE 
    ///   [ VT_DATE ] Indicates the last time a series in a media cast was changed or edited.
    ///   Recommended Device Services Property: PKEY_GenericObj_DateRevised
    let WPD_MEDIA_LAST_BUILD_DATE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 35u)
    
    ///
    /// WPD_MEDIA_BYTE_BOOKMARK 
    ///   [ VT_UI8 ] Indicates a bookmark (as a zero-based byte offset) of the last position played or viewed on this media object.
    ///   Recommended Device Services Property: PKEY_MediaObj_BookmarkByte
    let WPD_MEDIA_BYTE_BOOKMARK = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 36u)
    
    ///
    /// WPD_MEDIA_TIME_TO_LIVE 
    ///   [ VT_UI8 ] It is the number of minutes that indicates how long a channel can be cached before refreshing from the source. Applies to WPD_CONTENT_TYPE_MEDIA_CAST objects.
    ///   Recommended Device Services Property: PKEY_GenericObj_TimeToLive
    let WPD_MEDIA_TIME_TO_LIVE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 37u)
    
    ///
    /// WPD_MEDIA_GUID 
    ///   [ VT_LPWSTR ] A text field indicating the GUID of this media.
    ///   Recommended Device Services Property: PKEY_MediaObj_MediaUID
    let WPD_MEDIA_GUID = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 38u)
    
    ///
    /// WPD_MEDIA_SUB_DESCRIPTION 
    ///   [ VT_LPWSTR ] Contains a sub description of the media content for this object.
    ///   Recommended Device Services Property: PKEY_GenericObj_SubDescription
    let WPD_MEDIA_SUB_DESCRIPTION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 39u)
    
    ///
    /// WPD_MEDIA_AUDIO_ENCODING_PROFILE 
    ///   [ VT_LPWSTR ] Media codecs may be encoded in accordance with a profile, which defines a particular encoding algorithm or optimization process.
    ///   Recommended Device Services Property: PKEY_MediaObj_AudioEncodingProfile
    let WPD_MEDIA_AUDIO_ENCODING_PROFILE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MEDIA_PROPERTIES_V1, pid = 49u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_CONTACT_OBJECT_PROPERTIES_V1 
    ///
    /// This category is for properties common to all contact objects.
    ///
    let WPD_CONTACT_OBJECT_PROPERTIES_V1 = new System.Guid(0xFBD4FDABu, 0x987Dus, 0x4777us, 0xB3uy, 0xF9uy, 0x72uy, 0x61uy, 0x85uy, 0xA9uy, 0x31uy, 0x2Buy)
    
    ///
    /// WPD_CONTACT_DISPLAY_NAME 
    ///   [ VT_LPWSTR ] Indicates the display name of the contact (e.g "John Doe")
    ///   Recommended Device Services Property: None
    let WPD_CONTACT_DISPLAY_NAME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 2u)
    
    ///
    /// WPD_CONTACT_FIRST_NAME 
    ///   [ VT_LPWSTR ] Indicates the first name of the contact (e.g. "John")
    ///   Recommended Device Services Property: PKEY_ContactObj_GivenName
    let WPD_CONTACT_FIRST_NAME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 3u)
    
    ///
    /// WPD_CONTACT_MIDDLE_NAMES 
    ///   [ VT_LPWSTR ] Indicates the middle name of the contact
    ///   Recommended Device Services Property: PKEY_ContactObj_MiddleNames
    let WPD_CONTACT_MIDDLE_NAMES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 4u)
    
    ///
    /// WPD_CONTACT_LAST_NAME 
    ///   [ VT_LPWSTR ] Indicates the last name of the contact (e.g. "Doe")
    ///   Recommended Device Services Property: PKEY_ContactObj_FamilyName
    let WPD_CONTACT_LAST_NAME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 5u)
    
    ///
    /// WPD_CONTACT_PREFIX 
    ///   [ VT_LPWSTR ] Indicates the prefix of the name of the contact (e.g. "Mr.")
    ///   Recommended Device Services Property: PKEY_ContactObj_Title
    let WPD_CONTACT_PREFIX = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 6u)
    
    ///
    /// WPD_CONTACT_SUFFIX 
    ///   [ VT_LPWSTR ] Indicates the suffix of the name of the contact (e.g. "Jr.")
    ///   Recommended Device Services Property: PKEY_ContactObj_Suffix
    let WPD_CONTACT_SUFFIX = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 7u)
    
    ///
    /// WPD_CONTACT_PHONETIC_FIRST_NAME 
    ///   [ VT_LPWSTR ] The phonetic guide for pronouncing the contact's first name.
    ///   Recommended Device Services Property: PKEY_ContactObj_PhoneticGivenName
    let WPD_CONTACT_PHONETIC_FIRST_NAME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 8u)
    
    ///
    /// WPD_CONTACT_PHONETIC_LAST_NAME 
    ///   [ VT_LPWSTR ] The phonetic guide for pronouncing the contact's last name.
    ///   Recommended Device Services Property: PKEY_ContactObj_PhoneticFamilyName
    let WPD_CONTACT_PHONETIC_LAST_NAME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 9u)
    
    ///
    /// WPD_CONTACT_PERSONAL_FULL_POSTAL_ADDRESS 
    ///   [ VT_LPWSTR ] Indicates the full postal address of the contact (e.g. "555 Dial Drive, PhoneLand, WA 12345")
    ///   Recommended Device Services Property: PKEY_ContactObj_PersonalAddressFull
    let WPD_CONTACT_PERSONAL_FULL_POSTAL_ADDRESS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 10u)
    
    ///
    /// WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_LINE1 
    ///   [ VT_LPWSTR ] Indicates the first line of a postal address of the contact (e.g. "555 Dial Drive")
    ///   Recommended Device Services Property: PKEY_ContactObj_PersonalAddressStreet
    let WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_LINE1 = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 11u)
    
    ///
    /// WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_LINE2 
    ///   [ VT_LPWSTR ] Indicates the second line of a postal address of the contact
    ///   Recommended Device Services Property: PKEY_ContactObj_PersonalAddressLine2
    let WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_LINE2 = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 12u)
    
    ///
    /// WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_CITY 
    ///   [ VT_LPWSTR ] Indicates the city of a postal address of the contact (e.g. "PhoneLand")
    ///   Recommended Device Services Property: PKEY_ContactObj_PersonalAddressCity
    let WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_CITY = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 13u)
    
    ///
    /// WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_REGION 
    ///   [ VT_LPWSTR ] Indicates the region of a postal address of the contact
    ///   Recommended Device Services Property: PKEY_ContactObj_PersonalAddressRegion
    let WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_REGION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 14u)
    
    ///
    /// WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_POSTAL_CODE 
    ///   [ VT_LPWSTR ] Indicates the postal code of the address.
    ///   Recommended Device Services Property: PKEY_ContactObj_PersonalAddressPostalCode
    let WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_POSTAL_CODE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 15u)
    
    ///
    /// WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_COUNTRY 
    ///   [ VT_LPWSTR ] 
    ///   Recommended Device Services Property: PKEY_ContactObj_PersonalAddressCountry
    let WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_COUNTRY = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 16u)
    
    ///
    /// WPD_CONTACT_BUSINESS_FULL_POSTAL_ADDRESS 
    ///   [ VT_LPWSTR ] Indicates the full postal address of the contact (e.g. "555 Dial Drive, PhoneLand, WA 12345")
    ///   Recommended Device Services Property: PKEY_ContactObj_BusinessAddressFull
    let WPD_CONTACT_BUSINESS_FULL_POSTAL_ADDRESS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 17u)
    
    ///
    /// WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_LINE1 
    ///   [ VT_LPWSTR ] Indicates the first line of a postal address of the contact (e.g. "555 Dial Drive")
    ///   Recommended Device Services Property: PKEY_ContactObj_BusinessAddressStreet
    let WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_LINE1 = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 18u)
    
    ///
    /// WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_LINE2 
    ///   [ VT_LPWSTR ] Indicates the second line of a postal address of the contact
    ///   Recommended Device Services Property: PKEY_ContactObj_BusinessAddressLine2
    let WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_LINE2 = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 19u)
    
    ///
    /// WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_CITY 
    ///   [ VT_LPWSTR ] Indicates the city of a postal address of the contact (e.g. "PhoneLand")
    ///   Recommended Device Services Property: PKEY_ContactObj_BusinessAddressCity
    let WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_CITY = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 20u)
    
    ///
    /// WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_REGION 
    ///   [ VT_LPWSTR ] 
    ///   Recommended Device Services Property: PKEY_ContactObj_BusinessAddressRegion
    let WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_REGION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 21u)
    
    ///
    /// WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_POSTAL_CODE 
    ///   [ VT_LPWSTR ] Indicates the postal code of the address.
    ///   Recommended Device Services Property: PKEY_ContactObj_BusinessAddressPostalCode
    let WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_POSTAL_CODE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 22u)
    
    ///
    /// WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_COUNTRY 
    ///   [ VT_LPWSTR ] 
    ///   Recommended Device Services Property: PKEY_ContactObj_BusinessAddressCountry
    let WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_COUNTRY = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 23u)
    
    ///
    /// WPD_CONTACT_OTHER_FULL_POSTAL_ADDRESS 
    ///   [ VT_LPWSTR ] Indicates the full postal address of the contact (e.g. "555 Dial Drive, PhoneLand, WA 12345").
    ///   Recommended Device Services Property: PKEY_ContactObj_OtherAddressFull
    let WPD_CONTACT_OTHER_FULL_POSTAL_ADDRESS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 24u)
    
    ///
    /// WPD_CONTACT_OTHER_POSTAL_ADDRESS_LINE1 
    ///   [ VT_LPWSTR ] Indicates the first line of a postal address of the contact (e.g. "555 Dial Drive").
    ///   Recommended Device Services Property: PKEY_ContactObj_OtherAddressStreet
    let WPD_CONTACT_OTHER_POSTAL_ADDRESS_LINE1 = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 25u)
    
    ///
    /// WPD_CONTACT_OTHER_POSTAL_ADDRESS_LINE2 
    ///   [ VT_LPWSTR ] Indicates the second line of a postal address of the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_OtherAddressLine2
    let WPD_CONTACT_OTHER_POSTAL_ADDRESS_LINE2 = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 26u)
    
    ///
    /// WPD_CONTACT_OTHER_POSTAL_ADDRESS_CITY 
    ///   [ VT_LPWSTR ] Indicates the city of a postal address of the contact (e.g. "PhoneLand").
    ///   Recommended Device Services Property: PKEY_ContactObj_OtherAddressCity
    let WPD_CONTACT_OTHER_POSTAL_ADDRESS_CITY = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 27u)
    
    ///
    /// WPD_CONTACT_OTHER_POSTAL_ADDRESS_REGION 
    ///   [ VT_LPWSTR ] Indicates the region of a postal address of the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_OtherAddressRegion
    let WPD_CONTACT_OTHER_POSTAL_ADDRESS_REGION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 28u)
    
    ///
    /// WPD_CONTACT_OTHER_POSTAL_ADDRESS_POSTAL_CODE 
    ///   [ VT_LPWSTR ] Indicates the postal code of the address.
    ///   Recommended Device Services Property: PKEY_ContactObj_OtherAddressPostalCode
    let WPD_CONTACT_OTHER_POSTAL_ADDRESS_POSTAL_CODE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 29u)
    
    ///
    /// WPD_CONTACT_OTHER_POSTAL_ADDRESS_POSTAL_COUNTRY 
    ///   [ VT_LPWSTR ] Indicates the country/region of the postal address.
    ///   Recommended Device Services Property: PKEY_ContactObj_OtherAddressCountry
    let WPD_CONTACT_OTHER_POSTAL_ADDRESS_POSTAL_COUNTRY = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 30u)
    
    ///
    /// WPD_CONTACT_PRIMARY_EMAIL_ADDRESS 
    ///   [ VT_LPWSTR ] Indicates the primary email address for the contact e.g. "someone@example.com"
    ///   Recommended Device Services Property: PKEY_ContactObj_Email
    let WPD_CONTACT_PRIMARY_EMAIL_ADDRESS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 31u)
    
    ///
    /// WPD_CONTACT_PERSONAL_EMAIL 
    ///   [ VT_LPWSTR ] Indicates the personal email address for the contact e.g. "someone@example.com"
    ///   Recommended Device Services Property: PKEY_ContactObj_PersonalEmail
    let WPD_CONTACT_PERSONAL_EMAIL = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 32u)
    
    ///
    /// WPD_CONTACT_PERSONAL_EMAIL2 
    ///   [ VT_LPWSTR ] Indicates an alternate personal email address for the contact e.g. "someone@example.com"
    ///   Recommended Device Services Property: PKEY_ContactObj_PersonalEmail2
    let WPD_CONTACT_PERSONAL_EMAIL2 = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 33u)
    
    ///
    /// WPD_CONTACT_BUSINESS_EMAIL 
    ///   [ VT_LPWSTR ] Indicates the business email address for the contact e.g. "someone@example.com"
    ///   Recommended Device Services Property: PKEY_ContactObj_BusinessEmail
    let WPD_CONTACT_BUSINESS_EMAIL = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 34u)
    
    ///
    /// WPD_CONTACT_BUSINESS_EMAIL2 
    ///   [ VT_LPWSTR ] Indicates an alternate business email address for the contact e.g. "someone@example.com"
    ///   Recommended Device Services Property: PKEY_ContactObj_BusinessEmail2
    let WPD_CONTACT_BUSINESS_EMAIL2 = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 35u)
    
    ///
    /// WPD_CONTACT_OTHER_EMAILS 
    ///   [ VT_UNKNOWN ] An IPortableDevicePropVariantCollection of type VT_LPWSTR, where each element is an alternate email addresses for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_OtherEmail
    let WPD_CONTACT_OTHER_EMAILS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 36u)
    
    ///
    /// WPD_CONTACT_PRIMARY_PHONE 
    ///   [ VT_LPWSTR ] Indicates the primary phone number for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_Phone
    let WPD_CONTACT_PRIMARY_PHONE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 37u)
    
    ///
    /// WPD_CONTACT_PERSONAL_PHONE 
    ///   [ VT_LPWSTR ] Indicates the personal phone number for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_PersonalPhone
    let WPD_CONTACT_PERSONAL_PHONE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 38u)
    
    ///
    /// WPD_CONTACT_PERSONAL_PHONE2 
    ///   [ VT_LPWSTR ] Indicates an alternate personal phone number for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_PersonalPhone2
    let WPD_CONTACT_PERSONAL_PHONE2 = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 39u)
    
    ///
    /// WPD_CONTACT_BUSINESS_PHONE 
    ///   [ VT_LPWSTR ] Indicates the business phone number for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_BusinessPhone
    let WPD_CONTACT_BUSINESS_PHONE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 40u)
    
    ///
    /// WPD_CONTACT_BUSINESS_PHONE2 
    ///   [ VT_LPWSTR ] Indicates an alternate business phone number for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_BusinessPhone2
    let WPD_CONTACT_BUSINESS_PHONE2 = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 41u)
    
    ///
    /// WPD_CONTACT_MOBILE_PHONE 
    ///   [ VT_LPWSTR ] Indicates the mobile phone number for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_MobilePhone
    let WPD_CONTACT_MOBILE_PHONE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 42u)
    
    ///
    /// WPD_CONTACT_MOBILE_PHONE2 
    ///   [ VT_LPWSTR ] Indicates an alternate mobile phone number for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_MobilePhone2
    let WPD_CONTACT_MOBILE_PHONE2 = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 43u)
    
    ///
    /// WPD_CONTACT_PERSONAL_FAX 
    ///   [ VT_LPWSTR ] Indicates the personal fax number for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_PersonalFax
    let WPD_CONTACT_PERSONAL_FAX = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 44u)
    
    ///
    /// WPD_CONTACT_BUSINESS_FAX 
    ///   [ VT_LPWSTR ] Indicates the business fax number for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_BusinessFax
    let WPD_CONTACT_BUSINESS_FAX = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 45u)
    
    ///
    /// WPD_CONTACT_PAGER 
    ///   [ VT_LPWSTR ] 
    ///   Recommended Device Services Property: PKEY_ContactObj_Pager
    let WPD_CONTACT_PAGER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 46u)
    
    ///
    /// WPD_CONTACT_OTHER_PHONES 
    ///   [ VT_UNKNOWN ] An IPortableDevicePropVariantCollection of type VT_LPWSTR, where each element is an alternate phone number for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_OtherPhone
    let WPD_CONTACT_OTHER_PHONES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 47u)
    
    ///
    /// WPD_CONTACT_PRIMARY_WEB_ADDRESS 
    ///   [ VT_LPWSTR ] Indicates the primary web address for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_WebAddress
    let WPD_CONTACT_PRIMARY_WEB_ADDRESS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 48u)
    
    ///
    /// WPD_CONTACT_PERSONAL_WEB_ADDRESS 
    ///   [ VT_LPWSTR ] Indicates the personal web address for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_PersonalWebAddress
    let WPD_CONTACT_PERSONAL_WEB_ADDRESS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 49u)
    
    ///
    /// WPD_CONTACT_BUSINESS_WEB_ADDRESS 
    ///   [ VT_LPWSTR ] Indicates the business web address for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_BusinessWebAddress
    let WPD_CONTACT_BUSINESS_WEB_ADDRESS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 50u)
    
    ///
    /// WPD_CONTACT_INSTANT_MESSENGER 
    ///   [ VT_LPWSTR ] Indicates the instant messenger address for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_IMAddress
    let WPD_CONTACT_INSTANT_MESSENGER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 51u)
    
    ///
    /// WPD_CONTACT_INSTANT_MESSENGER2 
    ///   [ VT_LPWSTR ] Indicates an alternate instant messenger address for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_IMAddress2
    let WPD_CONTACT_INSTANT_MESSENGER2 = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 52u)
    
    ///
    /// WPD_CONTACT_INSTANT_MESSENGER3 
    ///   [ VT_LPWSTR ] Indicates an alternate instant messenger address for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_IMAddress3
    let WPD_CONTACT_INSTANT_MESSENGER3 = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 53u)
    
    ///
    /// WPD_CONTACT_COMPANY_NAME 
    ///   [ VT_LPWSTR ] Indicates the company name for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_Organization
    let WPD_CONTACT_COMPANY_NAME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 54u)
    
    ///
    /// WPD_CONTACT_PHONETIC_COMPANY_NAME 
    ///   [ VT_LPWSTR ] The phonetic guide for pronouncing the contact's company name.
    ///   Recommended Device Services Property: PKEY_ContactObj_PhoneticOrganization
    let WPD_CONTACT_PHONETIC_COMPANY_NAME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 55u)
    
    ///
    /// WPD_CONTACT_ROLE 
    ///   [ VT_LPWSTR ] Indicates the role for the contact e.g. "Software Engineer".
    ///   Recommended Device Services Property: PKEY_ContactObj_Role
    let WPD_CONTACT_ROLE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 56u)
    
    ///
    /// WPD_CONTACT_BIRTHDATE 
    ///   [ VT_DATE ] Indicates the birthdate for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_Birthdate
    let WPD_CONTACT_BIRTHDATE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 57u)
    
    ///
    /// WPD_CONTACT_PRIMARY_FAX 
    ///   [ VT_LPWSTR ] Indicates the primary fax number for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_Fax
    let WPD_CONTACT_PRIMARY_FAX = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 58u)
    
    ///
    /// WPD_CONTACT_SPOUSE 
    ///   [ VT_LPWSTR ] Indicates the full name of the spouse/domestic partner for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_Spouse
    let WPD_CONTACT_SPOUSE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 59u)
    
    ///
    /// WPD_CONTACT_CHILDREN 
    ///   [ VT_UNKNOWN ] An IPortableDevicePropVariantCollection of type VT_LPWSTR, where each element is the full name of a child of the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_Children
    let WPD_CONTACT_CHILDREN = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 60u)
    
    ///
    /// WPD_CONTACT_ASSISTANT 
    ///   [ VT_LPWSTR ] Indicates the full name of the assistant for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_Assistant
    let WPD_CONTACT_ASSISTANT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 61u)
    
    ///
    /// WPD_CONTACT_ANNIVERSARY_DATE 
    ///   [ VT_DATE ] Indicates the anniversary date for the contact.
    ///   Recommended Device Services Property: PKEY_ContactObj_AnniversaryDate
    let WPD_CONTACT_ANNIVERSARY_DATE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 62u)
    
    ///
    /// WPD_CONTACT_RINGTONE 
    ///   [ VT_LPWSTR ] Indicates an object id of a ringtone file on the device.
    ///   Recommended Device Services Property: PKEY_ContactObj_Ringtone
    let WPD_CONTACT_RINGTONE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CONTACT_OBJECT_PROPERTIES_V1, pid = 63u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_MUSIC_OBJECT_PROPERTIES_V1 
    ///
    /// This category is for properties common to all music objects.
    ///
    let WPD_MUSIC_OBJECT_PROPERTIES_V1 = new System.Guid(0xB324F56Au, 0xDC5Dus, 0x46E5us, 0xB6uy, 0xDFuy, 0xD2uy, 0xEAuy, 0x41uy, 0x48uy, 0x88uy, 0xC6uy)
    
    ///
    /// WPD_MUSIC_ALBUM 
    ///   [ VT_LPWSTR ] Indicates the album of the music file.
    ///   Recommended Device Services Property: PKEY_MediaObj_AlbumName
    let WPD_MUSIC_ALBUM = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MUSIC_OBJECT_PROPERTIES_V1, pid = 3u)
    
    ///
    /// WPD_MUSIC_TRACK 
    ///   [ VT_UI4 ] Indicates the track number for the music file.
    ///   Recommended Device Services Property: PKEY_MediaObj_Track
    let WPD_MUSIC_TRACK = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MUSIC_OBJECT_PROPERTIES_V1, pid = 4u)
    
    ///
    /// WPD_MUSIC_LYRICS 
    ///   [ VT_LPWSTR ] Indicates the lyrics for the music file.
    ///   Recommended Device Services Property: PKEY_AudioObj_Lyrics
    let WPD_MUSIC_LYRICS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MUSIC_OBJECT_PROPERTIES_V1, pid = 6u)
    
    ///
    /// WPD_MUSIC_MOOD 
    ///   [ VT_LPWSTR ] Indicates the mood for the music file.
    ///   Recommended Device Services Property: PKEY_MediaObj_Mood
    let WPD_MUSIC_MOOD = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MUSIC_OBJECT_PROPERTIES_V1, pid = 8u)
    
    ///
    /// WPD_AUDIO_BITRATE 
    ///   [ VT_UI4 ] Indicates the bit rate for the audio data, specified in bits per second.
    ///   Recommended Device Services Property: PKEY_AudioObj_AudioBitRate
    let WPD_AUDIO_BITRATE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MUSIC_OBJECT_PROPERTIES_V1, pid = 9u)
    
    ///
    /// WPD_AUDIO_CHANNEL_COUNT 
    ///   [ VT_R4 ] Indicates the number of channels in this audio file e.g. 1, 2, 5.1 etc.
    ///   Recommended Device Services Property: PKEY_AudioObj_Channels
    let WPD_AUDIO_CHANNEL_COUNT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MUSIC_OBJECT_PROPERTIES_V1, pid = 10u)
    
    ///
    /// WPD_AUDIO_FORMAT_CODE 
    ///   [ VT_UI4 ] Indicates the registered WAVE format code.
    ///   Recommended Device Services Property: PKEY_AudioObj_AudioFormatCode
    let WPD_AUDIO_FORMAT_CODE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MUSIC_OBJECT_PROPERTIES_V1, pid = 11u)
    
    ///
    /// WPD_AUDIO_BIT_DEPTH 
    ///   [ VT_UI4 ] This property identifies the bit-depth of the audio.
    ///   Recommended Device Services Property: PKEY_AudioObj_AudioBitDepth
    let WPD_AUDIO_BIT_DEPTH = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MUSIC_OBJECT_PROPERTIES_V1, pid = 12u)
    
    ///
    /// WPD_AUDIO_BLOCK_ALIGNMENT 
    ///   [ VT_UI4 ] This property identifies the audio block alignment
    ///   Recommended Device Services Property: PKEY_AudioObj_AudioBlockAlignment
    let WPD_AUDIO_BLOCK_ALIGNMENT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_MUSIC_OBJECT_PROPERTIES_V1, pid = 13u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_VIDEO_OBJECT_PROPERTIES_V1 
    ///
    /// This category is for properties common to all video objects.
    ///
    let WPD_VIDEO_OBJECT_PROPERTIES_V1 = new System.Guid(0x346F2163u, 0xF998us, 0x4146us, 0x8Buy, 0x01uy, 0xD1uy, 0x9Buy, 0x4Cuy, 0x00uy, 0xDEuy, 0x9Auy)
    
    ///
    /// WPD_VIDEO_AUTHOR 
    ///   [ VT_LPWSTR ] Indicates the author of the video file.
    ///   Recommended Device Services Property: PKEY_MediaObj_Producer
    let WPD_VIDEO_AUTHOR = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_VIDEO_OBJECT_PROPERTIES_V1, pid = 2u)
    
    ///
    /// WPD_VIDEO_RECORDEDTV_STATION_NAME 
    ///   [ VT_LPWSTR ] Indicates the TV station the video was recorded from.
    ///   Recommended Device Services Property: PKEY_VideoObj_Source
    let WPD_VIDEO_RECORDEDTV_STATION_NAME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_VIDEO_OBJECT_PROPERTIES_V1, pid = 4u)
    
    ///
    /// WPD_VIDEO_RECORDEDTV_CHANNEL_NUMBER 
    ///   [ VT_UI4 ] Indicates the TV channel number the video was recorded from.
    ///   Recommended Device Services Property: None
    let WPD_VIDEO_RECORDEDTV_CHANNEL_NUMBER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_VIDEO_OBJECT_PROPERTIES_V1, pid = 5u)
    
    ///
    /// WPD_VIDEO_RECORDEDTV_REPEAT 
    ///   [ VT_BOOL ] Indicates whether the recorded TV program was a repeat showing.
    ///   Recommended Device Services Property: None
    let WPD_VIDEO_RECORDEDTV_REPEAT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_VIDEO_OBJECT_PROPERTIES_V1, pid = 7u)
    
    ///
    /// WPD_VIDEO_BUFFER_SIZE 
    ///   [ VT_UI4 ] Indicates the video buffer size.
    ///   Recommended Device Services Property: PKEY_MediaObj_BufferSize
    let WPD_VIDEO_BUFFER_SIZE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_VIDEO_OBJECT_PROPERTIES_V1, pid = 8u)
    
    ///
    /// WPD_VIDEO_CREDITS 
    ///   [ VT_LPWSTR ] Indicates the credit text for the video file.
    ///   Recommended Device Services Property: PKEY_MediaObj_Credits
    let WPD_VIDEO_CREDITS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_VIDEO_OBJECT_PROPERTIES_V1, pid = 9u)
    
    ///
    /// WPD_VIDEO_KEY_FRAME_DISTANCE 
    ///   [ VT_UI4 ] Indicates the interval between key frames in milliseconds.
    ///   Recommended Device Services Property: PKEY_VideoObj_KeyFrameDistance
    let WPD_VIDEO_KEY_FRAME_DISTANCE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_VIDEO_OBJECT_PROPERTIES_V1, pid = 10u)
    
    ///
    /// WPD_VIDEO_QUALITY_SETTING 
    ///   [ VT_UI4 ] Indicates the quality setting for the video file.
    ///   Recommended Device Services Property: PKEY_MediaObj_EncodingQuality
    let WPD_VIDEO_QUALITY_SETTING = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_VIDEO_OBJECT_PROPERTIES_V1, pid = 11u)
    
    ///
    /// WPD_VIDEO_SCAN_TYPE 
    ///   [ VT_UI4 ] This property identifies the video scan information.
    ///   Recommended Device Services Property: PKEY_VideoObj_ScanType
    let WPD_VIDEO_SCAN_TYPE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_VIDEO_OBJECT_PROPERTIES_V1, pid = 12u)
    
    ///
    /// WPD_VIDEO_BITRATE 
    ///   [ VT_UI4 ] Indicates the bitrate for the video data.
    ///   Recommended Device Services Property: PKEY_VideoObj_VideoBitRate
    let WPD_VIDEO_BITRATE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_VIDEO_OBJECT_PROPERTIES_V1, pid = 13u)
    
    ///
    /// WPD_VIDEO_FOURCC_CODE 
    ///   [ VT_UI4 ] The registered FourCC code indicating the codec used for the video file.
    ///   Recommended Device Services Property: PKEY_VideoObj_VideoFormatCode
    let WPD_VIDEO_FOURCC_CODE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_VIDEO_OBJECT_PROPERTIES_V1, pid = 14u)
    
    ///
    /// WPD_VIDEO_FRAMERATE 
    ///   [ VT_UI4 ] Indicates the frame rate for the video data.
    ///   Recommended Device Services Property: PKEY_VideoObj_VideoFrameRate
    let WPD_VIDEO_FRAMERATE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_VIDEO_OBJECT_PROPERTIES_V1, pid = 15u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_COMMON_INFORMATION_OBJECT_PROPERTIES_V1 
    ///
    /// This category is properties that pertain to informational objects such as appointments, tasks, memos and even documents.
    ///
    let WPD_COMMON_INFORMATION_OBJECT_PROPERTIES_V1 = new System.Guid(0xB28AE94Bu, 0x05A4us, 0x4E8Eus, 0xBEuy, 0x01uy, 0x72uy, 0xCCuy, 0x7Euy, 0x09uy, 0x9Duy, 0x8Fuy)
    
    ///
    /// WPD_COMMON_INFORMATION_SUBJECT 
    ///   [ VT_LPWSTR ] Indicates the subject field of this object.
    ///   Recommended Device Services Property: PKEY_MessageObj_Subject
    let WPD_COMMON_INFORMATION_SUBJECT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_COMMON_INFORMATION_OBJECT_PROPERTIES_V1, pid = 2u)
    
    ///
    /// WPD_COMMON_INFORMATION_BODY_TEXT 
    ///   [ VT_LPWSTR ] This property contains the body text of an object, in plaintext or HTML format.
    ///   Recommended Device Services Property: PKEY_MessageObj_Body
    let WPD_COMMON_INFORMATION_BODY_TEXT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_COMMON_INFORMATION_OBJECT_PROPERTIES_V1, pid = 3u)
    
    ///
    /// WPD_COMMON_INFORMATION_PRIORITY 
    ///   [ VT_UI4 ] Indicates the priority of this object.
    ///   Recommended Device Services Property: PKEY_MessageObj_Priority
    let WPD_COMMON_INFORMATION_PRIORITY = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_COMMON_INFORMATION_OBJECT_PROPERTIES_V1, pid = 4u)
    
    ///
    /// WPD_COMMON_INFORMATION_START_DATETIME 
    ///   [ VT_DATE ] For appointments, tasks and similar objects, this indicates the date/time that this item is scheduled to start.
    ///   Recommended Device Services Property: PKEY_MessageObj_PatternValidStartDate
    let WPD_COMMON_INFORMATION_START_DATETIME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_COMMON_INFORMATION_OBJECT_PROPERTIES_V1, pid = 5u)
    
    ///
    /// WPD_COMMON_INFORMATION_END_DATETIME 
    ///   [ VT_DATE ] For appointments, tasks and similar objects, this indicates the date/time that this item is scheduled to end.
    ///   Recommended Device Services Property: PKEY_MessageObj_PatternValidEndDate
    let WPD_COMMON_INFORMATION_END_DATETIME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_COMMON_INFORMATION_OBJECT_PROPERTIES_V1, pid = 6u)
    
    ///
    /// WPD_COMMON_INFORMATION_NOTES 
    ///   [ VT_LPWSTR ] For appointments, tasks and similar objects, this indicates any notes for this object.
    ///   Recommended Device Services Property: None
    let WPD_COMMON_INFORMATION_NOTES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_COMMON_INFORMATION_OBJECT_PROPERTIES_V1, pid = 7u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_MEMO_OBJECT_PROPERTIES_V1 
    ///
    /// This category is for properties common to all memo objects.
    ///
    let WPD_MEMO_OBJECT_PROPERTIES_V1 = new System.Guid(0x5FFBFC7Bu, 0x7483us, 0x41ADus, 0xAFuy, 0xB9uy, 0xDAuy, 0x3Fuy, 0x4Euy, 0x59uy, 0x2Buy, 0x8Duy)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_EMAIL_OBJECT_PROPERTIES_V1 
    ///
    /// This category is for properties common to all email objects.
    ///
    let WPD_EMAIL_OBJECT_PROPERTIES_V1 = new System.Guid(0x41F8F65Au, 0x5484us, 0x4782us, 0xB1uy, 0x3Duy, 0x47uy, 0x40uy, 0xDDuy, 0x7Cuy, 0x37uy, 0xC5uy)
    
    ///
    /// WPD_EMAIL_TO_LINE 
    ///   [ VT_LPWSTR ] Indicates the normal recipients for the message.
    ///   Recommended Device Services Property: PKEY_MessageObj_To
    let WPD_EMAIL_TO_LINE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_EMAIL_OBJECT_PROPERTIES_V1, pid = 2u)
    
    ///
    /// WPD_EMAIL_CC_LINE 
    ///   [ VT_LPWSTR ] Indicates the copied recipients for the message.
    ///   Recommended Device Services Property: PKEY_MessageObj_CC
    let WPD_EMAIL_CC_LINE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_EMAIL_OBJECT_PROPERTIES_V1, pid = 3u)
    
    ///
    /// WPD_EMAIL_BCC_LINE 
    ///   [ VT_LPWSTR ] Indicates the recipients for the message who receive a "blind copy".
    ///   Recommended Device Services Property: PKEY_MessageObj_BCC
    let WPD_EMAIL_BCC_LINE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_EMAIL_OBJECT_PROPERTIES_V1, pid = 4u)
    
    ///
    /// WPD_EMAIL_HAS_BEEN_READ 
    ///   [ VT_BOOL ] Indicates whether the user has read this message.
    ///   Recommended Device Services Property: PKEY_MessageObj_Read
    let WPD_EMAIL_HAS_BEEN_READ = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_EMAIL_OBJECT_PROPERTIES_V1, pid = 7u)
    
    ///
    /// WPD_EMAIL_RECEIVED_TIME 
    ///   [ VT_DATE ] Indicates at what time the message was received.
    ///   Recommended Device Services Property: PKEY_MessageObj_ReceivedTime
    let WPD_EMAIL_RECEIVED_TIME = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_EMAIL_OBJECT_PROPERTIES_V1, pid = 8u)
    
    ///
    /// WPD_EMAIL_HAS_ATTACHMENTS 
    ///   [ VT_BOOL ] Indicates whether this message has attachments.
    ///   Recommended Device Services Property: None
    let WPD_EMAIL_HAS_ATTACHMENTS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_EMAIL_OBJECT_PROPERTIES_V1, pid = 9u)
    
    ///
    /// WPD_EMAIL_SENDER_ADDRESS 
    ///   [ VT_LPWSTR ] Indicates who sent the message.
    ///   Recommended Device Services Property: PKEY_MessageObj_Sender
    let WPD_EMAIL_SENDER_ADDRESS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_EMAIL_OBJECT_PROPERTIES_V1, pid = 10u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_APPOINTMENT_OBJECT_PROPERTIES_V1 
    ///
    /// This category is for properties common to all appointment objects.
    ///
    let WPD_APPOINTMENT_OBJECT_PROPERTIES_V1 = new System.Guid(0xF99EFD03u, 0x431Dus, 0x40D8us, 0xA1uy, 0xC9uy, 0x4Euy, 0x22uy, 0x0Duy, 0x9Cuy, 0x88uy, 0xD3uy)
    
    ///
    /// WPD_APPOINTMENT_LOCATION 
    ///   [ VT_LPWSTR ] Indicates the location of the appointment e.g. "Building 5, Conf. room 7".
    ///   Recommended Device Services Property: PKEY_CalendarObj_Location
    let WPD_APPOINTMENT_LOCATION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_APPOINTMENT_OBJECT_PROPERTIES_V1, pid = 3u)
    
    ///
    /// WPD_APPOINTMENT_TYPE 
    ///   [ VT_LPWSTR ] Indicates the type of appointment e.g. "Personal", "Business" etc.
    ///   Recommended Device Services Property: None
    let WPD_APPOINTMENT_TYPE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_APPOINTMENT_OBJECT_PROPERTIES_V1, pid = 7u)
    
    ///
    /// WPD_APPOINTMENT_REQUIRED_ATTENDEES 
    ///   [ VT_LPWSTR ] Semi-colon separated list of required attendees.
    ///   Recommended Device Services Property: None
    let WPD_APPOINTMENT_REQUIRED_ATTENDEES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_APPOINTMENT_OBJECT_PROPERTIES_V1, pid = 8u)
    
    ///
    /// WPD_APPOINTMENT_OPTIONAL_ATTENDEES 
    ///   [ VT_LPWSTR ] Semi-colon separated list of optional attendees.
    ///   Recommended Device Services Property: None
    let WPD_APPOINTMENT_OPTIONAL_ATTENDEES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_APPOINTMENT_OBJECT_PROPERTIES_V1, pid = 9u)
    
    ///
    /// WPD_APPOINTMENT_ACCEPTED_ATTENDEES 
    ///   [ VT_LPWSTR ] Semi-colon separated list of attendees who have accepted the appointment.
    ///   Recommended Device Services Property: PKEY_CalendarObj_Accepted
    let WPD_APPOINTMENT_ACCEPTED_ATTENDEES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_APPOINTMENT_OBJECT_PROPERTIES_V1, pid = 10u)
    
    ///
    /// WPD_APPOINTMENT_RESOURCES 
    ///   [ VT_LPWSTR ] Semi-colon separated list of resources needed for the appointment.
    ///   Recommended Device Services Property: None
    let WPD_APPOINTMENT_RESOURCES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_APPOINTMENT_OBJECT_PROPERTIES_V1, pid = 11u)
    
    ///
    /// WPD_APPOINTMENT_TENTATIVE_ATTENDEES 
    ///   [ VT_LPWSTR ] Semi-colon separated list of attendees who have tentatively accepted the appointment.
    ///   Recommended Device Services Property: PKEY_CalendarObj_Tentative
    let WPD_APPOINTMENT_TENTATIVE_ATTENDEES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_APPOINTMENT_OBJECT_PROPERTIES_V1, pid = 12u)
    
    ///
    /// WPD_APPOINTMENT_DECLINED_ATTENDEES 
    ///   [ VT_LPWSTR ] Semi-colon separated list of attendees who have declined the appointment.
    ///   Recommended Device Services Property: PKEY_CalendarObj_Declined
    let WPD_APPOINTMENT_DECLINED_ATTENDEES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_APPOINTMENT_OBJECT_PROPERTIES_V1, pid = 13u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_TASK_OBJECT_PROPERTIES_V1 
    ///
    /// This category is for properties common to all task objects.
    ///
    let WPD_TASK_OBJECT_PROPERTIES_V1 = new System.Guid(0xE354E95Eu, 0xD8A0us, 0x4637us, 0xA0uy, 0x3Auy, 0x0Cuy, 0xB2uy, 0x68uy, 0x38uy, 0xDBuy, 0xC7uy)
    
    ///
    /// WPD_TASK_STATUS 
    ///   [ VT_LPWSTR ] Indicates the status of the task e.g. "In Progress".
    ///   Recommended Device Services Property: None
    let WPD_TASK_STATUS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_TASK_OBJECT_PROPERTIES_V1, pid = 6u)
    
    ///
    /// WPD_TASK_PERCENT_COMPLETE 
    ///   [ VT_UI4 ] Indicates how much of the task has been completed.
    ///   Recommended Device Services Property: PKEY_TaskObj_Complete
    let WPD_TASK_PERCENT_COMPLETE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_TASK_OBJECT_PROPERTIES_V1, pid = 8u)
    
    ///
    /// WPD_TASK_REMINDER_DATE 
    ///   [ VT_DATE ] Indicates the date and time set for the reminder. If this value is 0, then it is assumed that this task has no reminder.
    ///   Recommended Device Services Property: PKEY_TaskObj_ReminderDateTime
    let WPD_TASK_REMINDER_DATE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_TASK_OBJECT_PROPERTIES_V1, pid = 10u)
    
    ///
    /// WPD_TASK_OWNER 
    ///   [ VT_LPWSTR ] Indicates the owner of the task.
    ///   Recommended Device Services Property: None
    let WPD_TASK_OWNER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_TASK_OBJECT_PROPERTIES_V1, pid = 11u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_SMS_OBJECT_PROPERTIES_V1 
    ///
    /// This category is for properties common to all objects whose functional category is WPD_FUNCTIONAL_CATEGORY_SMS
    ///
    let WPD_SMS_OBJECT_PROPERTIES_V1 = new System.Guid(0x7E1074CCu, 0x50FFus, 0x4DD1us, 0xA7uy, 0x42uy, 0x53uy, 0xBEuy, 0x6Fuy, 0x09uy, 0x3Auy, 0x0Duy)
    
    ///
    /// WPD_SMS_PROVIDER 
    ///   [ VT_LPWSTR ] Indicates the service provider name.
    ///   Recommended Device Services Property: None
    let WPD_SMS_PROVIDER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_SMS_OBJECT_PROPERTIES_V1, pid = 2u)
    
    ///
    /// WPD_SMS_TIMEOUT 
    ///   [ VT_UI4 ] Indicates the number of milliseconds until a timeout is returned.
    ///   Recommended Device Services Property: None
    let WPD_SMS_TIMEOUT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_SMS_OBJECT_PROPERTIES_V1, pid = 3u)
    
    ///
    /// WPD_SMS_MAX_PAYLOAD 
    ///   [ VT_UI4 ] Indicates the maximum number of bytes that can be contained in a message.
    ///   Recommended Device Services Property: None
    let WPD_SMS_MAX_PAYLOAD = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_SMS_OBJECT_PROPERTIES_V1, pid = 4u)
    
    ///
    /// WPD_SMS_ENCODING 
    ///   [ VT_UI4 ] Indicates how the driver will encode the text message sent by the client.
    ///   Recommended Device Services Property: None
    let WPD_SMS_ENCODING = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_SMS_OBJECT_PROPERTIES_V1, pid = 5u)
    
    ////
    /// This section defines all Commands, Parameters and Options associated with:
    /// WPD_SECTION_OBJECT_PROPERTIES_V1 
    ///
    /// This category is for properties common to all objects whose content type is WPD_CONTENT_TYPE_SECTION
    ///
    let WPD_SECTION_OBJECT_PROPERTIES_V1 = new System.Guid(0x516AFD2Bu, 0xC64Eus, 0x44F0us, 0x98uy, 0xDCuy, 0xBEuy, 0xE1uy, 0xC8uy, 0x8Fuy, 0x7Duy, 0x66uy)
    
    ///
    /// WPD_SECTION_DATA_OFFSET 
    ///   [ VT_UI8 ] Indicates the zero-based offset of the data for the referenced object.
    ///   Recommended Device Services Property: None
    let WPD_SECTION_DATA_OFFSET = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_SECTION_OBJECT_PROPERTIES_V1, pid = 2u)
    
    ///
    /// WPD_SECTION_DATA_LENGTH 
    ///   [ VT_UI8 ] Indicates the length of data for the referenced object.
    ///   Recommended Device Services Property: None
    let WPD_SECTION_DATA_LENGTH = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_SECTION_OBJECT_PROPERTIES_V1, pid = 3u)
    
    ///
    /// WPD_SECTION_DATA_UNITS 
    ///   [ VT_UI4 ] Indicates the units for WPD_SECTION_DATA_OFFSET and WPD_SECTION_DATA_LENGTH properties on this object (e.g. offset in bytes, offset in milliseconds etc.).
    ///   Recommended Device Services Property: None
    let WPD_SECTION_DATA_UNITS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_SECTION_OBJECT_PROPERTIES_V1, pid = 4u)
    
    ///
    /// WPD_SECTION_DATA_REFERENCED_OBJECT_RESOURCE 
    ///   [ VT_UNKNOWN ] This is an IPortableDeviceKeyCollection containing a single value, which is the key identifying the resource on the referenced object which the WPD_SECTION_DATA_OFFSET and WPD_SECTION_DATA_LENGTH apply to.
    ///   Recommended Device Services Property: None
    let WPD_SECTION_DATA_REFERENCED_OBJECT_RESOURCE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_SECTION_OBJECT_PROPERTIES_V1, pid = 5u)
    
    //// 
    //// This section defines WPD commands for MTP vendor-extended operations
    ////
    /// {4D545058-1A2E-4106-A357-771E0819FC56}
    let WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS = new System.Guid(0x4d545058u, 0x1a2eus, 0x4106us, 0xa3uy, 0x57uy, 0x77uy, 0x1euy, 0x8uy, 0x19uy, 0xfcuy, 0x56uy)
    
    ///
    /// MTP extended commands for WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS
    ///
    /// Cmd Key: WPD_COMMAND_MTP_EXT_GET_SUPPORTED_VENDOR_OPCODES
    /// Usage:   queries for vendor extended operation codes
    /// Inputs:  None
    /// Outputs: WPD_PROPERTY_MTP_EXT_VENDOR_OPERATION_CODES: an IPortableDevicePropVariantCollection (of VT_UI4)
    ///                                which contains all vendor-extended operation codes
    let WPD_COMMAND_MTP_EXT_GET_SUPPORTED_VENDOR_OPCODES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 11u)
    
    ///
    /// Cmd Key: WPD_COMMAND_MTP_EXT_EXECUTE_COMMAND_WITHOUT_DATA_PHASE 
    /// Usage:   sends a MTP command block that no data phase follows
    /// Inputs:  WPD_PROPERTY_MTP_EXT_OPERATION_CODE (VT_UI4): identifies the vendor-extended MTP operation code
    ///          WPD_PROPERTY_MTP_EXT_OPERATION_PARAMS: An IPortableDevicePropVariantCollection (of VT_UI4)
    ///                                                 which identifies the required params for the vendor operation code.
    /// Outputs: WPD_PROPERTY_MTP_EXT_RESPONSE_CODE: [VT_UI4] the response code to the vendor operation code, and 
    ///          WPD_PROPERTY_MTP_EXT_RESPONSE_PARAMS: An IPortableDevicePropVariantCollection (of VT_UI4) identifying response params if any (could be empty)
    let WPD_COMMAND_MTP_EXT_EXECUTE_COMMAND_WITHOUT_DATA_PHASE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 12u)
    
    ///
    /// Cmd Key: WPD_COMMAND_MTP_EXT_EXECUTE_COMMAND_WITH_DATA_TO_READ 
    /// Usage:   sends a MTP command block followed by a data phase with data from Device to Host
    /// Inputs:  WPD_PROPERTY_MTP_EXT_OPERATION_CODE (VT_UI4): identifies the vendor-extended MTP operation code
    ///          WPD_PROPERTY_MTP_EXT_OPERATION_PARAMS: An IPortableDevicePropVariantCollection (of VT_UI4)
    ///                                                 which identifies the required params for the vendor operation code.
    /// Outputs: WPD_PROPERTY_MTP_EXT_TRANSFER_TOTAL_DATA_SIZE: [VT_UI8] Returns the total data size in bytes (excluding any overhead) coming from device.
    ///                                                         if Devie reports unknown datasize (0xFFFFFFFF), call ReadData() repeatedly until a short chunk received
    ///          WPD_PROPERTY_MTP_EXT_OPTIMAL_TRANSFER_BUFFER_SIZE: [VT_UI4] Returns the optimal size of the transfer buffer
    ///          WPD_PROPERTY_MTP_EXT_TRANSFER_CONTEXT: [VT_LPWSTR] Returned as a context idetifier for subsequent data transfer
    let WPD_COMMAND_MTP_EXT_EXECUTE_COMMAND_WITH_DATA_TO_READ = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 13u)
    
    ///
    /// Cmd Key: WPD_COMMAND_MTP_EXT_EXECUTE_COMMAND_WITH_DATA_TO_WRITE 
    /// Usage:   sends a MTP command block followed by a data phase with data from Host to Device 
    /// Inputs:  WPD_PROPERTY_MTP_EXT_OPERATION_CODE (VT_UI4): identifies the vendor-extended MTP operation code
    ///          WPD_PROPERTY_MTP_EXT_OPERATION_PARAMS: An IPortableDevicePropVariantCollection (of VT_UI4)
    ///                                                 which identifies the required params for the vendor operation code.
    ///          WPD_PROPERTY_MTP_EXT_TRANSFER_TOTAL_DATA_SIZE: [VT_UI8] Specifies the total data size in bytes (excluding any overhead) to be sent to device
    /// Outputs: WPD_PROPERTY_MTP_EXT_OPTIMAL_TRANSFER_BUFFER_SIZE: [VT_UI4] Returns the optimal size of the transfer buffer
    ///          WPD_PROPERTY_MTP_EXT_TRANSFER_CONTEXT: [VT_LPWSTR] Returned as a context idetifier for subsequent data transfer
    let WPD_COMMAND_MTP_EXT_EXECUTE_COMMAND_WITH_DATA_TO_WRITE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 14u)
    
    ///
    /// Cmd Key: WPD_COMMAND_MTP_EXT_READ_DATA 
    /// Usage:   receives a chunk of data from device following WPD_COMMAND_MTP_EXT_EXECUTE_COMMAND_WITH_DATA_TO_READ
    /// Inputs:  WPD_PROPERTY_MTP_EXT_TRANSFER_CONTEXT: [VT_LPWSTR] The context idetifier returned in previous calls 
    ///          WPD_PROPERTY_MTP_EXT_TRANSFER_NUM_BYTES_TO_READ: [VT_UI4] specifies the next number of bytes to read.
    ///          WPD_PROPERTY_MTP_EXT_TRANSFER_DATA: [VT_VECTOR|VT_UI1] specifies the buffer to which the data from device will be copied
    /// Outputs: WPD_PROPERTY_MTP_EXT_TRANSFER_NUM_BYTES_READ: [VT_UI4] returns actual number of bytes (no overhead) received from device in a read call 
    ///          WPD_PROPERTY_MTP_EXT_TRANSFER_DATA: [VT_VECTOR|VT_UI1] Returns the buffer with received data
    ///
    let WPD_COMMAND_MTP_EXT_READ_DATA = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 15u)
    
    ///
    /// Cmd Key: WPD_COMMAND_MTP_EXT_WRITE_DATA 
    /// Usage:   sends a chunk of data to device following WPD_COMMAND_MTP_EXT_EXECUTE_COMMAND_WITH_DATA_TO_WRITE
    /// Inputs:  WPD_PROPERTY_MTP_EXT_TRANSFER_CONTEXT: [VT_LPWSTR] The context idetifier returned in previous calls 
    ///          WPD_PROPERTY_MTP_EXT_TRANSFER_NUM_BYTES_TO_WRITE: [VT_UI4] specifies the next number of bytes to write.
    ///          WPD_PROPERTY_MTP_EXT_TRANSFER_DATA: [VT_VECTOR|VT_UI1] specifies the buffer which contains the data to send to device 
    /// Outputs: WPD_PROPERTY_MTP_EXT_TRANSFER_NUM_BYTES_WRITTEN: [VT_UI4] returns actual number of bytes (no overhead) sent to device in a write call 
    ///
    let WPD_COMMAND_MTP_EXT_WRITE_DATA = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 16u)
    
    ///
    /// Cmd Key: WPD_COMMAND_MTP_EXT_END_DATA_TRANSFER 
    /// Usage:   completes a data transfer and read response from device. The transfer is initiated by either 
    ///              WPD_COMMAND_MTP_EXT_EXECUTE_COMMAND_WITH_DATA_TO_READ, or WPD_COMMAND_MTP_EXT_EXECUTE_COMMAND_WITH_DATA_TO_WRITE
    /// Inputs:  WPD_PROPERTY_MTP_EXT_TRANSFER_CONTEXT: [VT_LPWSTR] The context idetifier returned in previous calls 
    /// Outputs: WPD_PROPERTY_MTP_EXT_RESPONSE_CODE: [VT_UI4] the response code to the vendor operation code, and 
    ///          WPD_PROPERTY_MTP_EXT_RESPONSE_PARAMS: An IPortableDevicePropVariantCollection (of VT_UI4) identifying response params if any (could be empty)
    ///
    let WPD_COMMAND_MTP_EXT_END_DATA_TRANSFER = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 17u)
    
    ///
    /// Cmd Key: WPD_COMMAND_MTP_EXT_GET_VENDOR_EXTENSION_DESCRIPTION
    /// Usage:   retrieves the vendor extension description string (as defined by DeviceInfo dataset)
    /// Inputs:  None
    /// Outputs: WPD_PROPERTY_MTP_EXT_VENDOR_EXTENSION_DESCRIPTION: [VT_LPWSTR] contains the vendor extension description string
    let WPD_COMMAND_MTP_EXT_GET_VENDOR_EXTENSION_DESCRIPTION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 18u)
    
    /// Command Parameters 
    /// [ VT_UI4 ] : Input param which identifies the vendor-extended MTP operation code
    let WPD_PROPERTY_MTP_EXT_OPERATION_CODE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 1001u)
    
    /// [ VT_UNKNOWN ] : Input IPortableDevicePropVariantCollection (of VT_UI4) specifying the params for the vendor operation
    let WPD_PROPERTY_MTP_EXT_OPERATION_PARAMS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 1002u)
    
    /// [ VT_UI4 ] : Output param which identifies the response code for the vendor operation
    let WPD_PROPERTY_MTP_EXT_RESPONSE_CODE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 1003u)
    
    /// [ VT_UNKNOWN ] : Returns an IPortableDevicePropVariantCollection (of VT_UI4) of response params for the vendor operation
    let WPD_PROPERTY_MTP_EXT_RESPONSE_PARAMS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 1004u)
    
    /// [ VT_UNKNOWN ] : Returns an IPortableDevicePropVariantCollection (of VT_UI4) of Vendor-extended MTP codes
    let WPD_PROPERTY_MTP_EXT_VENDOR_OPERATION_CODES = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 1005u)
    
    /// [ VT_LPWSTR ] : Returned as a context idetifier (a string value) for subsequent data transfer
    let WPD_PROPERTY_MTP_EXT_TRANSFER_CONTEXT = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 1006u)
    
    /// [ VT_UI8 ] : Input (when writing data) or output (when reading data) param which specifies total data size in bytes (excluding any overhead)
    let WPD_PROPERTY_MTP_EXT_TRANSFER_TOTAL_DATA_SIZE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 1007u)
    
    /// [ VT_UI4 ] : Input param specifying the number of bytes to read from device in a series of read calls
    let WPD_PROPERTY_MTP_EXT_TRANSFER_NUM_BYTES_TO_READ = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 1008u)
    
    /// [ VT_UI4 ] : Output param specifying the actual number of bytes (no overhead) received from device in a read call
    let WPD_PROPERTY_MTP_EXT_TRANSFER_NUM_BYTES_READ = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 1009u)
    
    /// [ VT_UI4 ] : Input specifying the number of bytes to send to device in a series of write calls
    let WPD_PROPERTY_MTP_EXT_TRANSFER_NUM_BYTES_TO_WRITE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 1010u)
    
    /// [ VT_UI4 ] : Returns the actual number of bytes (no overhead) sent to device in a write call
    let WPD_PROPERTY_MTP_EXT_TRANSFER_NUM_BYTES_WRITTEN = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 1011u)
    
    /// [ VT_VECTOR|VT_UI1 ] : Stores the binary data to transfer from/to device
    let WPD_PROPERTY_MTP_EXT_TRANSFER_DATA = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 1012u)
    
    /// [ VT_UI4 ] : Returns the optimal size of the transfer buffer
    let WPD_PROPERTY_MTP_EXT_OPTIMAL_TRANSFER_BUFFER_SIZE = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 1013u)
    
    /// [ VT_LPWSTR ] : Returns vendor extension description string
    let WPD_PROPERTY_MTP_EXT_VENDOR_EXTENSION_DESCRIPTION = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_CATEGORY_MTP_EXT_VENDOR_OPERATIONS, pid = 1014u)
    
    //// 
    //// This section defines the GUID for MTP Vendor-extended object properties 
    ////
    ///
    /// Microsoft MTP driver combines this GUID and any vendor-extended MTP object property code (as pid) 
    /// to construct a WPD PROPERTYKEY, which is reported to WPD applications as a WPD property.
    /// For example, vendor extended object prop code, 0xD801, will be reported as WPD PROPERTYKEY:
    /// 	{4D545058-4FCE-4578-95C8-8698A9BC0F49}\D801
    ///
    let WPD_PROPERTIES_MTP_VENDOR_EXTENDED_OBJECT_PROPS = new System.Guid(0x4d545058u, 0x4fceus, 0x4578us, 0x95uy, 0xc8uy, 0x86uy, 0x98uy, 0xa9uy, 0xbcuy, 0xfuy, 0x49uy)
    
    //// 
    //// This section defines the GUID for MTP Vendor-extended device properties 
    ////
    ///
    /// Microsoft MTP driver combines this GUID and any vendor-extended MTP device property code (as pid) 
    /// to construct a WPD PROPERTYKEY, which is reported to WPD applications as a WPD property.
    /// For example, vendor extended device prop code, 0xD001, will be reported as WPD PROPERTYKEY:
    /// 	{4D545058-8900-40b3-8F1D-DC246E1E8370}\D001
    ///
    let WPD_PROPERTIES_MTP_VENDOR_EXTENDED_DEVICE_PROPS = new System.Guid(0x4d545058u, 0x8900us, 0x40b3us, 0x8fuy, 0x1duy, 0xdcuy, 0x24uy, 0x6euy, 0x1euy, 0x83uy, 0x70uy)
    
    //// 
    //// This section defines the mapping between WPD event GUIDs and MTP Vendor-extended event codes
    ////
    ///
    /// For a MTP vendor-extended event to work with WPD, Microsoft MTP driver creates a new WPD event GUID by 
    /// replacing the highest 16 bits of WPD_EVENT_MTP_VENDOR_EXTENDED_EVENTS with the vendor event code (UINT16).
    /// For example, vendor-extended event code, 0xC001, will be reported as WPD event GUID:
    ///	{C0010000-5738-4ff2-8445-BE3126691059}
    ///
    let WPD_EVENT_MTP_VENDOR_EXTENDED_EVENTS = new System.Guid(0x00000000u, 0x5738us, 0x4ff2us, 0x84uy, 0x45uy, 0xbeuy, 0x31uy, 0x26uy, 0x69uy, 0x10uy, 0x59uy)
    
    //// Category placeholder for WPD_PROPERTY_MTP_EXT_EVENT_PARAMS
    let WPD_PROPERTY_MTP_EXT_EVENT_PARAMS_Guid = new System.Guid(0x4d545058u, 0xef88us, 0x4e4dus, 0x95uy, 0xc3uy, 0x4fuy, 0x32uy, 0x7fuy, 0x72uy, 0x8auy, 0x96uy)
    
    //// 
    //// This section defines the WPD property key for event parameters of a vendor-extended event
    ////
    ///
    /// Microsoft MTP driver reports a vendor-extended event to WPD with:
    ///      WPD_EVENT_PARAMETER_EVENT_ID: the WPD event GUID defined above; and 
    ///      WPD_PROPERTY_MTP_EXT_EVENT_PARAMS: a collection of PROPVARIANTs which map to parameters of the event.
    /// If there is no parameters for the event, the collection will be empty.
    ///
    ///	{4D545058-EF88-4e4d-95C3-4F327F728A96}
    /// [ VT_UNKNOWN ] : Returns an IPortableDevicePropVariantCollection (of VT_UI4) of event params for a vendor-extended event
    let WPD_PROPERTY_MTP_EXT_EVENT_PARAMS = new PortableDeviceApiLib._tagpropertykey(fmtid = WPD_PROPERTY_MTP_EXT_EVENT_PARAMS_Guid, pid = 1011u)
