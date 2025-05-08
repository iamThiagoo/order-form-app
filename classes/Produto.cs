using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.classes
{
    public class Produto
    {
        private int identificacao;
        private string descricao;
        private float preco;
        private int qtdEstoque;
        private Categoria categoria;

        public Produto(int identificacao, string descricao, float preco, int qtdEstoque, Categoria categoria)
        {
            this.identificacao = identificacao;
            this.descricao = descricao;
            this.preco = preco;
            this.qtdEstoque = qtdEstoque;
            this.categoria = categoria;
        }

        public int Identificacao
        {
            get { return identificacao; }
            set { identificacao = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public float Preco 
        { 
            get { return preco; }
            set { preco = value; }
        }

        public int QtdEstoque
        {
            get { return qtdEstoque; }
            set { qtdEstoque = value; }
        }

        public Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public override string ToString()
        {
            return $"[" +
                $"Identificação: {identificacao}, " +
                $"Descrição: {descricao}, " +
                $"Preço: {preco}, " +
                $"Quantidade Estoque: {qtdEstoque}, " +
                $"Categoria: {categoria.ToString()}]";
        }
    }
}
