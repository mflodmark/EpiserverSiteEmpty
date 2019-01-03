using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverSite1.Models.Pages
{
    [ContentType(DisplayName = "StandardPage", GUID = "f097d44f-0c66-44dd-ba8f-806ae3a5ca6f", Description = "")]
    public class StandardPage : PageData
    {

        [CultureSpecific]
        [Display(Name="Heading", 
            Description = "Hej" ,
            GroupName = SystemTabNames.Content, 
            Order = 0)]
        public virtual String Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

    }
}