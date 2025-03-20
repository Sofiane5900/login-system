using SecureLogin.Models;
using SecureLogin.Utils;

namespace SecureLogin.Services
{
    public class RegisterService
    {
        public static void RegisterUser()
        {
            // the json will get his users from this listUsers
            while (true)
            {
                Console.WriteLine("=== Register Page ===");
                // Console.WriteLine("Press 0 to go back...");
                // int.TryParse(Console.ReadLine(), out int userChoice);
                // if (userChoice == 0)
                // {
                //     return;
                // }
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();
                string passwordHashed = HashingServices.getHash256(password);
                User newUser = new User(username, passwordHashed);
                SaveJson.AddUserToJson(newUser);
                Console.Clear();
                return;
            }
        }
    }
}
