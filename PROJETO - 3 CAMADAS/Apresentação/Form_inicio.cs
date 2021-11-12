using PROJETO___3_CAMADAS.Apresentação;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO___3_CAMADAS
{
    public partial class Form_inicio : Form
    {
        public Form_inicio()
        {
            InitializeComponent();
        }

        private void cADASTRPSToolStripMenuItem_Click(object sender, EventArgs e)
        {            
        }

		private void cONSULTARToolStripMenuItem_Click(object sender, EventArgs e)
		{            
		}

		private void pESSOAFÍSICAToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Form_cadastrocliente form_cadastrocliente = new Form_cadastrocliente();
            form_cadastrocliente.ShowDialog();
        }

		private void pESSOAFÍSICAToolStripMenuItem1_Click(object sender, EventArgs e)
		{
            Form_consultacliente form_consultacliente = new Form_consultacliente();
            form_consultacliente.ShowDialog();
        }

		private void Form_inicio_FormClosed(object sender, FormClosedEventArgs e)
		{
            if (Application.OpenForms.Count != 0)//se o total de forms ABERTAS FOR diferente de 0 fechar aplicação
            {
                Application.Exit();
            }
		}

		private void cADASTROToolStripMenuItem1_Click(object sender, EventArgs e)
		{
            Form_cadastrousuario form_Cadastrousuario = new Form_cadastrousuario();
            form_Cadastrousuario.ShowDialog();
		}

		private void cONSULTAToolStripMenuItem1_Click(object sender, EventArgs e)
		{
            Form_consultausuario form_Consultausuario = new Form_consultausuario();
            form_Consultausuario.ShowDialog();
		}

		private void pESSOAJURÍDICAToolStripMenuItem2_Click(object sender, EventArgs e)
		{
            Form_cadastrofornecedor form_Cadastrofornecedor = new Form_cadastrofornecedor();
            form_Cadastrofornecedor.ShowDialog();
		}

        private void pESSOAJURÍDICAToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form_consultafornecedor form_Consultafornecedor = new Form_consultafornecedor();
            form_Consultafornecedor.ShowDialog();
        }
    }
}
