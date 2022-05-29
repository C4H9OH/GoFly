using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
    public class PlaneController : Controller
    {
        public IActionResult Plane()
        {
            return View();
        }
    }
}
