
using System.Security.Cryptography;
using System.Text;

namespace Lesson
{
    public class Sha1HashService : IHashService
    {
        public string GetHash(int value)
        {
            var sha1 = SHA1.Create();

            var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(value.ToString()));

            return Convert.ToBase64String(hash);
        }
    }
}