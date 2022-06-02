using GoFly_web.Managers.GoFlys;
using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
    public class BusController : Controller
    {
        private readonly IBusManager _manager;

        public BusController(IBusManager manager)
        {
            _manager = manager;
        }
        public IActionResult Bus()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SearchBus(string DepartureCity, string ArrivalCity, string DepartureDate, string ArrivalDate, int Persons)
        {
            var _busTickets = await _manager.Search(DepartureCity, ArrivalCity, DepartureDate, ArrivalDate);
            ViewBag.BusTickets = _busTickets;
            ViewBag.BusPersons = Persons;
            return View();
        }

    }
}
