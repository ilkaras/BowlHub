namespace BowlHub.DAL.Entities;

public class BoardEntity : BaseEntity
{
    public Guid PlaceId { get; set; }
    public int ColumnCount { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    
    public virtual ICollection<ReservationEntity>? Reservations { get; set; } = new List<ReservationEntity>();
    public virtual PlaceEntity? Place { get; set; }
}