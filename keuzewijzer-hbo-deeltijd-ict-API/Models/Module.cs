using System.ComponentModel.DataAnnotations;

namespace keuzewijzer_hbo_deeltijd_ict_API.Models
{
    public class Module
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public Module(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public Module() { }
    }
}
