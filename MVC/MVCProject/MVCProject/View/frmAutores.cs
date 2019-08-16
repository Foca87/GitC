using MVCProject.View.FormsAdicionar;
using MVCProject.View.FormsEditar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
        }

        private void FrmAutores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
        }

        private void DgvAutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectAutores = ((System.Data.DataRowView)this.dgvAutores.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.AutoresRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmEditAutor editAutor = new frmEditAutor();
                        editAutor.AutorRow = selectAutores;
                        editAutor.ShowDialog();

                        this.autoresTableAdapter.Update(editAutor.AutorRow);
                    }
                    break;
            }

            this.autoresTableAdapter.Fill(sistemaBibliotecaDBDataSet.Autores);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddAutor addAutor = new frmAddAutor();
            addAutor.ShowDialog();

            if (!string.IsNullOrEmpty(addAutor.novoAutor?.Nome))
                this.autoresTableAdapter.Insert(addAutor.novoAutor.Nome,
                                                addAutor.novoAutor.Descricao);

            this.autoresTableAdapter.Fill(sistemaBibliotecaDBDataSet.Autores);
        }
    }
}
