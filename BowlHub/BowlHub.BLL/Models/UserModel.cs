namespace BowlHub.BLL.Models;

public class UserModel
{
    public Guid Id { get; set; }
    public string Email { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string Name { get; set; } = default!;
}