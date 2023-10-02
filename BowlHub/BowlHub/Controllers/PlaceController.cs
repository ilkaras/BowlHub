using AutoMapper;
using BowlHub.BLL.Services.Interfaces;
using BowlHub.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BowlHub.Controllers;

[ApiController]
public class PlaceController : Controller
{
    private readonly IPlaceService _placeService;
    private readonly IMapper _mapper;

    public PlaceController(IMapper mapper, IPlaceService placeService)
    {
        _mapper = mapper;
        _placeService = placeService;
    }
    
    [HttpGet("places")]
    public async Task<IActionResult> GetAllPlaces()
    {
        var result = _mapper.Map<List<PlaceDto>>(await _placeService.GetAllPlaces());
        return View("../Pages/Hub", result);
    }
}