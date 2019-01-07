using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using EpiserverSite1.Models.Blocks;
using EpiserverSite1.Models.ViewModels;
using System;
using System.Web.Mvc;

namespace EpiserverSite1.Controllers
{
    [TemplateDescriptor(Tags = new[] { SiteTags.Full}, AvailableWithoutTag = true)]
    public class TeaserBlockController : BlockController<TeaserBlock>
    {
        public override ActionResult Index(TeaserBlock currentBlock)
        {
            var vm = new TeaserBlockViewModel()
            {
                CurrentBlock = currentBlock,
                TodaysVisitorCount = (new Random()).Next(300, 900)
            };
            return PartialView(vm);
        }
    }

    [TemplateDescriptor(Tags = new[] { SiteTags.Wide })]
    public class TeaserBlockWideController : BlockController<TeaserBlock>
    {
        public override ActionResult Index(TeaserBlock currentBlock)
        {
            var vm = new TeaserBlockViewModel()
            {
                CurrentBlock = currentBlock,
                TodaysVisitorCount = (new Random()).Next(300, 900)
            };
            return PartialView(vm);
        }
    }

    [TemplateDescriptor(Tags = new[] { SiteTags.Narrow })]
    public class TeaserBlockNarrowController : BlockController<TeaserBlock>
    {
        public override ActionResult Index(TeaserBlock currentBlock)
        {
            var vm = new TeaserBlockViewModel()
            {
                CurrentBlock = currentBlock,
                TodaysVisitorCount = (new Random()).Next(300, 900)
            };
            return PartialView(vm);
        }
    }
}
