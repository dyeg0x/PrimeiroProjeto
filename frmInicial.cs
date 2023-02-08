using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjeto
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
             frmCargo cargo = new frmCargo();
            cargo.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias categorias = new frmCategorias();
            categorias.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToLongDateString();
            labelTime.Text= DateTime.Now.ToShortTimeString();
        }

        

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        private void frmInicial_Load(object sender, EventArgs e)
        {
             frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.ShowDialog();
        }
    }
}
