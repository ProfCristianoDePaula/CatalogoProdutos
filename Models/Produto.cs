﻿namespace CatalogoProduto.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
    }
}
