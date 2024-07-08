// See https://aka.ms/new-console-template for more information
using Lab18Tema18.DataBase;
using Lab18Tema18.Models;

Console.WriteLine("Hello, World!");
/*Adaugare autovehicul*/
public static void AddVehicle();
{
    using var ctx = new VehicleDbContext();
    var vehicle = new Vehicle
    {
        Name = "Nissan Quashqai",
        Producer = "Nissan",
        Key = "2",
        CilindricalCpacity = 2000,
        FabYear = 2015,
        ChassisSeries = "WXTS2345"
    }
    var vehicle = new Vehicle
    {
        Name = "Mazda CX3",
        Producer = "Mazda",
        Key = "2",
        CilindricalCpacity = 1500,
        FabYear = 2015,
        ChassisSeries = "WRS5679"
    }
    ctx.SaveChanges();
}