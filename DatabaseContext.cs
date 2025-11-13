using Microsoft.EntityFrameworkCore;

namespace caixaSupermercado.Models;

public class Produto : DBContext
{
  public DbSet<Produto> Produtos {get; set;}
 
  private override void OnConfiguring(DbContextOptionsBuilder options){
    options.UseSqlite($"Data Source = sistema.db");
  }
}
