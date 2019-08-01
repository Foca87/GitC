﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Edicao
{
    public partial class frmEdicaoUsuarios : Form
    {
        public frmEdicaoUsuarios()
        {
            InitializeComponent();
        }

        public DataGridViewExample.QuerysInnerJoinDataSet1.UsuariosRow UsuariosRow;

        private void FrmEdicaoUsuarios_Load(object sender, EventArgs e)
        {
            tbxNome.Text = UsuariosRow.Usuario;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            UsuariosRow.Usuario = tbxNome.Text;

            this.Close();
        }
    }
}
