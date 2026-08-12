using Microsoft.EntityFrameworkCore;

public class HamroDarazContext(DbContextOptions<HamroDarazContext> options) : DbContext(options)
{
    public DbSet<HamroDaraz.Models.Category> Category { get; set; } = default!;
    public DbSet<HamroDaraz.Models.Product> Product { get; set; } = default!;
}
