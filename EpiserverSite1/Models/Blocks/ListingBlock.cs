using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace EpiserverSite1.Models.Blocks
{
    [SiteBlockIcon]
    [ContentType(DisplayName = "Listing", 
        GroupName = SiteGroupNames.Common,
        GUID = "e61440fa-ee30-47bf-a7d2-e1dcfc66f0ff", 
        Description = "")]
    public class ListingBlock : BlockData
    {
        [Display(Name = "Heading", Order = 10)]
        public virtual string Heading { get; set; }

        [Display(Name = "Show children of this page", Order = 20)]
        public virtual PageReference ShowChildrenOfThisPage { get; set; }
    }
}