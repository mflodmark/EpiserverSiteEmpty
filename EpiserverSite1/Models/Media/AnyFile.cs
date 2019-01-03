using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverSite1.Models.Media
{
    [ContentType(DisplayName = "Any File", 
        GUID = "968d56ac-bbe4-4233-b779-ad0eab68e7c1", 
        Description =  "Use this to upload any type of file." )]
    /*[MediaDescriptor(ExtensionString = "pdf,doc,docx")]*/
    public class AnyFile : MediaData
    {

    }
}