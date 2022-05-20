using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementSystem.Contracts;
using UserManagementSystem.Data;
using UserManagementSystem.DTOs;

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
                Username = x.Username,
                StatusIsActive = x.StatusIsActive
            }).ToList();

        }

        public async Task<PagingResult<UserResponseModel>> GetCustomersPageAsync(int skip, int take)
        {
            var totalRecords = await _context.Users.CountAsync();
            var users = await _context.Users
                                 .OrderBy(c => c.LastName)
                                 .Skip(skip)
                                 .Take(take)
                                 .ToListAsync();
            return new PagingResult<UserResponseModel>(users, totalRecords);
        }


    }
}
