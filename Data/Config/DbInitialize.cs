using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Data.Config
{
    public class DbInitialize
    {
        private readonly ModelBuilder _modelBuilder;

        public DbInitialize(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            SeedCuisines();
            SeedRestaurants();
        }

        private void SeedCuisines()
        {
            _modelBuilder.Entity<Cuisine>().HasData(
            new Cuisine
            {
                Id = 1,
                Name = "Australian"
            },
            new Cuisine
            {
                Id = 2,
                Name = "French"
            },
            new Cuisine
            {
                Id = 3,
                Name = "Japanese"
            }
            );
        }



        private void SeedRestaurants()
        {
            _modelBuilder.Entity<Restaurant>().HasData(

            new Restaurant
            {
                Id = 1,
                Name ="mcdonalds",
                Description = "1st in the world",
                CuisineId = 1
            },
            new Restaurant
            {
                Id = 2,
                Name = "Mistral",
                Description = "A classic Mistral",
                CuisineId = 2
            },
            new Restaurant
            {
                Id = 3,
                Name = "Tokyo sushi",
                Description = "A trendy Japanese sushi bar",
                CuisineId = 3
            }
            );
        }
    }
}
