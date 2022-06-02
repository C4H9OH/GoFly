namespace GoFly_web.Storage.Entity
{
    public class Wishlist
    {

        [Key]
        public int Id { get; set; }

        public string? DepartureCity { get; set; }

        public string? ArrivalCity { get; set; }

        public string? ArrivalTime { get; set; }

        public double Price { get; set; }
        public string? Hotel { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }
    }
}
