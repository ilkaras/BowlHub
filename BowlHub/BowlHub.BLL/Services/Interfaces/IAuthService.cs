using BowlHub.BLL.Models;

namespace BowlHub.BLL.Services.Interfaces;

public interface IAuthService
{
    string GenerateToken(UserModel user);
    Task<string?> Authorize(string email, string password);
}