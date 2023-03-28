using PrimeiroProjetoemWPF.Paginas;
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
using MySql.Data.MySqlClient;

namespace PrimeiroProjetoemWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btCadastrarContato_Click(object sender, RoutedEventArgs e)
        {
            new CadastroDeContato().ShowDialog();
        }

        private void btApresentarContato_Click(object sender, RoutedEventArgs e)
        {
            new ApresentacaoInformacoes().ShowDialog();
        }
    }
}
