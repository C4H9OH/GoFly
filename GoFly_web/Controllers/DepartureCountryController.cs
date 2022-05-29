using GoFly_web.Managers.GoFlys;
using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
    public class DepartureCountryController : Controller
    {
        private readonly IDepartureCountryManager _manager;

        public DepartureCountryController(IDepartureCountryManager manager)
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
            return Redirect("/ArrivalCountry/Page");
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

        public RedirectResult GoToAdminHome()
        {
            return Redirect("/AdminHome/Index");
        }
    }
}
