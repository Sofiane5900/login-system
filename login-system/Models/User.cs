namespace SecureLogin.Models
{
    public class User
    {
        public static List<User> UserList { get; set; } = new List<User>();
        private string _Username { get; set; }
        private string _PasswordHash { get; set; }

        public User(string Username, string PasswordHash) { }
    }
}
