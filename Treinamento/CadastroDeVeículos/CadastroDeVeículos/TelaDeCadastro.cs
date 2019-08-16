using CadastroDeVeículos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeVeículos
{
    public partial class TelaDeCadastro : Form
    {
        public TelaDeCadastro()
        {
            InitializeComponent();
        }

        public Carros novoCarro = new Carros();

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            novoCarro.Modelo = tbxModelo.Text;
            novoCarro.Ano = int.Parse(tbxAno.Text);

            this.Close();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
