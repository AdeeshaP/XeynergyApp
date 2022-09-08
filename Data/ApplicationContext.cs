using Microsoft.EntityFrameworkCore;
using Xeynergy_App.Models;

namespace Xeynergy_App.Data
{
    public class ApplicationContext : DbContext

    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Person> People { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<AccessRule> AccessRules { get; set; }

    }
}
