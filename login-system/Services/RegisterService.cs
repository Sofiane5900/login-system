namespace SecureLogin.Services
{
    public class RegisterService
    {
        public static void RegisterUser()
        {
            Console.WriteLine("=== Register Page ===");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            User newUser = new User(username, password);
            Console.WriteLine(HashingServices.getHash256(password));
        }
    }
}
