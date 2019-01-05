using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlloyTraining.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace EpiserverSite1.Controllers
{
    public class ContentFolderController : PartialContentController<ContentFolder>
    {
        public ContentFolderController(IContentLoader loader)
        {
            this.loader = loader;
        }

        public IContentLoader loader { get; }

        public override ActionResult Index(ContentFolder currentBlock)
        {
            var vm = new ContentFolderViewModel()
            {
                CurrentFolder = currentBlock,
                ItemsCount = loader.GetChildren<IContent>(currentBlock.ContentLink).Count()
            };

            return PartialView(vm);
        }
    }
}
