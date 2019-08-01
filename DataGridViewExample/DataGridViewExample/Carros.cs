using DataGridViewExample.Adicao;
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
    public partial class Carros : Form
    {
        public Carros()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Carros);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Marcas frmMarcas = new Marcas();
            frmMarcas.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Vendas frmVendas = new Vendas();
            frmVendas.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Usuarios frmUsuarios = new Usuarios();
            frmUsuarios.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carrosSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.QuerysInnerJoinDataSet1.CarrosRow;

            switch (e.ColumnIndex)
            {
                case 0: { this.carrosTableAdapter.DeleteQuery(carrosSelect.Id); } break;    // Coluna DELETAR
                case 1:                                                                     // Coluna EDITAR
                    {
                        frmEdicaoCarros editarCarros = new frmEdicaoCarros();
                        editarCarros.CarrosRow = carrosSelect;                  // Atribui o resultado da pesquisa feita anteriormente ao objeto 'CarrosRow'.
                        editarCarros.ShowDialog();

                        this.carrosTableAdapter.Update(editarCarros.CarrosRow); //Faz a mesma coisa que o código comentado abaixo sem precisar 
                                                                                // de query no sql, mas é mais "custoso" para o Banco de Dados.

                        /*this.carrosTableAdapter.UpdateQuery(
                            editarCarros.CarrosRow.Modelo, 
                            editarCarros.CarrosRow.Ano.ToString(), 
                            editarCarros.CarrosRow.Marca,
                            editarCarros.CarrosRow.UsuAlt,
                            DateTime.Now,
                            editarCarros.CarrosRow.Id); */
                    }
                    break;
            }
            this.carrosTableAdapter.CustomQuery(querysInnerJoinDataSet1.Carros);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Lixeira lixo = new Lixeira();
            lixo.ShowDialog();

            this.carrosTableAdapter.CustomQuery(querysInnerJoinDataSet1.Carros);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarCarros adicionarCarro = new frmAdicionarCarros();
            adicionarCarro.ShowDialog();

            this.carrosTableAdapter.Insert(
                adicionarCarro.CarrosRow.Modelo,
                adicionarCarro.CarrosRow.Ano,
                adicionarCarro.CarrosRow.Marca,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now); // Atualiza a tabela

            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Carros);
        }
    }
}
