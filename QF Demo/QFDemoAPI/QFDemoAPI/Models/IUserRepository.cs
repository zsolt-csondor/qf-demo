using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace QFDemoAPI.Models
{
    public interface IUserRepository
    {
        User GetUser(int id);

        IEnumerable<User> GetAllUsers();

        void DeleteUser(int id);

        void CreateUser(User newUser);

        void UpdateUser(int id, User user);
    }
}
