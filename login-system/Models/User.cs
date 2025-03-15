namespace SecureLogin.Models
{
    public class User
    {
        // might need a constructor later
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }
}
