using GoFly_web.Storage.Entity;

namespace GoFly_web.Managers.GoFlys
{
    public interface IHotelManager
    {
        Task<IList<Hotel>> GetAll();

        Task CreateHotel(double price, int stars, int placeNumber, string name, string city);

        Task DeleteHotel(int id);

    }
}
