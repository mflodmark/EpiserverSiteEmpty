using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using EpiserverSite1.Models.Pages;
using EpiserverSite1.Models.ViewModels;
using System.Web.Mvc;

namespace EpiserverSite1.Controllers
{
    [TemplateDescriptor(Inherited = true, 
        Tags = new[] { SiteTags.Full }, 
        AvailableWithoutTag = true)]
    public class AllPagesFullPartialController : PartialContentController<SitePageData>
    {
        public override ActionResult Index(SitePageData currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return PartialView(viewName: SiteTags.Full, model: PageViewModel.Create(currentPage));
        }
    }

    [TemplateDescriptor(Inherited = true,
        Tags = new[] { SiteTags.Wide },
        AvailableWithoutTag = false)]
    public class AllPagesWidePartialController : PartialContentController<SitePageData>
    {
        public override ActionResult Index(SitePageData currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return PartialView(viewName: SiteTags.Wide, model: PageViewModel.Create(currentPage));
        }
    }

    [TemplateDescriptor(Inherited = true,
        Tags = new[] { SiteTags.Narrow },
        AvailableWithoutTag = false)]
    public class AllPagesNarrowPartialController : PartialContentController<SitePageData>
    {
        public override ActionResult Index(SitePageData currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return PartialView(viewName: SiteTags.Narrow, model: PageViewModel.Create(currentPage));
        }
    }
}