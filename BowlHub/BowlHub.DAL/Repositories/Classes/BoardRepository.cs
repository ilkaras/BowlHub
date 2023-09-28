using BowlHub.DAL.Entities;
using BowlHub.DAL.Repositories.Interfaces;

namespace BowlHub.DAL.Repositories.Classes;

public class BoardRepository : BaseRepository<BoardEntity>, IBoardRepository
{
    public BoardRepository(DataBaseContext context) : base(context)
    {
    }
}