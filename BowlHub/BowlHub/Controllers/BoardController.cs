using AutoMapper;
using BowlHub.BLL.Services.Interfaces;
using BowlHub.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BowlHub.Controllers;

[ApiController]
public class BoardController : Controller
{
    private readonly IBoardService _boardService;
    private readonly IMapper _mapper;

    public BoardController(IMapper mapper, IBoardService boardService)
    {
        _mapper = mapper;
        _boardService = boardService;
    }
    
    [HttpGet("board")]
    public async Task<IActionResult> GetBoardByPlaceId(Guid id)
    {
        var result = _mapper.Map<BoardDto>(await _boardService.GetBoardByPlaceId(id));
        return View("../Pages/Bowling",result);
    }
}