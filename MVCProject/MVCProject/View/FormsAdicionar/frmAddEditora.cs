﻿using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.FormsAdicionar
{
    public partial class frmAddEditora : Form
    {
        public frmAddEditora()
        {
            InitializeComponent();
        }

        public Editora novaEditora;

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {

            novaEditora = new Editora
            {
                Nome = tbxNome.Text,
                Descricao = tbxDescricao.Text
            };

            this.Close();
        }
    }
}
