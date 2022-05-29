using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
    public class FavouriteTrainController : Controller
    {
        public IActionResult FavouriteTrain()
        {
            return View();
        }
    }
}
