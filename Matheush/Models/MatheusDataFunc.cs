using Matheush;
using Microsoft.EntityFrameworkCore;

namespace API.Models;

public class MatheusDataFunc : DbContext
{
    public DbSet<Funcionario> Funcionarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=MatheusHenrique.db");
    }
}
