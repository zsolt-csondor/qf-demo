using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace QFDemoAPI.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly QFDemoDbContext context;

        public UserRepository(QFDemoDbContext context)
        {
            this.context = context;
        }

        public User GetUser(int id)
        {
            return context.Users.FirstOrDefault(user => user.UserId == id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return context.Users.ToList();
        }

        public void DeleteUser(int id)
        {
            context.Database.ExecuteSqlCommand($"DeleteUser {id}");
        }

        public void CreateUser([FromBody] User newUser)
        {
            context.Users.Add(newUser);
            context.SaveChanges();
        }

        public void UpdateUser(int id, [FromBody] User user)
        {
            var oldUser = context.Users.FirstOrDefault(u => u.UserId == id);
            oldUser.FirstName = user.FirstName;
            oldUser.LastName = user.LastName;
            oldUser.UserName = user.UserName;
            oldUser.Alias = user.Alias;
            oldUser.Email = user.Email;

            context.SaveChanges();
        }
    }
}
