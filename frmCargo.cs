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
    public partial class frmCargo : Form
    {
        public frmCargo()
        {
            InitializeComponent();
        }
        
        private void LimpaCampo()
        {
            Codigo.Clear();
            Cargo.Clear();
        }

        private void labelCódigo_Click(object sender, EventArgs e)
        {

        }

        private void labelCargo_Click(object sender, EventArgs e)
        {

        }

        private void textCódigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Novo_Click(object sender, EventArgs e)
        {
            Cargo.Clear();
            Cancelar.Enabled = true;
            Salvar.Enabled = true;
            Excluir.Enabled = false;
            Cargo.Enabled = false;
            Localizar.Enabled = false;
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            Novo.Enabled = true;
            Cancelar.Enabled = true;
            Excluir.Enabled = false;
            Codigo.Enabled = false;
            Cargo.Enabled = false;
            Localizar.Enabled = false;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Salvar.Enabled = false;
            Excluir.Enabled = false;
            Codigo.Enabled = false;
            Cargo.Enabled = false;
            Localizar.Enabled = false;
        }

         private void Excluir_Click(object sender, EventArgs e)
        {
            Cancelar.Enabled = true;
            Salvar.Enabled = true;      
            Codigo.Enabled = false;
            Cargo.Enabled = false;
            Localizar.Enabled = false;
        }

        private void Localizar_Click(object sender, EventArgs e)
        {
            Cancelar.Enabled = true;
            Salvar.Enabled = true;
            Excluir.Enabled = false;
            Codigo.Enabled = false;
            Cargo.Enabled = false;
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCargo_Load(object sender, EventArgs e)
        {

        }
    }
}
