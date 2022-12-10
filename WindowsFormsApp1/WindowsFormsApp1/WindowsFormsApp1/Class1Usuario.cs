using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Class1Usuario
    {
        public int id_cadastro;
        public string nome_cliente;
        public string email_cliente;
        public string endereco_cliente;
        public string senha_cliente;
        public int perfil;
        int logado;

        public int logar(string login, string senha)
        {
            Conexão con = new Conexão();
            MySqlConnection conexao = con.GetConexão();
            String sql = "SELECT*FROM cadastro WHERE nome_cliente=@nome_cliente and senha_cliente=@senha_cliente";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nome_cliente", login);
            comando.Parameters.AddWithValue("@senha_cliente", senha);

            conexao.Open();

            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.HasRows)
            {
                logado = (int) registro ["id_login"];
                FormPainel principal = new FormPainel(logado);
                principal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha invalidos");
            }
            return logado;
            conexao.Close();
        }
    }

}
