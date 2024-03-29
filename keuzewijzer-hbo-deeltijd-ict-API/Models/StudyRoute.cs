﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace keuzewijzer_hbo_deeltijd_ict_API.Models
{
    public class StudyRoute
    {
        public int Id { get; set; }
        public bool Send_sb { get; set; }
        public bool? Approved_sb { get; set; }
        public bool? Send_eb { get; set; }
        public bool? Approved_eb { get; set; }
        public string? Note { get; set; }
        public string? UserId { get; set; }

        [NotMapped]
        public User? User { get; set; }

        public ICollection<StudyRouteItem> StudyRouteItems { get; set; }

        public StudyRoute(int id, bool approved_sb, bool approved_eb, string note, bool send_sb, bool send_eb, string userId, User user, ICollection<StudyRouteItem> studyRouteItems)
        {
            Id = id;
            Approved_sb = approved_sb;
            Approved_eb = approved_eb;
            Note = note;
            Send_sb = send_sb;
            Send_eb = send_eb;
            UserId = userId;
            User = user;
            StudyRouteItems = studyRouteItems;
        }

        public StudyRoute()
        {
        }

    }
}
