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
    public partial class FormEntrar : Form
    {
        public FormEntrar()
        {
            InitializeComponent();
        }

        private void FormEntrar_Load(object sender, EventArgs e)
        {
            
        }

        private void FormEntrar_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnEntrar_Click(object sender, EventArgs e)

        {
            FormBemVindo formBemVindo = new FormBemVindo();
            formBemVindo.Show();
            this.Hide();

            Controle controle = new Controle();
            controle.acessar(mtxLogin.Text, mtxSenha.Text);

            if (controle.mensagem.Equals(""))
            {

                if (controle.tem) //se para se for encontrado os logins exatamente igual 
                {
                    MessageBox.Show("Logado com sucesso!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                   
                }
                else
                {
                    MessageBox.Show("Login ou Senha incorreta, tente novamente!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
