using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
    public class FeedbackController : Controller
    {
        public IActionResult Feedback()
        {
            return View();
        }
    }
}