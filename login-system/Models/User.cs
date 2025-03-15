namespace SecureLogin.Models
{
    public class User
    {
        public List<User> UserList = new List<User>();
        private string _Username { get; set; }
        private string _PasswordHash { get; set; }

        public User(string Username, string PasswordHash) { }
    }
}
