namespace SecureLogin.Models
{
    public class User
    {
        private string _username;
        private string _uasswordHash;

        public static List<User> UserList { get; set; } = new List<User>();
        public string username { get; set; }
        public string passwordHash { get; set; }

        public User(string Username, string PasswordHash)
        {
            username = Username;
            passwordHash = PasswordHash;
        }
    }
}
