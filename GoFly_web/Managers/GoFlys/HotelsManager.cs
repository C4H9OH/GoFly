using GoFly_web.Storage;
using GoFly_web.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace GoFly_web.Managers.GoFlys
{
    public class HotelsManager : IHotelsManager
    {
        private readonly GOflyContext _context;

        public HotelsManager(GOflyContext context)
        {
            _context = context;
        }

        public async Task<IList<Hotel>> Search(string city,int threeStar, int fourStar, int fiveStar)
        {
            List<Hotel> _hotels = new List<Hotel>();

            foreach (var _hotel in _context.Hotels)
            {
                if (_hotel.ArrivalCityName == city)
                {
                    if ((threeStar == 3) & (_hotel.StarRating == 3))
                    {
                        _hotels.Add(_hotel);

                    }
                    if ((fourStar == 4) & (_hotel.StarRating == 4))
                    {
                        _hotels.Add(_hotel);
                    }
                    if ((fiveStar == 5) & (_hotel.StarRating == 5))
                    {
                        _hotels.Add(_hotel);
                    }

                    if ((fiveStar == 0) & (fourStar == 0) & (threeStar == 0))
                    {
                        _hotels.Add(_hotel);
                    }


                }


                
            }
            try
            {
                if (_hotels.Count == 0)
                {
                    foreach (var _hotel in _context.Hotels)
                    {
                        if (_hotel.ArrivalCityName == city.Replace(" ", ""))
                        {
                            if ((threeStar == 3) & (_hotel.StarRating == 3))
                            {
                                _hotels.Add(_hotel);

                            }
                            if ((fourStar == 4) & (_hotel.StarRating == 4))
                            {
                                _hotels.Add(_hotel);
                            }
                            if ((fiveStar == 5) & (_hotel.StarRating == 5))
                            {
                                _hotels.Add(_hotel);
                            }

                            if ((fiveStar == 0) & (fourStar == 0) & (threeStar == 0))
                            {
                                _hotels.Add(_hotel);
                            }


                        }
                    }
                }
            }
            catch (Exception ex) {  }
            return _hotels;
        }
       

        public async Task<IList<Hotel>> GetAll() => await _context.Hotels.ToListAsync();
    }
}
