using Microsoft.EntityFrameworkCore;
private readonly ApplicationDbContext _context;

public HomeController(ApplicationDbContext context)
{
    _context = context;
}

namespace DotNetCoreApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
    }
}
