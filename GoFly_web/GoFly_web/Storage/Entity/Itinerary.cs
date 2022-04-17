

namespace GoFly_web.Storage.Entity
{
    public class Itinerary
    {
        public Guid Id { get; set; }
        public City DepartureCity { get; set; }

        public City ArrivalCity { get; set; }

        
        public Itinerary(Guid id, City departureCity, City arrivalCity)
        {
            Id = id;
            DepartureCity = departureCity;  
            ArrivalCity = arrivalCity;  
        }
    }
}
