using System.Diagnostics;
using Trabalho.classes;
using Trabalho.models;
using Trabalho.views;

namespace Trabalho.controllers
{
    public class ProductController
    {
        private ProdutoModel _model;
        private ProdutoView _view;
        private List<Categoria> categorias;

        public ProductController(ProdutoModel model, ProdutoView view) {
            _model = model;
            _view = view;

            categorias = GetCategorias();
            _model.Add(new Produto(1, "Notebook", 4500f, 100, categorias[0]));
            _model.Add(new Produto(2, "Detergente", 60f, 1000, categorias[1]));
            _model.Add(new Produto(3, "Sucrilhos", 2500f, 50, categorias[2]));

            TotalItemsEstoque();
            TotalValorEstoque();
        }

        public List<Produto> GetProdutos()
        {
            return _model.Find();
        }

        public List<Categoria> GetCategorias()
        {
            categorias = new List<Categoria>();
            categorias.Add(new Categoria(1, "Eletrônica"));
            categorias.Add(new Categoria(2, "Limpeza"));
            categorias.Add(new Categoria(3, "Alimentícia"));
            return categorias;
        }

        public void Insert()
        {
            if (
                string.IsNullOrWhiteSpace(_view.DescricaoBox) ||
                string.IsNullOrWhiteSpace(_view.PrecoBox) ||
                string.IsNullOrWhiteSpace(_view.EstoqueBox) ||
                _view.CategoriaComboBox == null
            ) return;

            int identificacao = _model.GetNextIdentificacao();
            string descricaoBox = _view.DescricaoBox;
            float precoBox = float.Parse(_view.PrecoBox);
            int estoqueBox = int.Parse(_view.EstoqueBox);
            Categoria categoriaBox = _view.CategoriaComboBox;

            Produto produto = new Produto(identificacao, descricaoBox, precoBox, estoqueBox, categoriaBox);
            _model.Add(produto);

            _view.resetFields();
            _view.loadDataTable();

            TotalItemsEstoque();
            TotalValorEstoque();
        }

        public void OrderPreco()
        {
            List<Produto> produtos = _model.OrderByPreco();
            _view.loadDataTable(produtos);
        }

        public void SearchByIdentificacao(string? identificacaoString)
        {
            if (int.TryParse(identificacaoString, out int identificacao))
            {
                Produto produto = _model.FindByIdentificacao(identificacao);
                List<Produto> produtos = new List<Produto> { produto };
                _view.loadDataTable(produtos);
            }
            else
            {
                _view.loadDataTable();
            }
        }

        public void SearchByDescricao(string search)
        {
            List<Produto> produtos = _model.Search(search);
            _view.loadDataTable(produtos);
        }

        public void SearchByCategoria(string categoriaIdentificacaoString)
        {
            if (int.TryParse(categoriaIdentificacaoString, out int categoriaIdentificacao))
            {
                List<Produto> produtos = _model.FindByCategoriaIdentificacao(categoriaIdentificacao);
                _view.loadDataTable(produtos);
            } else
            {
                _view.loadDataTable();
            }
        }

        public void SearchByEstoqueAbaixo(string? qtd)
        {
            if (int.TryParse(qtd, out int estoqueLimite))
            {
                List<Produto> produtos = _model.FindByEstoqueAbaixo(estoqueLimite);
                _view.loadDataTable(produtos);
            }
            else
            {
                _view.loadDataTable();
            }
        }

        public void TotalItemsEstoque()
        {
            int totalEstoque = _model.GetEstoqueTotal();
            _view.TotalItensLabel = $"Total de Itens no Estoque: {totalEstoque}";
        }

        public void TotalValorEstoque()
        {
            float totalValorEstoque = _model.GetValorEstoqueTotal();
            _view.TotalValorLabel = $"Valor Total em Estoque: {totalValorEstoque.ToString("C2", new System.Globalization.CultureInfo("pt-BR"))}";
        }
    }
}
