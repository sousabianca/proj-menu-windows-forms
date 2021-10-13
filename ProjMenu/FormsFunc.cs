using ProjMenu.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjMenu
{
    public partial class FormsFunc : Form
    {
        public FormsFunc()
        {
            InitializeComponent();
        }

        private void FormsLoginHosp_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormsLoginHosp_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            Controle controle = new Controle();
            String mensagem =  controle.cadastrar(txbNome.Text, txbCPF.Text, txbCell.Text, txbEmail.Text, txbSenha.Text, txbConfSenha.Text);
            if (controle.tem)
            {
               
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
            
        }
    }
}
