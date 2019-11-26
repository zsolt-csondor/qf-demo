using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QFDemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QFDemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository userRepo;
        
        public UsersController(IUserRepository userRepo)
        {   
            this.userRepo = userRepo;
        }

        //GET api/users/3
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = userRepo.GetUser(id);
            if (user == null) return NoContent();

            return Ok(user);
        }

        //GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            List<User> userList = (List<User>) userRepo.GetAllUsers();
            if (userList == null) return NoContent();

            return Ok(userList);
        }

        //DELETE api/users/3
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            userRepo.DeleteUser(id);
            return NoContent();
        }

        //POST api/users/
        [HttpPost]
        public ActionResult<User> CreateUser(User newUser)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            userRepo.CreateUser(newUser);
            return CreatedAtAction("CreateUser", newUser);            
        }

        //PUT api/users/3
        [HttpPut("{id}")]
        public ActionResult UpdateUser(int id, User user)
        {
            if(id != user.UserId)
            {
                return BadRequest();
            }
            userRepo.UpdateUser(id, user);
            return NoContent(); 
        }
    }
}
