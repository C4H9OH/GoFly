using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
    public class HotelsController : Controller
    {
        public IActionResult Hotels()
        {
            return View();
        }
    }
}
