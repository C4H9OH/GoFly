using GoFly_web.Storage;
using GoFly_web.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace GoFly_web.Managers.GoFlys
{
    public class TrainManager : ITrainManager
    {
        private readonly GOflyContext _context;

        public TrainManager(GOflyContext context)
        {
            _context = context;
        }
        public async Task<IList<Itinerary>> GetAll() => await _context.Itineraries.ToListAsync();



        public async Task<IList<Itinerary>> Search(string departureCity, string arrivalCity, string departureTime, string arrivalTime)
        {
            List<Itinerary> _trainTickets = new List<Itinerary>();

            foreach (var _tTicket in _context.Itineraries)
            {
                if ((_tTicket.DepartureCityName == departureCity) & (_tTicket.ArrivalCityName == arrivalCity) & (_tTicket.Date == departureTime) & (_tTicket.TransportName == "Поезд"))
                {
                    _trainTickets.Add(_tTicket);
                }

            }

            try
            {
                if (_trainTickets.Count == 0)
                {
                    foreach (var _tTicket in _context.Itineraries)
                    {
                        if ((_tTicket.DepartureCityName == departureCity.Replace(" ", "")) & (_tTicket.ArrivalCityName == arrivalCity.Replace(" ", "")) & (_tTicket.Date == departureTime) & (_tTicket.TransportName == "Поезд"))
                        {
                            _trainTickets.Add(_tTicket);
                        }

                    }
                }
            }
            catch (Exception ex) { }

            return _trainTickets;
        }
    }
}
