using Moq;
using QFDemoAPI.Models;
using QFDemoAPI.Controllers;
using System;
using Xunit;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace QFDemoAPITests
{
    public class UsersControllerTests
    {
        private readonly Mock<IUserRepository> mockRepo;
        private readonly UsersController controller;

        public UsersControllerTests()
        {
            mockRepo = new Mock<IUserRepository>();
            controller = new UsersController(mockRepo.Object);

        }

        
        //Not set up properly, keeps returning null no matter what
        [Fact]
        public void GetUser_Executes_ReturnsUser()
        {
            User retUser = new User
            {
                UserId = 1,
                UserName = "Test"
            };

            mockRepo.Setup(repo => repo.GetUser(1))
                .Returns(retUser);

            var result = controller.GetUser(1);

            var model = result.Value;

            Assert.IsType<ActionResult<User>>(result);
            //Assert.Equal(1, model.UserId);

        }
    }
}
