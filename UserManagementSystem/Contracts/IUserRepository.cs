using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementSystem.Data;
using UserManagementSystem.DTOs;
using UserManagementSystem.Models;

namespace UserManagementSystem.Contracts
{
    public interface IUserRepository
    {
        Task<List<UserResponseModel>> GetUsersAsync();
        Task<PagingResult<UserResponseModel>> GetUsersPageAsync(int skip, int take);
        Task<UserResponseModel> GetUserAsync(int id);
        Task<UserRequestModel> InsertUserAsync(UserRequestModel user);
        Task<bool> UpdateUserAsync(UpdateUserModel user);
        Task<bool> DeleteUserAsync(int id);
    }
}
