namespace GoFly_web.Storage.Entity
{
    public class City
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        public Country Country { get; set; }

        public City(Guid id, string name, Country country)
        {
            Id = id;
            Name = name;    
            Country = country;
        }
    }
}
