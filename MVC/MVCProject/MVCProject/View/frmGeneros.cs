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
    public partial class frmGeneros : Form
    {
        public frmGeneros()
        {
            InitializeComponent();
        }

        private void FrmGeneros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
        }

        private void DgvGeneros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectGenero = ((System.Data.DataRowView)this.dgvGeneros.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.GenerosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmEditGenero editGenero = new frmEditGenero();
                        editGenero.GeneroRow = selectGenero;
                        editGenero.ShowDialog();

                        this.generosTableAdapter.Update(editGenero.GeneroRow);
                    } break;
            }

            this.generosTableAdapter.Fill(sistemaBibliotecaDBDataSet.Generos);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddGenero addGenero = new frmAddGenero();
            addGenero.ShowDialog();

            if (!string.IsNullOrEmpty(addGenero.novoGenero?.Tipo))
                this.generosTableAdapter.Insert(addGenero.novoGenero.Tipo,
                                                addGenero.novoGenero.Descricao);

            this.generosTableAdapter.Fill(sistemaBibliotecaDBDataSet.Generos);
        }
    }
}
