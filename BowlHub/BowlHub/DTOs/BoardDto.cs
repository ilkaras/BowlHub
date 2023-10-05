namespace BowlHub.DTOs;

public class BoardDto
{
    public Guid Id { get; set; }
    public Guid PlaceId { get; set; }
    public int ColumnCount { get; set; }
    public int StartTime { get; set; }
    public int EndTime { get; set; }
}