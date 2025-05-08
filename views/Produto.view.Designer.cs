namespace Trabalho.views
{
    partial class ProdutoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnInsert = new Button();
            descricaoBox = new TextBox();
            precoBox = new TextBox();
            estoqueBox = new TextBox();
            bindingSource1 = new BindingSource(components);
            comboBox = new ComboBox();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            identificacao = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            preco = new DataGridViewTextBoxColumn();
            estoque = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            totalItensLabel = new Label();
            identificacaoSearchBox = new TextBox();
            descricaoSearchBox = new TextBox();
            EstoqueAbaixoSearchBox = new TextBox();
            categoriaComboBoxSearch = new ComboBox();
            panel2 = new Panel();
            panel3 = new Panel();
            precoOrderButton = new Button();
            totalValorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(669, 15);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(119, 23);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Inserir";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // descricaoBox
            // 
            descricaoBox.Location = new Point(12, 15);
            descricaoBox.Name = "descricaoBox";
            descricaoBox.PlaceholderText = "Nome do Produto";
            descricaoBox.Size = new Size(308, 23);
            descricaoBox.TabIndex = 1;
            // 
            // precoBox
            // 
            precoBox.Location = new Point(326, 15);
            precoBox.Name = "precoBox";
            precoBox.PlaceholderText = "Preço";
            precoBox.Size = new Size(79, 23);
            precoBox.TabIndex = 2;
            precoBox.KeyPress += precoBox_KeyPress;
            // 
            // estoqueBox
            // 
            estoqueBox.Location = new Point(411, 15);
            estoqueBox.Name = "estoqueBox";
            estoqueBox.PlaceholderText = "Estoque";
            estoqueBox.Size = new Size(100, 23);
            estoqueBox.TabIndex = 3;
            estoqueBox.KeyPress += estoqueBox_KeyPress;
            // 
            // comboBox
            // 
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(517, 15);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(146, 23);
            comboBox.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 233);
            panel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { identificacao, descricao, preco, estoque, categoria });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 245);
            dataGridView1.TabIndex = 0;
            // 
            // identificacao
            // 
            identificacao.HeaderText = "ID";
            identificacao.Name = "identificacao";
            identificacao.ReadOnly = true;
            identificacao.Width = 50;
            // 
            // descricao
            // 
            descricao.HeaderText = "Descrição";
            descricao.Name = "descricao";
            descricao.Width = 190;
            // 
            // preco
            // 
            preco.HeaderText = "Preço";
            preco.Name = "preco";
            preco.Width = 175;
            // 
            // estoque
            // 
            estoque.HeaderText = "Estoque";
            estoque.Name = "estoque";
            estoque.Width = 150;
            // 
            // categoria
            // 
            categoria.HeaderText = "Categoria";
            categoria.Name = "categoria";
            categoria.Width = 175;
            // 
            // totalItensLabel
            // 
            totalItensLabel.AutoSize = true;
            totalItensLabel.Location = new Point(620, 340);
            totalItensLabel.Name = "totalItensLabel";
            totalItensLabel.Size = new Size(151, 15);
            totalItensLabel.TabIndex = 6;
            totalItensLabel.Text = "Total de Itens no Estoque: 0";
            // 
            // identificacaoSearchBox
            // 
            identificacaoSearchBox.Location = new Point(12, 65);
            identificacaoSearchBox.Name = "identificacaoSearchBox";
            identificacaoSearchBox.PlaceholderText = "Filtre por ID...";
            identificacaoSearchBox.Size = new Size(93, 23);
            identificacaoSearchBox.TabIndex = 7;
            identificacaoSearchBox.TextChanged += identificacaoSearchBox_TextChanged;
            // 
            // descricaoSearchBox
            // 
            descricaoSearchBox.Location = new Point(111, 65);
            descricaoSearchBox.Name = "descricaoSearchBox";
            descricaoSearchBox.PlaceholderText = "Filtre por Descrição...";
            descricaoSearchBox.Size = new Size(209, 23);
            descricaoSearchBox.TabIndex = 8;
            descricaoSearchBox.TextChanged += descricaoSearchBox_TextChanged;
            // 
            // EstoqueAbaixoSearchBox
            // 
            EstoqueAbaixoSearchBox.Location = new Point(541, 66);
            EstoqueAbaixoSearchBox.Name = "EstoqueAbaixoSearchBox";
            EstoqueAbaixoSearchBox.PlaceholderText = "Estoque Abaixo de...";
            EstoqueAbaixoSearchBox.Size = new Size(122, 23);
            EstoqueAbaixoSearchBox.TabIndex = 9;
            EstoqueAbaixoSearchBox.TextChanged += EstoqueAbaixoSearchBox_TextChanged;
            EstoqueAbaixoSearchBox.KeyPress += estoqueBox_KeyPress;
            // 
            // categoriaComboBoxSearch
            // 
            categoriaComboBoxSearch.FormattingEnabled = true;
            categoriaComboBoxSearch.Location = new Point(326, 65);
            categoriaComboBoxSearch.Name = "categoriaComboBoxSearch";
            categoriaComboBoxSearch.Size = new Size(121, 23);
            categoriaComboBoxSearch.TabIndex = 10;
            categoriaComboBoxSearch.SelectedIndexChanged += categoriaComboBoxSearch_SelectedIndexChanged;
            categoriaComboBoxSearch.TextChanged += categoriaComboBoxSearch_TextChanged;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(12, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(773, 1);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(15, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(773, 1);
            panel3.TabIndex = 11;
            // 
            // precoOrderButton
            // 
            precoOrderButton.Location = new Point(669, 65);
            precoOrderButton.Name = "precoOrderButton";
            precoOrderButton.Size = new Size(116, 23);
            precoOrderButton.TabIndex = 12;
            precoOrderButton.Text = "Ordenar por Preço";
            precoOrderButton.UseVisualStyleBackColor = true;
            precoOrderButton.Click += precoOrderButton_Click;
            // 
            // totalValorLabel
            // 
            totalValorLabel.AutoSize = true;
            totalValorLabel.Location = new Point(12, 340);
            totalValorLabel.Name = "totalValorLabel";
            totalValorLabel.Size = new Size(170, 15);
            totalValorLabel.TabIndex = 13;
            totalValorLabel.Text = "Valor Total em Estoque: R$ 0.00";
            // 
            // ProdutoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 372);
            Controls.Add(totalValorLabel);
            Controls.Add(precoOrderButton);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(categoriaComboBoxSearch);
            Controls.Add(EstoqueAbaixoSearchBox);
            Controls.Add(descricaoSearchBox);
            Controls.Add(identificacaoSearchBox);
            Controls.Add(totalItensLabel);
            Controls.Add(panel1);
            Controls.Add(comboBox);
            Controls.Add(estoqueBox);
            Controls.Add(precoBox);
            Controls.Add(descricaoBox);
            Controls.Add(btnInsert);
            Name = "ProdutoView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produto";
            Load += Produto_Load;
            TextChanged += descricaoSearchBox_TextChanged;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsert;
        private TextBox descricaoBox;
        private TextBox precoBox;
        private TextBox estoqueBox;
        private BindingSource bindingSource1;
        private ComboBox comboBox;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label totalItensLabel;
        private TextBox identificacaoSearchBox;
        private TextBox descricaoSearchBox;
        private TextBox EstoqueAbaixoSearchBox;
        private ComboBox categoriaComboBoxSearch;
        private DataGridViewTextBoxColumn identificacao;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn preco;
        private DataGridViewTextBoxColumn estoque;
        private DataGridViewTextBoxColumn categoria;
        private Panel panel2;
        private Panel panel3;
        private Button precoOrderButton;
        private Label totalValorLabel;
    }
}