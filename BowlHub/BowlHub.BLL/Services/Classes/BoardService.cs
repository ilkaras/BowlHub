using AutoMapper;
using BowlHub.BLL.Models;
using BowlHub.BLL.Services.Interfaces;
using BowlHub.DAL.Repositories.Interfaces;

namespace BowlHub.BLL.Services.Classes;

public class BoardService : IBoardService
{
    private readonly IBoardRepository _boardRepository;
    private readonly IMapper _mapper;
    
    public BoardService(IMapper mapper, IBoardRepository repository)
    {
        _mapper = mapper;
        _boardRepository = repository;
    }
    
    public async Task<BoardModel> GetBoardByPlaceId(Guid id)
    {
        return _mapper.Map<BoardModel>(await _boardRepository.GetBoardByPlaceIdAsync(id));
    }
}