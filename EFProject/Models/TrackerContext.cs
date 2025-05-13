using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFProject.Models
{
    public class TrackerContext: DbContext
    {

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Mood> Mood { get; set; }
        public virtual DbSet<Recommendations> Recommendations { get; set; }
        public virtual DbSet<UserMood> UserMoods { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=Malak-PC;Database=MoodTracker;Trusted_Connection=True;Encrypt=False;");



        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new Recommendations { recommend = "Take a deep breath and relax." };
            new Recommendations { recommend = "Go for a walk to clear your mind." };
            new Recommendations { recommend = "Try engaging in a hobby you enjoy." };
            new Recommendations { recommend = "Consider talking to a friend or family member." };
            new Recommendations { recommend = "Try a meditation app to reduce stress." };
            new Recommendations { recommend = "Write in a journal about what's bothering you." };
        }

    }
}
