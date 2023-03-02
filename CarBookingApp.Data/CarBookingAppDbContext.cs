﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookingApp.Data
{
    public class CarBookingAppDbContext : DbContext
    {
        public CarBookingAppDbContext(DbContextOptions<CarBookingAppDbContext> options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Make> Makes { get; set; }
    }
}
