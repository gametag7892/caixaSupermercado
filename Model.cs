using Microsoft.EntityFrameworkCore.Sqlite;

namespace caixaSupermercado.Models;

public class Produto:DBContext
{

  public DbSet<Produto> Produto {get; set;}
  public string DbPath {get;}

  public ProdutoContext(){
    DbPath = "sistema.db";
  }
  
  private override void OnConfiguring() => options.UseSqlite($"Data Source = {DbPath}");
    
}

public class Produto  
{
  public string nomeProduto {get; set;}
  public float precoProduto {get; set;}
}
