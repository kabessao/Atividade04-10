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

namespace ListBoxExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region construtor
        public MainWindow()
        {
            InitializeComponent();
        }



        #endregion

        #region Excluir
        private void Excluir(object sender, RoutedEventArgs e)
        {
            // exclui um item

            lstLista.Items.Remove(lstLista.SelectedItem);

        }
        #endregion


        #region Mostrar
        private void Mostrar(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("", "");
        }
        #endregion


        #region Adicionar
        private void Adicionar(object sender, RoutedEventArgs e)
        {
            //adiciona um item

            if (!string.IsNullOrWhiteSpace(txtTexto.Text))
            lstLista.Items.Add(txtTexto.Text);
            txtTexto.Clear();
            txtTexto.Focus();

        }
        #endregion


    }
}
