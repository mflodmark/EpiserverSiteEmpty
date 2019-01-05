using EpiserverSite1.Models.Pages;

namespace EpiserverSite1.Controllers
{
    internal class DefaultPageViewModel<T>
    {
        private StandardPage currentPage;

        public DefaultPageViewModel(StandardPage currentPage)
        {
            this.currentPage = currentPage;
        }
    }
}