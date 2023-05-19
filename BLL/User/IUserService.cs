using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.User
{
  
        public interface IUserService
        {
            User GetUserById(int userId);
            User GetUserByEmail(string email);
            IEnumerable<User> GetAllUsers();
            void RegisterUser(User user, string password);
            bool LoginUser(string email, string password);
            void UpdateUser(User user);
            void DeleteUser(int userId);
        }
    

}
