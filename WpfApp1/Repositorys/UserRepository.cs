using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.Repositorys
{
    public class UserRepository
    {
        private static List<User> users = new();

        public UserRepository()
        {
            users = Enumerable.Range(1, 10).Select(x => new User()
            {
                ID = x,
                Name = x.ToString(),
                Age = x
            }).ToList();
        }

        public List<User> GetAll()
        {
            return users;
        }

        public void Create(User user)
        {
            users.Add(user);
        }

        public void Update(User user)
        {
            User? target = users.FirstOrDefault(x => x.ID == user.ID);
            if (target != null)
            {
                target.Name = user.Name;
                target.Age = user.Age;
            }
        }

        public void Delete(User user)
        {
            users.Remove(user);
        }

        public User? FindById(User user)
        {
            return users.Find(x => x.ID == user.ID);
        }

        public int GetMaxSequence()
        {
            if (users.Count == 0)
                return 1;

            return users.Last().ID + 1;
        }
    }
}
