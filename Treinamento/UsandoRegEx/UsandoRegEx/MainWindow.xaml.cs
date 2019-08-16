using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace UsandoRegEx
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            var nomeRegex = "^[A-Z][a-z]*(\\s[A-Z][a-z]*)+$";
            
            var telefoneRegex = @"^\++[1-9]{1,2}\ (\([1-9]{2}\))\s([9]{1})?([0-9]{4})-([0-9]{4})$";

            var emailRegex = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            bool campoNome = Regex.IsMatch(tbxNome.Text, nomeRegex, RegexOptions.None);
            bool campoTelefone = Regex.IsMatch(tbxTelefone.Text, telefoneRegex, RegexOptions.None);
            bool campoEmail = Regex.IsMatch(tbxEmail.Text, emailRegex, RegexOptions.IgnoreCase);


            if (campoNome && campoTelefone && campoEmail)
                MessageBox.Show("Cadastro salvo com sucesso!");

            if (!campoNome)
                MessageBox.Show("O nome informado não é válido!");

            if (!campoTelefone)
                MessageBox.Show("O telefone informado não é válido!");

            if (!campoEmail)
                MessageBox.Show("O e-mail informado não é válido!");
        }
    }
}
