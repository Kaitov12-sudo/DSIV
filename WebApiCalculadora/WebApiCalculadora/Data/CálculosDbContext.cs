using Microsoft.EntityFrameworkCore;
using WebApiCalculadora.Models;

namespace WebApiCalculadora.Data
{
    public class CálculosDbContext : DbContext
    {
        public CálculosDbContext(DbContextOptions<CálculosDbContext> options) : base(options) { }

        public DbSet<Calculadora2> Calculadora2 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Calculadora2>().ToTable("Calculadora2");
        }
    }
}


