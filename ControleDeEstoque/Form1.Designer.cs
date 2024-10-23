namespace ControleDeEstoque
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridProdutos = new DataGridView();
            txtNome = new TextBox();
            txtQuantidade = new TextBox();
            txtPreco = new TextBox();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnRemover = new Button();
            btnPesquisar = new Button();
            btnLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridProdutos).BeginInit();
            SuspendLayout();
            // 
            // dataGridProdutos
            // 
            dataGridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProdutos.Location = new Point(12, 12);
            dataGridProdutos.Name = "dataGridProdutos";
            dataGridProdutos.RowHeadersWidth = 51;
            dataGridProdutos.Size = new Size(660, 188);
            dataGridProdutos.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 215);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome do produto";
            txtNome.Size = new Size(660, 27);
            txtNome.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(12, 257);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PlaceholderText = "Quantidade";
            txtQuantidade.Size = new Size(660, 27);
            txtQuantidade.TabIndex = 2;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(12, 302);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "Preço";
            txtPreco.Size = new Size(660, 27);
            txtPreco.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(12, 364);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(112, 364);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(212, 364);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(94, 29);
            btnRemover.TabIndex = 6;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(312, 364);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 7;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(412, 364);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 532);
            Controls.Add(btnLimpar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnRemover);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtPreco);
            Controls.Add(txtQuantidade);
            Controls.Add(txtNome);
            Controls.Add(dataGridProdutos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridProdutos;
        private TextBox txtNome;
        private TextBox txtQuantidade;
        private TextBox txtPreco;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnRemover;
        private Button btnPesquisar;
        private Button btnLimpar;
    }
}
