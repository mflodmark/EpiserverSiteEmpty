using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.Blobs;
using EPiServer.Framework.DataAnnotations;

namespace EpiserverSite1.Models.Media
{
    [ContentType(DisplayName = "SVG File", 
        GUID = "8b7b7eec-d31d-4932-8a52-c53f7e4091cb", 
        Description = "Use this to upload Scalable Vector Graphic (SVG) images")]
    [MediaDescriptor(ExtensionString = "pdf,doc,docx")]
    public class SvgFile : ImageData
    {
        public override Blob Thumbnail { get => base.BinaryData; }
    }
}