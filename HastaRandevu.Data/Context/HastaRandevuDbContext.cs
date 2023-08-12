using HastaRandevu.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevu.Data.Context
{
    public class HastaRandevuDbContext : DbContext
    {
        public DbSet<Hasta> Hastalar { get; set; }
        public DbSet<Doktor> Doktorlar { get; set; }
        public DbSet<Brans> Branslar { get; set; }
        public DbSet<Kurum> Kurumlar { get; set; }

        public HastaRandevuDbContext()
        {

        }

        public HastaRandevuDbContext(DbContextOptions<HastaRandevuDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=HastaRandevuDb;Trusted_Connection=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
