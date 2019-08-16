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
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }

        public Alunos novoAluno = new Alunos();

        private void ButtonRegistrarAluno_Click(object sender, EventArgs e)
        {
            novoAluno.Nome = textBoxNome.Text;
            novoAluno.Idade = (int)numericUpDownIdade.Value;

            this.Close();
        }
    }
}
