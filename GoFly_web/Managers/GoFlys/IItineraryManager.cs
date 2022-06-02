using GoFly_web.Storage.Entity;

namespace GoFly_web.Managers
{
    public interface IItineraryManager
    {
        //ICollection<Itinerary> GetAll();
        Task<IList<Itinerary>> GetAll();

        Task DeleteItinerary(int id);

        Task AddItinerary(string departureCity, string arrivalCity, 
            string transport, string travalTime, string departureTime, string arrivalTime, double price);
    }
}
