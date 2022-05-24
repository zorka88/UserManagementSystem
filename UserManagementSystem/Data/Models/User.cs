
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UserManagementSystem.Data.Models;

namespace UserManagementSystem.Models
{
    public class User : IdentityUser<int>
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool StatusIsActive { get; set; }
        public List<UserPermission> Permissions { get; set; }

    }
   
}
