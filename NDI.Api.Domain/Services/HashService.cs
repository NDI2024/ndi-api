using System.Security.Cryptography;
using System.Text;

namespace NDI.Api.Domain.Services;

public abstract class HashService
{

    public static string Hash(string input)
    {
        using SHA256 sha256 = SHA256.Create();
        var bytes = Encoding.UTF8.GetBytes(input);
        var hash = sha256.ComputeHash(bytes);
        return Convert.ToBase64String(hash);
    }
}