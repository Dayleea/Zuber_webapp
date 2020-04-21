using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Zuber_webapp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Driver> Drivers { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<Trip> Trips { get; set; }
      




    }
}
