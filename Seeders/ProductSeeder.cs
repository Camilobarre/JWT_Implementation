using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using JWT_Implementation.Models;
using Microsoft.EntityFrameworkCore;
using static JWT_Implementation.Models.Products;

namespace JWT_Implementation.Seeders
{
    public class ProductSeeder
    {
        public static void Seed(ModelBuilder modelBuilder, int amount)
        {
            var products = GenerateProducts(amount);
            modelBuilder.Entity<Products>().HasData(products);
        }

        private static IEnumerable<Products> GenerateProducts(int count)
        {
            var faker = new Faker<Products>()
                .RuleFor(p => p.Id, f => f.IndexFaker + 1)
                .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                .RuleFor(p => p.Cost, f => f.Random.Double(1, 1000));

            return faker.Generate(count);
        }
    }
}