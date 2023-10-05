using BowlHub.BLL.Models;

namespace BowlHub.BLL.Services.Interfaces;

public interface IReservationService
{
    Task<Dictionary<string, List<int[]>>> GetTimeInfoByLineId(Guid id, int lineId);
    Task<ReservationModel> AddNewReservation(ReservationModel reservationModel);
}