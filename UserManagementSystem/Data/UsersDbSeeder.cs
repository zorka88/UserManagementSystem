using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserManagementSystem.Data.Models;
using UserManagementSystem.Models;

namespace UserManagementSystem.Data
{
    public class UsersDbSeeder
    {

        public async Task SeedAsync(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var usersDb = serviceScope.ServiceProvider.GetService<UsersDbContext>();
                if (await usersDb.Database.EnsureCreatedAsync())
                {
                    if (!await usersDb.Users.AnyAsync())
                    {
                        await SeedInitData(usersDb);
                    }
                }
            }
        }

        public async Task SeedInitData(UsersDbContext db)
        {
            var users = GetAllUsers();
            db.Users.AddRange(users);
            try
            {
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }

            var permissions = GetAllPermissions();
            db.Permissions.AddRange(permissions);
            try
            {
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        private List<User> GetAllUsers()
        {
            var users = new List<User>
                {
                    new User{Email= "marko@marko.com",FirstName="Mark",LastName = "Markovic",Password = "test",Username = "usernm",StatusIsActive = true},
                    new User{Email= "marko@marko.com",FirstName="Mark",LastName = "Markovic",Password = "test",Username = "usernm",StatusIsActive = true},
                    new User{Email= "marko@marko.com",FirstName="Mark",LastName = "Markovic",Password = "test",Username = "usernm",StatusIsActive = true},
                    new User{Email= "marko@marko.com",FirstName="Mark",LastName = "Markovic",Password = "test",Username = "usernm",StatusIsActive = true},
                    new User{Email= "marko@marko.com",FirstName="Mark",LastName = "Markovic",Password = "test",Username = "usernm",StatusIsActive = true},
                    new User{Email= "marko@marko.com",FirstName="Mark",LastName = "Markovic",Password = "test",Username = "usernm",StatusIsActive = true},
                    new User{Email= "marko@marko.com",FirstName="Mark",LastName = "Markovic",Password = "test",Username = "usernm",StatusIsActive = true},
                    new User{Email= "marko@marko.com",FirstName="Mark",LastName = "Markovic",Password = "test",Username = "usernm",StatusIsActive = true},
                    new User{Email= "marko@marko.com",FirstName="Mark",LastName = "Markovic",Password = "test",Username = "usernm",StatusIsActive = true},
                    new User{Email= "marko@marko.com",FirstName="Mark",LastName = "Markovic",Password = "test",Username = "usernm",StatusIsActive = true},
                    new User{Email= "marko@marko.com",FirstName="Mark",LastName = "Markovic",Password = "test",Username = "usernm",StatusIsActive = true},
                    new User{Email= "marko@marko.com",FirstName="Mark",LastName = "Markovic",Password = "test",Username = "usernm",StatusIsActive = true},
                    new User{Email= "marko@marko.com",FirstName="Mark",LastName = "Markovic",Password = "test",Username = "usernm",StatusIsActive = true}

                };
            return users;
        }

        private List<Permission> GetAllPermissions()
        {
            var permissions = new List<Permission>
            {
                new Permission{Code ="Admin",Description = "Admin opis"},
                new Permission{Code ="User",Description = "User opsi"},
                
            };
            return permissions;
        }

    }
}
