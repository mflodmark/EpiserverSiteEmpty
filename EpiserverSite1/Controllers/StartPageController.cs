using EPiServer;
using EPiServer.Web.Mvc;
using EpiserverSite1.Models.Pages;
using System.Web.Mvc;

namespace EpiserverSite1.Controllers
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        public StartPageController(IContentLoader loader): base(loader)
        {

        }

        public ActionResult Index(StartPage currentPage)
        {
            return View(CreatePageViewModel(currentPage));
        }
    }
}