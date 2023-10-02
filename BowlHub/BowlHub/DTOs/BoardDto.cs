namespace BowlHub.DTOs;

public class BoardDto
{
    public Guid Id { get; set; }
    public Guid PlaceId { get; set; }
    public int ColumnCount { get; set; }
    public string StartTime { get; set; }
    public string EndTime { get; set; }
}