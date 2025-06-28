using Microsoft.EntityFrameworkCore;
using StaniaAPI.Domain.Entities;
using StaniaAPI.Services.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<RentalUnit> RentalUnits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RentalUnit>(entity =>
            {
                entity.Property(x => x.RentalUnitType)
                    .HasConversion<string>();

                entity.Property(x => x.RentalUnitTerm)
                    .HasConversion<string>();

                entity.Property(x => x.ParkingOption)
                    .HasConversion<string>();

                entity.Property(x => x.ParkingCost)
                    .HasConversion(
                        y => y.HasValue ? y.Value.ToString() : null,
                        y => y != null ? Enum.Parse<ParkingCost>(y) : (ParkingCost?)null
                    );
            });
        }
    }
}
