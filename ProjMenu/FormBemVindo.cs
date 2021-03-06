using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjMenu
{
    public partial class FormBemVindo : Form
    {
        public FormBemVindo()
        {
            InitializeComponent();
        }

        private void FormBemVindo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formOpen in Application.OpenForms)
                {
                    if (formOpen is Form1)
                    {
                        formOpen.Show();
                        break;
                    }
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string strconexao = "Data Source=MOONBI\\SQLEXPRESS;Initial Catalog=BDLogin;Integrated Security=True";
            string query = "INSERT INTO quarto ([nome],[numero],[descricaoQuarto],[preco]) VALUES ('" + txbNome.Text + "','" + txbNum.Text + "','" + txbDesc.Text + "', '" + txbP.Text + "')";

            SqlConnection conexao = new SqlConnection(strconexao);
            SqlCommand comando = new SqlCommand(query, conexao);

            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string strconexao = "Data Source=MOONBI\\SQLEXPRESS;Initial Catalog=BDLogin;Integrated Security=True";
            string query = "UPDATE quarto SET nome = '" + txbNome.Text + "', numero ='" + txbNum.Text + "', descricaoQuarto = '" + txbDesc.Text + "', preco = '" + txbPreco.Text + "' WHERE idQUarto = " + txbID.Text;

            SqlConnection conexao = new SqlConnection(strconexao);
            SqlCommand comando = new SqlCommand(query, conexao);

            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string strconexao = "Data Source=MOONBI\\SQLEXPRESS;Initial Catalog=BDLogin;Integrated Security=True";
            string query = "SELECT [idQuarto],[nome],[numero],[descricaoQuarto],[preco] FROM quarto";

            SqlConnection conexao = new SqlConnection(strconexao);
            SqlDataAdapter da = new SqlDataAdapter(query, conexao);

            DataTable tb = new DataTable();

            da.Fill(tb); //adiciona tudo que tem no da para uma tabela na memória

            dgvSelect.DataSource = tb;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string strconexao = "Data Source=MOONBI\\SQLEXPRESS;Initial Catalog=BDLogin;Integrated Security=True";
            string query = "DELETE FROM quarto WHERE idQuarto = " + txbDelete.Text;

            SqlConnection conexao = new SqlConnection(strconexao);
            SqlCommand comando = new SqlCommand(query, conexao);

            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        private void FormBemVindo_Load(object sender, EventArgs e)
        {

        }
    }
}
