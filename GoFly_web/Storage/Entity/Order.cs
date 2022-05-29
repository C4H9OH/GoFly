namespace GoFly_web.Storage.Entity
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]

        public double Summary { get; set; }

        [Required]

        public string OrederDate { get; set; }


        [Required]

        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }

        [Required]

        public int ItineraryId { get; set; }

        [ForeignKey(nameof(ItineraryId))]
        public virtual Itinerary Itinerary { get; set; }


    }
}
