using DATN2022.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DATN2022.DBContext
{
    public class DATN2022DbContext : DbContext
    {
        public DbSet<CoachOwner> CoachOwners { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Pickup> Pickups { get; set; }
        public DbSet<DropOff> DropOffs { get; set; }
        public DbSet<Account> Accounts { get; set; }
       
        public DbSet<Types> Types { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Seat> Seat { get; set; }

        public DbSet<Layout> Layouts { get; set; }
        // public DbSet<Colors> Colors { get; set; }

        public DATN2022DbContext(DbContextOptions<DATN2022DbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoachOwner>().HasData(new CoachOwner
            {
                Id = Guid.NewGuid(),
                FirstName = "Uncle",
                LastName = "Bob",
                Email = "uncle.bob@gmail.com",
                DateOfBirth = new DateTime(1979, 04, 25),
                PhoneNumber = "999-888-7777"
            }, new CoachOwner
            {
                Id = Guid.NewGuid(),
                FirstName = "Vital",
                LastName = "Water",
                Email = "vital.bob@gmail.com",
                DateOfBirth = new DateTime(1920, 05, 15),
                PhoneNumber = "666-123-2345"
            });
        }
    }
}
