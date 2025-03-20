using System.Text.Json;
using SecureLogin.Models;

namespace SecureLogin.Services
{
    public class LoginService
    {
        public static void LoginUser()
        {
            Console.WriteLine("=== Login User ===");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.ReadLine();
            isLoginCorrect(username, password);
        }

        public static bool isLoginCorrect(string username, string password)
        {
            string filename = "users.json";
            if (!File.Exists(filename))
            {
                Console.WriteLine("This file dosen't exists.");
            }
            string jsonFile = File.ReadAllText(filename);
            // json file is deserialize into a list
            List<User> users = JsonSerializer.Deserialize<List<User>>(jsonFile);

            User foundUser = users.FirstOrDefault(u =>
                u.username.Trim().ToLower() == username.Trim().ToLower()
            );
            if (foundUser is null)
            {
                Console.WriteLine("Unknow user..");
                return false;
            }

            // we hash the password to compare it with the hash of the foundUser
            string passwordHashed = HashingServices.getHash256(password);

            if (passwordHashed == foundUser.passwordHash)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Login succeed !");
                Console.ResetColor();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
