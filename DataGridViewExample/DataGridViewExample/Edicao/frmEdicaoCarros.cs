using System;
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
    public partial class frmEdicaoCarros : Form
    {
        public frmEdicaoCarros()
        {
            InitializeComponent();
        }

        public DataGridViewExample.QuerysInnerJoinDataSet1.CarrosRow CarrosRow;

        private void FrmEdicaoCarros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Marcas);

            tbxModelo.Text = CarrosRow.Modelo;
            dtpAno.Value = CarrosRow.Ano;
            cbxMarca.SelectedValue = CarrosRow.Marca;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CarrosRow.Modelo = tbxModelo.Text;
            CarrosRow.Ano = dtpAno.Value;
            CarrosRow.Marca = (int)cbxMarca.SelectedValue;

            this.Close();
        }
    }
}
