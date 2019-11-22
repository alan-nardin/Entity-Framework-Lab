using System;
using System.Linq;
using System.Text.Json;

namespace EntityApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ProdutoContext())
            {
                // // Criando um novo produto
                var produto = new Produto()
                {
                    ProdutoId = 1,
                    Descricao = "Caneta azul",
                    Estoque = 10,
                    Preco = 3.90m
                };

                if (!db.Produtos.Any(p => p.ProdutoId.Equals(produto.ProdutoId)))
                {
                    db.Add(produto);
                    db.SaveChanges();
                }

                //Consultando a base
                var products = db.Produtos;
                Console.WriteLine(JsonSerializer.Serialize(products));
            }
        }
    }
}
