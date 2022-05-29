using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
    public class FavouriteHotelController : Controller
    {
        public IActionResult FavouriteHotel()
        {
            return View();
        }
    }
}
