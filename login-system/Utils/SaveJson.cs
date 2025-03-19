using System.Text.Json;
using SecureLogin.Models;

namespace SecureLogin.Utils
{
    public static class SaveJson
    {
        private static string filename = "users.json";

        public static void CreateJson()
        {
            if (!File.Exists(filename))
            {
                using (FileStream createFile = File.Create(filename)) { }
                ;
            }
        }

        public static void AddUserToJson(User user)
        { // create json file before writing it
            CreateJson();
            User.UserList.Add(user);
            var userToJson = JsonSerializer.Serialize(User.UserList);
            File.WriteAllText(filename, userToJson);
            Console.WriteLine(user.username);
        }

        public static bool isLoginCorrect(string password, string username)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("This file dosen't exists.");
            }
            string jsonFile = File.ReadAllText(filename);
            List<User> users = JsonSerializer.Deserialize<List<User>>(jsonFile);
            User foundUser = users.FirstOrDefault(u => u.username == username);
            if (foundUser is null)
            {
                Console.WriteLine("Unknow user..");
                return false;
            }
        }
    }
}
