namespace keuzewijzer_hbo_deeltijd_ict_API.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User>? Users { get; set; }

        public Role(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
