using Microsoft.EntityFrameworkCore;

public class HamroDarazContext : DbContext
{
    public HamroDarazContext(DbContextOptions<HamroDarazContext> options)
        : base(options)
    {
    }

    public DbSet<HamroDaraz.Models.Product> Product { get; set; } = default!;
    public DbSet<HamroDaraz.Models.Category> Category { get; set; } = default!;
}
