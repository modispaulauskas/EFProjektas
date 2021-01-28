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

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>();

            modelBuilder.Entity<Student>();

            modelBuilder.Entity<Course>();

            modelBuilder.Entity<Hobby>();

            modelBuilder.Entity<Dormitory>();

            modelBuilder.Entity<Enrolment>();

            modelBuilder.Entity<Location>();

            modelBuilder.Entity<Profession>();

        }
    }
}
