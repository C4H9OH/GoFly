using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
    public class FavouriteController : Controller
    {
        public IActionResult Favourite()
        {
            return View();
        }
    }
}
