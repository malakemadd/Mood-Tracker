using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Models
{
    public class Recommendations
    {
        [Key]
        public int Id { get; set; }
        public string recommend { get; set; }
        
        public int moodid { get; set; }
        public string resource { get; set; }
      
       
        public ICollection<User> Users { get; set; }
        public virtual Mood Mood { get; set; }
    }
}
