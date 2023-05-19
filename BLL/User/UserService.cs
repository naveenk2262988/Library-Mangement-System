using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.User
{
        public class UserService : IUserService
        {
            private readonly IUserRepository _userRepository;

            public UserService(IUserRepository userRepository)
            {
                _userRepository = userRepository;
            }

            public User GetUserById(int userId)
            {
                return _userRepository.GetUserById(userId);
            }

            public User GetUserByEmail(string email)
            {
                return _userRepository.GetUserByEmail(email);
            }

            public IEnumerable<User> GetAllUsers()
            {
                return _userRepository.GetAllUsers();
            }

            public void RegisterUser(User user, string password)
            {
                // Perform any necessary validation or business logic before registering the user
                // For example, check if the email address is already registered, perform password hashing, etc.

                // Call the repository method to register the user
                _userRepository.RegisterUser(user, password);
            }

            public bool LoginUser(string email, string password)
            {
                // Perform any necessary validation or business logic before logging in the user

                // Call the repository method to authenticate the user
                return _userRepository.LoginUser(email, password);
            }

            public void UpdateUser(User user)
            {
                // Perform any necessary validation or business logic before updating the user

                // Call the repository method to update the user
                _userRepository.UpdateUser(user);
            }

            public void DeleteUser(int userId)
            {
                // Perform any necessary validation or business logic before deleting the user

                // Call the repository method to delete the user
                _userRepository.DeleteUser(userId);
            }
        }
    }

}
