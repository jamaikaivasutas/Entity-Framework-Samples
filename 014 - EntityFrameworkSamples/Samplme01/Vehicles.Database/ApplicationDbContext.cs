namespace Vehicles.Database;

public class ApplicationDbContext : DbContext
{
    public DbSet<VehicleEntity> Vehicles { get; set; }

    public ApplicationDbContext() : base()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=VehicleDB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {

        // UNIQUE constraint beallitasa (vagy osztaly szinten INDEX, vagy itt az alabbi koddal)
        //builder.Entity<VehicleEntity>()
        //       .HasIndex(x => x.LicencePlate)
        //       .IsUnique();

        builder.Entity<ColorEntity>()
                .HasData(new ColorEntity()
                {
                    Id = 1,
                    Name = "white",
                    Code = "FFFFFF"
                });

        builder.Entity<ColorEntity>()
               .HasData(new ColorEntity()
               {
                   Id = 2,
                   Name = "black",
                   Code = "000000"
               });
    }
}
