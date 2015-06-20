namespace PortableDevices

module PDHeaderUtils = 
    open PortableDevices.PDHeader
    
    let (|MatchGuids|) (guid1 : System.Guid) (guid2 : System.Guid) = guid1.CompareTo(guid2) = 0
    
    let GetPropertyName guid pv = 
        match guid with
        | MatchGuids WPD_CATEGORY_NULL true -> 
            let guidName = "WPD_CATEGORY_NULL"
            match pv with
            | 0u -> (guidName, "WPD_PROPERTY_NULL")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_OBJECT_PROPERTIES_V1 true -> 
            let guidName = "WPD_OBJECT_PROPERTIES_V1"
            match pv with
            | 2u -> (guidName, "WPD_OBJECT_ID")
            | 3u -> (guidName, "WPD_OBJECT_PARENT_ID")
            | 4u -> (guidName, "WPD_OBJECT_NAME")
            | 5u -> (guidName, "WPD_OBJECT_PERSISTENT_UNIQUE_ID")
            | 6u -> (guidName, "WPD_OBJECT_FORMAT")
            | 7u -> (guidName, "WPD_OBJECT_CONTENT_TYPE")
            | 9u -> (guidName, "WPD_OBJECT_ISHIDDEN")
            | 10u -> (guidName, "WPD_OBJECT_ISSYSTEM")
            | 11u -> (guidName, "WPD_OBJECT_SIZE")
            | 12u -> (guidName, "WPD_OBJECT_ORIGINAL_FILE_NAME")
            | 13u -> (guidName, "WPD_OBJECT_NON_CONSUMABLE")
            | 14u -> (guidName, "WPD_OBJECT_REFERENCES")
            | 15u -> (guidName, "WPD_OBJECT_KEYWORDS")
            | 16u -> (guidName, "WPD_OBJECT_SYNC_ID")
            | 17u -> (guidName, "WPD_OBJECT_IS_DRM_PROTECTED")
            | 18u -> (guidName, "WPD_OBJECT_DATE_CREATED")
            | 19u -> (guidName, "WPD_OBJECT_DATE_MODIFIED")
            | 20u -> (guidName, "WPD_OBJECT_DATE_AUTHORED")
            | 21u -> (guidName, "WPD_OBJECT_BACK_REFERENCES")
            | 23u -> (guidName, "WPD_OBJECT_CONTAINER_FUNCTIONAL_OBJECT_ID")
            | 24u -> (guidName, "WPD_OBJECT_GENERATE_THUMBNAIL_FROM_RESOURCE")
            | 25u -> (guidName, "WPD_OBJECT_HINT_LOCATION_DISPLAY_NAME")
            | 26u -> (guidName, "WPD_OBJECT_CAN_DELETE")
            | 27u -> (guidName, "WPD_OBJECT_LANGUAGE_LOCALE")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_OBJECT_PROPERTIES_V2 true -> 
            let guidName = "WPD_OBJECT_PROPERTIES_V2"
            match pv with
            | 2u -> (guidName, "WPD_OBJECT_SUPPORTED_UNITS")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_FUNCTIONAL_OBJECT_PROPERTIES_V1 true -> 
            let guidName = "WPD_FUNCTIONAL_OBJECT_PROPERTIES_V1"
            match pv with
            | 2u -> (guidName, "WPD_FUNCTIONAL_OBJECT_CATEGORY")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_STORAGE_OBJECT_PROPERTIES_V1 true -> 
            let guidName = "WPD_STORAGE_OBJECT_PROPERTIES_V1"
            match pv with
            | 2u -> (guidName, "WPD_STORAGE_TYPE")
            | 3u -> (guidName, "WPD_STORAGE_FILE_SYSTEM_TYPE")
            | 4u -> (guidName, "WPD_STORAGE_CAPACITY")
            | 5u -> (guidName, "WPD_STORAGE_FREE_SPACE_IN_BYTES")
            | 6u -> (guidName, "WPD_STORAGE_FREE_SPACE_IN_OBJECTS")
            | 7u -> (guidName, "WPD_STORAGE_DESCRIPTION")
            | 8u -> (guidName, "WPD_STORAGE_SERIAL_NUMBER")
            | 9u -> (guidName, "WPD_STORAGE_MAX_OBJECT_SIZE")
            | 10u -> (guidName, "WPD_STORAGE_CAPACITY_IN_OBJECTS")
            | 11u -> (guidName, "WPD_STORAGE_ACCESS_CAPABILITY")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_NETWORK_ASSOCIATION_PROPERTIES_V1 true -> 
            let guidName = "WPD_NETWORK_ASSOCIATION_PROPERTIES_V1"
            match pv with
            | 2u -> (guidName, "WPD_NETWORK_ASSOCIATION_HOST_NETWORK_IDENTIFIERS")
            | 3u -> (guidName, "WPD_NETWORK_ASSOCIATION_X509V3SEQUENCE")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1 true -> 
            let guidName = "WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1"
            match pv with
            | 2u -> (guidName, "WPD_STILL_IMAGE_CAPTURE_RESOLUTION")
            | 3u -> (guidName, "WPD_STILL_IMAGE_CAPTURE_FORMAT")
            | 4u -> (guidName, "WPD_STILL_IMAGE_COMPRESSION_SETTING")
            | 5u -> (guidName, "WPD_STILL_IMAGE_WHITE_BALANCE")
            | 6u -> (guidName, "WPD_STILL_IMAGE_RGB_GAIN")
            | 7u -> (guidName, "WPD_STILL_IMAGE_FNUMBER")
            | 8u -> (guidName, "WPD_STILL_IMAGE_FOCAL_LENGTH")
            | 9u -> (guidName, "WPD_STILL_IMAGE_FOCUS_DISTANCE")
            | 10u -> (guidName, "WPD_STILL_IMAGE_FOCUS_MODE")
            | 11u -> (guidName, "WPD_STILL_IMAGE_EXPOSURE_METERING_MODE")
            | 12u -> (guidName, "WPD_STILL_IMAGE_FLASH_MODE")
            | 13u -> (guidName, "WPD_STILL_IMAGE_EXPOSURE_TIME")
            | 14u -> (guidName, "WPD_STILL_IMAGE_EXPOSURE_PROGRAM_MODE")
            | 15u -> (guidName, "WPD_STILL_IMAGE_EXPOSURE_INDEX")
            | 16u -> (guidName, "WPD_STILL_IMAGE_EXPOSURE_BIAS_COMPENSATION")
            | 17u -> (guidName, "WPD_STILL_IMAGE_CAPTURE_DELAY")
            | 18u -> (guidName, "WPD_STILL_IMAGE_CAPTURE_MODE")
            | 19u -> (guidName, "WPD_STILL_IMAGE_CONTRAST")
            | 20u -> (guidName, "WPD_STILL_IMAGE_SHARPNESS")
            | 21u -> (guidName, "WPD_STILL_IMAGE_DIGITAL_ZOOM")
            | 22u -> (guidName, "WPD_STILL_IMAGE_EFFECT_MODE")
            | 23u -> (guidName, "WPD_STILL_IMAGE_BURST_NUMBER")
            | 24u -> (guidName, "WPD_STILL_IMAGE_BURST_INTERVAL")
            | 25u -> (guidName, "WPD_STILL_IMAGE_TIMELAPSE_NUMBER")
            | 26u -> (guidName, "WPD_STILL_IMAGE_TIMELAPSE_INTERVAL")
            | 27u -> (guidName, "WPD_STILL_IMAGE_FOCUS_METERING_MODE")
            | 28u -> (guidName, "WPD_STILL_IMAGE_UPLOAD_URL")
            | 29u -> (guidName, "WPD_STILL_IMAGE_ARTIST")
            | 30u -> (guidName, "WPD_STILL_IMAGE_CAMERA_MODEL")
            | 31u -> (guidName, "WPD_STILL_IMAGE_CAMERA_MANUFACTURER")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_RENDERING_INFORMATION_OBJECT_PROPERTIES_V1 true -> 
            let guidName = "WPD_RENDERING_INFORMATION_OBJECT_PROPERTIES_V1"
            match pv with
            | 2u -> (guidName, "WPD_RENDERING_INFORMATION_PROFILES")
            | 3u -> (guidName, "WPD_RENDERING_INFORMATION_PROFILE_ENTRY_TYPE")
            | 4u -> (guidName, "WPD_RENDERING_INFORMATION_PROFILE_ENTRY_CREATABLE_RESOURCES")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CLIENT_INFORMATION_PROPERTIES_V1 true -> 
            let guidName = "WPD_CLIENT_INFORMATION_PROPERTIES_V1"
            match pv with
            | 2u -> (guidName, "WPD_CLIENT_NAME")
            | 3u -> (guidName, "WPD_CLIENT_MAJOR_VERSION")
            | 4u -> (guidName, "WPD_CLIENT_MINOR_VERSION")
            | 5u -> (guidName, "WPD_CLIENT_REVISION")
            | 6u -> (guidName, "WPD_CLIENT_WMDRM_APPLICATION_PRIVATE_KEY")
            | 7u -> (guidName, "WPD_CLIENT_WMDRM_APPLICATION_CERTIFICATE")
            | 8u -> (guidName, "WPD_CLIENT_SECURITY_QUALITY_OF_SERVICE")
            | 9u -> (guidName, "WPD_CLIENT_DESIRED_ACCESS")
            | 10u -> (guidName, "WPD_CLIENT_SHARE_MODE")
            | 11u -> (guidName, "WPD_CLIENT_EVENT_COOKIE")
            | 12u -> (guidName, "WPD_CLIENT_MINIMUM_RESULTS_BUFFER_SIZE")
            | 13u -> (guidName, "WPD_CLIENT_MANUAL_CLOSE_ON_DISCONNECT")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_PROPERTY_ATTRIBUTES_V1 true -> 
            let guidName = "WPD_PROPERTY_ATTRIBUTES_V1"
            match pv with
            | 2u -> (guidName, "WPD_PROPERTY_ATTRIBUTE_FORM")
            | 3u -> (guidName, "WPD_PROPERTY_ATTRIBUTE_CAN_READ")
            | 4u -> (guidName, "WPD_PROPERTY_ATTRIBUTE_CAN_WRITE")
            | 5u -> (guidName, "WPD_PROPERTY_ATTRIBUTE_CAN_DELETE")
            | 6u -> (guidName, "WPD_PROPERTY_ATTRIBUTE_DEFAULT_VALUE")
            | 7u -> (guidName, "WPD_PROPERTY_ATTRIBUTE_FAST_PROPERTY")
            | 8u -> (guidName, "WPD_PROPERTY_ATTRIBUTE_RANGE_MIN")
            | 9u -> (guidName, "WPD_PROPERTY_ATTRIBUTE_RANGE_MAX")
            | 10u -> (guidName, "WPD_PROPERTY_ATTRIBUTE_RANGE_STEP")
            | 11u -> (guidName, "WPD_PROPERTY_ATTRIBUTE_ENUMERATION_ELEMENTS")
            | 12u -> (guidName, "WPD_PROPERTY_ATTRIBUTE_REGULAR_EXPRESSION")
            | 13u -> (guidName, "WPD_PROPERTY_ATTRIBUTE_MAX_SIZE")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_PROPERTY_ATTRIBUTES_V2 true -> 
            let guidName = "WPD_PROPERTY_ATTRIBUTES_V2"
            match pv with
            | 2u -> (guidName, "WPD_PROPERTY_ATTRIBUTE_NAME")
            | 3u -> (guidName, "WPD_PROPERTY_ATTRIBUTE_VARTYPE")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CLASS_EXTENSION_OPTIONS_V1 true -> 
            let guidName = "WPD_CLASS_EXTENSION_OPTIONS_V1"
            match pv with
            | 2u -> (guidName, "WPD_CLASS_EXTENSION_OPTIONS_SUPPORTED_CONTENT_TYPES")
            | 3u -> (guidName, "WPD_CLASS_EXTENSION_OPTIONS_DONT_REGISTER_WPD_DEVICE_INTERFACE")
            | 4u -> (guidName, "WPD_CLASS_EXTENSION_OPTIONS_REGISTER_WPD_PRIVATE_DEVICE_INTERFACE")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CLASS_EXTENSION_OPTIONS_V2 true -> 
            let guidName = "WPD_CLASS_EXTENSION_OPTIONS_V2"
            match pv with
            | 2u -> (guidName, "WPD_CLASS_EXTENSION_OPTIONS_MULTITRANSPORT_MODE")
            | 3u -> (guidName, "WPD_CLASS_EXTENSION_OPTIONS_DEVICE_IDENTIFICATION_VALUES")
            | 4u -> (guidName, "WPD_CLASS_EXTENSION_OPTIONS_TRANSPORT_BANDWIDTH")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CLASS_EXTENSION_OPTIONS_V3 true -> 
            let guidName = "WPD_CLASS_EXTENSION_OPTIONS_V3"
            match pv with
            | 2u -> (guidName, "WPD_CLASS_EXTENSION_OPTIONS_SILENCE_AUTOPLAY")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_RESOURCE_ATTRIBUTES_V1 true -> 
            let guidName = "WPD_RESOURCE_ATTRIBUTES_V1"
            match pv with
            | 2u -> (guidName, "WPD_RESOURCE_ATTRIBUTE_TOTAL_SIZE")
            | 3u -> (guidName, "WPD_RESOURCE_ATTRIBUTE_CAN_READ")
            | 4u -> (guidName, "WPD_RESOURCE_ATTRIBUTE_CAN_WRITE")
            | 5u -> (guidName, "WPD_RESOURCE_ATTRIBUTE_CAN_DELETE")
            | 6u -> (guidName, "WPD_RESOURCE_ATTRIBUTE_OPTIMAL_READ_BUFFER_SIZE")
            | 7u -> (guidName, "WPD_RESOURCE_ATTRIBUTE_OPTIMAL_WRITE_BUFFER_SIZE")
            | 8u -> (guidName, "WPD_RESOURCE_ATTRIBUTE_FORMAT")
            | 9u -> (guidName, "WPD_RESOURCE_ATTRIBUTE_RESOURCE_KEY")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_DEVICE_PROPERTIES_V1 true -> 
            let guidName = "WPD_DEVICE_PROPERTIES_V1"
            match pv with
            | 2u -> (guidName, "WPD_DEVICE_SYNC_PARTNER")
            | 3u -> (guidName, "WPD_DEVICE_FIRMWARE_VERSION")
            | 4u -> (guidName, "WPD_DEVICE_POWER_LEVEL")
            | 5u -> (guidName, "WPD_DEVICE_POWER_SOURCE")
            | 6u -> (guidName, "WPD_DEVICE_PROTOCOL")
            | 7u -> (guidName, "WPD_DEVICE_MANUFACTURER")
            | 8u -> (guidName, "WPD_DEVICE_MODEL")
            | 9u -> (guidName, "WPD_DEVICE_SERIAL_NUMBER")
            | 10u -> (guidName, "WPD_DEVICE_SUPPORTS_NON_CONSUMABLE")
            | 11u -> (guidName, "WPD_DEVICE_DATETIME")
            | 12u -> (guidName, "WPD_DEVICE_FRIENDLY_NAME")
            | 13u -> (guidName, "WPD_DEVICE_SUPPORTED_DRM_SCHEMES")
            | 14u -> (guidName, "WPD_DEVICE_SUPPORTED_FORMATS_ARE_ORDERED")
            | 15u -> (guidName, "WPD_DEVICE_TYPE")
            | 16u -> (guidName, "WPD_DEVICE_NETWORK_IDENTIFIER")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_DEVICE_PROPERTIES_V2 true -> 
            let guidName = "WPD_DEVICE_PROPERTIES_V2"
            match pv with
            | 2u -> (guidName, "WPD_DEVICE_FUNCTIONAL_UNIQUE_ID")
            | 3u -> (guidName, "WPD_DEVICE_MODEL_UNIQUE_ID")
            | 4u -> (guidName, "WPD_DEVICE_TRANSPORT")
            | 5u -> (guidName, "WPD_DEVICE_USE_DEVICE_STAGE")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_SERVICE_PROPERTIES_V1 true -> 
            let guidName = "WPD_SERVICE_PROPERTIES_V1"
            match pv with
            | 2u -> (guidName, "WPD_SERVICE_VERSION")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_EVENT_PROPERTIES_V1 true -> 
            let guidName = "WPD_EVENT_PROPERTIES_V1"
            match pv with
            | 2u -> (guidName, "WPD_EVENT_PARAMETER_PNP_DEVICE_ID")
            | 3u -> (guidName, "WPD_EVENT_PARAMETER_EVENT_ID")
            | 4u -> (guidName, "WPD_EVENT_PARAMETER_OPERATION_STATE")
            | 5u -> (guidName, "WPD_EVENT_PARAMETER_OPERATION_PROGRESS")
            | 6u -> (guidName, "WPD_EVENT_PARAMETER_OBJECT_PARENT_PERSISTENT_UNIQUE_ID")
            | 7u -> (guidName, "WPD_EVENT_PARAMETER_OBJECT_CREATION_COOKIE")
            | 8u -> (guidName, "WPD_EVENT_PARAMETER_CHILD_HIERARCHY_CHANGED")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_EVENT_PROPERTIES_V2 true -> 
            let guidName = "WPD_EVENT_PROPERTIES_V2"
            match pv with
            | 2u -> (guidName, "WPD_EVENT_PARAMETER_SERVICE_METHOD_CONTEXT")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_EVENT_OPTIONS_V1 true -> 
            let guidName = "WPD_EVENT_OPTIONS_V1"
            match pv with
            | 2u -> (guidName, "WPD_EVENT_OPTION_IS_BROADCAST_EVENT")
            | 3u -> (guidName, "WPD_EVENT_OPTION_IS_AUTOPLAY_EVENT")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_EVENT_ATTRIBUTES_V1 true -> 
            let guidName = "WPD_EVENT_ATTRIBUTES_V1"
            match pv with
            | 2u -> (guidName, "WPD_EVENT_ATTRIBUTE_NAME")
            | 3u -> (guidName, "WPD_EVENT_ATTRIBUTE_PARAMETERS")
            | 4u -> (guidName, "WPD_EVENT_ATTRIBUTE_OPTIONS")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_API_OPTIONS_V1 true -> 
            let guidName = "WPD_API_OPTIONS_V1"
            match pv with
            | 2u -> (guidName, "WPD_API_OPTION_USE_CLEAR_DATA_STREAM")
            | 3u -> (guidName, "WPD_API_OPTION_IOCTL_ACCESS")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_FORMAT_ATTRIBUTES_V1 true -> 
            let guidName = "WPD_FORMAT_ATTRIBUTES_V1"
            match pv with
            | 2u -> (guidName, "WPD_FORMAT_ATTRIBUTE_NAME")
            | 3u -> (guidName, "WPD_FORMAT_ATTRIBUTE_MIMETYPE")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_METHOD_ATTRIBUTES_V1 true -> 
            let guidName = "WPD_METHOD_ATTRIBUTES_V1"
            match pv with
            | 2u -> (guidName, "WPD_METHOD_ATTRIBUTE_NAME")
            | 3u -> (guidName, "WPD_METHOD_ATTRIBUTE_ASSOCIATED_FORMAT")
            | 4u -> (guidName, "WPD_METHOD_ATTRIBUTE_ACCESS")
            | 5u -> (guidName, "WPD_METHOD_ATTRIBUTE_PARAMETERS")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_PARAMETER_ATTRIBUTES_V1 true -> 
            let guidName = "WPD_PARAMETER_ATTRIBUTES_V1"
            match pv with
            | 2u -> (guidName, "WPD_PARAMETER_ATTRIBUTE_ORDER")
            | 3u -> (guidName, "WPD_PARAMETER_ATTRIBUTE_USAGE")
            | 4u -> (guidName, "WPD_PARAMETER_ATTRIBUTE_FORM")
            | 5u -> (guidName, "WPD_PARAMETER_ATTRIBUTE_DEFAULT_VALUE")
            | 6u -> (guidName, "WPD_PARAMETER_ATTRIBUTE_RANGE_MIN")
            | 7u -> (guidName, "WPD_PARAMETER_ATTRIBUTE_RANGE_MAX")
            | 8u -> (guidName, "WPD_PARAMETER_ATTRIBUTE_RANGE_STEP")
            | 9u -> (guidName, "WPD_PARAMETER_ATTRIBUTE_ENUMERATION_ELEMENTS")
            | 10u -> (guidName, "WPD_PARAMETER_ATTRIBUTE_REGULAR_EXPRESSION")
            | 11u -> (guidName, "WPD_PARAMETER_ATTRIBUTE_MAX_SIZE")
            | 12u -> (guidName, "WPD_PARAMETER_ATTRIBUTE_VARTYPE")
            | 13u -> (guidName, "WPD_PARAMETER_ATTRIBUTE_NAME")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CATEGORY_COMMON true -> 
            let guidName = "WPD_CATEGORY_COMMON"
            match pv with
            | 2u -> (guidName, "WPD_COMMAND_COMMON_RESET_DEVICE")
            | 3u -> (guidName, "WPD_COMMAND_COMMON_GET_OBJECT_IDS_FROM_PERSISTENT_UNIQUE_IDS")
            | 4u -> (guidName, "WPD_COMMAND_COMMON_SAVE_CLIENT_INFORMATION")
            | 1001u -> (guidName, "WPD_PROPERTY_COMMON_COMMAND_CATEGORY")
            | 1002u -> (guidName, "WPD_PROPERTY_COMMON_COMMAND_ID")
            | 1003u -> (guidName, "WPD_PROPERTY_COMMON_HRESULT")
            | 1004u -> (guidName, "WPD_PROPERTY_COMMON_DRIVER_ERROR_CODE")
            | 1006u -> (guidName, "WPD_PROPERTY_COMMON_COMMAND_TARGET")
            | 1007u -> (guidName, "WPD_PROPERTY_COMMON_PERSISTENT_UNIQUE_IDS")
            | 1008u -> (guidName, "WPD_PROPERTY_COMMON_OBJECT_IDS")
            | 1009u -> (guidName, "WPD_PROPERTY_COMMON_CLIENT_INFORMATION")
            | 1010u -> (guidName, "WPD_PROPERTY_COMMON_CLIENT_INFORMATION_CONTEXT")
            | 1011u -> (guidName, "WPD_PROPERTY_COMMON_ACTIVITY_ID")
            | 5001u -> (guidName, "WPD_OPTION_VALID_OBJECT_IDS")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CATEGORY_OBJECT_ENUMERATION true -> 
            let guidName = "WPD_CATEGORY_OBJECT_ENUMERATION"
            match pv with
            | 2u -> (guidName, "WPD_COMMAND_OBJECT_ENUMERATION_START_FIND")
            | 3u -> (guidName, "WPD_COMMAND_OBJECT_ENUMERATION_FIND_NEXT")
            | 4u -> (guidName, "WPD_COMMAND_OBJECT_ENUMERATION_END_FIND")
            | 1001u -> (guidName, "WPD_PROPERTY_OBJECT_ENUMERATION_PARENT_ID")
            | 1002u -> (guidName, "WPD_PROPERTY_OBJECT_ENUMERATION_FILTER")
            | 1003u -> (guidName, "WPD_PROPERTY_OBJECT_ENUMERATION_OBJECT_IDS")
            | 1004u -> (guidName, "WPD_PROPERTY_OBJECT_ENUMERATION_CONTEXT")
            | 1005u -> (guidName, "WPD_PROPERTY_OBJECT_ENUMERATION_NUM_OBJECTS_REQUESTED")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CATEGORY_OBJECT_PROPERTIES true -> 
            let guidName = "WPD_CATEGORY_OBJECT_PROPERTIES"
            match pv with
            | 2u -> (guidName, "WPD_COMMAND_OBJECT_PROPERTIES_GET_SUPPORTED")
            | 3u -> (guidName, "WPD_COMMAND_OBJECT_PROPERTIES_GET_ATTRIBUTES")
            | 4u -> (guidName, "WPD_COMMAND_OBJECT_PROPERTIES_GET")
            | 5u -> (guidName, "WPD_COMMAND_OBJECT_PROPERTIES_SET")
            | 6u -> (guidName, "WPD_COMMAND_OBJECT_PROPERTIES_GET_ALL")
            | 7u -> (guidName, "WPD_COMMAND_OBJECT_PROPERTIES_DELETE")
            | 1001u -> (guidName, "WPD_PROPERTY_OBJECT_PROPERTIES_OBJECT_ID")
            | 1002u -> (guidName, "WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_KEYS")
            | 1003u -> (guidName, "WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_ATTRIBUTES")
            | 1004u -> (guidName, "WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_VALUES")
            | 1005u -> (guidName, "WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_WRITE_RESULTS")
            | 1006u -> (guidName, "WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_DELETE_RESULTS")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CATEGORY_OBJECT_PROPERTIES_BULK true -> 
            let guidName = "WPD_CATEGORY_OBJECT_PROPERTIES_BULK"
            match pv with
            | 2u -> (guidName, "WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_LIST_START")
            | 3u -> (guidName, "WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_LIST_NEXT")
            | 4u -> (guidName, "WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_LIST_END")
            | 5u -> (guidName, "WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_FORMAT_START")
            | 6u -> (guidName, "WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_FORMAT_NEXT")
            | 7u -> (guidName, "WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_FORMAT_END")
            | 8u -> (guidName, "WPD_COMMAND_OBJECT_PROPERTIES_BULK_SET_VALUES_BY_OBJECT_LIST_START")
            | 9u -> (guidName, "WPD_COMMAND_OBJECT_PROPERTIES_BULK_SET_VALUES_BY_OBJECT_LIST_NEXT")
            | 10u -> (guidName, "WPD_COMMAND_OBJECT_PROPERTIES_BULK_SET_VALUES_BY_OBJECT_LIST_END")
            | 1001u -> (guidName, "WPD_PROPERTY_OBJECT_PROPERTIES_BULK_OBJECT_IDS")
            | 1002u -> (guidName, "WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT")
            | 1003u -> (guidName, "WPD_PROPERTY_OBJECT_PROPERTIES_BULK_VALUES")
            | 1004u -> (guidName, "WPD_PROPERTY_OBJECT_PROPERTIES_BULK_PROPERTY_KEYS")
            | 1005u -> (guidName, "WPD_PROPERTY_OBJECT_PROPERTIES_BULK_DEPTH")
            | 1006u -> (guidName, "WPD_PROPERTY_OBJECT_PROPERTIES_BULK_PARENT_OBJECT_ID")
            | 1007u -> (guidName, "WPD_PROPERTY_OBJECT_PROPERTIES_BULK_OBJECT_FORMAT")
            | 1008u -> (guidName, "WPD_PROPERTY_OBJECT_PROPERTIES_BULK_WRITE_RESULTS")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CATEGORY_OBJECT_RESOURCES true -> 
            let guidName = "WPD_CATEGORY_OBJECT_RESOURCES"
            match pv with
            | 2u -> (guidName, "WPD_COMMAND_OBJECT_RESOURCES_GET_SUPPORTED")
            | 3u -> (guidName, "WPD_COMMAND_OBJECT_RESOURCES_GET_ATTRIBUTES")
            | 4u -> (guidName, "WPD_COMMAND_OBJECT_RESOURCES_OPEN")
            | 5u -> (guidName, "WPD_COMMAND_OBJECT_RESOURCES_READ")
            | 6u -> (guidName, "WPD_COMMAND_OBJECT_RESOURCES_WRITE")
            | 7u -> (guidName, "WPD_COMMAND_OBJECT_RESOURCES_CLOSE")
            | 8u -> (guidName, "WPD_COMMAND_OBJECT_RESOURCES_DELETE")
            | 9u -> (guidName, "WPD_COMMAND_OBJECT_RESOURCES_CREATE_RESOURCE")
            | 10u -> (guidName, "WPD_COMMAND_OBJECT_RESOURCES_REVERT")
            | 11u -> (guidName, "WPD_COMMAND_OBJECT_RESOURCES_SEEK")
            | 12u -> (guidName, "WPD_COMMAND_OBJECT_RESOURCES_COMMIT")
            | 13u -> (guidName, "WPD_COMMAND_OBJECT_RESOURCES_SEEK_IN_UNITS")
            | 1001u -> (guidName, "WPD_PROPERTY_OBJECT_RESOURCES_OBJECT_ID")
            | 1002u -> (guidName, "WPD_PROPERTY_OBJECT_RESOURCES_ACCESS_MODE")
            | 1003u -> (guidName, "WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_KEYS")
            | 1004u -> (guidName, "WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_ATTRIBUTES")
            | 1005u -> (guidName, "WPD_PROPERTY_OBJECT_RESOURCES_CONTEXT")
            | 1006u -> (guidName, "WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_TO_READ")
            | 1007u -> (guidName, "WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_READ")
            | 1008u -> (guidName, "WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_TO_WRITE")
            | 1009u -> (guidName, "WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_WRITTEN")
            | 1010u -> (guidName, "WPD_PROPERTY_OBJECT_RESOURCES_DATA")
            | 1011u -> (guidName, "WPD_PROPERTY_OBJECT_RESOURCES_OPTIMAL_TRANSFER_BUFFER_SIZE")
            | 1012u -> (guidName, "WPD_PROPERTY_OBJECT_RESOURCES_SEEK_OFFSET")
            | 1013u -> (guidName, "WPD_PROPERTY_OBJECT_RESOURCES_SEEK_ORIGIN_FLAG")
            | 1014u -> (guidName, "WPD_PROPERTY_OBJECT_RESOURCES_POSITION_FROM_START")
            | 1015u -> (guidName, "WPD_PROPERTY_OBJECT_RESOURCES_SUPPORTS_UNITS")
            | 1016u -> (guidName, "WPD_PROPERTY_OBJECT_RESOURCES_STREAM_UNITS")
            | 5001u -> (guidName, "WPD_OPTION_OBJECT_RESOURCES_SEEK_ON_READ_SUPPORTED")
            | 5002u -> (guidName, "WPD_OPTION_OBJECT_RESOURCES_SEEK_ON_WRITE_SUPPORTED")
            | 5003u -> (guidName, "WPD_OPTION_OBJECT_RESOURCES_NO_INPUT_BUFFER_ON_READ")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CATEGORY_OBJECT_MANAGEMENT true -> 
            let guidName = "WPD_CATEGORY_OBJECT_MANAGEMENT"
            match pv with
            | 2u -> (guidName, "WPD_COMMAND_OBJECT_MANAGEMENT_CREATE_OBJECT_WITH_PROPERTIES_ONLY")
            | 3u -> (guidName, "WPD_COMMAND_OBJECT_MANAGEMENT_CREATE_OBJECT_WITH_PROPERTIES_AND_DATA")
            | 4u -> (guidName, "WPD_COMMAND_OBJECT_MANAGEMENT_WRITE_OBJECT_DATA")
            | 5u -> (guidName, "WPD_COMMAND_OBJECT_MANAGEMENT_COMMIT_OBJECT")
            | 6u -> (guidName, "WPD_COMMAND_OBJECT_MANAGEMENT_REVERT_OBJECT")
            | 7u -> (guidName, "WPD_COMMAND_OBJECT_MANAGEMENT_DELETE_OBJECTS")
            | 8u -> (guidName, "WPD_COMMAND_OBJECT_MANAGEMENT_MOVE_OBJECTS")
            | 9u -> (guidName, "WPD_COMMAND_OBJECT_MANAGEMENT_COPY_OBJECTS")
            | 10u -> (guidName, "WPD_COMMAND_OBJECT_MANAGEMENT_UPDATE_OBJECT_WITH_PROPERTIES_AND_DATA")
            | 1001u -> (guidName, "WPD_PROPERTY_OBJECT_MANAGEMENT_CREATION_PROPERTIES")
            | 1002u -> (guidName, "WPD_PROPERTY_OBJECT_MANAGEMENT_CONTEXT")
            | 1003u -> (guidName, "WPD_PROPERTY_OBJECT_MANAGEMENT_NUM_BYTES_TO_WRITE")
            | 1004u -> (guidName, "WPD_PROPERTY_OBJECT_MANAGEMENT_NUM_BYTES_WRITTEN")
            | 1005u -> (guidName, "WPD_PROPERTY_OBJECT_MANAGEMENT_DATA")
            | 1006u -> (guidName, "WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_ID")
            | 1007u -> (guidName, "WPD_PROPERTY_OBJECT_MANAGEMENT_DELETE_OPTIONS")
            | 1008u -> (guidName, "WPD_PROPERTY_OBJECT_MANAGEMENT_OPTIMAL_TRANSFER_BUFFER_SIZE")
            | 1009u -> (guidName, "WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_IDS")
            | 1010u -> (guidName, "WPD_PROPERTY_OBJECT_MANAGEMENT_DELETE_RESULTS")
            | 1011u -> (guidName, "WPD_PROPERTY_OBJECT_MANAGEMENT_DESTINATION_FOLDER_OBJECT_ID")
            | 1012u -> (guidName, "WPD_PROPERTY_OBJECT_MANAGEMENT_MOVE_RESULTS")
            | 1013u -> (guidName, "WPD_PROPERTY_OBJECT_MANAGEMENT_COPY_RESULTS")
            | 1014u -> (guidName, "WPD_PROPERTY_OBJECT_MANAGEMENT_UPDATE_PROPERTIES")
            | 1015u -> (guidName, "WPD_PROPERTY_OBJECT_MANAGEMENT_PROPERTY_KEYS")
            | 1016u -> (guidName, "WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_FORMAT")
            | 5001u -> (guidName, "WPD_OPTION_OBJECT_MANAGEMENT_RECURSIVE_DELETE_SUPPORTED")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CATEGORY_CAPABILITIES true -> 
            let guidName = "WPD_CATEGORY_CAPABILITIES"
            match pv with
            | 2u -> (guidName, "WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_COMMANDS")
            | 3u -> (guidName, "WPD_COMMAND_CAPABILITIES_GET_COMMAND_OPTIONS")
            | 4u -> (guidName, "WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FUNCTIONAL_CATEGORIES")
            | 5u -> (guidName, "WPD_COMMAND_CAPABILITIES_GET_FUNCTIONAL_OBJECTS")
            | 6u -> (guidName, "WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_CONTENT_TYPES")
            | 7u -> (guidName, "WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FORMATS")
            | 8u -> (guidName, "WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FORMAT_PROPERTIES")
            | 9u -> (guidName, "WPD_COMMAND_CAPABILITIES_GET_FIXED_PROPERTY_ATTRIBUTES")
            | 10u -> (guidName, "WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_EVENTS")
            | 11u -> (guidName, "WPD_COMMAND_CAPABILITIES_GET_EVENT_OPTIONS")
            | 1001u -> (guidName, "WPD_PROPERTY_CAPABILITIES_SUPPORTED_COMMANDS")
            | 1002u -> (guidName, "WPD_PROPERTY_CAPABILITIES_COMMAND")
            | 1003u -> (guidName, "WPD_PROPERTY_CAPABILITIES_COMMAND_OPTIONS")
            | 1004u -> (guidName, "WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_CATEGORIES")
            | 1005u -> (guidName, "WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_CATEGORY")
            | 1006u -> (guidName, "WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_OBJECTS")
            | 1007u -> (guidName, "WPD_PROPERTY_CAPABILITIES_CONTENT_TYPES")
            | 1008u -> (guidName, "WPD_PROPERTY_CAPABILITIES_CONTENT_TYPE")
            | 1009u -> (guidName, "WPD_PROPERTY_CAPABILITIES_FORMATS")
            | 1010u -> (guidName, "WPD_PROPERTY_CAPABILITIES_FORMAT")
            | 1011u -> (guidName, "WPD_PROPERTY_CAPABILITIES_PROPERTY_KEYS")
            | 1012u -> (guidName, "WPD_PROPERTY_CAPABILITIES_PROPERTY_ATTRIBUTES")
            | 1013u -> (guidName, "WPD_PROPERTY_CAPABILITIES_SUPPORTED_EVENTS")
            | 1014u -> (guidName, "WPD_PROPERTY_CAPABILITIES_EVENT")
            | 1015u -> (guidName, "WPD_PROPERTY_CAPABILITIES_EVENT_OPTIONS")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CATEGORY_STORAGE true -> 
            let guidName = "WPD_CATEGORY_STORAGE"
            match pv with
            | 2u -> (guidName, "WPD_COMMAND_STORAGE_FORMAT")
            | 4u -> (guidName, "WPD_COMMAND_STORAGE_EJECT")
            | 1001u -> (guidName, "WPD_PROPERTY_STORAGE_OBJECT_ID")
            | 1002u -> (guidName, "WPD_PROPERTY_STORAGE_DESTINATION_OBJECT_ID")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CATEGORY_SMS true -> 
            let guidName = "WPD_CATEGORY_SMS"
            match pv with
            | 2u -> (guidName, "WPD_COMMAND_SMS_SEND")
            | 1001u -> (guidName, "WPD_PROPERTY_SMS_RECIPIENT")
            | 1002u -> (guidName, "WPD_PROPERTY_SMS_MESSAGE_TYPE")
            | 1003u -> (guidName, "WPD_PROPERTY_SMS_TEXT_MESSAGE")
            | 1004u -> (guidName, "WPD_PROPERTY_SMS_BINARY_MESSAGE")
            | 5001u -> (guidName, "WPD_OPTION_SMS_BINARY_MESSAGE_SUPPORTED")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CATEGORY_STILL_IMAGE_CAPTURE true -> 
            let guidName = "WPD_CATEGORY_STILL_IMAGE_CAPTURE"
            match pv with
            | 2u -> (guidName, "WPD_COMMAND_STILL_IMAGE_CAPTURE_INITIATE")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CATEGORY_MEDIA_CAPTURE true -> 
            let guidName = "WPD_CATEGORY_MEDIA_CAPTURE"
            match pv with
            | 2u -> (guidName, "WPD_COMMAND_MEDIA_CAPTURE_START")
            | 3u -> (guidName, "WPD_COMMAND_MEDIA_CAPTURE_STOP")
            | 4u -> (guidName, "WPD_COMMAND_MEDIA_CAPTURE_PAUSE")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CATEGORY_DEVICE_HINTS true -> 
            let guidName = "WPD_CATEGORY_DEVICE_HINTS"
            match pv with
            | 2u -> (guidName, "WPD_COMMAND_DEVICE_HINTS_GET_CONTENT_LOCATION")
            | 1001u -> (guidName, "WPD_PROPERTY_DEVICE_HINTS_CONTENT_TYPE")
            | 1002u -> (guidName, "WPD_PROPERTY_DEVICE_HINTS_CONTENT_LOCATIONS")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CLASS_EXTENSION_V1 true -> 
            let guidName = "WPD_CLASS_EXTENSION_V1"
            match pv with
            | 2u -> (guidName, "WPD_COMMAND_CLASS_EXTENSION_WRITE_DEVICE_INFORMATION")
            | 1001u -> (guidName, "WPD_PROPERTY_CLASS_EXTENSION_DEVICE_INFORMATION_VALUES")
            | 1002u -> (guidName, "WPD_PROPERTY_CLASS_EXTENSION_DEVICE_INFORMATION_WRITE_RESULTS")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CLASS_EXTENSION_V2 true -> 
            let guidName = "WPD_CLASS_EXTENSION_V2"
            match pv with
            | 2u -> (guidName, "WPD_COMMAND_CLASS_EXTENSION_REGISTER_SERVICE_INTERFACES")
            | 3u -> (guidName, "WPD_COMMAND_CLASS_EXTENSION_UNREGISTER_SERVICE_INTERFACES")
            | 1001u -> (guidName, "WPD_PROPERTY_CLASS_EXTENSION_SERVICE_OBJECT_ID")
            | 1002u -> (guidName, "WPD_PROPERTY_CLASS_EXTENSION_SERVICE_INTERFACES")
            | 1003u -> (guidName, "WPD_PROPERTY_CLASS_EXTENSION_SERVICE_REGISTRATION_RESULTS")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CATEGORY_NETWORK_CONFIGURATION true -> 
            let guidName = "WPD_CATEGORY_NETWORK_CONFIGURATION"
            match pv with
            | 2u -> (guidName, "WPD_COMMAND_GENERATE_KEYPAIR")
            | 3u -> (guidName, "WPD_COMMAND_COMMIT_KEYPAIR")
            | 4u -> (guidName, "WPD_COMMAND_PROCESS_WIRELESS_PROFILE")
            | 1001u -> (guidName, "WPD_PROPERTY_PUBLIC_KEY")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CATEGORY_SERVICE_COMMON true -> 
            let guidName = "WPD_CATEGORY_SERVICE_COMMON"
            match pv with
            | 2u -> (guidName, "WPD_COMMAND_SERVICE_COMMON_GET_SERVICE_OBJECT_ID")
            | 1001u -> (guidName, "WPD_PROPERTY_SERVICE_OBJECT_ID")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CATEGORY_SERVICE_CAPABILITIES true -> 
            let guidName = "WPD_CATEGORY_SERVICE_CAPABILITIES"
            match pv with
            | 2u -> (guidName, "WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_METHODS")
            | 3u -> (guidName, "WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_METHODS_BY_FORMAT")
            | 4u -> (guidName, "WPD_COMMAND_SERVICE_CAPABILITIES_GET_METHOD_ATTRIBUTES")
            | 5u -> (guidName, "WPD_COMMAND_SERVICE_CAPABILITIES_GET_METHOD_PARAMETER_ATTRIBUTES")
            | 6u -> (guidName, "WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_FORMATS")
            | 7u -> (guidName, "WPD_COMMAND_SERVICE_CAPABILITIES_GET_FORMAT_ATTRIBUTES")
            | 8u -> (guidName, "WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_FORMAT_PROPERTIES")
            | 9u -> (guidName, "WPD_COMMAND_SERVICE_CAPABILITIES_GET_FORMAT_PROPERTY_ATTRIBUTES")
            | 10u -> (guidName, "WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_EVENTS")
            | 11u -> (guidName, "WPD_COMMAND_SERVICE_CAPABILITIES_GET_EVENT_ATTRIBUTES")
            | 12u -> (guidName, "WPD_COMMAND_SERVICE_CAPABILITIES_GET_EVENT_PARAMETER_ATTRIBUTES")
            | 13u -> (guidName, "WPD_COMMAND_SERVICE_CAPABILITIES_GET_INHERITED_SERVICES")
            | 14u -> (guidName, "WPD_COMMAND_SERVICE_CAPABILITIES_GET_FORMAT_RENDERING_PROFILES")
            | 15u -> (guidName, "WPD_COMMAND_SERVICE_CAPABILITIES_GET_SUPPORTED_COMMANDS")
            | 16u -> (guidName, "WPD_COMMAND_SERVICE_CAPABILITIES_GET_COMMAND_OPTIONS")
            | 1001u -> (guidName, "WPD_PROPERTY_SERVICE_CAPABILITIES_SUPPORTED_METHODS")
            | 1002u -> (guidName, "WPD_PROPERTY_SERVICE_CAPABILITIES_FORMAT")
            | 1003u -> (guidName, "WPD_PROPERTY_SERVICE_CAPABILITIES_METHOD")
            | 1004u -> (guidName, "WPD_PROPERTY_SERVICE_CAPABILITIES_METHOD_ATTRIBUTES")
            | 1005u -> (guidName, "WPD_PROPERTY_SERVICE_CAPABILITIES_PARAMETER")
            | 1006u -> (guidName, "WPD_PROPERTY_SERVICE_CAPABILITIES_PARAMETER_ATTRIBUTES")
            | 1007u -> (guidName, "WPD_PROPERTY_SERVICE_CAPABILITIES_FORMATS")
            | 1008u -> (guidName, "WPD_PROPERTY_SERVICE_CAPABILITIES_FORMAT_ATTRIBUTES")
            | 1009u -> (guidName, "WPD_PROPERTY_SERVICE_CAPABILITIES_PROPERTY_KEYS")
            | 1010u -> (guidName, "WPD_PROPERTY_SERVICE_CAPABILITIES_PROPERTY_ATTRIBUTES")
            | 1011u -> (guidName, "WPD_PROPERTY_SERVICE_CAPABILITIES_SUPPORTED_EVENTS")
            | 1012u -> (guidName, "WPD_PROPERTY_SERVICE_CAPABILITIES_EVENT")
            | 1013u -> (guidName, "WPD_PROPERTY_SERVICE_CAPABILITIES_EVENT_ATTRIBUTES")
            | 1014u -> (guidName, "WPD_PROPERTY_SERVICE_CAPABILITIES_INHERITANCE_TYPE")
            | 1015u -> (guidName, "WPD_PROPERTY_SERVICE_CAPABILITIES_INHERITED_SERVICES")
            | 1016u -> (guidName, "WPD_PROPERTY_SERVICE_CAPABILITIES_RENDERING_PROFILES")
            | 1017u -> (guidName, "WPD_PROPERTY_SERVICE_CAPABILITIES_SUPPORTED_COMMANDS")
            | 1018u -> (guidName, "WPD_PROPERTY_SERVICE_CAPABILITIES_COMMAND")
            | 1019u -> (guidName, "WPD_PROPERTY_SERVICE_CAPABILITIES_COMMAND_OPTIONS")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CATEGORY_SERVICE_METHODS true -> 
            let guidName = "WPD_CATEGORY_SERVICE_METHODS"
            match pv with
            | 2u -> (guidName, "WPD_COMMAND_SERVICE_METHODS_START_INVOKE")
            | 3u -> (guidName, "WPD_COMMAND_SERVICE_METHODS_CANCEL_INVOKE")
            | 4u -> (guidName, "WPD_COMMAND_SERVICE_METHODS_END_INVOKE")
            | 1001u -> (guidName, "WPD_PROPERTY_SERVICE_METHOD")
            | 1002u -> (guidName, "WPD_PROPERTY_SERVICE_METHOD_PARAMETER_VALUES")
            | 1003u -> (guidName, "WPD_PROPERTY_SERVICE_METHOD_RESULT_VALUES")
            | 1004u -> (guidName, "WPD_PROPERTY_SERVICE_METHOD_CONTEXT")
            | 1005u -> (guidName, "WPD_PROPERTY_SERVICE_METHOD_HRESULT")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_RESOURCE_DEFAULT_Guid true -> 
            let guidName = "WPD_RESOURCE_DEFAULT_Guid"
            match pv with
            | 0u -> (guidName, "WPD_RESOURCE_DEFAULT")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_RESOURCE_CONTACT_PHOTO_Guid true -> 
            let guidName = "WPD_RESOURCE_CONTACT_PHOTO_Guid"
            match pv with
            | 0u -> (guidName, "WPD_RESOURCE_CONTACT_PHOTO")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_RESOURCE_THUMBNAIL_Guid true -> 
            let guidName = "WPD_RESOURCE_THUMBNAIL_Guid"
            match pv with
            | 0u -> (guidName, "WPD_RESOURCE_THUMBNAIL")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_RESOURCE_ICON_Guid true -> 
            let guidName = "WPD_RESOURCE_ICON_Guid"
            match pv with
            | 0u -> (guidName, "WPD_RESOURCE_ICON")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_RESOURCE_AUDIO_CLIP_Guid true -> 
            let guidName = "WPD_RESOURCE_AUDIO_CLIP_Guid"
            match pv with
            | 0u -> (guidName, "WPD_RESOURCE_AUDIO_CLIP")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_RESOURCE_ALBUM_ART_Guid true -> 
            let guidName = "WPD_RESOURCE_ALBUM_ART_Guid"
            match pv with
            | 0u -> (guidName, "WPD_RESOURCE_ALBUM_ART")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_RESOURCE_GENERIC_Guid true -> 
            let guidName = "WPD_RESOURCE_GENERIC_Guid"
            match pv with
            | 0u -> (guidName, "WPD_RESOURCE_GENERIC")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_RESOURCE_VIDEO_CLIP_Guid true -> 
            let guidName = "WPD_RESOURCE_VIDEO_CLIP_Guid"
            match pv with
            | 0u -> (guidName, "WPD_RESOURCE_VIDEO_CLIP")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_RESOURCE_BRANDING_ART_Guid true -> 
            let guidName = "WPD_RESOURCE_BRANDING_ART_Guid"
            match pv with
            | 0u -> (guidName, "WPD_RESOURCE_BRANDING_ART")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_FOLDER_OBJECT_PROPERTIES_V1 true -> 
            let guidName = "WPD_FOLDER_OBJECT_PROPERTIES_V1"
            match pv with
            | 2u -> (guidName, "WPD_FOLDER_CONTENT_TYPES_ALLOWED")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_IMAGE_OBJECT_PROPERTIES_V1 true -> 
            let guidName = "WPD_IMAGE_OBJECT_PROPERTIES_V1"
            match pv with
            | 3u -> (guidName, "WPD_IMAGE_BITDEPTH")
            | 4u -> (guidName, "WPD_IMAGE_CROPPED_STATUS")
            | 5u -> (guidName, "WPD_IMAGE_COLOR_CORRECTED_STATUS")
            | 6u -> (guidName, "WPD_IMAGE_FNUMBER")
            | 7u -> (guidName, "WPD_IMAGE_EXPOSURE_TIME")
            | 8u -> (guidName, "WPD_IMAGE_EXPOSURE_INDEX")
            | 9u -> (guidName, "WPD_IMAGE_HORIZONTAL_RESOLUTION")
            | 10u -> (guidName, "WPD_IMAGE_VERTICAL_RESOLUTION")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_MEDIA_PROPERTIES_V1 true -> 
            let guidName = "WPD_MEDIA_PROPERTIES_V1"
            match pv with
            | 2u -> (guidName, "WPD_MEDIA_TOTAL_BITRATE")
            | 3u -> (guidName, "WPD_MEDIA_BITRATE_TYPE")
            | 4u -> (guidName, "WPD_MEDIA_COPYRIGHT")
            | 5u -> (guidName, "WPD_MEDIA_SUBSCRIPTION_CONTENT_ID")
            | 6u -> (guidName, "WPD_MEDIA_USE_COUNT")
            | 7u -> (guidName, "WPD_MEDIA_SKIP_COUNT")
            | 8u -> (guidName, "WPD_MEDIA_LAST_ACCESSED_TIME")
            | 9u -> (guidName, "WPD_MEDIA_PARENTAL_RATING")
            | 10u -> (guidName, "WPD_MEDIA_META_GENRE")
            | 11u -> (guidName, "WPD_MEDIA_COMPOSER")
            | 12u -> (guidName, "WPD_MEDIA_EFFECTIVE_RATING")
            | 13u -> (guidName, "WPD_MEDIA_SUB_TITLE")
            | 14u -> (guidName, "WPD_MEDIA_RELEASE_DATE")
            | 15u -> (guidName, "WPD_MEDIA_SAMPLE_RATE")
            | 16u -> (guidName, "WPD_MEDIA_STAR_RATING")
            | 17u -> (guidName, "WPD_MEDIA_USER_EFFECTIVE_RATING")
            | 18u -> (guidName, "WPD_MEDIA_TITLE")
            | 19u -> (guidName, "WPD_MEDIA_DURATION")
            | 20u -> (guidName, "WPD_MEDIA_BUY_NOW")
            | 21u -> (guidName, "WPD_MEDIA_ENCODING_PROFILE")
            | 22u -> (guidName, "WPD_MEDIA_WIDTH")
            | 23u -> (guidName, "WPD_MEDIA_HEIGHT")
            | 24u -> (guidName, "WPD_MEDIA_ARTIST")
            | 25u -> (guidName, "WPD_MEDIA_ALBUM_ARTIST")
            | 26u -> (guidName, "WPD_MEDIA_OWNER")
            | 27u -> (guidName, "WPD_MEDIA_MANAGING_EDITOR")
            | 28u -> (guidName, "WPD_MEDIA_WEBMASTER")
            | 29u -> (guidName, "WPD_MEDIA_SOURCE_URL")
            | 30u -> (guidName, "WPD_MEDIA_DESTINATION_URL")
            | 31u -> (guidName, "WPD_MEDIA_DESCRIPTION")
            | 32u -> (guidName, "WPD_MEDIA_GENRE")
            | 33u -> (guidName, "WPD_MEDIA_TIME_BOOKMARK")
            | 34u -> (guidName, "WPD_MEDIA_OBJECT_BOOKMARK")
            | 35u -> (guidName, "WPD_MEDIA_LAST_BUILD_DATE")
            | 36u -> (guidName, "WPD_MEDIA_BYTE_BOOKMARK")
            | 37u -> (guidName, "WPD_MEDIA_TIME_TO_LIVE")
            | 38u -> (guidName, "WPD_MEDIA_GUID")
            | 39u -> (guidName, "WPD_MEDIA_SUB_DESCRIPTION")
            | 49u -> (guidName, "WPD_MEDIA_AUDIO_ENCODING_PROFILE")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_CONTACT_OBJECT_PROPERTIES_V1 true -> 
            let guidName = "WPD_CONTACT_OBJECT_PROPERTIES_V1"
            match pv with
            | 2u -> (guidName, "WPD_CONTACT_DISPLAY_NAME")
            | 3u -> (guidName, "WPD_CONTACT_FIRST_NAME")
            | 4u -> (guidName, "WPD_CONTACT_MIDDLE_NAMES")
            | 5u -> (guidName, "WPD_CONTACT_LAST_NAME")
            | 6u -> (guidName, "WPD_CONTACT_PREFIX")
            | 7u -> (guidName, "WPD_CONTACT_SUFFIX")
            | 8u -> (guidName, "WPD_CONTACT_PHONETIC_FIRST_NAME")
            | 9u -> (guidName, "WPD_CONTACT_PHONETIC_LAST_NAME")
            | 10u -> (guidName, "WPD_CONTACT_PERSONAL_FULL_POSTAL_ADDRESS")
            | 11u -> (guidName, "WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_LINE1")
            | 12u -> (guidName, "WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_LINE2")
            | 13u -> (guidName, "WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_CITY")
            | 14u -> (guidName, "WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_REGION")
            | 15u -> (guidName, "WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_POSTAL_CODE")
            | 16u -> (guidName, "WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_COUNTRY")
            | 17u -> (guidName, "WPD_CONTACT_BUSINESS_FULL_POSTAL_ADDRESS")
            | 18u -> (guidName, "WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_LINE1")
            | 19u -> (guidName, "WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_LINE2")
            | 20u -> (guidName, "WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_CITY")
            | 21u -> (guidName, "WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_REGION")
            | 22u -> (guidName, "WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_POSTAL_CODE")
            | 23u -> (guidName, "WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_COUNTRY")
            | 24u -> (guidName, "WPD_CONTACT_OTHER_FULL_POSTAL_ADDRESS")
            | 25u -> (guidName, "WPD_CONTACT_OTHER_POSTAL_ADDRESS_LINE1")
            | 26u -> (guidName, "WPD_CONTACT_OTHER_POSTAL_ADDRESS_LINE2")
            | 27u -> (guidName, "WPD_CONTACT_OTHER_POSTAL_ADDRESS_CITY")
            | 28u -> (guidName, "WPD_CONTACT_OTHER_POSTAL_ADDRESS_REGION")
            | 29u -> (guidName, "WPD_CONTACT_OTHER_POSTAL_ADDRESS_POSTAL_CODE")
            | 30u -> (guidName, "WPD_CONTACT_OTHER_POSTAL_ADDRESS_POSTAL_COUNTRY")
            | 31u -> (guidName, "WPD_CONTACT_PRIMARY_EMAIL_ADDRESS")
            | 32u -> (guidName, "WPD_CONTACT_PERSONAL_EMAIL")
            | 33u -> (guidName, "WPD_CONTACT_PERSONAL_EMAIL2")
            | 34u -> (guidName, "WPD_CONTACT_BUSINESS_EMAIL")
            | 35u -> (guidName, "WPD_CONTACT_BUSINESS_EMAIL2")
            | 36u -> (guidName, "WPD_CONTACT_OTHER_EMAILS")
            | 37u -> (guidName, "WPD_CONTACT_PRIMARY_PHONE")
            | 38u -> (guidName, "WPD_CONTACT_PERSONAL_PHONE")
            | 39u -> (guidName, "WPD_CONTACT_PERSONAL_PHONE2")
            | 40u -> (guidName, "WPD_CONTACT_BUSINESS_PHONE")
            | 41u -> (guidName, "WPD_CONTACT_BUSINESS_PHONE2")
            | 42u -> (guidName, "WPD_CONTACT_MOBILE_PHONE")
            | 43u -> (guidName, "WPD_CONTACT_MOBILE_PHONE2")
            | 44u -> (guidName, "WPD_CONTACT_PERSONAL_FAX")
            | 45u -> (guidName, "WPD_CONTACT_BUSINESS_FAX")
            | 46u -> (guidName, "WPD_CONTACT_PAGER")
            | 47u -> (guidName, "WPD_CONTACT_OTHER_PHONES")
            | 48u -> (guidName, "WPD_CONTACT_PRIMARY_WEB_ADDRESS")
            | 49u -> (guidName, "WPD_CONTACT_PERSONAL_WEB_ADDRESS")
            | 50u -> (guidName, "WPD_CONTACT_BUSINESS_WEB_ADDRESS")
            | 51u -> (guidName, "WPD_CONTACT_INSTANT_MESSENGER")
            | 52u -> (guidName, "WPD_CONTACT_INSTANT_MESSENGER2")
            | 53u -> (guidName, "WPD_CONTACT_INSTANT_MESSENGER3")
            | 54u -> (guidName, "WPD_CONTACT_COMPANY_NAME")
            | 55u -> (guidName, "WPD_CONTACT_PHONETIC_COMPANY_NAME")
            | 56u -> (guidName, "WPD_CONTACT_ROLE")
            | 57u -> (guidName, "WPD_CONTACT_BIRTHDATE")
            | 58u -> (guidName, "WPD_CONTACT_PRIMARY_FAX")
            | 59u -> (guidName, "WPD_CONTACT_SPOUSE")
            | 60u -> (guidName, "WPD_CONTACT_CHILDREN")
            | 61u -> (guidName, "WPD_CONTACT_ASSISTANT")
            | 62u -> (guidName, "WPD_CONTACT_ANNIVERSARY_DATE")
            | 63u -> (guidName, "WPD_CONTACT_RINGTONE")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_MUSIC_OBJECT_PROPERTIES_V1 true -> 
            let guidName = "WPD_MUSIC_OBJECT_PROPERTIES_V1"
            match pv with
            | 3u -> (guidName, "WPD_MUSIC_ALBUM")
            | 4u -> (guidName, "WPD_MUSIC_TRACK")
            | 6u -> (guidName, "WPD_MUSIC_LYRICS")
            | 8u -> (guidName, "WPD_MUSIC_MOOD")
            | 9u -> (guidName, "WPD_AUDIO_BITRATE")
            | 10u -> (guidName, "WPD_AUDIO_CHANNEL_COUNT")
            | 11u -> (guidName, "WPD_AUDIO_FORMAT_CODE")
            | 12u -> (guidName, "WPD_AUDIO_BIT_DEPTH")
            | 13u -> (guidName, "WPD_AUDIO_BLOCK_ALIGNMENT")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_VIDEO_OBJECT_PROPERTIES_V1 true -> 
            let guidName = "WPD_VIDEO_OBJECT_PROPERTIES_V1"
            match pv with
            | 2u -> (guidName, "WPD_VIDEO_AUTHOR")
            | 4u -> (guidName, "WPD_VIDEO_RECORDEDTV_STATION_NAME")
            | 5u -> (guidName, "WPD_VIDEO_RECORDEDTV_CHANNEL_NUMBER")
            | 7u -> (guidName, "WPD_VIDEO_RECORDEDTV_REPEAT")
            | 8u -> (guidName, "WPD_VIDEO_BUFFER_SIZE")
            | 9u -> (guidName, "WPD_VIDEO_CREDITS")
            | 10u -> (guidName, "WPD_VIDEO_KEY_FRAME_DISTANCE")
            | 11u -> (guidName, "WPD_VIDEO_QUALITY_SETTING")
            | 12u -> (guidName, "WPD_VIDEO_SCAN_TYPE")
            | 13u -> (guidName, "WPD_VIDEO_BITRATE")
            | 14u -> (guidName, "WPD_VIDEO_FOURCC_CODE")
            | 15u -> (guidName, "WPD_VIDEO_FRAMERATE")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_COMMON_INFORMATION_OBJECT_PROPERTIES_V1 true -> 
            let guidName = "WPD_COMMON_INFORMATION_OBJECT_PROPERTIES_V1"
            match pv with
            | 2u -> (guidName, "WPD_COMMON_INFORMATION_SUBJECT")
            | 3u -> (guidName, "WPD_COMMON_INFORMATION_BODY_TEXT")
            | 4u -> (guidName, "WPD_COMMON_INFORMATION_PRIORITY")
            | 5u -> (guidName, "WPD_COMMON_INFORMATION_START_DATETIME")
            | 6u -> (guidName, "WPD_COMMON_INFORMATION_END_DATETIME")
            | 7u -> (guidName, "WPD_COMMON_INFORMATION_NOTES")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_EMAIL_OBJECT_PROPERTIES_V1 true -> 
            let guidName = "WPD_EMAIL_OBJECT_PROPERTIES_V1"
            match pv with
            | 2u -> (guidName, "WPD_EMAIL_TO_LINE")
            | 3u -> (guidName, "WPD_EMAIL_CC_LINE")
            | 4u -> (guidName, "WPD_EMAIL_BCC_LINE")
            | 7u -> (guidName, "WPD_EMAIL_HAS_BEEN_READ")
            | 8u -> (guidName, "WPD_EMAIL_RECEIVED_TIME")
            | 9u -> (guidName, "WPD_EMAIL_HAS_ATTACHMENTS")
            | 10u -> (guidName, "WPD_EMAIL_SENDER_ADDRESS")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_APPOINTMENT_OBJECT_PROPERTIES_V1 true -> 
            let guidName = "WPD_APPOINTMENT_OBJECT_PROPERTIES_V1"
            match pv with
            | 3u -> (guidName, "WPD_APPOINTMENT_LOCATION")
            | 7u -> (guidName, "WPD_APPOINTMENT_TYPE")
            | 8u -> (guidName, "WPD_APPOINTMENT_REQUIRED_ATTENDEES")
            | 9u -> (guidName, "WPD_APPOINTMENT_OPTIONAL_ATTENDEES")
            | 10u -> (guidName, "WPD_APPOINTMENT_ACCEPTED_ATTENDEES")
            | 11u -> (guidName, "WPD_APPOINTMENT_RESOURCES")
            | 12u -> (guidName, "WPD_APPOINTMENT_TENTATIVE_ATTENDEES")
            | 13u -> (guidName, "WPD_APPOINTMENT_DECLINED_ATTENDEES")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_TASK_OBJECT_PROPERTIES_V1 true -> 
            let guidName = "WPD_TASK_OBJECT_PROPERTIES_V1"
            match pv with
            | 6u -> (guidName, "WPD_TASK_STATUS")
            | 8u -> (guidName, "WPD_TASK_PERCENT_COMPLETE")
            | 10u -> (guidName, "WPD_TASK_REMINDER_DATE")
            | 11u -> (guidName, "WPD_TASK_OWNER")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_SMS_OBJECT_PROPERTIES_V1 true -> 
            let guidName = "WPD_SMS_OBJECT_PROPERTIES_V1"
            match pv with
            | 2u -> (guidName, "WPD_SMS_PROVIDER")
            | 3u -> (guidName, "WPD_SMS_TIMEOUT")
            | 4u -> (guidName, "WPD_SMS_MAX_PAYLOAD")
            | 5u -> (guidName, "WPD_SMS_ENCODING")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids WPD_SECTION_OBJECT_PROPERTIES_V1 true -> 
            let guidName = "WPD_SECTION_OBJECT_PROPERTIES_V1"
            match pv with
            | 2u -> (guidName, "WPD_SECTION_DATA_OFFSET")
            | 3u -> (guidName, "WPD_SECTION_DATA_LENGTH")
            | 4u -> (guidName, "WPD_SECTION_DATA_UNITS")
            | 5u -> (guidName, "WPD_SECTION_DATA_REFERENCED_OBJECT_RESOURCE")
            | _ -> (guidName, "Unknown Property")
        | MatchGuids GUID_DEVINTERFACE_WPD true -> ("GUID_DEVINTERFACE_WPD", "No Properties")
        | MatchGuids GUID_DEVINTERFACE_WPD_PRIVATE true -> ("GUID_DEVINTERFACE_WPD_PRIVATE", "No Properties")
        | MatchGuids GUID_DEVINTERFACE_WPD_SERVICE true -> ("GUID_DEVINTERFACE_WPD_SERVICE", "No Properties")
        | MatchGuids WPD_EVENT_NOTIFICATION true -> ("WPD_EVENT_NOTIFICATION", "No Properties")
        | MatchGuids WPD_EVENT_OBJECT_ADDED true -> ("WPD_EVENT_OBJECT_ADDED", "No Properties")
        | MatchGuids WPD_EVENT_OBJECT_REMOVED true -> ("WPD_EVENT_OBJECT_REMOVED", "No Properties")
        | MatchGuids WPD_EVENT_OBJECT_UPDATED true -> ("WPD_EVENT_OBJECT_UPDATED", "No Properties")
        | MatchGuids WPD_EVENT_DEVICE_RESET true -> ("WPD_EVENT_DEVICE_RESET", "No Properties")
        | MatchGuids WPD_EVENT_DEVICE_CAPABILITIES_UPDATED true -> 
            ("WPD_EVENT_DEVICE_CAPABILITIES_UPDATED", "No Properties")
        | MatchGuids WPD_EVENT_STORAGE_FORMAT true -> ("WPD_EVENT_STORAGE_FORMAT", "No Properties")
        | MatchGuids WPD_EVENT_OBJECT_TRANSFER_REQUESTED true -> 
            ("WPD_EVENT_OBJECT_TRANSFER_REQUESTED", "No Properties")
        | MatchGuids WPD_EVENT_DEVICE_REMOVED true -> ("WPD_EVENT_DEVICE_REMOVED", "No Properties")
        | MatchGuids WPD_EVENT_SERVICE_METHOD_COMPLETE true -> ("WPD_EVENT_SERVICE_METHOD_COMPLETE", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_FUNCTIONAL_OBJECT true -> ("WPD_CONTENT_TYPE_FUNCTIONAL_OBJECT", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_FOLDER true -> ("WPD_CONTENT_TYPE_FOLDER", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_IMAGE true -> ("WPD_CONTENT_TYPE_IMAGE", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_DOCUMENT true -> ("WPD_CONTENT_TYPE_DOCUMENT", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_CONTACT true -> ("WPD_CONTENT_TYPE_CONTACT", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_CONTACT_GROUP true -> ("WPD_CONTENT_TYPE_CONTACT_GROUP", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_AUDIO true -> ("WPD_CONTENT_TYPE_AUDIO", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_VIDEO true -> ("WPD_CONTENT_TYPE_VIDEO", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_TELEVISION true -> ("WPD_CONTENT_TYPE_TELEVISION", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_PLAYLIST true -> ("WPD_CONTENT_TYPE_PLAYLIST", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_MIXED_CONTENT_ALBUM true -> 
            ("WPD_CONTENT_TYPE_MIXED_CONTENT_ALBUM", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_AUDIO_ALBUM true -> ("WPD_CONTENT_TYPE_AUDIO_ALBUM", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_IMAGE_ALBUM true -> ("WPD_CONTENT_TYPE_IMAGE_ALBUM", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_VIDEO_ALBUM true -> ("WPD_CONTENT_TYPE_VIDEO_ALBUM", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_MEMO true -> ("WPD_CONTENT_TYPE_MEMO", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_EMAIL true -> ("WPD_CONTENT_TYPE_EMAIL", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_APPOINTMENT true -> ("WPD_CONTENT_TYPE_APPOINTMENT", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_TASK true -> ("WPD_CONTENT_TYPE_TASK", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_PROGRAM true -> ("WPD_CONTENT_TYPE_PROGRAM", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_GENERIC_FILE true -> ("WPD_CONTENT_TYPE_GENERIC_FILE", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_CALENDAR true -> ("WPD_CONTENT_TYPE_CALENDAR", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_GENERIC_MESSAGE true -> ("WPD_CONTENT_TYPE_GENERIC_MESSAGE", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_NETWORK_ASSOCIATION true -> 
            ("WPD_CONTENT_TYPE_NETWORK_ASSOCIATION", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_CERTIFICATE true -> ("WPD_CONTENT_TYPE_CERTIFICATE", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_WIRELESS_PROFILE true -> ("WPD_CONTENT_TYPE_WIRELESS_PROFILE", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_MEDIA_CAST true -> ("WPD_CONTENT_TYPE_MEDIA_CAST", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_SECTION true -> ("WPD_CONTENT_TYPE_SECTION", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_UNSPECIFIED true -> ("WPD_CONTENT_TYPE_UNSPECIFIED", "No Properties")
        | MatchGuids WPD_CONTENT_TYPE_ALL true -> ("WPD_CONTENT_TYPE_ALL", "No Properties")
        | MatchGuids WPD_FUNCTIONAL_CATEGORY_DEVICE true -> ("WPD_FUNCTIONAL_CATEGORY_DEVICE", "No Properties")
        | MatchGuids WPD_FUNCTIONAL_CATEGORY_STORAGE true -> ("WPD_FUNCTIONAL_CATEGORY_STORAGE", "No Properties")
        | MatchGuids WPD_FUNCTIONAL_CATEGORY_STILL_IMAGE_CAPTURE true -> 
            ("WPD_FUNCTIONAL_CATEGORY_STILL_IMAGE_CAPTURE", "No Properties")
        | MatchGuids WPD_FUNCTIONAL_CATEGORY_AUDIO_CAPTURE true -> 
            ("WPD_FUNCTIONAL_CATEGORY_AUDIO_CAPTURE", "No Properties")
        | MatchGuids WPD_FUNCTIONAL_CATEGORY_VIDEO_CAPTURE true -> 
            ("WPD_FUNCTIONAL_CATEGORY_VIDEO_CAPTURE", "No Properties")
        | MatchGuids WPD_FUNCTIONAL_CATEGORY_SMS true -> ("WPD_FUNCTIONAL_CATEGORY_SMS", "No Properties")
        | MatchGuids WPD_FUNCTIONAL_CATEGORY_RENDERING_INFORMATION true -> 
            ("WPD_FUNCTIONAL_CATEGORY_RENDERING_INFORMATION", "No Properties")
        | MatchGuids WPD_FUNCTIONAL_CATEGORY_NETWORK_CONFIGURATION true -> 
            ("WPD_FUNCTIONAL_CATEGORY_NETWORK_CONFIGURATION", "No Properties")
        | MatchGuids WPD_FUNCTIONAL_CATEGORY_ALL true -> ("WPD_FUNCTIONAL_CATEGORY_ALL", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_ICON true -> ("WPD_OBJECT_FORMAT_ICON", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_M4A true -> ("WPD_OBJECT_FORMAT_M4A", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_NETWORK_ASSOCIATION true -> 
            ("WPD_OBJECT_FORMAT_NETWORK_ASSOCIATION", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_X509V3CERTIFICATE true -> 
            ("WPD_OBJECT_FORMAT_X509V3CERTIFICATE", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_MICROSOFT_WFC true -> ("WPD_OBJECT_FORMAT_MICROSOFT_WFC", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_3GPA true -> ("WPD_OBJECT_FORMAT_3GPA", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_3G2A true -> ("WPD_OBJECT_FORMAT_3G2A", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_ALL true -> ("WPD_OBJECT_FORMAT_ALL", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_PROPERTIES_ONLY true -> ("WPD_OBJECT_FORMAT_PROPERTIES_ONLY", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_UNSPECIFIED true -> ("WPD_OBJECT_FORMAT_UNSPECIFIED", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_SCRIPT true -> ("WPD_OBJECT_FORMAT_SCRIPT", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_EXECUTABLE true -> ("WPD_OBJECT_FORMAT_EXECUTABLE", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_TEXT true -> ("WPD_OBJECT_FORMAT_TEXT", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_HTML true -> ("WPD_OBJECT_FORMAT_HTML", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_DPOF true -> ("WPD_OBJECT_FORMAT_DPOF", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_AIFF true -> ("WPD_OBJECT_FORMAT_AIFF", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_WAVE true -> ("WPD_OBJECT_FORMAT_WAVE", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_MP3 true -> ("WPD_OBJECT_FORMAT_MP3", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_AVI true -> ("WPD_OBJECT_FORMAT_AVI", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_MPEG true -> ("WPD_OBJECT_FORMAT_MPEG", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_ASF true -> ("WPD_OBJECT_FORMAT_ASF", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_EXIF true -> ("WPD_OBJECT_FORMAT_EXIF", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_TIFFEP true -> ("WPD_OBJECT_FORMAT_TIFFEP", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_FLASHPIX true -> ("WPD_OBJECT_FORMAT_FLASHPIX", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_BMP true -> ("WPD_OBJECT_FORMAT_BMP", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_CIFF true -> ("WPD_OBJECT_FORMAT_CIFF", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_GIF true -> ("WPD_OBJECT_FORMAT_GIF", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_JFIF true -> ("WPD_OBJECT_FORMAT_JFIF", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_PCD true -> ("WPD_OBJECT_FORMAT_PCD", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_PICT true -> ("WPD_OBJECT_FORMAT_PICT", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_PNG true -> ("WPD_OBJECT_FORMAT_PNG", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_TIFF true -> ("WPD_OBJECT_FORMAT_TIFF", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_TIFFIT true -> ("WPD_OBJECT_FORMAT_TIFFIT", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_JP2 true -> ("WPD_OBJECT_FORMAT_JP2", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_JPX true -> ("WPD_OBJECT_FORMAT_JPX", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_WBMP true -> ("WPD_OBJECT_FORMAT_WBMP", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_JPEGXR true -> ("WPD_OBJECT_FORMAT_JPEGXR", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_WINDOWSIMAGEFORMAT true -> 
            ("WPD_OBJECT_FORMAT_WINDOWSIMAGEFORMAT", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_WMA true -> ("WPD_OBJECT_FORMAT_WMA", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_WMV true -> ("WPD_OBJECT_FORMAT_WMV", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_WPLPLAYLIST true -> ("WPD_OBJECT_FORMAT_WPLPLAYLIST", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_M3UPLAYLIST true -> ("WPD_OBJECT_FORMAT_M3UPLAYLIST", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_MPLPLAYLIST true -> ("WPD_OBJECT_FORMAT_MPLPLAYLIST", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_ASXPLAYLIST true -> ("WPD_OBJECT_FORMAT_ASXPLAYLIST", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_PLSPLAYLIST true -> ("WPD_OBJECT_FORMAT_PLSPLAYLIST", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_ABSTRACT_CONTACT_GROUP true -> 
            ("WPD_OBJECT_FORMAT_ABSTRACT_CONTACT_GROUP", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_ABSTRACT_MEDIA_CAST true -> 
            ("WPD_OBJECT_FORMAT_ABSTRACT_MEDIA_CAST", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_VCALENDAR1 true -> ("WPD_OBJECT_FORMAT_VCALENDAR1", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_ICALENDAR true -> ("WPD_OBJECT_FORMAT_ICALENDAR", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_ABSTRACT_CONTACT true -> ("WPD_OBJECT_FORMAT_ABSTRACT_CONTACT", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_VCARD2 true -> ("WPD_OBJECT_FORMAT_VCARD2", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_VCARD3 true -> ("WPD_OBJECT_FORMAT_VCARD3", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_XML true -> ("WPD_OBJECT_FORMAT_XML", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_AAC true -> ("WPD_OBJECT_FORMAT_AAC", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_AUDIBLE true -> ("WPD_OBJECT_FORMAT_AUDIBLE", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_FLAC true -> ("WPD_OBJECT_FORMAT_FLAC", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_QCELP true -> ("WPD_OBJECT_FORMAT_QCELP", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_AMR true -> ("WPD_OBJECT_FORMAT_AMR", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_OGG true -> ("WPD_OBJECT_FORMAT_OGG", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_MP4 true -> ("WPD_OBJECT_FORMAT_MP4", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_MP2 true -> ("WPD_OBJECT_FORMAT_MP2", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_MICROSOFT_WORD true -> ("WPD_OBJECT_FORMAT_MICROSOFT_WORD", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_MHT_COMPILED_HTML true -> 
            ("WPD_OBJECT_FORMAT_MHT_COMPILED_HTML", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_MICROSOFT_EXCEL true -> ("WPD_OBJECT_FORMAT_MICROSOFT_EXCEL", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_MICROSOFT_POWERPOINT true -> 
            ("WPD_OBJECT_FORMAT_MICROSOFT_POWERPOINT", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_3GP true -> ("WPD_OBJECT_FORMAT_3GP", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_3G2 true -> ("WPD_OBJECT_FORMAT_3G2", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_AVCHD true -> ("WPD_OBJECT_FORMAT_AVCHD", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_ATSCTS true -> ("WPD_OBJECT_FORMAT_ATSCTS", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_DVBTS true -> ("WPD_OBJECT_FORMAT_DVBTS", "No Properties")
        | MatchGuids WPD_OBJECT_FORMAT_MKV true -> ("WPD_OBJECT_FORMAT_MKV", "No Properties")
        | MatchGuids WPD_DOCUMENT_OBJECT_PROPERTIES_V1 true -> ("WPD_DOCUMENT_OBJECT_PROPERTIES_V1", "No Properties")
        | MatchGuids WPD_MEMO_OBJECT_PROPERTIES_V1 true -> ("WPD_MEMO_OBJECT_PROPERTIES_V1", "No Properties")
        | _ -> ("Uknown Category", "")
    
    let (|ParsePropertyKey|) (tag : PortableDeviceApiLib._tagpropertykey) = GetPropertyName tag.fmtid tag.pid
    
   
    let GetPropertiesFromCategory guid =
        match guid with
        | MatchGuids WPD_CATEGORY_NULL true -> [|0u|]
        | MatchGuids WPD_OBJECT_PROPERTIES_V1 true -> [|7u; 14u; 23u; 24u; 25u; 2u; 3u; 4u; 5u; 6u; 9u; 10u; 11u; 12u; 13u; 15u; 16u; 17u; 18u; 19u; 20u; 21u; 26u; 27u|]
        | MatchGuids WPD_OBJECT_PROPERTIES_V2 true -> [|2u|]
        | MatchGuids WPD_FUNCTIONAL_OBJECT_PROPERTIES_V1 true -> [|2u|]
        | MatchGuids WPD_STORAGE_OBJECT_PROPERTIES_V1 true -> [|2u; 3u; 4u; 5u; 6u; 7u; 8u; 9u; 10u; 11u|]
        | MatchGuids WPD_NETWORK_ASSOCIATION_PROPERTIES_V1 true -> [|2u; 3u|]
        | MatchGuids WPD_STILL_IMAGE_CAPTURE_OBJECT_PROPERTIES_V1 true -> [|2u; 3u; 4u; 5u; 6u; 7u; 8u; 9u; 10u; 11u; 12u; 13u; 14u; 15u; 16u; 17u; 18u; 19u; 20u; 21u; 22u; 23u; 24u; 25u; 26u; 27u; 28u; 29u; 30u; 31u|]
        | MatchGuids WPD_RENDERING_INFORMATION_OBJECT_PROPERTIES_V1 true -> [|2u; 3u; 4u|]
        | MatchGuids WPD_CLIENT_INFORMATION_PROPERTIES_V1 true -> [|2u; 3u; 4u; 5u; 6u; 7u; 8u; 9u; 10u; 11u; 12u; 13u|]
        | MatchGuids WPD_PROPERTY_ATTRIBUTES_V1 true -> [|2u; 3u; 4u; 5u; 6u; 7u; 8u; 9u; 10u; 11u; 12u; 13u|]
        | MatchGuids WPD_PROPERTY_ATTRIBUTES_V2 true -> [|2u; 3u|]
        | MatchGuids WPD_CLASS_EXTENSION_OPTIONS_V1 true -> [|2u; 3u; 4u|]
        | MatchGuids WPD_CLASS_EXTENSION_OPTIONS_V2 true -> [|2u; 3u; 4u|]
        | MatchGuids WPD_CLASS_EXTENSION_OPTIONS_V3 true -> [|2u|]
        | MatchGuids WPD_RESOURCE_ATTRIBUTES_V1 true -> [|2u; 3u; 4u; 5u; 6u; 7u; 8u; 9u|]
        | MatchGuids WPD_DEVICE_PROPERTIES_V1 true -> [|2u; 3u; 4u; 5u; 6u; 7u; 8u; 9u; 10u; 11u; 12u; 13u; 14u; 15u; 16u|]
        | MatchGuids WPD_DEVICE_PROPERTIES_V2 true -> [|2u; 3u; 4u; 5u|]
        | MatchGuids WPD_SERVICE_PROPERTIES_V1 true -> [|2u|]
        | MatchGuids WPD_EVENT_PROPERTIES_V1 true -> [|2u; 3u; 4u; 5u; 6u; 7u; 8u|]
        | MatchGuids WPD_EVENT_PROPERTIES_V2 true -> [|2u|]
        | MatchGuids WPD_EVENT_OPTIONS_V1 true -> [|2u; 3u|]
        | MatchGuids WPD_EVENT_ATTRIBUTES_V1 true -> [|2u; 3u; 4u|]
        | MatchGuids WPD_API_OPTIONS_V1 true -> [|2u; 3u|]
        | MatchGuids WPD_FORMAT_ATTRIBUTES_V1 true -> [|2u; 3u|]
        | MatchGuids WPD_METHOD_ATTRIBUTES_V1 true -> [|2u; 3u; 4u; 5u|]
        | MatchGuids WPD_PARAMETER_ATTRIBUTES_V1 true -> [|2u; 3u; 4u; 5u; 6u; 7u; 8u; 9u; 10u; 11u; 12u; 13u|]
        | MatchGuids WPD_CATEGORY_COMMON true -> [|2u; 3u; 4u; 1001u; 1002u; 1003u; 1004u; 1006u; 1007u; 1008u; 1009u; 1010u; 1011u; 5001u|]
        | MatchGuids WPD_CATEGORY_OBJECT_ENUMERATION true -> [|2u; 3u; 4u; 1001u; 1002u; 1003u; 1004u; 1005u|]
        | MatchGuids WPD_CATEGORY_OBJECT_PROPERTIES true -> [|2u; 3u; 4u; 5u; 6u; 7u; 1001u; 1002u; 1003u; 1004u; 1005u; 1006u|]
        | MatchGuids WPD_CATEGORY_OBJECT_PROPERTIES_BULK true -> [|2u; 3u; 4u; 5u; 6u; 7u; 8u; 9u; 10u; 1001u; 1002u; 1003u; 1004u; 1005u; 1006u; 1007u; 1008u|]
        | MatchGuids WPD_CATEGORY_OBJECT_RESOURCES true -> [|2u; 3u; 4u; 5u; 6u; 7u; 8u; 9u; 10u; 11u; 12u; 13u; 1001u; 1002u; 1003u; 1004u; 1005u; 1006u; 1007u; 1008u; 1009u; 1010u; 1011u; 1012u; 1013u; 1014u; 1015u; 1016u; 5001u; 5002u; 5003u|]
        | MatchGuids WPD_CATEGORY_OBJECT_MANAGEMENT true -> [|2u; 3u; 4u; 5u; 6u; 7u; 8u; 9u; 10u; 1001u; 1002u; 1003u; 1004u; 1005u; 1006u; 1007u; 1008u; 1009u; 1010u; 1011u; 1012u; 1013u; 1014u; 1015u; 1016u; 5001u|]
        | MatchGuids WPD_CATEGORY_CAPABILITIES true -> [|2u; 3u; 4u; 5u; 6u; 7u; 8u; 9u; 10u; 11u; 1001u; 1002u; 1003u; 1004u; 1005u; 1006u; 1007u; 1008u; 1009u; 1010u; 1011u; 1012u; 1013u; 1014u; 1015u|]
        | MatchGuids WPD_CATEGORY_STORAGE true -> [|2u; 4u; 1001u; 1002u|]
        | MatchGuids WPD_CATEGORY_SMS true -> [|2u; 1001u; 1002u; 1003u; 1004u; 5001u|]
        | MatchGuids WPD_CATEGORY_STILL_IMAGE_CAPTURE true -> [|2u|]
        | MatchGuids WPD_CATEGORY_MEDIA_CAPTURE true -> [|2u; 3u; 4u|]
        | MatchGuids WPD_CATEGORY_DEVICE_HINTS true -> [|2u; 1001u; 1002u|]
        | MatchGuids WPD_CLASS_EXTENSION_V1 true -> [|2u; 1001u; 1002u|]
        | MatchGuids WPD_CLASS_EXTENSION_V2 true -> [|2u; 3u; 1001u; 1002u; 1003u|]
        | MatchGuids WPD_CATEGORY_NETWORK_CONFIGURATION true -> [|2u; 3u; 4u; 1001u|]
        | MatchGuids WPD_CATEGORY_SERVICE_COMMON true -> [|2u; 1001u|]
        | MatchGuids WPD_CATEGORY_SERVICE_CAPABILITIES true -> [|2u; 3u; 4u; 5u; 6u; 7u; 8u; 9u; 10u; 11u; 12u; 13u; 14u; 15u; 16u; 1001u; 1002u; 1003u; 1004u; 1005u; 1006u; 1007u; 1008u; 1009u; 1010u; 1011u; 1012u; 1013u; 1014u; 1015u; 1016u; 1017u; 1018u; 1019u|]
        | MatchGuids WPD_CATEGORY_SERVICE_METHODS true -> [|2u; 3u; 4u; 1001u; 1002u; 1003u; 1004u; 1005u|]
        | MatchGuids WPD_RESOURCE_DEFAULT_Guid true -> [|0u|]
        | MatchGuids WPD_RESOURCE_CONTACT_PHOTO_Guid true -> [|0u|]
        | MatchGuids WPD_RESOURCE_THUMBNAIL_Guid true -> [|0u|]
        | MatchGuids WPD_RESOURCE_ICON_Guid true -> [|0u|]
        | MatchGuids WPD_RESOURCE_AUDIO_CLIP_Guid true -> [|0u|]
        | MatchGuids WPD_RESOURCE_ALBUM_ART_Guid true -> [|0u|]
        | MatchGuids WPD_RESOURCE_GENERIC_Guid true -> [|0u|]
        | MatchGuids WPD_RESOURCE_VIDEO_CLIP_Guid true -> [|0u|]
        | MatchGuids WPD_RESOURCE_BRANDING_ART_Guid true -> [|0u|]
        | MatchGuids WPD_FOLDER_OBJECT_PROPERTIES_V1 true -> [|2u|]
        | MatchGuids WPD_IMAGE_OBJECT_PROPERTIES_V1 true -> [|3u; 4u; 5u; 6u; 7u; 8u; 9u; 10u|]
        | MatchGuids WPD_MEDIA_PROPERTIES_V1 true -> [|2u; 3u; 4u; 5u; 6u; 7u; 8u; 9u; 10u; 11u; 12u; 13u; 14u; 15u; 16u; 17u; 18u; 19u; 20u; 21u; 22u; 23u; 24u; 25u; 26u; 27u; 28u; 29u; 30u; 31u; 32u; 33u; 34u; 35u; 36u; 37u; 38u; 39u; 49u|]
        | MatchGuids WPD_CONTACT_OBJECT_PROPERTIES_V1 true -> [|2u; 3u; 4u; 5u; 6u; 7u; 8u; 9u; 10u; 11u; 12u; 13u; 14u; 15u; 16u; 17u; 18u; 19u; 20u; 21u; 22u; 23u; 24u; 25u; 26u; 27u; 28u; 29u; 30u; 31u; 32u; 33u; 34u; 35u; 36u; 37u; 38u; 39u; 40u; 41u; 42u; 43u; 44u; 45u; 46u; 47u; 48u; 49u; 50u; 51u; 52u; 53u; 54u; 55u; 56u; 57u; 58u; 59u; 60u; 61u; 62u; 63u|]
        | MatchGuids WPD_MUSIC_OBJECT_PROPERTIES_V1 true -> [|3u; 4u; 6u; 8u; 9u; 10u; 11u; 12u; 13u|]
        | MatchGuids WPD_VIDEO_OBJECT_PROPERTIES_V1 true -> [|2u; 4u; 5u; 7u; 8u; 9u; 10u; 11u; 12u; 13u; 14u; 15u|]
        | MatchGuids WPD_COMMON_INFORMATION_OBJECT_PROPERTIES_V1 true -> [|2u; 3u; 4u; 5u; 6u; 7u|]
        | MatchGuids WPD_EMAIL_OBJECT_PROPERTIES_V1 true -> [|2u; 3u; 4u; 7u; 8u; 9u; 10u|]
        | MatchGuids WPD_APPOINTMENT_OBJECT_PROPERTIES_V1 true -> [|3u; 7u; 8u; 9u; 10u; 11u; 12u; 13u|]
        | MatchGuids WPD_TASK_OBJECT_PROPERTIES_V1 true -> [|6u; 8u; 10u; 11u|]
        | MatchGuids WPD_SMS_OBJECT_PROPERTIES_V1 true -> [|2u; 3u; 4u; 5u|]
        | MatchGuids WPD_SECTION_OBJECT_PROPERTIES_V1 true -> [|2u; 3u; 4u; 5u|]
        | _ -> [||]
