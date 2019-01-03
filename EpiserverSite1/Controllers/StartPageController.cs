using EPiServer.Web.Mvc;
using EpiserverSite1.Models.Pages;
using System.Web.Mvc;

namespace AlloyTraining.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            return View(currentPage);
        }
    }
}