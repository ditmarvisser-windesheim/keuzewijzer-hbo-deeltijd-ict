namespace keuzewijzer_hbo_deeltijd_ict_MVC.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User()
        {
        }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}