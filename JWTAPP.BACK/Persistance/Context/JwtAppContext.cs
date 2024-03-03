using JWTAPP.BACK.Persistance.Configurations;
using JWTAPP.BACK.Persistance.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace JWTAPP.BACK.Persistance.Context
{
    public class JwtAppContext:DbContext
    {
        public JwtAppContext(DbContextOptions<JwtAppContext> options):base(options)
        {
                
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            base.OnModelCreating(modelBuilder);

        }
    }
}
