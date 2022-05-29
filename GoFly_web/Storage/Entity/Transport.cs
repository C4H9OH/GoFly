namespace GoFly_web.Storage.Entity
{
    public class Transport
    {
        [Key]
        public int Id { get; set; }
       
        [Required]
        public string Name { get; set; }

        public int Popularity { get; set; }
    }
}
