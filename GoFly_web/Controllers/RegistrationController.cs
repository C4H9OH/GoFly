
using GoFly_web.Managers.GoFlys;
using Microsoft.AspNetCore.Mvc;
using GoFly_web.Managers.GoFlys;
using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
  
    public class RegistrationController : Controller
    {
        private readonly IAccountManager _manager;
        public RegistrationController(IAccountManager manager)
        {
            _manager = manager;
        }
        public IActionResult Registration()
        {
            return View();
        }

        
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult MailConfirmation()
        {
            return View();
        }

        public IActionResult UserHomePage()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            TempData["UserName"] = null;
            TempData["UserMail"] = null;
            return Redirect("/Plane/Plane");
        }

        [HttpPost]
        public async Task<IActionResult> Registration(string userFirstName, string userLastName, 
            string userEmail, string userPassword, string userGender, string userPhoneNumber, int userAge, string userLanguage)
        {
            await _manager.Register(userFirstName, userLastName, userEmail, userPassword, userGender, userPhoneNumber, userAge);
            return Redirect("/EmailConfirm/EmailConfirm");
        }


        [HttpPost]
        public async Task<IActionResult> MailConfirmation(string mailConfirmation)
        {
            await _manager.MailConfirmation(mailConfirmation);
            return Redirect("/Plane/Plane");
        }

        [HttpPost]
        public  IActionResult Login(string Email, string Password)
        {
            if((Email == "<Moderator>")&(Password == "<Moderator>"))
            {
                return Redirect("/AdminHome/Index");
            }

            var user = _manager.Login(Email, Password);
            if (user != null)
            {
                TempData["UserName"] = user.FirstName;
                TempData["UserMail"] = user.Email;
            }
            
            return Redirect("/Plane/Plane");
            
        }
    }
}