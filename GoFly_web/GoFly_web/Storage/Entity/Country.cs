namespace GoFly_web.Storage.Entity
{
    public class Country
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Country(Guid id, string name)
        {
            Id = id;
            Name = name;    
        }
    }
}
