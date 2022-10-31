using Bogus;
using MarketApp_DomainModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MarketApp_DAL.Data
{
    public static class DbContextExtension
    {
        public static void SeedUsers(this ModelBuilder builder)
        {
            List<IdentityRole> roles = new List<IdentityRole>()
            {
                new IdentityRole()
                {
                    Id = "e124ebf3-a05a-4f19-a049-3237c26e416d",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                },
                new IdentityRole()
                {
                    Id = "e498fbb0-6d78-42c2-bf93-f4c839914cb6",
                    Name = "User",
                    NormalizedName = "USER"
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);

            var passwordHasher = new PasswordHasher<ApplicationUser>();

            var user = new ApplicationUser()
            {
                Id = "9f15051c-3dcd-406c-bb73-ced7c4372f8f",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                EmailConfirmed = true,
                FirstName = "Admin",
                LastName = "Admin",
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var hashed = passwordHasher.HashPassword(user, "P@ssword");
            user.PasswordHash = hashed;

            builder.Entity<ApplicationUser>().HasData(user);
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();

            userRoles.Add(new IdentityUserRole<string>
            {
                RoleId = roles.First(r => r.Name == "Admin").Id,
                UserId = user.Id
            });

            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
        public static void SeedEntities(this ModelBuilder builder)
        {
            //int productsId = 1;
            var productNames = new List<string>() { "Eggs", "Butter", "Lemon", "Flour", };
            //Faker<Product> products = new Faker<Product>()
            //    .RuleFor(m => m.Id, f => productsId++)
            //    .RuleFor(m => m.Name, f => f.PickRandom(productNames))
            //    .RuleFor(m => m.Price, f => f.Random.Decimal(1, 10));

            //builder.Entity<Product>().ToTable("Product").HasData(products.Generate(10));

            int recipesId = 1;
            var types = new List<string>() { "Breakfast", "Lunch", "Dinner" };
            var names = new List<string>() { "Caramilk croissant slice", "Cookie Recipe", "Baked ricotta cake", "Cheat's chickpea korma curry" };
            var pictures = new List<string>()
            {
                "https://images.unsplash.com/photo-1532499016263-f2c3e89de9cd?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=880&q=8",
                "https://images.unsplash.com/photo-1530610476181-d83430b64dcd?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=735&q=80",
                "https://images.unsplash.com/photo-1512223792601-592a9809eed4?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=652&q=80",
                "https://img.taste.com.au/2hNkshpW/w643-h428-cfill-q90/taste/2020/06/july20_cheats-chickpea-korma-curry-162751-1.jpg"
            };
            Faker<Recipe> recipes = new Faker<Recipe>()
            .RuleFor(m => m.Id, f => recipesId++)
            .RuleFor(m => m.Image, f => f.PickRandom(pictures))
            .RuleFor(m => m.Name, f => f.PickRandom(names))
            .RuleFor(m => m.Description, f => f.Random.Words(10))
            .RuleFor(m => m.Type, f => f.PickRandom(types))
            .RuleFor(m => m.Ingredients , f => f.Random.Words(5));

            builder.Entity<Recipe>().ToTable("Recipe").HasData(recipes.Generate(10));

            //int ingridientId = 1;
            //Faker<Ingredient> ingredients = new Faker<Ingredient>()
            //    .RuleFor(m => m.Id, f => ingridientId++)
            //    .RuleFor(m => m.Ingredients, f => f.Random.Words(10))
            //    .RuleFor(m => m.RecipeId, f => f.Random.Int(1, 10));
            //builder.Entity<Ingredient>().ToTable("Ingredients").HasData(ingredients.Generate(20));
           
        }
    }
}
