using MarketApp_DomainModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp_DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //public DbSet<Product> Products { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
        
        public DbSet<FavoriteRecipe> FavoriteRecipes { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<FavoriteRecipe>().ToTable("FavoriteRecipe");
            builder.SeedUsers();
            builder.SeedEntities();
        }
    }
}
