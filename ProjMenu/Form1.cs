﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exibirAjudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjuda tela = new frmAjuda();
            tela.Show();

            this.Hide(); //esconder a tela do user
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsLoginHosp formLogin = new FormsLoginHosp();
            formLogin.Show();

           this.Hide();
        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormEntrar formEntrar = new FormEntrar();
            formEntrar.Show();

           this.Hide();
        }
    }
}
