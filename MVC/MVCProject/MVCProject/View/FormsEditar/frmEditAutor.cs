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
    public partial class frmEditAutor : Form
    {
        public frmEditAutor()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.AutoresRow AutorRow;

        private void FrmEditAutor_Load(object sender, EventArgs e)
        {
            tbxNome.Text = AutorRow.Nome;
            tbxDescricao.Text = AutorRow.Descricao;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            AutorRow.Nome = tbxNome.Text;
            AutorRow.Descricao = tbxDescricao.Text;

            this.Close();
        }
    }
}
