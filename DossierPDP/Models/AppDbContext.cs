using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DossierPDP.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        //
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    CustomerFirstName = "Nick",
                    CustomerLastName = "Foulon",
                    Email = "foulonnick@gmail.com",
                    Telephonenumber = "123456789"
                },
                new Customer { CustomerId = 2, CustomerFirstName = "Raf", CustomerLastName = "Gillisjans" },
                new Customer { CustomerId = 3, CustomerFirstName = "Paul-Henry", CustomerLastName = "Decuvelier" }
            );
        }
    }
}
