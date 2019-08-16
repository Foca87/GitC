using System;
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
    public partial class frmEditUsuario : Form
    {
        public frmEditUsuario()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow UsuarioRow;

        private void FrmEditUsuario_Load(object sender, EventArgs e)
        {
            tbxNome.Text = UsuarioRow.Nome ;
            tbxLogin.Text = UsuarioRow.Login;
            tbxSenha.Text = UsuarioRow.Senha;
            tbxEmail.Text = UsuarioRow.Email;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            UsuarioRow.Nome = tbxNome.Text;
            UsuarioRow.Login = tbxLogin.Text;
            UsuarioRow.Senha = tbxSenha.Text;
            UsuarioRow.Email = tbxEmail.Text;

            this.Close();
        }
    }
}
