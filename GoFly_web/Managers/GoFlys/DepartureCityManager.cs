using GoFly_web.Storage;
using GoFly_web.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace GoFly_web.Managers.GoFlys
{
    public class DepartureCityManager : IDepartureCityManager
    {
        private readonly GOflyContext _context;

        public DepartureCityManager(GOflyContext context)
        {
            _context = context;
        }

        public async Task CreateCity(string name, string currency, string language, string description, string imageLink, string country)
        {
            var _country = _context.DepartureCountries.FirstOrDefault(c => c.Name == country);
            if (_country != null)
            {
                var depCity = new DepartureCity
                {
                    Name = name,
                    DepartureCountry = _country,
                    Currency = currency,
                    Language = language,
                    Description = description,
                    Image = imageLink,
                    CountryName = _country.Name
                };

                _context.DepartureCities.Add(depCity);

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteCity(int id)
        {
            var city = _context.DepartureCities.FirstOrDefault(c => c.Id == id);
            if (city != null)
            {
                _context.DepartureCities.Remove(city);

                await _context.SaveChangesAsync();
            }
        }

        public async Task<IList<DepartureCity>> GetAll() => await _context.DepartureCities.ToListAsync();
    }
}
