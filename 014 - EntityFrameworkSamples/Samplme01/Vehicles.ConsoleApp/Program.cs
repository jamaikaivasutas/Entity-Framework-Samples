using Microsoft.EntityFrameworkCore;
using Vehicles.Database;
using Vehicles.Database.Entities;

using var dbContext = new ApplicationDbContext();

await AddFirstVehicleToDB();

Console.WriteLine("Done");
Console.ReadKey();

async Task AddFirstVehicleToDB()
{
    ManufacturerEntity mazda = new ManufacturerEntity
    {
        Name = "MAZDA"

    };

    await dbContext.Manufacturers.AddAsync(mazda);
    await dbContext.SaveChangesAsync();


    ModelEntity mazda2de = new ModelEntity
    {
        Name = "2 DE",
        ManufacturerId = mazda.Id
    };

    await dbContext.Models.AddAsync(mazda2de);
    await dbContext.SaveChangesAsync();

    VehicleEntity vehicle = new VehicleEntity
    {
        ChassisNumber= "SIGMASKIBIDISIGMA",
        ColorId = 1,
        EngineNumber = "D2",
        LicencePlate = "AAPFWR4",
        ModelId = 1,
        NumberOfDoors = 5,
        Power = 86,
        Weight = 980
    };

    await dbContext.Vehicles.AddAsync(vehicle);
    await dbContext.SaveChangesAsync(); 
}

void PrintVehiclesOnConsole(ICollection<VehicleEntity> vehicles)
{
    foreach (var vehicle in vehicles)
    {
        Console.WriteLine($"{vehicle.LicencePlate} ({vehicle.Color.Name})");
    }
}
