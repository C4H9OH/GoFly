using GoFly_web.Managers;
using Microsoft.AspNetCore.Mvc;
using GoFly_web.Storage;
using GoFly_web.Storage.Entity;

namespace GoFly_web.Controllers
{
    public class GoFlyController : Controller
    {
        private IGoFlyManager _manager;

        public GoFlyController(IGoFlyManager manager)
        {
            _manager = manager;         
        }

        public IActionResult Index()
        {
            var itineraries = _manager.GetAll();
            return View(itineraries);
        }

        [HttpPost]
        public IActionResult DeleteItinerary(Guid itineraryId)
        {
            _manager.Delete(itineraryId);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult CreateItinerary(string departureCity, string arrivalCity)
        {
            _manager.AddItinerary(departureCity, arrivalCity);
            return RedirectToAction(nameof(Index));
        }

    }
}
