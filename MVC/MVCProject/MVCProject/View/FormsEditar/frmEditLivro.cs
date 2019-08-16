using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.FormsEditar
{
    public partial class frmEditLivro : Form
    {
        public frmEditLivro()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.LivrosRow LivroRow;

        private void FrmEditLivro_Load(object sender, EventArgs e)
        {
            tbxRegistro.Text = LivroRow.Registro.ToString();
            tbxTitulo.Text = LivroRow.Titulo;
            tbxISBN.Text = LivroRow.Isbn;
            cbxGenero.SelectedItem = LivroRow.Genero;
            cbxEditora.SelectedItem = LivroRow.Editora;
            tbxSinopse.Text = LivroRow.Sinopse;
            tbxObservacoes.Text = LivroRow.Observacoes;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            int.TryParse(tbxRegistro.Text, out int tempRegistro);

            LivroRow.Registro = tempRegistro;
            LivroRow.Titulo = tbxTitulo.Text;
            LivroRow.Isbn = tbxISBN.Text;
            LivroRow.Genero = cbxGenero.SelectedValue != null ? (int)cbxGenero.SelectedValue : 0;
            LivroRow.Editora = cbxEditora.SelectedValue != null ? (int)cbxEditora.SelectedValue : 0;
            LivroRow.Sinopse = tbxSinopse.Text;
            LivroRow.Observacoes = tbxObservacoes.Text;

            this.Close();
        }
    }
}
