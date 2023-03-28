using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Primeiro_Projeto_PDS.Formularios;
using MySql.Data.MySqlClient;
using Google.Protobuf.WellKnownTypes;
using System.Runtime.CompilerServices;

namespace Primeiro_Projeto_PDS.Formularios
{
    public partial class CadastroDeContato : Form
    {
        private MySqlConnection _conexao;

        public CadastroDeContato()
        {
            InitializeComponent();

            Conexao();
            
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            edNome.Enabled = false;
            edSexo.Enabled = false;
            edNascimento.Enabled = false;
            edEmail.Enabled = false;
            edTelefone.Enabled = false;
        }

        //this is used to connect the code to the database; you can change these datas based on your personal ones
        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;" +
                "user=root;password=root;port=3360";
            _conexao = new MySqlConnection(conexaoString);
            _conexao.Open();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            edNome.Enabled = true;
            edSexo.Enabled = true;
            edNascimento.Enabled = true;
            edEmail.Enabled = true;
            edTelefone.Enabled = true;
            btAdicionar.Enabled = false;
            btCancelar.Enabled = true;
            btSalvar.Enabled = true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //limpar campos
            edNome.Clear();
            edSexo.Clear();
            edNascimento.Clear();
            edEmail.Clear();
            edTelefone.Clear();
            btAdicionar.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            edNome.Enabled = false;
            edSexo.Enabled = false;
            edNascimento.Enabled = false;
            edEmail.Enabled = false;
            edTelefone.Enabled = false;
        }

        private void btSalvar_Click(object sender, EventArgs e)
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
                    var comando = new MySqlCommand(sql, _conexao);


                    comando.Parameters.AddWithValue("@_nome", nome);
                    comando.Parameters.AddWithValue("@_data_nasc", data_nasc);
                    comando.Parameters.AddWithValue("@_sexo", sexo);
                    comando.Parameters.AddWithValue("@_email", email);
                    comando.Parameters.AddWithValue("@_telefone", telefone);
                    comando.ExecuteNonQuery();

                    edNome.Clear();
                    edSexo.Clear();
                    edNascimento.Clear();
                    edEmail.Clear();
                    edTelefone.Clear();
                    btAdicionar.Enabled = true;
                    btCancelar.Enabled = false;
                    btSalvar.Enabled = false;
                    edNome.Enabled = false;
                    edSexo.Enabled = false;
                    edNascimento.Enabled = false;
                    edEmail.Enabled = false;
                    edTelefone.Enabled = false;

                    MessageBox.Show("Informações salvas com sucesso!");

                    _conexao.Close();

                    CadastroDeContato form = this;
                    form.Close();
                }
            }
            catch
            { MessageBox.Show("Algum erro ocorreu ao tentar salvar as informações. Entre em contato com o administrador do programa!"); }
        }
    }
}
