using System.Collections.Generic;
using UserManagementSystem.Data.Models;

namespace UserManagementSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool StatusIsActive { get; set; }
        public List<UserPermission> Permissions { get; set; }

    }
}
