using Microsoft.EntityFrameworkCore.Sqlite;

await using var db = new ProdutoContext();

var resultados = from Produto in db.Produtos
                 where Produto.Id == 1
                 select produto;

await foreach (var r in resultados.AsAsyncEnumerable()) 
{
  Console.WriteLine($"ID:{r.Id} | Produto: {r.nomeProduto}");
}

