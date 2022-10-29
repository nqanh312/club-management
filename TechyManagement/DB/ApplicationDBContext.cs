using BusinessObject;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TechyManagement.Models;

namespace TechyManagement.DB
{
    public class ApplicationDBContext : IdentityDbContext<AppUser>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }
        }
        public DbSet<ClubActivity> ClubActivities { get; set; }
        public DbSet<TaskUser> Tasks { get; set; }

        public DbSet<StateActivity> SateActivities { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<StateUser> StateUsers { get; set; }

        
    }
}

