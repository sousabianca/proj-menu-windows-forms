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
    public partial class FormsLoginHosp : Form
    {
        public FormsLoginHosp()
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
            FormCad formCad = new FormCad();
            formCad.Show();
            this.Hide();
        }
    }
}
