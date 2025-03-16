namespace SecureLogin.Models
{
    public class User
    {
        public static List<User> UserList { get; set; } = new List<User>();
        private string _Username;
        private string _PasswordHash;

        public string Username { get; set; }
        public string PasswordHash { get; set; }

        public User(string username, string passwordHash)
        {
            Username = username;
            PasswordHash = passwordHash;
        }
    }
}
