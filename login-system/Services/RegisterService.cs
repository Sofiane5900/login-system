using SecureLogin.Models;
using SecureLogin.Utils;

namespace SecureLogin.Services
{
    public class RegisterService
    {
        public static void RegisterUser()
        {
            // the json will get his users from this listUsers

            Console.WriteLine("=== Register Page ===");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            User newUser = new User(username, password);
            SaveJson.AddUserToJson(newUser);
            Console.WriteLine(HashingServices.getHash256(password));
        }
    }
}
