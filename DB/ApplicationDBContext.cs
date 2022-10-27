using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagementObject.DB
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<ClubActivity> ClubActivities { get; set; }
        public DbSet<Task> Tasks { get; set; }

        public DbSet<StateActivity> SateActivities { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<StateUser> StateUsers { get; set; }
    }
}
