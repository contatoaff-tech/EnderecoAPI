using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TestarConexao();
        }

        private void TestarConexao()
        {
            using (MySqlConnection banco =
                new MySqlConnection(conexao.StringConexao))
            {
                banco.Open();

                MessageBox.Show("Conectado ao MySql");
            }
        }

        private async void btn_consultar_cep_Click(
            object sender, EventArgs e)
        {
            // Obtendo o CEP do campo que o usuário digitou
            string cep = txt_cep.Text;

            // Tirando o traço e o espaço
            cep = cep.Replace("-", "").Replace(" ", "");

            // Monta a URL de conexão com a API
            string url =
                $"https://viacep.com.br/ws/{cep}/json/";

            // Cria o cliente para fazer a requisição na API
            using (HttpClient cliente = new HttpClient())
            {
                // Faz a requisição na API
                string json = await cliente.GetStringAsync(url);

                // Converte o JSON recebido para a classe Endereco
                Endereco endereco =
                    JsonConvert.DeserializeObject<Endereco>(json);

                // Mostrar dados na tela
                txt_logradouro.Text = endereco.Logradouro;
                txt_bairro.Text = endereco.Bairro;
                txt_cidade.Text = endereco.Localidade;
                txt_estado.Text = endereco.Uf;
            }
        }

        private void buttonSalvar_Click(
            object sender, EventArgs e)
        {
            string sql = @"
                INSERT INTO enderecos
                (cep, logradouro, numero, cidade, bairro, estado)
                VALUES
                (@cep, @logradouro, @numero, @cidade, @bairro, @estado)";

            using (MySqlConnection banco = new MySqlConnection(conexao.StringConexao))
            {
                banco.Open();

                using (MySqlCommand comando = new MySqlCommand(sql, banco))
                {
                    comando.Parameters.AddWithValue("@cep",txt_cep.Text);
                    comando.Parameters.AddWithValue("@logradouro",txt_logradouro.Text);
                    comando.Parameters.AddWithValue("@numero",txt_numero.Text);
                    comando.Parameters.AddWithValue("@cidade",txt_cidade.Text);
                    comando.Parameters.AddWithValue("@bairro",txt_bairro.Text);
                    comando.Parameters.AddWithValue("@estado",txt_estado.Text);

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Endereço incluído com sucesso!"
            );
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            FormConsultas tela  = new FormConsultas();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                int id = tela.IdSelecionado;
            }
        }
    }
}