using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Prj.Models;
using Final_Prj.Repository;

namespace Final_Prj.Controllers
{
    class UserController
    {
        public UserRepository userRepository;
        public UserController()
        {
            userRepository = new UserRepository();
        }
        public String AddUser(User user)
        {
            return userRepository.AddUser(user);
        }
        public String UpdateUser(User user)
        {
            return userRepository.UpdateUser(user);
        }
        public String DeleteUser(int id)
        {
            return userRepository.DeleteUser(id);
        }
        public bool Login(User user)
        {
            return userRepository.Login(user);
        }
    }
}
