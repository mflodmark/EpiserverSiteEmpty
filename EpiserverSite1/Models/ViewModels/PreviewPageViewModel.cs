using EpiserverSite1.Models.Pages;
using EPiServer.Core;
using EpiserverSite1.Models.ViewModels;

namespace AlloyTraining.Models.ViewModels
{
    public class PreviewPageViewModel : PageViewModel<SitePageData>
    {
        public PreviewPageViewModel(SitePageData currentPage, IContent contentToPreview) : base(currentPage)
        {
            this.PreviewArea = new ContentArea();
                this.PreviewArea.Items.Add(new ContentAreaItem
                {
                    ContentLink = contentToPreview.ContentLink
                });
        }

        public ContentArea PreviewArea { get; set; }
    }
}