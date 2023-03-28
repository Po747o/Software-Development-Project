using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Primeiro_Projeto_PDS.Formularios
{
    public partial class ApresentacaoInformacoes : Form
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
            Conexao();

            string sql = "SELECT * FROM contato";
            var comando = new MySqlCommand(sql, conexao);
            var adaptador = new MySqlDataAdapter(comando);

            DataTable tabela = new DataTable();

            adaptador.Fill(tabela);

            tabela.Columns["con_id"].ColumnName = "ID";
            dgvContatos.DataSource = tabela;
        }
    }
}
