using Microsoft.AspNetCore.Mvc;

namespace GoFly_web.Controllers
{
    public class AdminHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }






        public RedirectResult GoToDepCountries()
        {
            return Redirect("/DepartureCountry/Page");
        }

        public RedirectResult GoToArrCountries()
        {
            return Redirect("/ArrivalCountry/Page");
        }

        public RedirectResult GoToDepCities()
        {
            return Redirect("/DepartureCity/Index");
        }

        public RedirectResult GoToArrCities()
        {
            return Redirect("/ArrivalCity/Index");
        }

        public RedirectResult GoToHotels()
        {
            return Redirect("/Hotel/Index");
        }
    }
}


