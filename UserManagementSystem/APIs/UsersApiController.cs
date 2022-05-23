using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementSystem.Contracts;
using UserManagementSystem.DTOs;

namespace UserManagementSystem.APIs
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersApiController : ControllerBase
    {
        IUserRepository _userRepository;
        public UsersApiController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("GetAllUsers")]
       // [NoCache]
        [ProducesResponseType(typeof(List<UserResponseModel>), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<ActionResult> Users()
        {
            try
            {
                var users = await _userRepository.GetUsersAsync();
                return Ok(users);
            }
            catch (Exception exp)
            {
                return BadRequest(new ApiResponse { Status = false });
            }
        }


        
        [HttpGet("GetPaginatedUsers/{skip}/{take}")]
        //[NoCache]
        [ProducesResponseType(typeof(List<UserResponseModel>), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<ActionResult> UsersPage(int skip, int take)
        {
            try
            {
                var pagingResult = await _userRepository.GetUsersPageAsync(skip, take);
                return Ok(pagingResult.Records);
            }
            catch (Exception exp)
            {
                //_Logger.LogError(exp.Message);
                return BadRequest(new ApiResponse { Status = false });
            }
        }


        
        [HttpGet("GetUserById/{id}", Name = "GetUserRoute")]
       // [NoCache]
        [ProducesResponseType(typeof(UserResponseModel), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<ActionResult> Users(int id)
        {
            try
            {
                var user = await _userRepository.GetUserAsync(id);
                return Ok(user);
            }
            catch (Exception exp)
            {
                //_Logger.LogError(exp.Message);
                return BadRequest(new ApiResponse { Status = false });
            }
        }




        
        [HttpPost("CreateUser")]
        // [ValidateAntiForgeryToken]
        [ProducesResponseType(typeof(ApiResponse), 201)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<ActionResult> CreateUser([FromBody] UserRequestModel user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ApiResponse { Status = false, ModelState = ModelState });
            }

            try
            {
                var newUser = await _userRepository.InsertUserAsync(user);
                if (newUser == null)
                {
                    return BadRequest(new ApiResponse { Status = false });
                }

                //PODESITI REDIREKCIJU
                return CreatedAtRoute("GetUserRoute", new { id = newUser.Id },
                        new ApiResponse { Status = true, UserResponse = newUser });
            }
            catch (Exception exp)
            {
                //_Logger.LogError(exp.Message);
                return BadRequest(new ApiResponse { Status = false });
            }
        }

        
        [HttpPut("UpdateUser")]
        // [ValidateAntiForgeryToken]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<ActionResult> UpdateUser(/*int id,*/ [FromBody] UpdateUserModel user)
        {
            //URADITI VALIDACIJU ALI RADI ENDPOINT
            if (!ModelState.IsValid)
            {
                return BadRequest(new ApiResponse { Status = false, ModelState = ModelState });
            }

            try
            {
                var status = await _userRepository.UpdateUserAsync(user);
                if (!status)
                {
                    return BadRequest(new ApiResponse { Status = false });
                }
                return Ok(new ApiResponse { Status = true, UpdatedUserModel = user });
            }
            catch (Exception exp)
            {
                //_Logger.LogError(exp.Message);
                return BadRequest(new ApiResponse { Status = false });
            }
        }

        
        [HttpDelete("DeleteUser/{id}")]
        // [ValidateAntiForgeryToken]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<ActionResult> DeleteUser(int id)
        {
            try
            {
                var status = await _userRepository.DeleteUserAsync(id);
                if (!status)
                {
                    return BadRequest(new ApiResponse { Status = false });
                }
                return Ok(new ApiResponse { Status = true });
            }
            catch (Exception exp)
            {
                //_Logger.LogError(exp.Message);
                return BadRequest(new ApiResponse { Status = false });
            }
        }



        [HttpGet("GetUserPermission/{id}")]
        // [NoCache]
        [ProducesResponseType(typeof(PermissionResponseModel), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<ActionResult> GetUserPermissions(int id)
        {
            try
            {
                var permissions = await _userRepository.ViewAssignedUserPermissions(id);
                return Ok(permissions);
            }
            catch (Exception exp)
            {
                //_Logger.LogError(exp.Message);
                return BadRequest(new ApiResponse { Status = false });
            }
        }


        [HttpPost("AssignPermissionsToUser")]
        // [NoCache]
        [ProducesResponseType(typeof(PermissionResponseModel), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<ActionResult> AssignPermissions(int userId,List<int> permissionsIds)
        {
            try
            {
                var permissions = await _userRepository.AssignPermissionToUser(userId, permissionsIds);
                return Ok(permissions);
            }
            catch (Exception exp)
            {
                //_Logger.LogError(exp.Message);
                return BadRequest(new ApiResponse { Status = false });
            }
        }
    }
}
