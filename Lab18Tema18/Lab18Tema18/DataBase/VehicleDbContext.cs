using Lab18Tema18.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18Tema18.DataBase
{
    internal class VehicleDbContext:DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<TehnicalBook> TehnicalBooks { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Key> Keys { get; set; }
        public VehicleDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ionut\source\repos\Lab17Ex1\Lab17Ex1\ProductDb.mdf;Integrated Security=True");
        }
    }
}
