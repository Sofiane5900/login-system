using SecureLogin.Models;

namespace SecureLogin.Utils
{
    public class SaveJson
    {
        public static void CreateJson()
        {
            string filename = "users.json";
            if (!File.Exists(filename))
            {
                FileStream createFile = File.Create(filename);
            }
        }

        public static void AddUserJson(User user) { }
    }
}
