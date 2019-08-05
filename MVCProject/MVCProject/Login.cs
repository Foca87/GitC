using MVCProject.Model;
using MVCProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var login = this.usuariosTableAdapter1.QueryLogin(tbxLogin.Text, tbxSenha.Text);

            if (login != null)
            {
                Session.user = new Usuario();
                Session.user.Id = (int)login;

                frmPrincipal telaPrincipal = new frmPrincipal();
                this.Hide();

                telaPrincipal.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Login Inválido!");
        }
    }
}
