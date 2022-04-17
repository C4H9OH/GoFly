using GoFly_web.Storage.Entity;

namespace GoFly_web.Storage
{
    public class GOflyContext
    {
        public List<City> Cities { get; set; }

        public List<Country> Countries { get; set; }

        public List<Itinerary> Itineraries { get; set; }

        public GOflyContext()
        {
            Cities = new List<City>();
            Countries = new List<Country>();    
            Itineraries = new List<Itinerary>();


            var country1 = new Country(Guid.NewGuid(), "Russia");
            var country2 = new Country(Guid.NewGuid(), "Finland");

            Cities.Add(new City(Guid.NewGuid(), "Moscow", country1));
            Cities.Add(new City(Guid.NewGuid(), "Krasnoyarsk", country1));
            Cities.Add(new City(Guid.NewGuid(), "Helsinki", country2));


            Itineraries.Add(new Itinerary(Guid.NewGuid(), Cities[1], Cities[0]));
            Itineraries.Add(new Itinerary(Guid.NewGuid(), Cities[0], Cities[2]));

        }
    }
}
