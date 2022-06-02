using GoFly_web.Managers.GoFlys;
using Microsoft.AspNetCore.Mvc;
using GoFly_web.Managers.GoFlys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
    public class EmailConfirmController : Controller
    {
        private readonly IAccountManager _manager;
        public EmailConfirmController(IAccountManager manager)
        {
            _manager = manager;
        }
        public IActionResult EmailConfirm()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EmailConfirm(string EmailConfirm)
        {
            await _manager.MailConfirmation(EmailConfirm);
            return Redirect("/Plane/Plane");
        }
    }
}
