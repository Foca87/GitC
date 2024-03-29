﻿using DataGridViewExample.Adicao;
using DataGridViewExample.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Usuarios);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuariosSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.QuerysInnerJoinDataSet1.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0: { this.usuariosTableAdapter.DeleteQuery(usuariosSelect.Id); } break;
                case 1:
                    {
                        frmEdicaoUsuarios editarUsuario = new frmEdicaoUsuarios();
                        editarUsuario.UsuariosRow = usuariosSelect;
                        editarUsuario.ShowDialog();

                        this.usuariosTableAdapter.Update(editarUsuario.UsuariosRow);
                    }
                    break;
            }

            this.usuariosTableAdapter.CustomQuery(querysInnerJoinDataSet1.Usuarios);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuarios adicionarUsuario = new frmAdicionarUsuarios();
            adicionarUsuario.ShowDialog();

            if (!string.IsNullOrEmpty(adicionarUsuario.UsuariosRow?.Nome))
            {
                this.usuariosTableAdapter.Insert(adicionarUsuario.UsuariosRow.Nome,
                                                 true,
                                                 1001,
                                                 1001,
                                                 DateTime.Now,
                                                 DateTime.Now);
            }

            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Usuarios);
        }
    }
}
