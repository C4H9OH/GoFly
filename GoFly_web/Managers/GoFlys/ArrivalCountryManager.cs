using GoFly_web.Storage;
using GoFly_web.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace GoFly_web.Managers.GoFlys
{
    public class ArrivalCountryManager : IArrivalCountryManager
    {
        private readonly GOflyContext _context;

        public ArrivalCountryManager(GOflyContext context)
        {
            _context = context;
        }
        public async Task CreateCountry(string name)
        {
            var country = new ArrivalCountry { Name = name };

            _context.ArrivalCountries.Add(country);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteCountry(int id)
        {
            var country = _context.ArrivalCountries.FirstOrDefault(c => c.Id == id);
            if (country != null)
            {
                _context.ArrivalCountries.Remove(country);

                await _context.SaveChangesAsync();
            }
        }

        public async Task<IList<ArrivalCountry>> GetAll() => await _context.ArrivalCountries.ToListAsync();

    }
}
