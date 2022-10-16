using GoFly_web.Storage;
using GoFly_web.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace GoFly_web.Managers.GoFlys
{
    public class PlaneManager : IPlaneManager
    {
        private readonly GOflyContext _context;

        public PlaneManager(GOflyContext context)
        {
            _context = context;
        }
        public async Task<IList<Itinerary>> GetAll() => await _context.Itineraries.ToListAsync();



        public async Task<IList<Itinerary>> Search(string departureCity, string arrivalCity, string departureTime, string arrivalTime)
        {
            List<Itinerary> _planeTickets = new List<Itinerary>();

            foreach (var _pTicket in _context.Itineraries) 
            {
                if ((_pTicket.DepartureCityName == departureCity) & (_pTicket.ArrivalCityName == arrivalCity)& (_pTicket.Date == departureTime) & (_pTicket.TransportName == "Самолёт"))
                {
                    _planeTickets.Add(_pTicket);
                }
                    
            }

            try
            {
                if (_planeTickets.Count == 0)
                {
                    foreach (var _pTicket in _context.Itineraries)
                    {
                        if ((_pTicket.DepartureCityName == departureCity.Replace(" ", "")) & (_pTicket.ArrivalCityName == arrivalCity.Replace(" ", "")) & (_pTicket.Date == departureTime) & (_pTicket.TransportName == "Самолёт"))
                        {
                            _planeTickets.Add(_pTicket);
                        }

                    }
                }
            }
            catch (Exception ex) { }

            return _planeTickets;
        }
    }
}
