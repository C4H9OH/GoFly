using GoFly_web.Storage.Entity;

namespace GoFly_web.Managers.GoFlys
{
    public interface IBusManager
    {
        Task<IList<Itinerary>> GetAll();

        Task<IList<Itinerary>> Search(string departureCity, string arrivalCity, string departureTime, string arrivalTime);
    }
}
