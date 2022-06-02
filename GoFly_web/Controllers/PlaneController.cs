using GoFly_web.Managers;
using GoFly_web.Managers.GoFlys;
using GoFly_web.Storage.Entity;
using Microsoft.AspNetCore.Mvc;


namespace GoFly_web.Controllers
{
    public class PlaneController : Controller
    {

        private readonly IPlaneManager _manager;

        private readonly IAccountManager _accountmanager;
        public PlaneController(IPlaneManager manager, IAccountManager accountManager)
        {
            _manager = manager;
            _accountmanager = accountManager;   
        }
        public IActionResult Plane()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SearchPlane(string DepartureCity, string ArrivalCity, string DepartureDate, string ArrivalDate, int Persons)
        {
            var _planeTickets = await _manager.Search(DepartureCity, ArrivalCity, DepartureDate, ArrivalDate);
            ViewBag.PlaneTickets = _planeTickets;
            ViewBag.PlanePersons = Persons;
            return View();
        }

        [HttpPost]
        public IActionResult Plane(string Email, string Password)
        {
            var user = _accountmanager.Login(Email, Password);
            if (user != null)
            {
                ViewBag.UserName = user.FirstName;
                TempData["UserName"] = user.FirstName;
            }

            return View();

        }

    }
}
