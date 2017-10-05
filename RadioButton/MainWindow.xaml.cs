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

namespace RadioButton1
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


        private void Mudar(object sender, RoutedEventArgs e)
        {
            txtTexto.FontSize = double.Parse((sender as RadioButton).Content.ToString());
        }
    }
}
