namespace GoFly_web.Storage.Entity
{
    public class Feedback
    {

        [Key]
        public int Id { get; set; }

        public string? Description { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }

    }
}