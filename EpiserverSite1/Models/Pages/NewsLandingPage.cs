using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EpiserverSite1.Models.Blocks;

namespace EpiserverSite1.Models.Pages
{
    [ContentType(DisplayName = "News Landing", 
        GroupName = SiteGroupNames.News,
        GUID = "1bc57887-4b8e-42a9-bd65-037b29e2da71", 
        Description = "Use this as a landing page for a list of news articles")]
    [SitePageIcon]
    public class NewsLandingPage : StandardPage
    {
        [Display(Name = "News listing", Order = 315)]
        public virtual ListingBlock NewsListing { get; set; }

    }
}