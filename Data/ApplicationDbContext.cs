using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWT_Implementation.Models;
using JWT_Implementation.Seeders;
using Microsoft.EntityFrameworkCore;

namespace JWT_Implementation.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Products> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ProductSeeder.Seed(modelBuilder, 1000);
        }

    }
}