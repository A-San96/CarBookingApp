using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookingApp.Data
{
    public class CarBookAppDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}
