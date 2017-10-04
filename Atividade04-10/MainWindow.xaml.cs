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

namespace Atividade04_10
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

        private void Exibir(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Data selecionada é :\n"
                + "Dia: " + dtpData.SelectedDate.Value.Day.ToString()
                + "\nMes: " + dtpData.SelectedDate.Value.Month.ToString()
                + "\nAno: " + dtpData.SelectedDate.Value.Year.ToString(),
                "Resultado");
            
        }
    }
}
