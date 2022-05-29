using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
    public class HistoryController : Controller
    {
        public IActionResult History()
        {
            return View();
        }
    }
}
