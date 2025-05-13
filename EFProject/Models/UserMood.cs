using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Models
{
    public class UserMood
    {
        [Key] public int MoodId { get; set; }
        public string? Moodtitle { get; set; }
        public string? Trigger { get; set; }
        public int? Intensity { get; set; }
        public string? Details { get; set; }
        public DateTime? MoodDate { get; set; }
        public ICollection<Mood> Moods { get; set; }


    }
}
