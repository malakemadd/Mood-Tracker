using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Models
{
    public class Mood
    {
        [Key]public int MoodId { get; set; }
        public string? Moodtitle { get; set; }
       
        public ICollection<Recommendations> Recommendations { get; set; }
      


    }
}
