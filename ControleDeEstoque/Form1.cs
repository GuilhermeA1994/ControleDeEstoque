using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ControleDeEstoque
{
    public partial class Form1 : Form
    {
        private int idProdutoSelecionado;
        string connectionString = "Server=localhost;Database=ControleEstoque;Uid=root;Pwd=123456;";
        public Form1()
        {
            InitializeComponent();
        }

        private void AtualizarDataGridView()
        {
            string query = "SELECT * FROM Produtos";

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conexao))
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridProdutos.DataSource = dt;
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Produtos (nome, quantidade, preco) VALUES (@nome, @quantidade, @preco)";

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conexao))
            {
                conexao.Open();
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@quantidade", Convert.ToInt32(txtQuantidade.Text));
                cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(txtPreco.Text));

                cmd.ExecuteNonQuery();
            }

            AtualizarDataGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Produtos SET nome = @nome, quantidade = @quantidade, preco = @preco WHERE id = @id";

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conexao))
            {
                conexao.Open();
                cmd.Parameters.AddWithValue("@id", idProdutoSelecionado);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@quantidade", Convert.ToInt32(txtQuantidade.Text));
                cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(txtPreco.Text));

                cmd.ExecuteNonQuery();
            }

            AtualizarDataGridView();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Produtos WHERE id = @id";

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conexao))
            {
                conexao.Open();
                cmd.Parameters.AddWithValue("@id", idProdutoSelecionado);
                cmd.ExecuteNonQuery();
            }

            AtualizarDataGridView();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Produtos WHERE nome LIKE @nome";

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conexao))
            {
                conexao.Open();
                cmd.Parameters.AddWithValue("@nome", "%" + txtNome.Text + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridProdutos.DataSource = dt;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
            txtNome.Focus();
            AtualizarDataGridView(); // Atualiza o DataGrid sem filtros
        }

    }
}
