using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //biblioteca do formulario
using MySql.Data.MySqlClient; //blibioteca MYSQL
namespace WindowsFormsApp1
{
    class Conexão
    {
    // declaração da variavel 
        static private string servidor = "localhost";
        static private string bancodedados = "projeto2";
        static private string usuario = "root";
        static private string senha = "";
        static public  string StrCon = "server ="+ servidor +";database="+ bancodedados +";user id="+ usuario +";password="+ senha;


        public MySqlConnection GetConexão()
        {
            MySqlConnection con = new MySqlConnection(StrCon);
            return con;
        }
        public bool conectar()
        {
            var result = false;
            try
            {
                GetConexão().Open(); //abro Conexão
                result = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Falha" + ex.Message);
            }

            return result;
        }
    }
}
