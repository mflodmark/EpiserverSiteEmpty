using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace EpiserverSite1.Models.Blocks
{
    [SiteBlockIcon]
    [ContentType(DisplayName = "Teaser", 
        GroupName = SiteGroupNames.Common,
        GUID = "56feaec4-72f0-4933-bd89-002203ab1693", 
        Description = "Teaser block")]
    public class TeaserBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Heading", Order = 10, GroupName = SystemTabNames.PageHeader)]
        public virtual string TeaserHeading { get; set; }

        [CultureSpecific]
        [Display(Name = "Rich text", Order = 20)]
        public virtual XhtmlString TeaserText { get; set; }

        [Display(Name = "Image", Order = 30, GroupName = SystemTabNames.PageHeader)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference TeaserImage { get; set; }

        [Display(Name = "Link", Order = 40, GroupName = SystemTabNames.PageHeader)]
        public virtual PageReference TeaserLink { get; set; }
    }
}