using System.Data.Entity.Core;
using AutoMapper;
using BowlHub.BLL.Models;
using BowlHub.BLL.Services.Interfaces;
using BowlHub.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BowlHub.Controllers;

[ApiController]
[Route("auth")]
public class AuthController : Controller
{
    private readonly IUserService _userService;
    private readonly IAuthService _authService;
    private readonly IMapper _mapper;
    
    public AuthController(IUserService userService, IMapper mapper, IAuthService authService)
    {
        _userService = userService;
        _mapper = mapper;
        _authService = authService;
    }
    
    [HttpGet("{type}")]
    public IActionResult RenderAuth(string? type)
    {
        switch (type)
        {
            case "login":
                return View("../Pages/Login");
            case "signup":
                return View("../Pages/Signup");
            default:
                return View("../Pages/Login");
        }
    }

    [HttpPost("userSignup")]
    public async Task<IActionResult> UserSignup([FromForm]UserSignupDto user)
    {
        await _userService.AddNewUser(_mapper.Map<UserModel>(user));
        return View("../Pages/Login");
    }

    [HttpPost("userLogin")]
    public async Task<IActionResult> UserLogin([FromForm]UserLoginDto user)
    {
        try
        {
            var token = await _authService.Authorize(user.Email, user.Password);
            HttpContext.Session.SetString("accessToken", token!);
            return Redirect("/places");
        }
        catch (ObjectNotFoundException e)
        {
            return new NotFoundResult();
        }
        catch (ArgumentException e)
        {
            return new UnauthorizedObjectResult(e.Message);
        }
    }
}