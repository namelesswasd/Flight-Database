using Flight.DataAccess.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Flight.DataAccess.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private List<User> _users;

        public UserRepository()
        {
            _users = new List<User>();
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public void SaveToJson(string filePath)
        {
            string json = JsonSerializer.Serialize(_users);

            File.WriteAllText(filePath, json);
        }

        public void LoadFromJson(string filePath)
        {
            string json = File.ReadAllText(filePath);

            _users = JsonSerializer.Deserialize<List<User>>(json);
        }

        public User Get(int id)
        {
            return _users.FirstOrDefault(u => u.ID == id);
        }

        public User GetLast()
        {
            if (_users.Count == 0)
            {
                return null;
            } else
            {
                return _users.Last();
            }
            
        }

        public string GetToString(int id)
        {
            var t = _users.FirstOrDefault(s => s.ID == id);
            return "FlightInstance(" + ", " +
                t.ID.ToString() + ", " +
                t.Username.ToString() + ", " +
                t.Password.ToString() + ", " + 
                t.UserEnum.ToString() + ")";
        }

        public void Create(User user)
        {
            _users.Add(user);
        }

        public void Update(int id, User user)
        {
            var oldUser = _users.FirstOrDefault(u => u.ID == id);
            if (oldUser != null)
            {
                oldUser.Username = user.Username;
                oldUser.Password = user.Password;
                oldUser.UserEnum = user.UserEnum;
            }
        }

        public void Delete(int id)
        {
            var removeUser = _users.FirstOrDefault(u => u.ID == id);
            if (removeUser != null)
            {
                _users.Remove(removeUser);
            }
        }
    }
}
