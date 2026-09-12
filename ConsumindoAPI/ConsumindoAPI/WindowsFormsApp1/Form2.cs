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

namespace WindowsFormsApp1
{
    public partial class FormConsultas : Form
    {
        public int IdSelecionado { get; private set; }

        public FormConsultas()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CarregarEnderecos();
        }

        private void CarregarEnderecos(string pesquisa = "")
        {
            string sql = @"SELECT
                            id,
                            cep,
                            logradouro,
                            numero,
                            cidade,
                            bairro,
                            estado
                        FROM enderecos";

            if (pesquisa != "")
            {
                sql += " WHERE logradouro Like @pesquisa";
            }

            using (MySqlConnection banco = new MySqlConnection(conexao.StringConexao))
            {
                banco.Open();

                using (MySqlCommand comando = new MySqlCommand(sql, banco))
                {

                    if (pesquisa != "")
                    {
                        comando.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");
                    }

                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                    {

                        DataTable tabela = new DataTable(); //tabela em memoria

                        adaptador.Fill(tabela);

                        dataGridViewEnderecos.DataSource = tabela;
                    }

                }
            }
        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CarregarEnderecos(txt_pesquisa.Text);

        }

        private void dataGridViewEnderecos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            IdSelecionado = Convert.ToInt32(
                dataGridViewEnderecos.Rows[e.RowIndex].Cells["id"].Value
            );

            this.DialogResult = DialogResult.OK;

            this.Close();
             
        }
    }
}
