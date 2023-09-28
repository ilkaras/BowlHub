namespace BowlHub.DAL.Entities;

public class UserEntity : BaseEntity
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    
    public virtual ICollection<ReservationEntity>? Reservations { get; set; } = new List<ReservationEntity>();
}