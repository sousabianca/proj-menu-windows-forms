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

            string strconexao = "Data Source=MOONBI\SQLEXPRESS;Initial Catalog=BDLogin;Integrated Security=True";
            string query = "INSERT INTO TB_User ([nome],[numero],[descricao]) VALUES ('" + txbNome.Text + "','"+txbNum.Text+"','"+txbDesc.Text+"')";

            SqlConnection conexao = new SqlConnection(strconexao);
            SqlCommand comando = new SqlCommand(query, conexao);

            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
