using GoFly_web.Storage.Entity;

namespace GoFly_web.Managers.GoFlys
{
    public interface IOrderManager
    {
        Task<IList<Order>> GetAll();

        Task CreateOrder(string departureCity, string arrivalCity, string arrivalTime, string price,
            string Hotel, string orderTime, User user);
    }
}
