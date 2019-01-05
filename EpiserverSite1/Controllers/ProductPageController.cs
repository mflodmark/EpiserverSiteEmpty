﻿using EPiServer;
using EpiserverSite1.Models.Pages;
using System.Web.Mvc;

namespace EpiserverSite1.Controllers
{
    public class ProductPageController : PageControllerBase<ProductPage>
    {
        public ProductPageController(IContentLoader loader): base(loader)
        {

        }

        public ActionResult Index(ProductPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(CreatePageViewModel(currentPage));
        }
    }
}