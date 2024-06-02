using BackOffice.Data;
using Microsoft.AspNetCore.Identity;

namespace BackOffice.Components.Services;

public class AdminService
{
    private readonly UserManager<ApplicationUser> _userManager;

    public AdminService(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<List<ApplicationUser>> GetAdministratorsAsync()
    {
        var users = await _userManager.GetUsersInRoleAsync("Admin");
        return users.ToList();
    }
}

