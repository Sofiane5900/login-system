using SecureLogin.Models;

namespace SecureLogin.Utils
{
    public static class SaveJson
    {
        private static string filename = "";

        public static void CreateJson()
        {
            filename = "users.json";
            if (!File.Exists(filename))
            {
                FileStream createFile = File.Create(filename);
            }
        }

        public static void AddUserToJson(User user)
        { // create json file before writing it
            CreateJson();
        }
    }
}
