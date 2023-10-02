using BowlHub.DAL.Entities;
using BowlHub.DAL.Repositories.Classes;

namespace BowlHub.DAL.Repositories.Interfaces;

public interface IBoardRepository : IRepository<BoardEntity>
{
    Task<BoardEntity> GetBoardByPlaceIdAsync(Guid id);
}