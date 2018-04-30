using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SportsStore.Models;
using System;


namespace SportsStore.Models {
    public static class SeedData {
        public static void EnsurePopulated(IServiceProvider services) {
            //ApplicationDbContext context = services.GetRequiredService<ApplicationDbContext>();
            //context.Database.Migrate();
            //context.Database.EnsureCreated();
            using (var context = new ApplicationDbContext(
                services.GetRequiredService<DbContextOptions<ApplicationDbContext>>())){
            if (context.Products.Any()) {
                return;
            }
            context.Products.AddRange(
                new Product {
                    ProductID = 1,
                    Name = "Kayak", Description = "A boat for one person",
                    Category = "Watersports", Price = 275
                },
                new Product {
                    ProductID = 2,
                    Name = "Lifejacket",
                    Description = "Protective and fashionable",
                    Category = "Watersports", Price = 48.95m
                },
                new Product {
                    ProductID = 3,
                    Name = "Soccer Ball",
                    Description = "FIFA-approved size and weight",
                    Category = "Soccer", Price = 19.50m
                },
                new Product {
                    ProductID = 4,
                    Name = "Corner Flags",
                    Description = "Give your playing field a professional touch",
                    Category = "Soccer", Price = 34.95m
                },
                new Product {
                    ProductID = 5,
                    Name = "Stadium",
                    Description = "Flat-packed 35,000-seat stadium",
                    Category = "Soccer", Price = 79500
                },
                new Product {
                    ProductID = 6,
                    Name = "Thinking Cap",
                    Description = "Improve brain efficiency by 75%",
                    Category = "Chess", Price = 16
                },
                new Product {
                    ProductID = 7,
                    Name = "Unsteady Chair",
                    Description = "Secretly give your opponent a disadvantage",
                    Category = "Chess", Price = 29.95m
                },
                new Product {
                    ProductID = 8,
                    Name = "Human Chess Board",
                    Description = "A fun game for the family",
                    Category = "Chess", Price = 75
                },
                new Product {
                    ProductID = 9,
                    Name = "Bling-Bling King",
                    Description = "Gold-plated, diamond-studded King",
                    Category = "Chess", Price = 1200
                }
            );
            context.SaveChanges();
            }
        }
    }
}
