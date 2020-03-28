using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPISampleHandsOn.Models;

namespace WebAPISampleHandsOn.DataLayer
{
    public class ApplicationDbContext : DbContext
    {
        //public DbSet<Movie> Movies { get; set; }

        //public DbSet<Brand> Brands { get; set; }
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<Stock> Stocks { get; set; }
        //public DbSet<Product> Products { get; set; }
        //public DbSet<Customer> Customers { get; set; }

        //public DbSet<OrderItems> OrderItems { get; set; }

        //public DbSet<Order> Orders { get; set; }
        //public DbSet<Staff> Staffs { get; set; }
        //public DbSet<Store> Stores { get; set; }



        //Book module

        public DbSet<Author> authors { get; set; }
        public DbSet<Book> books { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
