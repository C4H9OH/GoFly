
namespace GoFly_web.Storage.Entity
{
    public class DepartureCity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Currency { get; set; }

        [Required]
        public string Language { get; set; }

        [Required]
        public string Description { get; set; }

        public string Image { get; set; }

        [Required]
        public int DepartureCountryId { get; set; }

        [ForeignKey(nameof(DepartureCountryId))]
        public virtual DepartureCountry DepartureCountry { get; set; }
    }
}
