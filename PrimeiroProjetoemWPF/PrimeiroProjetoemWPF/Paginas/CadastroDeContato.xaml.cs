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
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace PrimeiroProjetoemWPF.Paginas
{
    /// <summary>
    /// Lógica interna para CadastroDeContato.xaml
    /// </summary>
    public partial class CadastroDeContato : Window
    {
        private MySqlConnection conexao;

        public CadastroDeContato()
        {
            InitializeComponent();

            Conexao();
        }

        //this is used to connect the code to the database; you can change these datas based on your personal ones
        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;" +
                "user=root;password=root;port=3360";
            conexao = new MySqlConnection(conexaoString);
            conexao.Open();
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (edNome.Text == "" | edSexo.Text == "" | edNascimento.Text == "" | edEmail.Text == "" | edTelefone.Text == "")
                {
                    MessageBox.Show("Ao menos um dos campos está vazio. Preencha todos eles antes de salvar as informações.");
                }
                else
                {
                    var nome = edNome.Text;
                    var data_nasc = edNascimento.Text;
                    var sexo = edSexo.Text;
                    var email = edEmail.Text;
                    var telefone = edTelefone.Text;
                    var sql = "insert into contato (con_nome, con_data_nasc, con_sexo, con_email, con_telefone) values (@_nome, @_data_nasc, @_sexo, @_email, @_telefone)";
                    var comando = new MySqlCommand(sql, conexao);


                    comando.Parameters.AddWithValue("@_nome", nome);
                    comando.Parameters.AddWithValue("@_data_nasc", data_nasc);
                    comando.Parameters.AddWithValue("@_sexo", sexo);
                    comando.Parameters.AddWithValue("@_email", email);
                    comando.Parameters.AddWithValue("@_telefone", telefone);
                    comando.ExecuteNonQuery();

                    //edNome.Clear();
                    //edSexo.Clear();
                    //edNascimento.Clear();
                    //edEmail.Clear();
                    //edTelefone.Clear();
                  
                    MessageBox.Show("Informações salvas com sucesso!");

                    conexao.Close();

                    CadastroDeContato form = this;
                    form.Close();
                }
            }
            catch
            { MessageBox.Show("Algum erro ocorreu ao tentar salvar as informações. Entre em contato com o administrador do programa!"); }
        }
    }
}
