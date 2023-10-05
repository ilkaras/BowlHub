namespace BowlHub.DTOs;

public class ReservationDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid BoardId { get; set; }
    public int ColumnNum { get; set; }
    public int FromReservation { get; set; }
    public int TillReservation { get; set; }
    public DateTime DateReservation { get; set; }
}