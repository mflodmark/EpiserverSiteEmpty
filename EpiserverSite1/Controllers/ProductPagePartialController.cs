using EPiServer;
using EPiServer.Web.Mvc;
using EpiserverSite1.Models.Pages;
using EpiserverSite1.Models.ViewModels;
using System.Web.Mvc;

namespace EpiserverSite1.Controllers
{
    public class ProductPagePartialController : PartialContentController<ProductPage>
    {
        public override ActionResult Index(ProductPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return PartialView(PageViewModel.Create(currentPage));
        }
    }
}