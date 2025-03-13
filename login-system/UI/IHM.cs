namespace SecureLogin.UI
{
    public class IHM
    {
        public static void MainMenu()
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
        }
    }
}
