using GoFly_web.Storage;
using GoFly_web.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace GoFly_web.Managers
{
    public class ItineraryManager : IItineraryManager
    {
        private GOflyContext _context;

        public ItineraryManager(GOflyContext context)
        {
            _context = context;
        }

        public async Task AddItinerary(string departureCity, string arrivalCity,
            string transport, string travalTime, string departureTime, string arrivalTime, double price)
        {
            var _departureCity = _context.DepartureCities.FirstOrDefault(c=>c.Name == departureCity);
            var _arrivalCity = _context.ArrivalCities.FirstOrDefault(c=>c.Name == arrivalCity);
            var _transport = _context.Transports.FirstOrDefault(t=>t.Name == transport);
                

            if ((_departureCity != null) & (_arrivalCity != null) & (_transport != null))
                    {
                        var itinerary = new Itinerary 
                        {
                            DepartureCity = _departureCity, 
                            ArrivalCity = _arrivalCity,
                            Transport = _transport,
                            TravalTime = travalTime,  
                            DepartureTime = departureTime,
                            ArrivalTime = arrivalTime,
                            Price = price 
                        };

                         _context.Itineraries.Add(itinerary);

                        await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteItinerary(int id)
        {
            var itinerary = _context.Itineraries.FirstOrDefault(i => i.Id == id);
            if (itinerary != null)
            {
                _context.Itineraries.Remove(itinerary);

                await _context.SaveChangesAsync();
            }
        }

        public async Task<IList<Itinerary>> GetAll() => await _context.Itineraries.ToListAsync();

       
    }
}
