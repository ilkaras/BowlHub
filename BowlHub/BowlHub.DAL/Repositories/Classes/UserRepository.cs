using BowlHub.DAL.Entities;
using BowlHub.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BowlHub.DAL.Repositories.Classes;


public class UserRepository : BaseRepository<UserEntity>, IUserRepository
{
    public UserRepository(DataBaseContext context) : base(context)
    {
    }

    public async Task<UserEntity?> GetUserByEmail(string email)
    {
        var result = await DbSet.FirstOrDefaultAsync(x => x.Email == email);
        return result;
    }

    public async Task<bool> CheckUser(string email, string password)
    {
        var result = await DbSet.FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
        return result != null;
    }
}