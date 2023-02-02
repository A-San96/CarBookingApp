using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookingApp.Data
{
    public class CarBookingAppDbContextFactory : IDesignTimeDbContextFactory<CarBookingAppDbContext>
    {
        
        public CarBookingAppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CarBookingAppDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CarBookingApp_db;Trusted_Connection=True;MultipleActiveResultSets=True");

            return new CarBookingAppDbContext(optionsBuilder.Options);
        }
    }
}
