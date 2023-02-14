using CharSheetBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace CharSheetBackend;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    { }

    public DbSet<CharacterDetail> CharacterDetails { get; set; }
    public DbSet<AbilityScore> AbilityScores { get; set; }
}
