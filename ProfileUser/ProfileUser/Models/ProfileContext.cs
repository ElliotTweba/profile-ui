using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProfileUser.Models
{
    public class ProfileContext : DbContext
    {

        public ProfileContext(DbContextOptions<ProfileContext> options)
           : base(options)
        { }

       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>(entity =>
            {
                entity.Property(e => e.PID).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.SurName).IsRequired();
                entity.Property(e => e.Gender).IsRequired();
                entity.Property(e => e.Contact).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Website);
                entity.Property(e => e.About);
                entity.Property(e => e.CV);
                entity.Property(e => e.ProfilePic);
            });

            modelBuilder.Entity<Profile>().HasData(
                new Profile() { PID = 1, Name = "Tsekiso", SurName = "Thokoana", Gender = "male", Contact = "57090909", Email = "stseki@gmail.com", Website = "www.stseki.com", About = "A mosotho young men who is inlove with software development", CV = " ", ProfilePic = " " },
                new Profile() { PID = 2, Name = "Setumo", SurName = "Semakela", Gender = "male", Contact = "57133124", Email = "stseki@gmail.com", Website = "www.stseki.com", About = "A mosotho young men who is inlove with software development", CV = " ", ProfilePic = " " },
                new Profile() { PID = 3, Name = "Thabo", SurName = "Majoro", Gender = "male", Contact = "57133124", Email = "stseki@gmail.com", Website = "www.stseki.com", About = "A mosotho young men who is inlove with software development", CV = " ", ProfilePic = " " },
                new Profile() { PID = 4, Name = "Khauta", SurName = "Maliehe", Gender = "male", Contact = "57133124", Email = "stseki@gmail.com", Website = "www.stseki.com", About = "A mosotho young men who is inlove with software development", CV = " ", ProfilePic = " " });
            
        } */

        public DbSet<Profile> Profiles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=ProfileDB;");
        }
    }
}