namespace BowlHub.BLL.Models;

public class BoardModel
{
    public Guid Id { get; set; }
    public Guid PlaceId { get; set; }
    public int ColumnCount { get; set; }
    public string StartTime { get; set; } = default!;
    public string EndTime { get; set; } = default!;
}