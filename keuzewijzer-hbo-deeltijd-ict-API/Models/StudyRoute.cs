using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Hosting;

namespace keuzewijzer_hbo_deeltijd_ict_API.Models
{
    public class StudyRoute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Approved_sb { get; set; }
        public bool Approved_eb { get; set; }
        public string Note { get; set; }
        public bool Send_sb { get; set; }
        public bool Send_eb { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public ICollection<StudyRouteItem> Posts { get; set; }

        public StudyRoute(int id, string name, bool approved_sb, bool approved_eb, string note, bool send_sb, bool send_eb, int userId, User user, ICollection<StudyRouteItem> posts)
        {
            Id = id;
            Name = name;
            Approved_sb = approved_sb;
            Approved_eb = approved_eb;
            Note = note;
            Send_sb = send_sb;
            Send_eb = send_eb;
            UserId = userId;
            User = user;
            Posts = posts;
        }

        public StudyRoute()
        {
        }
    }
}
