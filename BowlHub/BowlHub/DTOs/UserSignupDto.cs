namespace BowlHub.DTOs;

public class UserSignupDto
{
    public string Email { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string Name { get; set; } = default!;
}