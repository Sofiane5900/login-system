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
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();
            Console.ReadLine();
        }
    }
}
