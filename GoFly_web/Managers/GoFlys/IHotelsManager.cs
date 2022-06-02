using GoFly_web.Storage.Entity;

namespace GoFly_web.Managers.GoFlys
{
    public interface IHotelsManager
    {
        Task<IList<Hotel>> GetAll();

        Task<IList<Hotel>> Search(string city, int threeStar, int fourStar, int fiveStar);
    }
}
