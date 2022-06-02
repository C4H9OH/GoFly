using GoFly_web.Managers.GoFlys;
using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
    public class TopCitiesController : Controller
    {
        private readonly IArrivalCityManager _manager;

        public TopCitiesController(IArrivalCityManager manager)
        {
            _manager = manager;
        }

        public async Task<IActionResult> TopCities()
        {
            var cities = await _manager.GetAll();
            return View(cities);
        }
    }
}
