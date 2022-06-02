using GoFly_web.Managers.GoFlys;
using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
    public class RailwayController : Controller
    {
        private readonly ITrainManager _manager;

        public RailwayController(ITrainManager manager)
        {
            _manager = manager;
        }
        public IActionResult Railway()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SearchTrain(string DepartureCity, string ArrivalCity, string DepartureDate, string ArrivalDate, int Persons)
        {
            var _planeTickets = await _manager.Search(DepartureCity, ArrivalCity, DepartureDate, ArrivalDate);
            ViewBag.TrainTickets = _planeTickets;
            ViewBag.TrainPersons = Persons;
            return View();
        }
    }
}
