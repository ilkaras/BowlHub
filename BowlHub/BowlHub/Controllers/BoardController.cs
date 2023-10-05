using System.IdentityModel.Tokens.Jwt;
using AutoMapper;
using BowlHub.BLL.Models;
using BowlHub.BLL.Services.Interfaces;
using BowlHub.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BowlHub.Controllers;

[ApiController]
public class BoardController : Controller
{
    private readonly IBoardService _boardService;
    private readonly IReservationService _reservationService;
    private readonly IMapper _mapper;

    public BoardController(IMapper mapper, IBoardService boardService, IReservationService reservationService)
    {
        _mapper = mapper;
        _boardService = boardService;
        _reservationService = reservationService;
    }
    
    [HttpGet("board")]
    public async Task<IActionResult> GetBoardByPlaceId(Guid id)
    {
        var result = _mapper.Map<BoardDto>(await _boardService.GetBoardByPlaceId(id));
        Response.Cookies.Delete("boardId");
        Response.Cookies.Append("boardId", result.Id.ToString(), new CookieOptions
        {
            Expires = DateTime.Now.AddDays(1),
        });
        return View("../Pages/Bowling",result);
    }

    [HttpGet("getTimeInfo")]
    public async Task<IActionResult> GetTimeInfo(Guid id, int lineId)
    {
        return Ok(Results.Json(await _reservationService.GetTimeInfoByLineId(id, lineId)));
    }

    [HttpPost("addNewReservation")] // TODO Authorize needed
    public async Task<IActionResult> AddNewReservation([FromBody] ReservationDto reservationDto)
    {
        var token = HttpContext.Session.GetString("accessToken");
        var handler = new JwtSecurityTokenHandler();
        var jwtSecurityToken = handler.ReadJwtToken(token);
        reservationDto.UserId = new Guid(jwtSecurityToken.Claims.First(claim => claim.Type == "adminId").Value);

        var result = await _reservationService.AddNewReservation(_mapper.Map<ReservationModel>(reservationDto));
        return Ok(Results.Json(_mapper.Map<ReservationDto>(result)));
    }
}