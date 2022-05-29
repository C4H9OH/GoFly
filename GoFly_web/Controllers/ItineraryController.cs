using GoFly_web.Managers;
using Microsoft.AspNetCore.Mvc;
using GoFly_web.Storage;
using GoFly_web.Storage.Entity;

namespace GoFly_web.Controllers
{
    public class ItineraryController : Controller
    {
        private readonly IItineraryManager _manager;

        public ItineraryController(IItineraryManager manager)
        {
            _manager = manager;
        }



        public async Task<IActionResult> Index()
        {
            var itineraries = await _manager.GetAll();

            return View(itineraries);
        }


        public IActionResult Hot()
        {

            return View();
        }

        [HttpPost]
        public IActionResult DeleteItinerary(int itineraryId)
        {
            _manager.DeleteItinerary(itineraryId);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult CreateItinerary(string departureCity, string arrivalCity,
        string transport, string travalTime, string departureTime, string arrivalTime, double price)
        {
            _manager.AddItinerary(departureCity, arrivalCity, transport, travalTime, departureTime, arrivalTime, price);
            return RedirectToAction(nameof(Index));
        }


    }
}