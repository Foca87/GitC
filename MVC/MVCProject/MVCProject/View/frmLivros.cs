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
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        private void FrmLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.QueryShowAtivos(this.sistemaBibliotecaDBDataSet.Livros);
        }

        private void DgvLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var selectLivros = ((System.Data.DataRowView)this.dgvLivros.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.LivrosRow;

            switch (e.ColumnIndex)
            {
                case 0: { this.livrosTableAdapter.DeleteQuery(selectLivros.Id); } break;
                case 1:
                    {
                        frmEditLivro editLivro = new frmEditLivro();
                        editLivro.LivroRow = selectLivros;
                        editLivro.ShowDialog();

                        this.livrosTableAdapter.Update(editLivro.LivroRow);
                    } break;
            }

            this.livrosTableAdapter.QueryShowAtivos(sistemaBibliotecaDBDataSet.Livros);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddLivro addLivro = new frmAddLivro();
            addLivro.ShowDialog();

            if (!(addLivro.novoLivro?.Registro < 1 && string.IsNullOrEmpty(addLivro.novoLivro.Titulo) && string.IsNullOrEmpty(addLivro.novoLivro.Isbn)))
            {
                this.livrosTableAdapter.Insert(addLivro.novoLivro.Registro,
                                               addLivro.novoLivro.Titulo,
                                               addLivro.novoLivro.Isbn,
                                               addLivro.novoLivro.Genero,
                                               addLivro.novoLivro.Editora,
                                               addLivro.novoLivro.Sinopse,
                                               addLivro.novoLivro.Observacoes,
                                               true,
                                               1,
                                               1,
                                               DateTime.Now,
                                               DateTime.Now);
            }

            this.livrosTableAdapter.QueryShowAtivos(sistemaBibliotecaDBDataSet.Livros);
        }
    }
}
