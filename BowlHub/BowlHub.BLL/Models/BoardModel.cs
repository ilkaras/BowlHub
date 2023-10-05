namespace BowlHub.BLL.Models;

public class BoardModel
{
    public Guid Id { get; set; }
    public Guid PlaceId { get; set; }
    public int ColumnCount { get; set; }
    public int StartTime { get; set; }
    public int EndTime { get; set; }
}