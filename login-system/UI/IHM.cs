using SecureLogin.Services;

namespace SecureLogin.UI
{
    public class IHM
    {
        public static void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("--- Console Login ---");
                Console.WriteLine("Pick an option below");
                Console.WriteLine("1 - Register");
                Console.WriteLine("2 - Login");
                Console.WriteLine("What is your choice: ");
                if (!int.TryParse(Console.ReadLine(), out int mainMenuChoice))
                {
                    Console.WriteLine("Error, you are not authorized to make this input.");
                }

                switch (mainMenuChoice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        RegisterService.RegisterUser();
                        break;
                    case 2:
                        LoginService.LoginUser();
                        break;
                }
            }
        }
    }
}
