using System.ComponentModel.DataAnnotations;

namespace keuzewijzer_hbo_deeltijd_ict_API.Models
{
    //Example model
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public User()
        {
        }
    }
}
