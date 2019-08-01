using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Lixeira : Form
    {
        public Lixeira()
        {
            InitializeComponent();
        }

        private void Lixeira_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Lixeira' table. You can move, or remove it, as needed.
            this.lixeiraTableAdapter.GetAllData(this.querysInnerJoinDataSet1.Lixeira);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var lixeiraGlobal = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
               as DataGridViewExample.QuerysInnerJoinDataSet1.LixeiraRow;

            switch (lixeiraGlobal.Tabela)
            {
                case "carros": { this.carrosTableAdapter1.RecoverQuery(lixeiraGlobal.Id); } break;
                case "marcas": { this.marcasTableAdapter1.RecoverQuery(lixeiraGlobal.Id); } break;
                case "vendas": { this.vendasTableAdapter1.RecoverQuery(lixeiraGlobal.Id); } break;
                case "usuarios": { this.usuariosTableAdapter1.RecoverQuery(lixeiraGlobal.Id); } break;
            }
            this.lixeiraTableAdapter.GetAllData(this.querysInnerJoinDataSet1.Lixeira);
        }
    }
}
