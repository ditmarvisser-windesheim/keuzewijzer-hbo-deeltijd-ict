using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace keuzewijzer_hbo_deeltijd_ict_API.Models
{
    // Example model
    public class User : IdentityUser<string>
    {
        // TODO: remove this and edit the user controller if 
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<IdentityRole>? Roles { get; set; }
        public StudyRoute? StudyRoute { get; set; }
        public Cohort? Cohort { get; set; }
        public DateTime? TimedOut { get; set; }
        public List<SemesterItem>? SemesterItems { get; set; }
        public string? MentorId { get; set; }
        public User? Mentor { get; set; }
        public List<User>? Students { get; set; }

        [NotMapped]
        public List<int> SemesterItemsId { get; set; }

        // TODO
        [NotMapped]
        public int? CohortId { get; set; }

        public User(string id, string name, string firstName, string lastName)
        {
            Id = id;
            Name = name;
            FirstName = firstName;
            LastName = lastName;
        }

        public User()
        {
        }
    }
}
