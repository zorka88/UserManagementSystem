using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Data.Models;
using UserManagementSystem.Models;

namespace UserManagementSystem.Data
{
    public class UsersDbContext : IdentityDbContext<User, ApplicationRole,int>
    {
        public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options) { }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPermission> UsersPermissions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                 new User { Id = 1, Email = "marko@marko1.com", EmailConfirmed = true, FirstName = "Administrator", LastName = "Markovic", UserName = "marko@marko1.com", StatusIsActive = true },
                    new User { Id = 2, Email = "marko@marko2.com", EmailConfirmed = true, FirstName = "Mark", LastName = "Markovic", UserName = "marko@marko2.com", StatusIsActive = true },
                    new User { Id = 3, Email = "marko@mar3ko.com", EmailConfirmed = true, FirstName = "Ivan", LastName = "Markovic", UserName = "marko@mar3ko.com", StatusIsActive = true },
                    new User { Id = 4, Email = "marko@mark4o.com", EmailConfirmed = true, FirstName = "Jovan", LastName = "Markovic", UserName = "marko@mark4o.com", StatusIsActive = true },
                    new User { Id = 5, Email = "marko@marko4.com", EmailConfirmed = true, FirstName = "Mirko", LastName = "Markovic", UserName = "marko@marko4.com", StatusIsActive = true },
                    new User { Id = 6, Email = "marko@m6arko.com", EmailConfirmed = true, FirstName = "Slavko", LastName = "Markovic", UserName = "marko@m6arko.com", StatusIsActive = true },
                    new User { Id = 7, Email = "marko@ma6rko.com", EmailConfirmed = true, FirstName = "Simo", LastName = "Markovic", UserName = "marko@ma6rko.com", StatusIsActive = true },
                    new User { Id = 8, Email = "marko@mar6ko.com", EmailConfirmed = true, FirstName = "Luka", LastName = "Markovic", UserName = "marko@mar6ko.com", StatusIsActive = true },
                    new User { Id = 9, Email = "marko@mark6o.com", EmailConfirmed = true, FirstName = "Ante", LastName = "Markovic", UserName = "arko@mark6o.com", StatusIsActive = true },
                    new User { Id = 10, Email = "marko@marko6.com", EmailConfirmed = true, FirstName = "Filip", LastName = "Markovic", UserName = "marko@marko6.com", StatusIsActive = true },
                    new User { Id = 11, Email = "marko@m7arko.com", EmailConfirmed = true, FirstName = "Djuro", LastName = "Markovic", UserName = "marko@m7arko.com", StatusIsActive = true },
                    new User { Id = 12, Email = "marko@ma7rko.com", EmailConfirmed = true, FirstName = "Ivica", LastName = "Markovic", UserName = "marko@ma7rko.com", StatusIsActive = true },
                    new User { Id = 13, Email = "marko@mar7ko.com", EmailConfirmed = true, FirstName = "Marica", LastName = "Markovic", UserName = "marko@mar7ko.com", StatusIsActive = true }
              );

            modelBuilder.Entity<Permission>().HasData(
                 new Permission { Id = 1, Code = "Admin", Description = "Admin opis" },
                 new Permission { Id = 2, Code = "User", Description = "User opis" }
                );

            modelBuilder.Entity<UserPermission>().HasData(
                new UserPermission {Id = 1, PermissionId = 1, UserId = 1 },
                new UserPermission {Id = 2, PermissionId = 2, UserId = 2 }
                );
        }
    }

    public class ApplicationRole : IdentityRole<int>
    {
    }
}
