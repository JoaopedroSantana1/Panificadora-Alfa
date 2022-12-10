using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //blibioteca MYSQL

namespace WindowsFormsApp1
{
    public partial class FormCadastro : Form
    {

        int codigo; //variavel para converter o registro do usuario

        public FormCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cadastrobtn_Click(object sender, EventArgs e)
        {
            //chamo conexão

            Conexão con = new Conexão();
            MySqlConnection conexao = con.GetConexão();

            string SQL = "INSERT INTO cadastro(nome_cliente,email_cliente,endereco_cliente,senha_cliente, perfil_usuario)" +

            "values(@nome_cliente,@email_cliente,@endereco_cliente,@senha_cliente,@perfil)";

            MySqlCommand comando = new MySqlCommand(SQL, conexao);

            comando.Parameters.AddWithValue("@nome_cliente", nomebox.Text);
            comando.Parameters.AddWithValue("@email_cleinte", emailbox.Text);
            comando.Parameters.AddWithValue("@endereco_cliente", enderecobox.Text);
            comando.Parameters.AddWithValue("@senha_cliente", senhabox.Text);

            comando.Parameters.AddWithValue("@perfil", Convert.ToInt32(perfilbox.Text));
            conexao.Open();
            comando.ExecuteNonQuery();


        }

        private void cadastrobtn_Click_1(object sender, EventArgs e)
        {

            Conexão con = new Conexão();
            MySqlConnection conexao = con.GetConexão();

            string SQL = "INSERT INTO cadastro(nome_cliente,email_cliente,endereco_cliente,senha_cliente, perfil)" +

            "values(@nome_cliente,@email_cliente,@endereco_cliente,@senha_cliente,@perfil)";

            MySqlCommand comando = new MySqlCommand(SQL, conexao);

            comando.Parameters.AddWithValue("@nome_cliente", nomebox.Text);
            comando.Parameters.AddWithValue("@email_cliente", emailbox.Text);
            comando.Parameters.AddWithValue("@endereco_cliente", enderecobox.Text);
            comando.Parameters.AddWithValue("@senha_cliente", senhabox.Text);

            comando.Parameters.AddWithValue("@perfil", Convert.ToInt32(perfilbox.Text));
            conexao.Open();
            if (comando.ExecuteNonQuery() >= 1)
            {

                MessageBox.Show("Cadastro Concluido");
                FormLogin login = new FormLogin();
                login.ShowDialog();
                this.Close();
            }
            else {
                MessageBox.Show("A Algo Errado No Cadastro");
            }
            conexao.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexão con = new Conexão();
            MySqlConnection conexao = con.GetConexão();
            string consulta;

            if (pesquisarbox.Text == "")
            {
                consulta = "SELECT*FROM cadastro";
            }
            else
            {
                consulta = "SELECT*FROM cadastro WHERE nome_cliente like '%" + pesquisarbox.Text + "%'";
            }
            MySqlCommand comando = new MySqlCommand(consulta, conexao);
            conexao.Open();
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable dtCadastro = new DataTable();
            dados.Fill(dtCadastro);
            pesquisabox.DataSource = dtCadastro;
            conexao.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void atualizarbtn_Click(object sender, EventArgs e)
        {
            Conexão con = new Conexão();
            MySqlConnection conexao = con.GetConexão();
            if (codigo >= 0)
            {
                string SQL = "UPDATE cadastro set nome_cliente = @nome_cliente,email_cliente = @email_cliente, endereco_cliente = @endereco_cliente, senha_cliente = @senha_cliente, perfil = @perfil WHERE id_cadastro=@cadastro ";
                MySqlCommand comando = new MySqlCommand(SQL, conexao);
                comando.Parameters.AddWithValue("@nome_cliente", nomebox.Text);
                comando.Parameters.AddWithValue("@email_cliente", emailbox.Text);
                comando.Parameters.AddWithValue("@endereco_cliente", enderecobox.Text);
                comando.Parameters.AddWithValue("@senha_cliente", senhabox.Text);
                comando.Parameters.AddWithValue("@perfil", Convert.ToInt32(perfilbox.Text));
                comando.Parameters.AddWithValue("@cadastro", codigo);
                conexao.Open();
                if (comando.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("Atualizado com Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro");

                }
            }
            else {
                MessageBox.Show("Deve selecionar o Registro");
            }

            conexao.Close();
        }

        private void excluirbtn_Click(object sender, EventArgs e)
        {
            Conexão con = new Conexão();
            MySqlConnection conexao = con.GetConexão();
            string SQL = "DELETE FROM cadastro WHERE id_cadastro=@cadastro";
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            comando.Parameters.AddWithValue("@cadastro", codigo);
            conexao.Open();

            if (comando.ExecuteNonQuery() >= 1) {
                MessageBox.Show("Excluido com sucesso");
            }
            else {
                MessageBox.Show("Erro ao Excluir");

            }
        }

        private void pesquisabox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                codigo = Convert.ToInt32(pesquisabox.Rows[e.RowIndex].Cells[0].Value);
                Conexão con = new Conexão();
                MySqlConnection conexao = con.GetConexão();
                String SQL = "SELECT*FROM cadastro WHERE id_cadastro=@cadastro";
                MySqlCommand comando = new MySqlCommand(SQL, conexao);
                conexao.Open();
                comando.Parameters.AddWithValue("@cadastro", codigo);
                MySqlDataReader registro = comando.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();
                    nomebox.Text = Convert.ToString(registro["nome_cliente"]);
                    emailbox.Text = Convert.ToString(registro["email_cliente"]);
                    enderecobox.Text = Convert.ToString(registro["endereco_cliente"]);
                    senhabox.Text = Convert.ToString(registro["senha_cliente"]);
                    perfilbox.Text = Convert.ToString(registro["perfil"]);

                }
                else
                {
                    MessageBox.Show("Falha selecionar um item");
                }

            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void butaocadastro_Click(object sender, EventArgs e)
        {

            Conexão con = new Conexão();
            MySqlConnection conexao = con.GetConexão();

            string SQL = "INSERT INTO cadastro(nome_rua_endereco,numero_endereco,complemento_endereco,estado, cidade)" +

            "values(@nome_rua_endereco,@numero_endereco,@complemento_endereco,@estado,@cidade)";

            MySqlCommand comando = new MySqlCommand(SQL, conexao);

            comando.Parameters.AddWithValue("@nome_rua_endereco", lagradourobox.Text);
            comando.Parameters.AddWithValue("@numero_endereco", numerobox.Text);
            comando.Parameters.AddWithValue("@complemento_endereco", complementobox.Text);
            comando.Parameters.AddWithValue("@cidade", cidadebox.Text);
            comando.Parameters.AddWithValue("@estado", estadobox.Text);


            conexao.Open();
            if (comando.ExecuteNonQuery() >= 1)
            {

                MessageBox.Show("Cadastro Concluido");
                enderecobox.Text = Convert.ToString(comando.LastInsertedId);
                nomebox.Focus();



            }
        }
    }
