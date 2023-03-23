using Microsoft.AspNetCore.Mvc;

namespace Leilao.WebApp.Mvc.Extensions
{
    public class SummaryViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
