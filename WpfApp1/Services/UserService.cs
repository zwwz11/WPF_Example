using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;
using WpfApp1.Repositorys;

namespace WpfApp1.Services
{
    public class UserService
    {
        private readonly UserRepository userRepository;
        public UserService()
        {
            userRepository = new UserRepository();
        }

        public List<User> GetAllUsers()
        {
            return userRepository.GetAll();
        }

        public List<User> GetAllUsers(User filter)
        {
            return userRepository.GetAll(filter);
        }

        public void CreateUser(User user)
        {
            if (user.ID != int.MinValue)
                return;

            user.ID = userRepository.GetMaxSequence();
            userRepository.Create(user);
        }

        public void UpdateUser(User user)
        {
            User? target = userRepository.FindById(user);
            if (target != null)
            {
                userRepository.Update(user);
            }
        }

        public void DeleteUser(User user)
        {
            userRepository.Delete(user);
        }

        public User? FindUserById(User user)
        {
            return userRepository.FindById(user);
        }

        public int? GetMaxUserSequence()
        {
            return userRepository.GetMaxSequence();
        }
    }
}
