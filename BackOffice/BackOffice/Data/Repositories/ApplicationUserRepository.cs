namespace BackOffice.Data.Repositories;

public class ApplicationUserRepository(ApplicationDbContext context)
{
    private readonly ApplicationDbContext _context = context;

}
