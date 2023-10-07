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
    private readonly IEmailSenderService _emailSenderService;
    private readonly IMapper _mapper;

    public BoardController(IMapper mapper, IBoardService boardService, IReservationService reservationService, IEmailSenderService emailSenderService)
    {
        _mapper = mapper;
        _boardService = boardService;
        _reservationService = reservationService;
        _emailSenderService = emailSenderService;
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
    public async Task<IActionResult> GetTimeInfo([FromQuery]GetInfoTimeDto infoTimeDto)
    {
        DateTime.TryParse(infoTimeDto.ReservationDate, out var date);
        return Ok(Results.Json(await _reservationService.GetTimeInfoByLineId(infoTimeDto.Id, infoTimeDto.LineId, date)));
    }

    [HttpPost("addNewReservation"), Authorize]
    public async Task<IActionResult> AddNewReservation([FromBody]ReservationDto reservationDto)
    {
        var token = Request.Cookies["accessToken"];
        var handler = new JwtSecurityTokenHandler();
        var jwtSecurityToken = handler.ReadJwtToken(token);
        reservationDto.UserId = new Guid(jwtSecurityToken.Claims.First(claim => claim.Type == "adminId").Value);

        var result = await _reservationService.AddNewReservation(_mapper.Map<ReservationModel>(reservationDto));

        var userEmail = jwtSecurityToken.Claims.First(claim => claim.Type == "sub").Value;
        await _emailSenderService.SendEmailAsync(userEmail, "subject", "message");
        
        return Ok(Results.Json(_mapper.Map<ReservationDto>(result)));
    }
}