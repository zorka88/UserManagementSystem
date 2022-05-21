using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementSystem.DTOs;

namespace UserManagementSystem.Contracts
{
    public interface IAuthRepository
    {
        Task<Token> Login(string userName, string password);
    }
}
