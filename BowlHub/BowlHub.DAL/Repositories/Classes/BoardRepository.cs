using BowlHub.DAL.Entities;
using BowlHub.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BowlHub.DAL.Repositories.Classes;

public class BoardRepository : BaseRepository<BoardEntity>, IBoardRepository
{
    public BoardRepository(DataBaseContext context) : base(context)
    {
    }
    
    public async Task<BoardEntity> GetBoardByPlaceIdAsync(Guid id)
    {
        return await DbSet.FirstOrDefaultAsync(x => x.PlaceId == id) ?? default!;
    }
}