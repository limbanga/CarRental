using CarRental.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Data
{
    public class CarRentalContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(AppSetting.ConnectionString);
        }

        public DbSet<AppUserEntity> AppUsers { get; set; } = null!;
        public DbSet<BookingNoteEntity> BookingNotes{ get; set; } = null!;
        public DbSet<CarEntity> Cars { get; set; } = null!;
        public DbSet<CustomerEntity> Customers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookingNoteEntity>()
                .HasOne(b => b.Car)
                .WithMany()
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<BookingNoteEntity>()
                .HasOne(b => b.Customer)
                .WithMany()
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
