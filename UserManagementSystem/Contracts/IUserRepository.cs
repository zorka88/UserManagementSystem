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

        //Task<PagingResult<Customer>> GetCustomersPageAsync(int skip, int take);
        //Task<Customer> GetCustomerAsync(int id);

        //Task<Customer> InsertCustomerAsync(Customer customer);
        //Task<bool> UpdateCustomerAsync(Customer customer);
        //Task<bool> DeleteCustomerAsync(int id);
    }
}
