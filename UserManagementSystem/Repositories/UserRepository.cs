using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementSystem.Contracts;
using UserManagementSystem.Data;
using UserManagementSystem.Data.Models;
using UserManagementSystem.DTOs;
using UserManagementSystem.Models;

namespace UserManagementSystem.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UsersDbContext _context;
        public readonly IPasswordHasher<User> _passwordHasher;

        public UserRepository(UsersDbContext context, IPasswordHasher<User> passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;

        }



        public async Task<List<UserResponseModel>> GetUsersAsync()
        {
            var users = await _context
                .Users
                .Where(x => x.StatusIsActive == true)
                .ToListAsync();

            return users.Select(x => new UserResponseModel
            {
                Id = x.Id,  
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                StatusIsActive = x.StatusIsActive
            }).ToList();

        }

        public async Task<PagingResult<UserResponseModel>> GetUsersPageAsync(int skip, int take)
        {
            var totalRecords = await _context.Users.CountAsync();
            var allUsers = await _context.Users
                                 .OrderBy(c => c.LastName)
                                 .Skip(skip)
                                 .Take(take)
                                 .ToListAsync();

            var users = allUsers.Select(x => new UserResponseModel
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                StatusIsActive = x.StatusIsActive

            }).ToList();
            return new PagingResult<UserResponseModel>(users, totalRecords);
        }

        public async Task<UserResponseModel> GetUserAsync(int id)
        {
            var user = await _context.Users
                                 .Include(c => c.Permissions)
                                 .SingleOrDefaultAsync(c => c.Id == id);

            return Map(user);

        }

        public async Task<UserResponseModel> InsertUserAsync(UserRequestModel request)
        {
            var user = new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                UserName = request.Email,
                EmailConfirmed = true,
                StatusIsActive = true

            };
            
            _context.Users.Add(user);

            var hashedPassword = _passwordHasher.HashPassword(user, request.Password);
            user.SecurityStamp = Guid.NewGuid().ToString();
            user.PasswordHash = hashedPassword;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (System.Exception exp)
            {

            }

            var response = new UserResponseModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName
            };

            return response;
        }

        public async Task<bool> UpdateUserAsync(UpdateUserModel request)
        {

            var userForUpdate = await _context.Users
                .Include(x => x.Permissions)
                .SingleOrDefaultAsync(x => x.Id == request.Id);

            if (userForUpdate == null) {
                return false;
            }

            userForUpdate.FirstName = request.FirstName;
            userForUpdate.LastName = request.LastName;
            userForUpdate.Email = request.Email;
            userForUpdate.UserName = request.Email;

            try
            {
                return (await _context.SaveChangesAsync() > 0 ? true : false);
            }
            catch (Exception exp)
            {
               // _Logger.LogError($"Error in {nameof(UpdateUserAsync)}: " + exp.Message);
            }
            return false;

            
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            var user = await _context.Users
                                .Include(c => c.Permissions)
                                .SingleOrDefaultAsync(c => c.Id == id);
            _context.Remove(user);
            try
            {
                return (await _context.SaveChangesAsync() > 0 ? true : false);
            }
            catch (System.Exception exp)
            {
               // _Logger.LogError($"Error in {nameof(DeleteUserAsync)}: " + exp.Message);
            }
            return false;
        }

        public async Task<List<PermissionResponseModel>> ViewAssignedUserPermissions(int userId)
        {
            var userPermissions = await _context.UsersPermissions
               .Include(x => x.Permission)
               .Include(x => x.User)
               .Where(x => x.UserId == userId).ToListAsync();

            return userPermissions.Select(x => new PermissionResponseModel
            {
                Code = x.Permission.Code,
                Description = x.Permission.Description

            }).ToList();

        }

        public async Task<bool> AssignPermissionToUser(int userId, List<int> permissionsIds)
        {

            var listaZaDodati = new List<UserPermission>();
            foreach(var id in permissionsIds)
            {
                listaZaDodati.Add(new UserPermission
                {
                    PermissionId = id,
                    UserId = userId
                });
            }

             _context.AddRange(listaZaDodati);
            await _context.SaveChangesAsync();

            return true;
        }

        private UserResponseModel Map(User user)
        {
            return new UserResponseModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                StatusIsActive = user.StatusIsActive
            };
        }

        
    }
}
