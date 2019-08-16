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
    public partial class frmEditoras : Form
    {
        public frmEditoras()
        {
            InitializeComponent();
        }

        private void FrmEditoras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
        }

        private void DgvEditoras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectEditoras = ((System.Data.DataRowView)this.dgvEditoras.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.EditorasRow ;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmEditEditora editEditora = new frmEditEditora();
                        editEditora.EditoraRow = selectEditoras;
                        editEditora.ShowDialog();

                        this.editorasTableAdapter.Update(editEditora.EditoraRow);
                    }
                    break;
            }

            this.editorasTableAdapter.Fill(sistemaBibliotecaDBDataSet.Editoras);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddEditora addEditora = new frmAddEditora();
            addEditora.ShowDialog();

            if (!string.IsNullOrEmpty(addEditora.novaEditora?.Nome))
                this.editorasTableAdapter.Insert(addEditora.novaEditora.Nome,
                                                addEditora.novaEditora.Descricao);

            this.editorasTableAdapter.Fill(sistemaBibliotecaDBDataSet.Editoras);
        }
    }
}
