namespace SecureLogin.Models
{
    public class User
    {
        // ? might need a constructor later
        private string _Username { get; set; }
        private string _PasswordHash { get; set; }

        public User(string Username, string PasswordHash) { }
    }
}
