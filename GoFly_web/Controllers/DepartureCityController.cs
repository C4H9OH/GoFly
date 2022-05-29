using GoFly_web.Managers.GoFlys;
using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
    public class DepartureCityController : Controller
    {
        private readonly IDepartureCityManager _manager;

        public DepartureCityController(IDepartureCityManager manager)
        {
            _manager = manager;
        }

        public async Task<IActionResult> Index()
        {
            var cities = await _manager.GetAll();
            return View(cities);
        }


        [HttpPost]
        public IActionResult CreateCity(string name, string currency, string language, string description, string imageLink, string country)
        {
            _manager.CreateCity(name, currency, language, description, imageLink, country);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult DeleteCity(int countryId)
        {
            _manager.DeleteCity(countryId);
            return RedirectToAction(nameof(Index));
        }

        public RedirectResult GoToAdminHome()
        {
            return Redirect("/AdminHome/Index");
        }
    }
}
