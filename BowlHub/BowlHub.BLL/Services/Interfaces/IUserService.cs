using BowlHub.BLL.Models;

namespace BowlHub.BLL.Services.Interfaces;

public interface IUserService
{
    Task<UserModel> AddNewUser(UserModel user);
    Task<UserModel?> GetUserByEmail(string email);
}