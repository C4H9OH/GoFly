using GoFly_web.Storage;
using GoFly_web.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace GoFly_web.Managers.GoFlys
{
    public class BusManager : IBusManager
    {
        private readonly GOflyContext _context;

        public BusManager(GOflyContext context)
        {
            _context = context;
        }
        public async Task<IList<Itinerary>> GetAll() => await _context.Itineraries.ToListAsync();



        public async Task<IList<Itinerary>> Search(string departureCity, string arrivalCity, string departureTime, string arrivalTime)
        {
            List<Itinerary> _busTickets = new List<Itinerary>();

            foreach (var _bTicket in _context.Itineraries)
            {
                if ((_bTicket.DeparturelCityName == departureCity) & (_bTicket.ArrivalCityName == arrivalCity) & (_bTicket.TransportName == "Автобус"))
                {
                    _busTickets.Add(_bTicket);
                }

            }

            try
            {

                if (_busTickets.Count == 0)
                {
                    foreach (var _bTicket in _context.Itineraries)
                    {
                        if ((_bTicket.DeparturelCityName == departureCity.Replace(" ", "")) & (_bTicket.ArrivalCityName == arrivalCity.Replace(" ", "")) & (_bTicket.TransportName == "Автобус"))
                        {
                            _busTickets.Add(_bTicket);
                        }

                    }
                }
            }
            catch (Exception ex) { }
            return _busTickets;
        }
    }
}
