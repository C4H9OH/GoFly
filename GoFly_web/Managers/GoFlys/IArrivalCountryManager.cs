using GoFly_web.Storage.Entity;

namespace GoFly_web.Managers.GoFlys
{
    public interface IArrivalCountryManager
    {
        Task<IList<ArrivalCountry>> GetAll();

        Task CreateCountry(string name);

        Task DeleteCountry(int id);

    }
}
