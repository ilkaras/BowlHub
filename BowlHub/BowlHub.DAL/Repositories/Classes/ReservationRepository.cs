using BowlHub.DAL.Entities;
using BowlHub.DAL.Repositories.Interfaces;

namespace BowlHub.DAL.Repositories.Classes;

public class ReservationRepository : BaseRepository<ReservationEntity>, IReservationRepository
{
    public ReservationRepository(DataBaseContext context) : base(context)
    {
    }
}