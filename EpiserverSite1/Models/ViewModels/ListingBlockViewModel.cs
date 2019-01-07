using EPiServer.Core;
using System.Collections.Generic;

namespace EpiserverSite1.Models.ViewModels
{
    public class ListingBlockViewModel
    {
        public string Heading { get; set; }
        public IEnumerable<PageData> Pages { get; set; }
    }
}