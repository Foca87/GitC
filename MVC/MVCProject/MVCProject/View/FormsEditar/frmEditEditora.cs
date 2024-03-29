﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.FormsEditar
{
    public partial class frmEditEditora : Form
    {
        public frmEditEditora()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.EditorasRow EditoraRow;

        private void FrmEditEditora_Load(object sender, EventArgs e)
        {
            tbxNome.Text = EditoraRow.Nome;
            tbxDescricao.Text = EditoraRow.Descricao;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            EditoraRow.Nome = tbxNome.Text;
            EditoraRow.Descricao = tbxDescricao.Text;

            this.Close();
        }
    }
}
