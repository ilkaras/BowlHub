using BowlHub.DAL.Entities;
using BowlHub.DAL.Repositories.Interfaces;

namespace BowlHub.DAL.Repositories.Classes;


public class UserRepository : BaseRepository<UserEntity>, IUserRepository
{
    public UserRepository(DataBaseContext context) : base(context)
    {
    }
}