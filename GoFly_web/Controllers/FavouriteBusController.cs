using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
    public class FavouriteBusController : Controller
    {
        public IActionResult FavouriteBus()
        {
            return View();
        }
    }
}
