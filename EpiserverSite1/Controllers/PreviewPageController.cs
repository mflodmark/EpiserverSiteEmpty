using AlloyTraining.Models.ViewModels;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EpiserverSite1.Models.Pages;
using System.Web.Mvc;

namespace EpiserverSite1.Controllers
{
    [TemplateDescriptor(Inherited = true,
        TemplateTypeCategory = TemplateTypeCategories.MvcController,
        Tags = new[] { RenderingTags.Preview }, AvailableWithoutTag = false)]
    public class PreviewPageController : ActionControllerBase, IRenderTemplate<BlockData>
    {
        public ActionResult Index(IContent currentContent)
        {
            var loader = ServiceLocator.Current.GetInstance<EPiServer.IContentLoader>();
            var startPage = loader.Get<SitePageData>(ContentReference.StartPage);
            var viewmodel = new PreviewPageViewModel(startPage, currentContent);
            return View(viewmodel);
        }
    }
}