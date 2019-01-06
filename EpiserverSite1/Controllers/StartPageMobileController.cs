using EPiServer;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using EPiServer.Web.Mvc;
using EpiserverSite1.Models.Pages;
using System.Web.Mvc;

namespace EpiserverSite1.Controllers
{
    [TemplateDescriptor(Tags = new[] { RenderingTags.Mobile }, AvailableWithoutTag = false)]
    public class StartPageMobileController : PageControllerBase<StartPage>
    {
        public StartPageMobileController(IContentLoader loader): base(loader)
        {

        }

        public ActionResult Index(StartPage currentPage)
        {
            return View(CreatePageViewModel(currentPage));
        }
    }
}