namespace BowlHub.DAL.Entities;

public class ReservationEntity : BaseEntity
{
    public Guid UserId { get; set; }
    public Guid BoardId { get; set; }
    public int ColumnNum { get; set; }
    public int FromReservation { get; set; }
    public int TillReservation { get; set; }
    public DateTime DateReservation { get; set; }
    
    public virtual UserEntity? User { get; set; }
    public virtual BoardEntity? Board { get; set; }
}