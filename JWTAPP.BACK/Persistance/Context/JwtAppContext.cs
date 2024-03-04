using JWTAPP.BACK.Persistance.Configurations;
using JWTAPP.BACK.Persistance.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace JWTAPP.BACK.Persistance.Context
{
    public class JwtAppContext : DbContext
    {
        public JwtAppContext(DbContextOptions<JwtAppContext> options) : base(options)
        {

        }
        public DbSet<Product> Products
        {
            get
            {

                return this.Set<Product>();
            }
        }
        public DbSet<Category> Categories {
            get
            {

                return this.Set<Category>();
            }
        }
        public DbSet<AppUser> AppUsers {
            get
            {

                return this.Set<AppUser>();
            }
        }
        public DbSet<AppRole> AppRoles {
            get
            {

                return this.Set<AppRole>();
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            base.OnModelCreating(modelBuilder);

        }
    }
}
