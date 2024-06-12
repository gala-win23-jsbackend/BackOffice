using Microsoft.AspNetCore.Identity;

namespace BackOffice.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string? UserProfileId { get; set; }
    public UserProfile? UserProfile { get; set; }

    public DateTime? Created { get; set; } = DateTime.Now;
    public DateTime? Modified { get; set; } = DateTime.Now;

    public int? UserAddressId { get; set; } = 2;// om saknar orsaker fel

    public UserAddress? UserAddress { get; set; }
    public string? PreferredEmail { get; set; }
    public bool SubscribeNewsletter { get; set; } = false;
    public bool DarkMode { get; set; } = false;
}
