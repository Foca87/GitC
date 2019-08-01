using CadastroDeAlunos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeAlunos
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        public List<Alunos> alunos = new List<Alunos>();

        private void Button1_Click(object sender, EventArgs e)
        {
            CadastroAluno cadastroAluno = new CadastroAluno();
            cadastroAluno.ShowDialog();

            alunos.Add(cadastroAluno.novoAluno);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alunos;
        }
    }
}
