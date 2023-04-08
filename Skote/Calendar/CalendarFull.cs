using Microsoft.AspNetCore.Mvc;

namespace Skote.Calendar
{
    public class CalendarFull : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
