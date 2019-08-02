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
    public partial class frmAdicionarVendas : Form
    {
        public frmAdicionarVendas()
        {
            InitializeComponent();
        }

        public Venda VendasRow;

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (cbxModelo.SelectedValue != null && nudQuantidade.Value > 0 && !string.IsNullOrEmpty(tbxValor.Text))
            {
                decimal.TryParse(tbxValor.Text, out decimal tempValor);

                VendasRow = new Venda
                {
                    Carro = (int)cbxModelo.SelectedValue,
                    Quantidade = (int)nudQuantidade.Value,
                    Valor = tempValor
                };
            }
            this.Close();
        }

        private void FrmAdicionarVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet1.Carros);

        }
    }
}
