namespace SecureLogin.Models
{
    public class User
    {
        public static List<User> UserList { get; set; } = new List<User>();
        public string _Username { get; set; }
        public string _PasswordHash { get; set; }

        public User(string Username, string PasswordHash)
        {
            _Username = Username;
            _PasswordHash = PasswordHash;
        }
    }
}
