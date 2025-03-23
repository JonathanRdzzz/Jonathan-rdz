using Microsoft.EntityFrameworkCore;
using PracticaWebApi.Model;
using static PracticaWebApi.Model.ProductionCulturecs;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace PracticaWebApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Culture> Cultures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Mapeo de tabla y esquema
            modelBuilder.Entity<Culture>().ToTable("Culture", "Production");

            // Clave primaria
            modelBuilder.Entity<Culture>().HasKey(c => c.CultureID);
        }
    }
}