using Microsoft.AspNetCore.Http;
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

        [HttpGet]
       // [NoCache]
        [ProducesResponseType(typeof(List<UserResponseModel>), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<ActionResult> Users()
        {
            try
            {
                var customers = await _userRepository.GetUsersAsync();
                return Ok(customers);
            }
            catch (Exception exp)
            {
                return BadRequest(new ApiResponse { Status = false });
            }
        }


        // GET api/customers/page/10/10
        [HttpGet("page/{skip}/{take}")]
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


        // GET api/customers/5
        [HttpGet("{id}", Name = "GetUserRoute")]
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




        // POST api/customers
        [HttpPost]
        // [ValidateAntiForgeryToken]
        [ProducesResponseType(typeof(ApiResponse), 201)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<ActionResult> CreateCustomer([FromBody] UserRequestModel user)
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
                return CreatedAtRoute("GetCustomerRoute", new { id = newUser.Id },
                        new ApiResponse { Status = true, UserRequest = newUser });
            }
            catch (Exception exp)
            {
                //_Logger.LogError(exp.Message);
                return BadRequest(new ApiResponse { Status = false });
            }
        }

        // PUT api/customers/5
        [HttpPut("{id}")]
        // [ValidateAntiForgeryToken]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<ActionResult> UpdateCustomer(/*int id,*/ [FromBody] UpdateUserModel user)
        {
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

        // DELETE api/customers/5
        [HttpDelete("{id}")]
        // [ValidateAntiForgeryToken]
        [ProducesResponseType(typeof(ApiResponse), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<ActionResult> DeleteCustomer(int id)
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
    }
}
