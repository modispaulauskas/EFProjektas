using EFAiskinimas.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfProjektasFr.Services
{
    public class EfProjektasContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Dormitory> Dormitories { get; set; }
        public DbSet<Enrolment> Enrolments { get; set; }
        public DbSet<Location> Locations { get; set; }

        public EfProjektasContext() : base("StudentDb")
        {
            Database.SetInitializer(new EfProjektasInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasKey(p => p.PersonId);

            modelBuilder.Entity<Student>()
                .HasKey(s => s.StudentId);

            modelBuilder.Entity<Course>()
                .HasKey(c => c.CourseId);

            modelBuilder.Entity<Hobby>()
                .HasKey(h => h.HobbyId);

            modelBuilder.Entity<Dormitory>()
                .HasKey(d => d.LocationId);

            modelBuilder.Entity<Enrolment>()
                .HasKey(e => new { e.StudentId, e.CourseId });

            modelBuilder.Entity<Location>()
                .HasKey(l => l.LocationId);

            modelBuilder.Entity<Profession>()
                .HasKey(p => p.ProfessionId);
        }
    }
}
