using System.ComponentModel.DataAnnotations;

namespace keuzewijzer_hbo_deeltijd_ict_API.Models
{
    public class SemesterItem
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required, Range(1, 999)]
        public int Year { get; set; }

        [Required, Range(1, 2)]
        public int Semester { get; set; }
        public ICollection<Cohort> Cohorts { get; set; }

        // Navigation property for the many-to-many relationship
        public List<SemesterItem> RequiredSemesterItem { get; set; }
        public List<SemesterItem> DependentSemesterItem { get; set; }
        public int StudyRouteId { get; set; }
        public StudyRoute StudyRoute { get; set; } = null!;
        public virtual List<SemesterItems> Modules { get; set; } = new List<SemesterItems>();
        public SemesterItem(int id, int year, int semester, int studyRouteId, StudyRoute studyRoute)
        {
            Id = id;
            Year = year;
            Semester = semester;
            StudyRouteId = studyRouteId;
            StudyRoute = studyRoute;
        }

        public SemesterItem()
        {
        }

    }
}
