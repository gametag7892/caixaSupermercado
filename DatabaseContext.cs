using Microsoft.EntityFrameworkCore;
using caixaSupermercado.Model;

namespace caixaSupermercado.DatabaseContext;

public class Produto : DBContext
{
  public DbSet<Produto> Produtos {get; set;}
 
  private override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
    optionsBuilder.UseSqlite($"Data Source = sistema.db");
  }
}
