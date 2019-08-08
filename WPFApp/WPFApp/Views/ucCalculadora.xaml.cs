using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFApp.Views
{
    /// <summary>
    /// Interaction logic for ucCalculadora.xaml
    /// </summary>
    public partial class ucCalculadora : UserControl
    {
        public ucCalculadora()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            decimal.TryParse(tbxValor1.Text, out decimal valor1);
            decimal.TryParse(tbxValor2.Text, out decimal valor2);

            decimal resultado = valor1 / valor2;

            tbxResultado.Text = resultado.ToString();
        }

        private void BtnMultiplicacao_Click(object sender, RoutedEventArgs e)
        {
            decimal.TryParse(tbxValor1.Text, out decimal valor1);
            decimal.TryParse(tbxValor2.Text, out decimal valor2);

            decimal resultado = valor1 * valor2;

            tbxResultado.Text = resultado.ToString();
        }

        private void BtnSubtracao_Click(object sender, RoutedEventArgs e)
        {
            decimal.TryParse(tbxValor1.Text, out decimal valor1);
            decimal.TryParse(tbxValor2.Text, out decimal valor2);

            decimal resultado = valor1 - valor2;

            tbxResultado.Text = resultado.ToString();
        }

        private void BtnSoma_Click(object sender, RoutedEventArgs e)
        {
            decimal.TryParse(tbxValor1.Text, out decimal valor1);
            decimal.TryParse(tbxValor2.Text, out decimal valor2);

            decimal resultado = valor1 + valor2;

            tbxResultado.Text = resultado.ToString();
        }
    }
}
