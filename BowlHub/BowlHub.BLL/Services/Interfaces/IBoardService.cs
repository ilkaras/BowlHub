using BowlHub.BLL.Models;

namespace BowlHub.BLL.Services.Interfaces;

public interface IBoardService
{
    Task <BoardModel> GetBoardByPlaceId(Guid id);
}
