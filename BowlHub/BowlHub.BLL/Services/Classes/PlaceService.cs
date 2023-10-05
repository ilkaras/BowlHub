using AutoMapper;
using BowlHub.BLL.Models;
using BowlHub.BLL.Services.Interfaces;
using BowlHub.DAL.Repositories.Interfaces;

namespace BowlHub.BLL.Services.Classes;

public class PlaceService : IPlaceService
{
    private readonly IPlaceRepository _placeRepository;
    private readonly IMapper _mapper;
    
    public PlaceService(IMapper mapper, IPlaceRepository repository)
    {
        _mapper = mapper;
        _placeRepository = repository;
    }

    public async Task<List<PlaceModel>> GetAllPlaces()
    {
        return _mapper.Map<List<PlaceModel>>(_placeRepository.GetAll());
    }
}