namespace BowlHub.BLL.Models;

public class BoardModel
{
    public Guid Id { get; set; }
    public Guid PlaceId { get; set; }
    public int ColumnCount { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}