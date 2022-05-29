namespace GoFly_web.Storage.Entity
{
    public class Wishlist
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }

        [Required]
        public int HotelsCount { get; set; }

        [Required]
        public int ItinerariesCount { get; set; }
    }
}
