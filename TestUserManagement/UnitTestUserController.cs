using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementSystem.APIs;
using UserManagementSystem.Contracts;
using UserManagementSystem.DTOs;
using UserManagementSystem.Models;
using UserManagementSystem.Repositories;
using Xunit;

namespace TestUserManagement
{
    public class UnitTestUserController
    {

        [Fact]
        public async void Test_Delete_User()
        {
            // Arrange
            var mockRepo = new Mock<IUserRepository>();
            mockRepo.Setup(repo => repo.DeleteUserAsync(It.IsAny<int>())).Verifiable();
            var controller = new UsersApiController(mockRepo.Object);

            // Act
           await controller.DeleteUser(1);

            // Assert
            mockRepo.Verify();
        }

    }

}
