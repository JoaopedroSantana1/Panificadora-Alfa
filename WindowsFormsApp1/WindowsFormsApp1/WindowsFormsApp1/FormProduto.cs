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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void nomebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            Conexão con = new Conexão();
            MySqlConnection conexao = con.GetConexão();

            string SQL = "INSERT INTO produto(caminho, nome_produto, descricao, peso, valor_produto, validade, quantidade)" +

            "values(@caminho, @nome_produto ,@descricao, @peso, @valor_produto, @validade, @quantidade)";

            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            var valor = decimal.Parse(valorbox.Text);
            comando.Parameters.AddWithValue("@caminho", boxfoto.Text);
            comando.Parameters.AddWithValue("@nome_produto", nomebox.Text);
            comando.Parameters.AddWithValue("@descricao", descbox.Text);
            comando.Parameters.AddWithValue("@peso", pesobox.Text);
            comando.Parameters.AddWithValue("@valor_produto", valor);
            comando.Parameters.AddWithValue("@validade",Convert.ToDateTime( valbox.Text));
            comando.Parameters.AddWithValue("@quantidade",Convert.ToInt32( quanbox.Text));

            

            conexao.Open();
            if (comando.ExecuteNonQuery() >= 1)
            {

                MessageBox.Show("Produto Cadastrado!");
               
            }
            else
            {
                MessageBox.Show("A Algo Errado No Cadastro!");
            }
            conexao.Close();
        }

        private void valbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
