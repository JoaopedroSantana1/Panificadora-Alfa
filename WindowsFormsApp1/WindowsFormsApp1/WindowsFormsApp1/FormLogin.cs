using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void cadastrobtn_Click(object sender, EventArgs e)
        {
            Conexão con = new Conexão();
            MySqlConnection conexao = con.GetConexão();
            String sql = "SELECT*FROM cadastro WHERE nome_cliente=@nome_cliente and senha_cliente=@senha_cliente";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nome_cliente", loginbox.Text);
            comando.Parameters.AddWithValue("@senha_cliente", senhabox.Text);

            conexao.Open();

            MySqlDataReader registro = comando.ExecuteReader();
            if(registro.HasRows)
            {

                FormPainel principal = new FormPainel((int)registro ["id_login"]);
                principal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha invalidos");
            }
            conexao.Close();
        }

        private void senhabox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
