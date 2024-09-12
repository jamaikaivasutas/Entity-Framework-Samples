using Microsoft.EntityFrameworkCore;

namespace Vehicles.Database;

public class ApplicationDbContext : DbContext
{
    //public ApplicationContext
}

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    base.OnConfiguring(optionsBuilder);
    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=VehicleDB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
}

protected override void OnModelCreating(ModelBuilder builder)
{
    // UNIQUE constraint beallitasa
    //builder.Entity<VehicleEntity>()
    //          .HasIndex(X => x.LicensePlate)
    //          .IsUnique();
}
