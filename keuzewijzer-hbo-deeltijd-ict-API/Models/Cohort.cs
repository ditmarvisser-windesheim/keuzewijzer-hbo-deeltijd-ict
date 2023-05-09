namespace keuzewijzer_hbo_deeltijd_ict_API.Models
{
    public class Cohort
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User User { get; set; }

        public Cohort(int id, string name, User user)
        {
            Id = id;
            Name = name;
            User = user;
        }

        public Cohort()
        {

        }
    }
}
