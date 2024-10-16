using Matheush;
using Microsoft.EntityFrameworkCore;

namespace API.Models;

public class MatheusHenriqueDataContext: DbContext
{
    public DbSet<Folha> Folhas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=MatheusHenrique.db");
    }
}
