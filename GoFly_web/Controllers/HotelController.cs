using GoFly_web.Managers.GoFlys;
using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
    public class HotelController : Controller
    {
        private readonly IHotelManager _manager;

        public HotelController(IHotelManager manager)
        {
            _manager = manager;
        }

        public async Task<IActionResult> Index()
        {
            var hotels = await _manager.GetAll();
            return View(hotels);
        }


        [HttpPost]
        public IActionResult CreateHotel(double price, int stars, int placeNumber, string name, string city)
        {
            _manager.CreateHotel(price, stars, placeNumber, name, city);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult DeleteHotel(int hotelId)
        {
            _manager.DeleteHotel(hotelId);
            return RedirectToAction(nameof(Index));
        }

        public RedirectResult GoToAdminHome()
        {
            return Redirect("/AdminHome/Index");
        }
    }
}
