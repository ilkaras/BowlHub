using AutoMapper;
using BowlHub.BLL.Services.Interfaces;
using BowlHub.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BowlHub.Controllers;

[ApiController]
public class VisitController : Controller
{
    public VisitController()
    {
    }
    
    [HttpGet("")]
    public IActionResult RenderVisit()
    {
        return View("../Pages/Visit");
    }
}