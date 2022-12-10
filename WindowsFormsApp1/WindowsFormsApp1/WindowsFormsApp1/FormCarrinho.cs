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
    public partial class FormCarrinho : Form
    {
        public FormCarrinho()
        {
            InitializeComponent();
        }

        private void carrinhobox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            Conexão con = new Conexão();
            MySqlConnection conexao = con.GetConexão();
            string consulta;

            if (carrinhobox.Text == "")
            {
                consulta = "SELECT*FROM produto";
            }
            else
            {
                consulta = "SELECT*FROM produto WHERE nome_produto like '%" + carrinhobox.Text + "%'";
            }
            MySqlCommand comando = new MySqlCommand(consulta, conexao);
            conexao.Open();
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable dtCadastro = new DataTable();
            dados.Fill(dtCadastro);
            carrinhobox.DataSource = dtCadastro;
            conexao.Close();
        }

        private void FormCarrinho_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


