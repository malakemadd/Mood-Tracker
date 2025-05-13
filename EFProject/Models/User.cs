using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Models
{
    public class User
    {
        
        [Key]
        public int Id { get; set; }
        public string username { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Password { get; set; }
        public ICollection<Recommendations> Recomm { get; set; }


    }
}
