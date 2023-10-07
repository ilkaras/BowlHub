using System.Data.Entity.Core;
using AutoMapper;
using BowlHub.BLL.Models;
using BowlHub.BLL.Services.Interfaces;
using BowlHub.DTOs;
using Microsoft.AspNetCore.Authorization;
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

    [HttpGet("checkAuth"), Authorize]
    public IActionResult CheckAuth()
    {
        return Ok();
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
        try
        {
            user.Email = user.Email.ToLower();
            await _userService.AddNewUser(_mapper.Map<UserModel>(user));
            return View("../Pages/Login");
        }
        catch (InvalidOperationException e)
        {
            return View("../Pages/Signup", e.Message);
        }
    }

    [HttpPost("userLogin")]
    public async Task<IActionResult> UserLogin([FromForm]UserLoginDto user)
    {
        try
        {
            user.Email = user.Email.ToLower();
            var token = await _authService.Authorize(user.Email, user.Password);
            Response.Cookies.Append("accessToken", token!, new CookieOptions
            {
                HttpOnly = false,
                Secure = true,
                SameSite = SameSiteMode.Lax,
                Expires = DateTime.UtcNow.AddHours(1)
            });
            return Redirect("/places");
        }
        catch (ObjectNotFoundException e)
        {
            return View("../Pages/Login", e.Message);
        }
        catch (ArgumentException e)
        {
            return View("../Pages/Login", e.Message);
        }
    }

    [HttpGet("logout")]
    public IActionResult UserLogout()
    {
        Response.Cookies.Delete("accessToken");
        return Ok();
    }
}