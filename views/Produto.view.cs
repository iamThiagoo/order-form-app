using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho.classes;
using Trabalho.controllers;

namespace Trabalho.views
{
    public partial class ProdutoView : Form
    {
        private ProductController _controller;

        public ProdutoView()
        {
            InitializeComponent();
        }

        // Informativos
        public string TotalValorLabel
        {
            get { return totalValorLabel.Text; }
            set { totalValorLabel.Text = value; }
        }

        public string TotalItensLabel
        {
            get { return totalItensLabel.Text; }
            set { totalItensLabel.Text = value; }
        }

        // Insert Form
        public string DescricaoBox
        {
            get { return descricaoBox.Text; }
            set { descricaoBox.Text = value; }
        }

        public string PrecoBox
        {
            get { return precoBox.Text; }
            set { precoBox.Text = value; }
        }

        public string EstoqueBox
        {
            get { return estoqueBox.Text; }
            set { estoqueBox.Text = value; }
        }
        public Categoria CategoriaComboBox
        {
            get { return (Categoria)comboBox.SelectedItem; }
            set { comboBox.SelectedItem = value; }
        }

        public void SetController(ProductController controller)
        {
            _controller = controller;
        }

        private void Produto_Load(object sender, EventArgs e)
        {
            comboBox.DataSource = _controller.GetCategorias();
            comboBox.DisplayMember = "Descricao";
            comboBox.ValueMember = "Identificacao";

            categoriaComboBoxSearch.DataSource = _controller.GetCategorias();
            categoriaComboBoxSearch.DisplayMember = "Descricao";
            categoriaComboBoxSearch.ValueMember = "Identificacao";

            loadDataTable();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            _controller.Insert();
        }

        public void loadDataTable(List<Produto>? produtos = null)
        {
            dataGridView1.Rows.Clear();

            if (produtos == null)
            {
                produtos = _controller.GetProdutos();
            }

            foreach (Produto produto in produtos)
            {
                dataGridView1.Rows.Add(
                    produto.Identificacao,
                    produto.Descricao,
                    produto.Preco,
                    produto.QtdEstoque,
                    produto.Categoria.Descricao
                );
            }
        }

        public void resetFields()
        {
            DescricaoBox = "";
            PrecoBox = "";
            EstoqueBox = "";
            comboBox.SelectedIndex = 0;
        }

        private void precoOrderButton_Click(object sender, EventArgs e)
        {
            _controller.OrderPreco();
        }
        private void identificacaoSearchBox_TextChanged(object sender, EventArgs e)
        {
            _controller.SearchByIdentificacao(identificacaoSearchBox.Text);
        }

        private void descricaoSearchBox_TextChanged(object sender, EventArgs e)
        {
            _controller.SearchByDescricao(descricaoSearchBox.Text);
        }

        private void EstoqueAbaixoSearchBox_TextChanged(object sender, EventArgs e)
        {
            _controller.SearchByEstoqueAbaixo(EstoqueAbaixoSearchBox.Text);
        }

        private void categoriaComboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.SearchByCategoria(categoriaComboBoxSearch.SelectedValue.ToString());
        }

        private void categoriaComboBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(categoriaComboBoxSearch.Text))
            {
                loadDataTable();
            }
        }

        private void estoqueBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void precoBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',' || e.KeyChar == '.') && (txt.Text.Contains(",") || txt.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }
    }
}
