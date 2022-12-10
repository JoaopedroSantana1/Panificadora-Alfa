using MySqlX.XDevAPI;
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
    public partial class FormPainel : Form
    {
        int login = 0;
        public FormPainel(int login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastro cliente = new FormCadastro();
            cliente.MdiParent= this;    
            cliente.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduto produto = new FormProduto();
           produto.MdiParent = this;
            produto.Show();
        }
    }
}
