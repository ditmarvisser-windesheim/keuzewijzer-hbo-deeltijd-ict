using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace keuzewijzer_hbo_deeltijd_ict_API.Models
{
    public class SemesterItem
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }


        [Required, Range(1, 2)]
        public int Semester { get; set; }
        public ICollection<Cohort> Cohorts { get; set; }

        // Navigation property for the many-to-many relationship
        public List<SemesterItem> RequiredSemesterItem { get; set; }
        public List<SemesterItem> DependentSemesterItem { get; set; }
        public virtual List<Module> Modules { get; set; } = new List<Module>();

        [NotMapped]
        public List<int> Year { get; set; } // Mark as not mapped to avoid primary key requirement

        [NotMapped]
        public List<int> CohortsId { get; set; }
        [NotMapped]
        public List<int> RequiredSemesterItemId { get; set; }

        public string YearJson
        {
            get => JsonConvert.SerializeObject(Year);
            set => Year = JsonConvert.DeserializeObject<List<int>>(value);
        }

        public SemesterItem()
        {
        }

        public SemesterItem(int id, string name, string description, List<int> year, int semester, ICollection<Cohort> cohorts)
        {
            Id = id;
            Name = name;
            Description = description;
            Year = year;
            Semester = semester;
            Cohorts = cohorts;
            RequiredSemesterItem = new List<SemesterItem>();
            DependentSemesterItem = new List<SemesterItem>();
        }
    }
}
