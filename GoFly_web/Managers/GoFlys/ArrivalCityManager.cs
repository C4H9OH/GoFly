using GoFly_web.Storage;
using GoFly_web.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace GoFly_web.Managers.GoFlys
{
    public class ArrivalCityManager : IArrivalCityManager
    {
        private readonly GOflyContext _context;

        public ArrivalCityManager(GOflyContext context)
        {
            _context = context;
        }
        public async Task CreateCity(string name, string currency, string language, string description, string imageLink, string country)
        {
            var _country = _context.ArrivalCountries.FirstOrDefault(c => c.Name == country);
            if (_country != null)
            {
                var arrCity = new ArrivalCity { 
                    Name = name,
                    ArrivalCountry = _country,
                    Currency = currency,
                    Language = language,
                    Description = description,
                    Image = imageLink,
                    CountryName = _country.Name};

                _context.ArrivalCities.Add(arrCity);

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteCity(int id)
        {
            var city = _context.ArrivalCities.FirstOrDefault(c => c.Id == id);
            if (city != null)
            {
                _context.ArrivalCities.Remove(city);

                await _context.SaveChangesAsync();
            }
        }

        public async Task<IList<ArrivalCity>> GetAll() => await _context.ArrivalCities.ToListAsync();
    }
}
