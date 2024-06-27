
using System.Security.Cryptography;
using System.Text;

namespace Lesson
{
    public class MD5HashService : IHashService
    {
        public string GetHash(int value)
        {
            var md5 = MD5.Create();

            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(value.ToString()));

            return Convert.ToBase64String(hash);
        }
    }
}