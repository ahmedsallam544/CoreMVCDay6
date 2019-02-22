using CoreMVCDay6.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCDay6.Data
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions options):base(options)
        {
                
        }

        public DbSet<User> users { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<UserProduct> userProducts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProduct>().HasKey(c => new { c.ProductID, c.UserID });
        }
    }
}
