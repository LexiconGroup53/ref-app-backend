using Microsoft.EntityFrameworkCore;
using ref_app_backend.Models;

namespace ref_app_backend.Data;

public class RefDbContext : DbContext
{
    public RefDbContext(DbContextOptions<RefDbContext> options) : base(options)
    {
        
    }

    public DbSet<Reference> References { get; set; }
}