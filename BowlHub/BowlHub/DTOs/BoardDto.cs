namespace BowlHub.DTOs;

public class BoardDto
{
    public Guid Id { get; set; }
    public Guid PlaceId { get; set; }
    public int ColumnCount { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}