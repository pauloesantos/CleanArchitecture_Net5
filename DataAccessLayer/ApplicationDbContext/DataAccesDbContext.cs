
using DataAccessLayer.EntityMappers;
using DataAccessLayer.Models;
using DataAccessLayer.SeedData;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.ApplicationDbContext
{
    public partial class DataAccesDbContext : DbContext
    {
        public DataAccesDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> users { get; set; }
        public DbSet<UserRoles> userRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new UserRoleMap());
            modelBuilder.ApplyConfiguration(new BranchMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}