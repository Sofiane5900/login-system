using System.Security.Cryptography;
using System.Text;

namespace SecureLogin.Services
{
    public class HashingServices
    {
        public static string getHash256(string password)
        {
            // instance of static method SHA256
            var sha256 = SHA256.Create();
            // convert password parameter to bytes array, UTF8 for special character
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

            // instance of StringBuilder
            var sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                // x2 = hexadecimal
                sb.Append(bytes[i].ToString("x2"));
            }
            //return the hashed password
            return sb.ToString();
        }
    }
}
