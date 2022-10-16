using GoFly_web.Managers.GoFlys;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace GoFly_web.Controllers
{
    public class ArrivalCountryController : Controller
    {

        private readonly IArrivalCountryManager _manager;




        public ArrivalCountryController(IArrivalCountryManager manager)
        {
            _manager = manager;
        }

        public async Task<IActionResult> Page()
        {
            var countries = await _manager.GetAll();
            return View(countries);
        }

        public RedirectResult GoToDepCountry()
        {
            return Redirect("/DepartureCountry/Page");
        }

        public RedirectResult GoToAdminHome()
        {
            return Redirect("/AdminHome/Index");
        }


        [HttpPost]
        public IActionResult DeleteCountry(int countryId)
        {
            _manager.DeleteCountry(countryId);
            return RedirectToAction(nameof(Page));
        }

        [HttpPost]
        public IActionResult CreateCountry(string name)
        {
            _manager.CreateCountry(name);
            return RedirectToAction(nameof(Page));
        }

     
    }
}
