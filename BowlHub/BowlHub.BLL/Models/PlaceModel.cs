namespace BowlHub.BLL.Models;

public class PlaceModel
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string City { get; set; } = default!;
    public string Address { get; set; } = default!;
    public string AdminPhone { get; set; } = default!;
}