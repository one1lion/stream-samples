using Microsoft.EntityFrameworkCore;
using SomeTaco.Models;
using SomeTaco.Models.Lookups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeTaco.Database
{
    public class SomeTacoContext : DbContext
    {
        public DbSet<Taco> Tacos { get; set; }
        public DbSet<Topping> Toppings { get; set; }


        public SomeTacoContext() { }

        public SomeTacoContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Taco>(entity =>
            {
                entity.Property(x => x.Name)
                  .HasMaxLength(60)
                  .IsUnicode(false);

                entity.Property(x => x.Created)
                  .HasDefaultValueSql("SYSUTCDATETIME()");

                entity.HasMany(x => x.Toppings)
                  .WithMany(x => x.Tacos);

            });

            modelBuilder.Entity<Topping>(entity =>
            {
                entity.Property(x => x.Name)
                  .HasMaxLength(60)
                  .IsUnicode(false);
            });
            SeedData(modelBuilder);
        }

        private static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topping>().HasData(
              Enum.GetValues<ToppingType>().Select(x => new Topping()
              {
                  Id = x,
                  Name = x.ToString()
              }
            ));
        }
    }
}
