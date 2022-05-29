namespace GoFly_web.Storage.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]

        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public int OrdersCount { get; set; }

        public string PhoneNumber { get; set; }
       
        [Required]
        public int Age { get; set; }
       
        [Required]

        public string Language { get; set; }


    }
}
