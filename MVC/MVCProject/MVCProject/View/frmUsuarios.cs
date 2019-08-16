using MVCProject.View.FormsAdicionar;
using MVCProject.View.FormsEditar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.QueryShowAtivos(this.sistemaBibliotecaDBDataSet.Usuarios);
        }

        private void DgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectUsuarios = ((System.Data.DataRowView)this.dgvUsuarios.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0: { this.usuariosTableAdapter.DeleteQuery(selectUsuarios.Id); } break;
                case 1:
                    {
                        frmEditUsuario editUsuario = new frmEditUsuario();
                        editUsuario.UsuarioRow = selectUsuarios;
                        editUsuario.ShowDialog();

                        this.usuariosTableAdapter.Update(editUsuario.UsuarioRow);
                    } break;
            }

            this.usuariosTableAdapter.QueryShowAtivos(sistemaBibliotecaDBDataSet.Usuarios);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddUsuario addUsuario = new frmAddUsuario();
            addUsuario.ShowDialog();

            if (!(string.IsNullOrEmpty(addUsuario.novoUsuario?.Nome) && string.IsNullOrEmpty(addUsuario.novoUsuario.Login)
                && string.IsNullOrEmpty(addUsuario.novoUsuario.Senha) && string.IsNullOrEmpty(addUsuario.novoUsuario.Email)))
            {
                this.usuariosTableAdapter.Insert(addUsuario.novoUsuario.Nome,
                                                 addUsuario.novoUsuario.Login,
                                                 addUsuario.novoUsuario.Senha,
                                                 addUsuario.novoUsuario.Email,
                                                 true,
                                                 1,
                                                 1,
                                                 DateTime.Now,
                                                 DateTime.Now);
            }
            this.usuariosTableAdapter.QueryShowAtivos(sistemaBibliotecaDBDataSet.Usuarios);
        }
    }
}
