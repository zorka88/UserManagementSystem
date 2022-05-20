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

        public async Task<Customer> InsertCustomerAsync(User user)
        {
            _context.Add(customer);
            try
            {
                await _Context.SaveChangesAsync();
            }
            catch (System.Exception exp)
            {
                _Logger.LogError($"Error in {nameof(InsertCustomerAsync)}: " + exp.Message);
            }

            return customer;
        }
    }
}
