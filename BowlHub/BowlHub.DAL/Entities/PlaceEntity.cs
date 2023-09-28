namespace BowlHub.DAL.Entities;

public class PlaceEntity : BaseEntity
{
    public string Name { get; set; }
    public string City { get; set; }
    public string Adress { get; set; }
    public string AdminPhone { get; set; }
    
    public virtual ICollection<BoardEntity>? Boards { get; set; } = new List<BoardEntity>();
}