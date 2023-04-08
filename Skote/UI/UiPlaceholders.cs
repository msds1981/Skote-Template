using Microsoft.AspNetCore.Mvc;

namespace Skote.UI
{
    public class UiPlaceholders : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
