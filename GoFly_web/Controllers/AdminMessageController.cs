using GoFly_web.Managers.GoFlys;
using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
    public class AdminMessageController : Controller
    {
        private readonly IAdminMessageManager _manager;

        public AdminMessageController(IAdminMessageManager manager)
        {
            _manager = manager;
        }
        public IActionResult AdminMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminMessage(string message)
        {
            
            string path = @"C:\Users\taiwa\source\repos\GoFly_web\GoFly_web\bin\Debug\TelegramBotCode\Message.txt";
            _manager.SendMessage(path, message);
            return View();
        }
    }
}
