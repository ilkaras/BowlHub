using BowlHub.DAL.Entities;
using BowlHub.DAL.Repositories.Interfaces;

namespace BowlHub.DAL.Repositories.Classes;

public class PlaceRepository : BaseRepository<PlaceEntity>, IPlaceRepository
{
    public PlaceRepository(DataBaseContext context) : base(context)
    {
    }
}