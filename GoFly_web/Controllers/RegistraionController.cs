using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Registration()
        {
            return View();
        }
    }
}