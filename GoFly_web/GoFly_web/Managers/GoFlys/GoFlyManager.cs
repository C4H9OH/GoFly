using GoFly_web.Storage;
using GoFly_web.Storage.Entity;

namespace GoFly_web.Managers
{
    public class GoFlyManager : IGoFlyManager
    {
        private GOflyContext _context;

        public GoFlyManager(GOflyContext context)
        {
            _context = context;
        }
        public void AddItinerary(string departureCity, string arrivalCity)
        {
            var cityDepart = _context.Cities.FirstOrDefault(cd => cd.Name == departureCity);
            var cityArriv = _context.Cities.FirstOrDefault(ca => ca.Name == arrivalCity);
            if ((cityArriv != null) & (cityDepart != null)) 
                    _context.Itineraries.Add(new Itinerary(Guid.NewGuid(), cityDepart, cityArriv));
        }

        public void Delete(Guid id)
        {
            var itinerary = _context.Itineraries.FirstOrDefault(it => it.Id == id);

            if (itinerary != null)
                _context.Itineraries.Remove(itinerary);
        }

        public ICollection<Itinerary> GetAll()
        {
            return _context.Itineraries;
        }

        public ICollection<Itinerary> GetItineraryByArrivalCity(Guid arrivalCityId)
        {
            return _context.Itineraries.Where(it => it.ArrivalCity.Id == arrivalCityId).ToList();
        }

        public ICollection<Itinerary> GetItineraryByDepartureCity(Guid departureCityId)
        {
            return _context.Itineraries.Where(it => it.DepartureCity.Id == departureCityId).ToList();
        }
    }
}
