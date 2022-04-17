using GoFly_web.Storage.Entity;

namespace GoFly_web.Managers
{
    public interface IGoFlyManager
    {
        ICollection<Itinerary> GetAll();

        ICollection<Itinerary> GetItineraryByDepartureCity(Guid departureCityId);
        ICollection<Itinerary> GetItineraryByArrivalCity(Guid arrivalCityId);
        void Delete(Guid id);

        void AddItinerary(string departureCity, string arrivalCity);
    }
}
