using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dbconnection.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext
            (DbContextOptions<ApplicationDbContext>option):
            base(option){ }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
