namespace BowlHub.BLL.Services.Interfaces;

public interface IAuthService
{
    Task<string?> Authorize(string email, string password);
}