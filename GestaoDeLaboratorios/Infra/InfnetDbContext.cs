using Microsoft.EntityFrameworkCore;
using GestaoDeLaboratorios.Models;

namespace GestaoDeLaboratorios.Infra;

public class InfnetDbContext : DbContext
{
    public InfnetDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Computador> Computador { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Computador>().ToTable("Computador");
    }
}
