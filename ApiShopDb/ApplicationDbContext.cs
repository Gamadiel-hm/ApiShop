using ApiShopModel.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ApiShopDb
{
    public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);

        }

        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<UserInfoUserRol> UserInfoUserRols { get; set; }
        public DbSet<UserRol> UserRols { get; set; }
        public DbSet<UserSecurity> UserSecurities { get; set; }
    }
}
