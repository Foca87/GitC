using CadastroDeVeículos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeVeículos
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        List<Carros> carros = new List<Carros>();

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            TelaDeCadastro formularioCadastro = new TelaDeCadastro();
            formularioCadastro.ShowDialog();

            carros.Add(formularioCadastro.novoCarro);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = carros;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                var collEdit = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var datCollSelect = collEdit.OwningColumn.DataPropertyName;

                switch (datCollSelect)
                {
                    case "DatInc":
                        {
                            if(DateTime.Parse(collEdit.Value.ToString()) <= DateTime.Now)
                            {
                                this.carrosBindingSource.EndEdit();
                                this.carrosTableAdapter.Update(this.querysInnerJoinDataSet.Carros);
                            }
                        } break;
                }
            }
        }
    }
}
