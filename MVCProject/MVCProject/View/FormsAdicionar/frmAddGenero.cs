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

namespace MVCProject.View.FormsAdicionar
{
    public partial class frmAddGenero : Form
    {
        public frmAddGenero()
        {
            InitializeComponent();
        }

        public Genero novoGenero;

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            novoGenero = new Genero
            {
                Tipo = tbxTipo.Text,
                Descricao = tbxDescricao.Text
            };

            this.Close();
        }
    }
}
