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
    }
}
