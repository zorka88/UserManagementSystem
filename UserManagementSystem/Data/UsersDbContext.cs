using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Data.Models;
using UserManagementSystem.Models;

namespace UserManagementSystem.Data
{
    public class UsersDbContext : DbContext
    {
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPermission> UsersPermissions { get; set; }

        public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options) { }


    }
}
