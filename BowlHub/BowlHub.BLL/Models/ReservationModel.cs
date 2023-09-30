namespace BowlHub.BLL.Models;

public class ReservationModel
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid BoardId { get; set; }
    public Guid ColumnNum { get; set; }
    public DateTime FromReservation { get; set; }
    public DateTime TillReservation { get; set; }
    public DateTime DateReservation { get; set; }
}