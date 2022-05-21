using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementSystem.Contracts;
using UserManagementSystem.Data;
using UserManagementSystem.DTOs;
using UserManagementSystem.Models;

namespace UserManagementSystem.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UsersDbContext _context;

        public UserRepository(UsersDbContext context)
        {
            _context = context;
        }

       

        public async Task<List<UserResponseModel>> GetUsersAsync()
        {
            var users = await _context
                .Users
                .ToListAsync();

            return users.Select(x => new UserResponseModel
            {
                Id = x.Id,  
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                //Username = x.Username,
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
                //Username = x.Username,
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

        public async Task<UserRequestModel> InsertUserAsync(UserRequestModel request)
        {
            var user = new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName
            };
            _context.Add(user);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (System.Exception exp)
            {
               // _Logger.LogError($"Error in {nameof(InsertCustomerAsync)}: " + exp.Message);
            }

            ///Provjeri ovaj response
            var response = new UserRequestModel
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

            userForUpdate.FirstName = request.FirstName;
            userForUpdate.LastName = request.LastName;
            //userForUpdate.Username = request.Username;
            userForUpdate.Email = request.Email;

            try
            {
                return (await _context.SaveChangesAsync() > 0 ? true : false);
            }
            catch (Exception exp)
            {
               // _Logger.LogError($"Error in {nameof(UpdateCustomerAsync)}: " + exp.Message);
            }
            return false;

            
        }

        public async Task<bool> DeleteUserAsync(int id)
        {//testiraj brisanje permisija s userom
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
               // _Logger.LogError($"Error in {nameof(DeleteCustomerAsync)}: " + exp.Message);
            }
            return false;
        }

        private UserResponseModel Map(User user)
        {
            return new UserResponseModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                //Password = user.Password,
                //Username = user.Username,
                StatusIsActive = user.StatusIsActive
            };
        }
    }
}
