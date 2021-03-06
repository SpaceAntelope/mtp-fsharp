﻿namespace PortableDevices.Sample.IO

module ContentExplorer = 
    open System
    open PortableDevices
    open PDGlobalTypes
    open PDUtils
    
    let ExploreContent deviceID = 
        DoOnDevice deviceID (fun device -> 
            let objectIdCompareProperty objectID = 
                let (PropertyValue name) = PDUtils.GetObjectName device objectID
                match objectID with
                | FolderID _ -> "0" + name
                | _ -> "1" + name
            
            let printChoice i objectId = 
                let (PropertyValueGuid objectType) = readObjectPropertyByType device objectId PDHeader.WPD_OBJECT_CONTENT_TYPE
                let (PropertyValue name) = GetObjectName device objectId
                printfn "[%d] %s\t%A %A" i name objectId (PDHeaderUtils.GetGuidName objectType)
            
            let mutable tmp = 
                PDContent.ListNodeIDs device false (FolderID "DEVICE")
                |> Array.ofSeq
                |> Array.sortBy objectIdCompareProperty
            
            tmp |> Array.iteri printChoice
            printf "Selection: "
            let mutable choice = Console.ReadLine()
            while (System.Text.RegularExpressions.Regex.IsMatch(choice, "\d+")) do
                printfn "%A selected\n" tmp.[int choice]
                tmp <- tmp.[int choice]
                       |> PDContent.ListNodeIDs device false
                       |> Array.ofSeq
                       |> Array.sortBy objectIdCompareProperty
                tmp |> Seq.iteri printChoice
                printf "Selection: "
                choice <- Console.ReadLine())
