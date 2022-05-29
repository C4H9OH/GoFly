using GoFly_web.Storage.Entity;

namespace GoFly_web.Managers.GoFlys
{
    public interface IDepartureCountryManager
    {
        Task<IList<DepartureCountry>> GetAll();

        Task CreateCountry(string name);

        Task DeleteCountry(int id);
    }
}
