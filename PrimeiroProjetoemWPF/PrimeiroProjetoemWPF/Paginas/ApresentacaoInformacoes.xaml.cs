using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using PrimeiroProjetoemWPF.RegrasDeNegocio;

namespace PrimeiroProjetoemWPF.Paginas
{
    /// <summary>
    /// Lógica interna para ApresentacaoInformacoes.xaml
    /// </summary>
    public partial class ApresentacaoInformacoes : Window
    {
        private MySqlConnection conexao;

        public ApresentacaoInformacoes()
        {
            InitializeComponent();
            Conexao();
            CarregarDados();
        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;" +
                "user=root;password=root;port=3360";
            conexao = new MySqlConnection(conexaoString);
            conexao.Open();
        }

        public void CarregarDados()
        {
            string sql = "SELECT * FROM contato";
            var comando = new MySqlCommand(sql, conexao);
            var reader = comando.ExecuteReader();
            var Lista = new List<Object>();
            while (reader.Read())
            {

                Contato contato = new Contato();
                contato.Id = reader.GetString(0);
                contato.Nome = reader.GetString(1);
                contato.Nascimento = reader.GetDateTime(2);
                contato.Sexo = reader.GetString(3);
                contato.Email = reader.GetString(4);
                contato.Telefone = reader.GetString(5);
                Lista.Add(contato);
            }
            dgvApresentarContatos.ItemsSource = Lista;
        }
    }
}
