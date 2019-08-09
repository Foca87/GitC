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
using WpfAppEntity.Data;

namespace WpfAppEntity.Views
{
    /// <summary>
    /// Interaction logic for ucGridView.xaml
    /// </summary>
    public partial class ucGridView : UserControl
    {
        public ucGridView()
        {
            InitializeComponent();
        }

        public BibliotecaDBContex context = new BibliotecaDBContex();

        private void DtGridView_Loaded(object sender, RoutedEventArgs e)
        {
            dtGridView.ItemsSource = context.Usuarios.ToList<Usuario>();
        }

        private void DtGridView_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            //Como deletar uma linha no Banco de dados.
            /*var objectToRemove = ((DataGrid)sender).SelectedValue as Usuario;
            context.Usuarios.Remove(objectToRemove);*/

            var objectToEdit = ((DataGrid)sender).SelectedValue as Usuario;
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();

            MessageBox.Show("Tabela atualizada com sucesso!");
        }

        private void DtGridView_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            var objectToEdit = ((DataGrid)sender).SelectedValue as Usuario;

            frmEditUser edit = new frmEditUser();
            edit.user = objectToEdit;

            edit.ShowDialog();

            ((DataGrid)sender).SelectedValue = edit.user;
        }
    }
}
