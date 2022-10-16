using GoFly_web.Managers;
using GoFly_web.Managers.GoFlys;
using GoFly_web.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
    public class HotelsController : Controller
    {
        private readonly IHotelsManager _manager;

        public HotelsController(IHotelsManager manager)
        {
            _manager = manager;
        }
        public IActionResult Hotels()
        {
            return View();
        }

       

        [HttpPost]
        public async Task<IActionResult> SearchHotels(string Icity, int Persons,
            int ThreeStars, int FourStars, int FiveStars, string CheckInDate, string CheckOutDate)
        {
            var _hotels = await _manager.Search(Icity,ThreeStars, FourStars, FiveStars);
            ViewBag.Hotel = _hotels;
            ViewBag.Persons = Persons;
            var checkInDate = DateTime.Parse(CheckInDate);
            var checkOutDate = DateTime.Parse(CheckOutDate);
            ViewBag.Days = ((checkOutDate - checkInDate).Days);
            if(ViewBag.Days < 1) { ViewBag.Days = 1; }
            ViewBag.starThree = ThreeStars;
            ViewBag.starFour = FourStars;
            ViewBag.starFive = FiveStars;
            return View();
        }


    }
}
