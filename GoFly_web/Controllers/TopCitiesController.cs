using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
    public class TopCitiesController : Controller
    {
        public IActionResult TopCities()
        {
            return View();
        }
    }
}
