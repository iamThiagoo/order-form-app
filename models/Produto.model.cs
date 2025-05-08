using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.classes;

namespace Trabalho.models
{
    public class ProdutoModel
    {
        private List<Produto> produtos;

        public ProdutoModel()
        {
            produtos = new List<Produto>();
        }

        public void Add(Produto produto)
        {
            produtos.Add(produto);
        }

        public List<Produto> Find()
        {
            return produtos;
        }

        public Produto? FindByIdentificacao(int identificacao)
        {
            foreach (Produto produto in produtos)
            {
                if (produto.Identificacao == identificacao)
                {
                    return produto;
                }
            }

            return null;
        }

        public List<Produto> FindByCategoriaIdentificacao(int categoriaIdentificacao)
        {
            return produtos.Where(produto => produto.Categoria.Identificacao == categoriaIdentificacao).ToList();
        }

        public List<Produto> FindByEstoqueAbaixo(int qtd) 
        {
            return produtos.Where(produto => produto.QtdEstoque < qtd).ToList();
        }

        public int GetEstoqueTotal()
        {
            int total = 0;

            foreach (Produto produto in produtos)
            {
                total += produto.QtdEstoque;
            }

            return total;
        }

        public float GetValorEstoqueTotal()
        {
            float total = 0f;

            foreach (Produto produto in produtos)
            {
                total += produto.Preco * produto.QtdEstoque;
            }

            return total;
        }

        public List<Produto> Search(string search)
        {
            return produtos.Where(produto => produto.Descricao.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Produto> OrderByPreco()
        {
            return produtos.OrderBy(produto => produto.Preco).ToList();
        }

        public int GetNextIdentificacao()
        {
            return produtos.Count + 1;
        }
    }
}
