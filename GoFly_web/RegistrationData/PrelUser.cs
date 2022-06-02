namespace GoFly_web.RegistrationData
{
    public class PrelUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

    
        public string Email { get; set; }

   
        public string Password { get; set; }

  
        public string Gender { get; set; }


        public int OrdersCount { get; set; }

        public string PhoneNumber { get; set; }

       
        public int Age { get; set; }

  

        public string Language { get; set; }

        public PrelUser(string firstName, string lastName, string email, string password, string gender, int orderCount, string phoneNumber, int age, string language)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Gender = gender;
            OrdersCount = orderCount;
            PhoneNumber = phoneNumber;
            Age = age;
            Language = language;

        }
    }
}
