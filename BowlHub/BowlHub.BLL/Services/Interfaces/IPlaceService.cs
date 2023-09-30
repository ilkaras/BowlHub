using BowlHub.BLL.Models;

namespace BowlHub.BLL.Services.Interfaces;

public interface IPlaceService
{
    Task<List<PlaceModel>> GetAllPlaces();
}
