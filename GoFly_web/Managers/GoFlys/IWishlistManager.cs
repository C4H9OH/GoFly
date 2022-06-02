using GoFly_web.Storage.Entity;

namespace GoFly_web.Managers.GoFlys
{
    public interface IWishlistManager
    {
        Task<IList<Wishlist>> GetAll();

        Task<IList<Wishlist>> Search(User user);
    }
}

