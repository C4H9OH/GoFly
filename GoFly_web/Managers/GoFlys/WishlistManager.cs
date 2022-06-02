using GoFly_web.Storage;
using GoFly_web.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace GoFly_web.Managers.GoFlys
{
    public class WishlistManager : IWishlistManager
    {
        private readonly GOflyContext _context;

        public WishlistManager(GOflyContext context)
        {
            _context = context;
        }
        public async Task<IList<Wishlist>> GetAll() => await _context.Wishlists.ToListAsync();

        public async Task<IList<Wishlist>> Search(User user)
        {
            List<Wishlist> _wishlists = new List<Wishlist>();

            foreach (var wlist in _context.Wishlists)
            {
                if(wlist.Id == user.Id)
                {
                    _context.Wishlists.Add(wlist);

                    await _context.SaveChangesAsync();
                }
            }

        return _wishlists;
        }
    }
}
