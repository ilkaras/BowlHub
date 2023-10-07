using BowlHub.DAL.Entities;

namespace BowlHub.DAL.Repositories.Interfaces;

public interface IReservationRepository : IRepository<ReservationEntity>
{
    Task<Dictionary<string, List<int[]>>> GetTimeInfoByLineId(Guid id, int lineId, DateTime date);
}
