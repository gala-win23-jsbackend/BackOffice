namespace BackOffice.Data;

public class UserProfile
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;

    public string? Biography { get; set; }
    public string? ProfileImage { get; set; }
}
