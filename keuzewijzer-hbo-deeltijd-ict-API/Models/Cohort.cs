using System.ComponentModel.DataAnnotations.Schema;

namespace keuzewijzer_hbo_deeltijd_ict_API.Models
{
    public class Cohort
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public ICollection<SemesterItem>? SemesterItems { get; set; }
        public int? UserId { get; set; }

        [NotMapped]
        public User User { get; set; } = null!;

        public Cohort(int id, string name, int year, int userId)
        {
            Id = id;
            Name = name;
            Year = year;
            UserId = userId;
        }

        public Cohort(int id, string name, int year)
        {
            Id = id;
            Name = name;
            Year = year;

        }

        public Cohort()
        {

        }
    }
}
