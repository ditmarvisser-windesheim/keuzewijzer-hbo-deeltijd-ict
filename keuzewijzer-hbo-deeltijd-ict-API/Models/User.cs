using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace keuzewijzer_hbo_deeltijd_ict_API.Models
{
    // Example model
    public class User : IdentityUser<string>
    {
        // TODO: remove this and edit the user controller if needed
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Role> Roles { get; set; }
        public StudyRoute? StudyRoute { get; set; }
        public Cohort? Cohort { get; set; }
        public DateTime? TimedOut { get; set; }
        public List<SemesterItem>? SemesterItems { get; set; }

        [NotMapped]
        public List<int> SemesterItemsId { get; set; }

        // TODO
        [NotMapped]
        public int? CohortId { get; set; }

        public User(string id, string name, string firstName, string lastName, List<Role> roles)
        {
            Id = id;
            Name = name;
            FirstName = firstName;
            LastName = lastName;
            Roles = roles;
        }

        public User()
        {
        }
    }
}
