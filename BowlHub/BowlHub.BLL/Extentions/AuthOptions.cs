using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace BowlHub.BLL.Extentions;

public static class AuthOptions
{
    public static readonly string Issuer = "BowlHubServer";
    public static readonly string Audience = "BowlHub";
    private static readonly string Key = Convert.ToBase64String(new HMACSHA256().Key);
    public static SymmetricSecurityKey GetSymmetricSecurityKey() => 
        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Key));
}