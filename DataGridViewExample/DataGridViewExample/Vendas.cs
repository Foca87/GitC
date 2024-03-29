﻿using DataGridViewExample.Adicao;
using DataGridViewExample.Edicao;
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
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vendasSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.QuerysInnerJoinDataSet1.VendasRow;

            switch (e.ColumnIndex)
            {
                case 0: { this.vendasTableAdapter.DeleteQuery(vendasSelect.Id); } break;
                case 1:
                    {
                        frmEdicaoVendas editarVendas = new frmEdicaoVendas();
                        editarVendas.VendasRow = vendasSelect;
                        editarVendas.ShowDialog();

                        this.vendasTableAdapter.Update(editarVendas.VendasRow);
                    }
                    break;
            }

            this.vendasTableAdapter.CustomQuery(querysInnerJoinDataSet1.Vendas);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAdicionarVendas venderCarro = new frmAdicionarVendas();
            venderCarro.ShowDialog();

            if (venderCarro.VendasRow?.Carro > 0 && venderCarro.VendasRow.Quantidade > 0 && venderCarro.VendasRow.Valor > 0)
            {
                this.vendasTableAdapter.Insert(venderCarro.VendasRow.Carro,
                                               venderCarro.VendasRow.Quantidade,
                                               venderCarro.VendasRow.Valor,
                                               true,
                                               1001,
                                               1001,
                                               DateTime.Now,
                                               DateTime.Now);
            }
        }
    }
}
