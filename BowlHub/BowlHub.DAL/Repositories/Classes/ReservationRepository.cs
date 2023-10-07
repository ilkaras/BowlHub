using BowlHub.DAL.Entities;
using BowlHub.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BowlHub.DAL.Repositories.Classes;

public class ReservationRepository : BaseRepository<ReservationEntity>, IReservationRepository
{
    private readonly DbSet<BoardEntity> _boardDbSet;
    
    public ReservationRepository(DataBaseContext context) : base(context)
    {
        _boardDbSet = context.Set<BoardEntity>();
    }

    public async Task<Dictionary<string, List<int[]>>> GetTimeInfoByLineId(Guid id, int lineId, DateTime date)
    {
        var board = await _boardDbSet.FirstOrDefaultAsync(x => x.PlaceId == id);
        
        List<int[]> busyTimes = await DbSet
            .Where(r => r.BoardId == board!.Id && r.ColumnNum == lineId && r.DateReservation == date)
            .OrderBy(r => r.FromReservation)
            .Select(r => new int[] { r.FromReservation, r.TillReservation }) 
            .ToListAsync();

        List<int[]> freeTimes = new List<int[]>();

        int startOfDay = board!.StartTime;
        int endOfDay = board.EndTime;
        int lastEnd = startOfDay;

        foreach (var busyTime in busyTimes)
        {
            if (busyTime[0] > lastEnd)
            {
                freeTimes.Add(new int[] { lastEnd, busyTime[0] });
            }
            lastEnd = busyTime[1];
        }

        if (lastEnd < endOfDay)
        {
            freeTimes.Add(new int[] { lastEnd, endOfDay });
        }

        return new Dictionary<string, List<int[]>> 
        {
            { "busy", busyTimes },
            { "free", freeTimes }
        };
    }
}