namespace GoFly_web.Storage.Entity
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }

        [Required]

        public string Name { get; set; }
       
        [Required]
        public Double Price { get; set; }

        [Required]

        public int StarRating { get; set; }

        [Required]
        public int PlacesNumber { get; set; }

        [Required]

        public string ArrivalCityName { get; set; }    

        [Required]
        public int ArrivalCityId { get; set; }

        [ForeignKey(nameof(ArrivalCityId))]
        public virtual ArrivalCity ArrivalCity { get; set; }

    }
}
