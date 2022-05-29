using GoFly_web.Storage;
using GoFly_web.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace GoFly_web.Managers.GoFlys
{
    public class DepartureCountryManager : IDepartureCountryManager
    {
        private readonly GOflyContext _context;

        public DepartureCountryManager(GOflyContext context)
        {
            _context = context;
        }
        public async Task CreateCountry(string name)
        {
            var country = new DepartureCountry { Name = name };

            _context.DepartureCountries.Add(country);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteCountry(int id)
        {
            var country = _context.DepartureCountries.FirstOrDefault(c => c.Id == id);
            if (country != null)
            {
                _context.DepartureCountries.Remove(country);

                await _context.SaveChangesAsync();
            }
        }

        public async Task<IList<DepartureCountry>> GetAll() => await _context.DepartureCountries.ToListAsync();
    }
}
