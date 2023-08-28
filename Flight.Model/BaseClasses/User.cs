using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;

namespace Flight.DataAccess.BaseClasses
{
    public enum UserEnum
    {
        Client = 1,
        Admin = 2
    }

    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserEnum UserEnum { get; set; }

        public User() { }

        public User(int id, string user, string pass, UserEnum type)
        {
            ID = id;
            Username = user;
            Password = pass;
            UserEnum = type;
        }

        public void SaveUserToDisk(string filePath, User u)
        {
            string json = JsonSerializer.Serialize(u);

            File.WriteAllText(filePath, json);
        }

        public User LoadUserFromDisk(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);

                return JsonSerializer.Deserialize<User>(json);
            }
            else return null;
        }
    }
}