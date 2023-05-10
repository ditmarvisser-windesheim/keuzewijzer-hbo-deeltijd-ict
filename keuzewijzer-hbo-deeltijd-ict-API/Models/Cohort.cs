namespace keuzewijzer_hbo_deeltijd_ict_API.Models
{
    public class Cohort
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public Cohort(int id, string name, int userId)
        {
            Id = id;
            Name = name;
            UserId = userId;
        }

        public Cohort()
        {

        }
    }
}
