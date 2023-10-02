using BowlHub.DAL.Entities;

namespace BowlHub.DAL.Repositories.Interfaces;

public interface IUserRepository : IRepository<UserEntity>
{
    Task<UserEntity?> GetUserByEmail(string email);
    Task<bool> CheckUser(string email, string password);
}
