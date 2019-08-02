using DataGridViewExample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Adicao
{
    public partial class frmAdicionarCarros : Form
    {
        public frmAdicionarCarros()
        {
            InitializeComponent();
        }

        public Carro CarrosRow;

        private void FrmAdicionarCarros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Marcas);

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {            
            CarrosRow = new Carro
            {
                Modelo = tbxModelo.Text,
                Ano = dtpAno.Value,
                Marca = cbxMarca.SelectedValue != null? (int)cbxMarca.SelectedValue : 0
            };

            this.Close();
        }
    }
}
