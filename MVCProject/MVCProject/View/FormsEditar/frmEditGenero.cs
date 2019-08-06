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
    public partial class frmEditGenero : Form
    {
        public frmEditGenero()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.GenerosRow GeneroRow;

        private void FrmEditGenero_Load(object sender, EventArgs e)
        {
            tbxTipo.Text = GeneroRow.Tipo;
            tbxDescricao.Text = GeneroRow.Descricao;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            GeneroRow.Tipo = tbxTipo.Text;
            GeneroRow.Descricao = tbxDescricao.Text;

            this.Close();
        }
    }
}
