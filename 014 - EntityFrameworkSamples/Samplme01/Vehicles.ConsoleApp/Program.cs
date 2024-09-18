using Microsoft.EntityFrameworkCore;
using Vehicles.Database;
using Vehicles.Database.Entities;

using var dbContext = new ApplicationDbContext();

//adat hozzaadasa az adatbazishoz
//var vehicle = new VehicleEntity
//{
//    ChassisNumber = "asigmaj642hghawk",
//    EngineNumber = "DT",
//    LicencePlate = "AAT598",
//    NumberOfDoors = 5,
//    Power = 148,
//    Weight = 1500,
//    ColorId= 2,
//};

//await dbContext.Vehicles.AddAsync(vehicle);
//await dbContext.SaveChangesAsync();

//rekord modositasa
//var vehicle = await dbContext.Vehicles.FindAsync((uint)1);
//vehicle.ChassisNumber = "11111111111111111";
//await dbContext.SaveChangesAsync();

//rekord torlese
//var vehicle = await dbContext.Vehicles.FindAsync((uint)1);
//dbContext.Vehicles.Remove(vehicle);
//await dbContext.SaveChangesAsync();


//adatok kiolvasasa az adatbazisbol
var vehicles = await dbContext.Vehicles.Include(x => x.Color)
                                    .ToListAsync();
PrintVehiclesOnConsole(vehicles);

Console.WriteLine("Done");
Console.ReadKey();


void PrintVehiclesOnConsole(ICollection<VehicleEntity> vehicles)
{
    foreach (var vehicle in vehicles)
    {
        Console.WriteLine($"{vehicle.LicencePlate} ({vehicle.Color.Name})");
    }
}
