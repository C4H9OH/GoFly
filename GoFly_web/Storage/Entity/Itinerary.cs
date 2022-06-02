

namespace GoFly_web.Storage.Entity
{
    public class Itinerary
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public int DepartureCityId { get; set; }

        [ForeignKey(nameof(DepartureCityId))]
        public virtual DepartureCity DepartureCity { get; set; }

        [Required]
        public int ArrivalCityId { get; set; }

        [ForeignKey(nameof(ArrivalCityId))]
        public virtual ArrivalCity ArrivalCity { get; set; }

        [Required]
        public int TransportId { get; set; }

        [ForeignKey(nameof(TransportId))]
        public virtual Transport Transport { get; set; }

        [Required]
        public string TravalTime { get; set; }

        [Required]
        public string DepartureTime { get; set; }

        [Required]
        public string ArrivalTime { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]

        public string ArrivalCityName { get; set; }

        [Required]

        public string DeparturelCityName { get; set; }

        [Required]

        public string TransportName { get; set; }




    }
}
