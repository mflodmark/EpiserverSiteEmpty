using EPiServer.Core;
using EpiserverSite1.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiserverSite1.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageData {
        T CurrentPage { get; }
        StartPage StartPage { get; }
        IEnumerable<SitePageData> MenuPages { get; }
        IContent Section { get; } }
}
