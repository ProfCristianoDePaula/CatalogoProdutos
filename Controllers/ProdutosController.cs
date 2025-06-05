using CatalogoProduto.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoProduto.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index(string categoria = null)
        {
            var produtos = new List<Produto>
            {
                new Produto { ProdutoId = 1,
                            Nome = "Smartphone Samsung",
                            Categoria = "Smartphone",
                            Preco = 1999,
                            ImagemUrl = "/img/celular.jpg"
                },
                new Produto { ProdutoId = 2,
                            Nome = "Notebook Samsung",
                            Categoria = "Notebook",
                            Preco = 3499,
                            ImagemUrl = "/img/notebook.jpg"
                },
                new Produto { ProdutoId = 3,
                            Nome = "Smartwatch Samsung",
                            Categoria = "Smartwatch",
                            Preco = 1199,
                            ImagemUrl = "/img/smartwatch.jpg"
                },
                new Produto { ProdutoId = 4,
                            Nome = "Smartphone Apple",
                            Categoria = "Smartphone",
                            Preco = 3999,
                            ImagemUrl = "/img/iphone.jpg"
                },
                new Produto { ProdutoId = 5,
                            Nome = "Notebook Apple",
                            Categoria = "Notebook",
                            Preco = 6999,
                            ImagemUrl = "/img/macbook.jpg"
                },
                new Produto { ProdutoId = 6,
                            Nome = "Smartwatch Apple",
                            Categoria = "Smartwatch",
                            Preco = 2399,
                            ImagemUrl = "/img/applewatch.jpg"
                }
            };

            if (!string.IsNullOrEmpty(categoria))
                produtos = produtos.Where(p => p.Categoria.ToLower() == categoria.ToLower()).ToList();

            return View(produtos);
        }
    }
}
