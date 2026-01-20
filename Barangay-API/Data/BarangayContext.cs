using Barangay_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Barangay_API.Data
{
    public class BarangayContext:DbContext
    {
        public DbSet<Household> Households { get; set; }
        public BarangayContext(DbContextOptions<BarangayContext> options) : base(options)
        {
             
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BarangayContext).Assembly);
        }
    }
}
