namespace GoFly_web.Storage.Entity
{
    public class ArrivalCity
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

        public string CountryName { get; set; }

        [Required]
        public int ArrivalCountryId { get; set; }

        [ForeignKey(nameof(ArrivalCountryId))]
        public virtual ArrivalCountry ArrivalCountry { get; set; }

    }
}
