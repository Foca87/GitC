using MVCProject.Model;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            if (Session.user == null)
                throw new Exception("Erro crítico do sistema!");
        }

        private void UsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios telaUsuarios = new frmUsuarios();
            telaUsuarios.ShowDialog();
        }

        private void AutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutores telaAutores = new frmAutores();
            telaAutores.ShowDialog();
        }
    }
}
