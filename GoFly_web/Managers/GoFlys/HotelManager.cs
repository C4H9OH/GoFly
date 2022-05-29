using GoFly_web.Storage;
using GoFly_web.Storage.Entity;
using Microsoft.EntityFrameworkCore;


namespace GoFly_web.Managers.GoFlys
{
    public class HotelManager : IHotelManager
    {
        private readonly GOflyContext _context;

        public HotelManager(GOflyContext context)
        {
            _context = context;
        }
        public async Task CreateHotel(double price, int stars, int placeNumber, string name, string city)
        {
            var _city = _context.ArrivalCities.FirstOrDefault(c => c.Name == city);
            if (_city != null)
            {
                var hotel = new Hotel
                {
                    Name = name,
                    Price = price,
                    StarRating = stars,
                    PlacesNumber = placeNumber,
                    ArrivalCity = _city,
                };

                _context.Hotels.Add(hotel);

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteHotel(int id)
        {
            var hotel = _context.Hotels.FirstOrDefault(h => h.Id == id);
            if (hotel != null)
            {
                _context.Hotels.Remove(hotel);

                await _context.SaveChangesAsync();
            }
        }

        public async Task<IList<Hotel>> GetAll() => await _context.Hotels.ToListAsync();
    }
}
