using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.FormsAdicionar
{
    public partial class frmAddLivro : Form
    {
        public frmAddLivro()
        {
            InitializeComponent();
        }

        public Livro novoLivro;

        private void FrmAddLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);

            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            int.TryParse(tbxRegistro.Text, out int tempRegistro);

            novoLivro = new Livro
            {
                Registro = tempRegistro,
                Titulo = tbxTitulo.Text,
                Isbn = tbxISBN.Text,
                Genero = cbxGenero.SelectedValue != null? (int)cbxGenero.SelectedValue : 0,
                Editora = cbxEditora.SelectedValue != null? (int)cbxEditora.SelectedValue : 0,
                Sinopse = tbxSinopse.Text,
                Observacoes = tbxObservacoes.Text
            };

            this.Close();
        }
    }
}
