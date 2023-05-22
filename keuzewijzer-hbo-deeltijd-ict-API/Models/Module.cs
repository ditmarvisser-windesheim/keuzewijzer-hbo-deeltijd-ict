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
        public int SemesterItemId { get; set; }
        public SemesterItem SemesterItem { get; set; } = null!;

        public Module(string name)
        {
            Name = name;
        }

        public Module(int id, string name, int semesterItemId)
        {
            Id = id;
            Name = name;
            SemesterItemId = semesterItemId;
        }

        public Module() { }
    }
}
