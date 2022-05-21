using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagementSystem.DTOs
{
    public class ApiResponse
    {
        public bool Status { get; set; }
        public UserResponseModel UserResponse { get; set; }
        public UserRequestModel UserRequest { get; set; }
        public UpdateUserModel UpdatedUserModel { get; set; }

        public ModelStateDictionary ModelState { get; set; }
    }
}
