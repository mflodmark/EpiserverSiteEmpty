using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace EpiserverSite1.Models.Blocks
{
    [SiteBlockIcon]
    [ContentType(DisplayName = "Editorial",
        GUID = "1e27e067-5bdd-4258-b1e0-65acfd57ab2c", 
        GroupName = SiteGroupNames.Common,
        Description = "Use this for a rich editorial text that will be reused in multiple places")]
    public class EditorialBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString MainBody { get; set; }

    }
}