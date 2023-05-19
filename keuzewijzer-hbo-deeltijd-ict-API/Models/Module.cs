using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace keuzewijzer_hbo_deeltijd_ict_API.Models
{
    public class Module
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required, Range(1, 2)]
        public int Semester { get; set; }

        [Required, Range(1, 999)]
        public int Year { get; set; }


        public ICollection<Cohort>? Cohorts { get; set; }

        // Navigation property for the many-to-many relationship
        public List<Module> RequiredModules { get; set; }

        public List<Module> DependentModules { get; set; }

        public Module(string name, string description, int semester, int year)
        {
            Name = name;
            Description = description;
            Semester = semester;
            Year = year;
            RequiredModules = new List<Module>();
            DependentModules = new List<Module>();
        }

        public Module(int id, string name, string description, int semester, int year)
        {
            Id = id;
            Name = name;
            Description = description;
            Semester = semester;
            Year = year;
            RequiredModules = new List<Module>();
            DependentModules = new List<Module>();
        }

        public Module() { }
    }
}
