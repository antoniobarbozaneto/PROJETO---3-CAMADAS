using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJETO___3_CAMADAS.CODE.BLL;
using PROJETO___3_CAMADAS.CODE.DTO;

namespace PROJETO___3_CAMADAS.Apresentação
{
	public partial class Form_consultacliente : Form
	{
		ClienteBLL bll = new ClienteBLL();
		ClienteDTO dto = new ClienteDTO();
		public Form_consultacliente()
		{
			InitializeComponent();
		}

		private void btn_voltar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void Form_consultacliente_Load(object sender, EventArgs e)
        {
			CarregarGridClientes();
        }
		public void CarregarGridClientes() //METODO LISTA CLIENTES
        {
			dataGridView_Clientes.DataSource = bll.SelecionaTodosClientes(); //pega a fonte de dados q vai me retornar			
        }

		public void PesquisarCliente() //METODO PESQUISAR CLIENTE
		{
			dataGridView_Clientes.DataSource = bll.PesquisarClientes(dto); //pega a fonte de dados para pesquisar q vai me retornar
		}
        private void dataGridView_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)//evento que o usario clicar na linha do grid
        {
			Form_cadastrocliente formCadastrocliente = new Form_cadastrocliente();
			formCadastrocliente.txb_codigocliente.Text = dataGridView_Clientes.Rows[e.RowIndex].Cells[0].Value.ToString(); //PEGA PELO INDEX
			formCadastrocliente.txb_nomecliente.Text = dataGridView_Clientes.Rows[e.RowIndex].Cells[1].Value.ToString();
			formCadastrocliente.maskedtxb_cpfcliente.Text = dataGridView_Clientes.Rows[e.RowIndex].Cells[2].Value.ToString();
			formCadastrocliente.maskedtxb_rgcliente.Text = dataGridView_Clientes.Rows[e.RowIndex].Cells[3].Value.ToString();
			formCadastrocliente.txb_enderecocliente.Text = dataGridView_Clientes.Rows[e.RowIndex].Cells[4].Value.ToString();
			formCadastrocliente.txb_numenderecocliente.Text = dataGridView_Clientes.Rows[e.RowIndex].Cells[5].Value.ToString();
			formCadastrocliente.txb_bairrocliente.Text = dataGridView_Clientes.Rows[e.RowIndex].Cells[6].Value.ToString();
			formCadastrocliente.txb_cidadecliente.Text = dataGridView_Clientes.Rows[e.RowIndex].Cells[7].Value.ToString();
			formCadastrocliente.cxb_estadocliente.Text = dataGridView_Clientes.Rows[e.RowIndex].Cells[8].Value.ToString();
			formCadastrocliente.maskedtxb_cepcliente.Text = dataGridView_Clientes.Rows[e.RowIndex].Cells[9].Value.ToString();
			formCadastrocliente.maskedtxb_telefonecliente.Text = dataGridView_Clientes.Rows[e.RowIndex].Cells[10].Value.ToString();
			formCadastrocliente.maskedtxb_celularcliente.Text = dataGridView_Clientes.Rows[e.RowIndex].Cells[11].Value.ToString();
			formCadastrocliente.txb_emailcliente.Text = dataGridView_Clientes.Rows[e.RowIndex].Cells[12].Value.ToString();

			formCadastrocliente.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e) //PRECISA TRATARO ERRO CASO NAO TIVER NENHUM CLIENTE SELECIONADO.
        {
			Form_cadastrocliente formCadastrocliente = new Form_cadastrocliente();
			formCadastrocliente.txb_codigocliente.Text = dataGridView_Clientes.CurrentRow.Cells[0].Value.ToString(); //PEGA A LINHA CORRENTE
			formCadastrocliente.txb_nomecliente.Text = dataGridView_Clientes.CurrentRow.Cells[1].Value.ToString();
			formCadastrocliente.maskedtxb_cpfcliente.Text = dataGridView_Clientes.CurrentRow.Cells[2].Value.ToString();
			formCadastrocliente.maskedtxb_rgcliente.Text = dataGridView_Clientes.CurrentRow.Cells[3].Value.ToString();
			formCadastrocliente.txb_enderecocliente.Text = dataGridView_Clientes.CurrentRow.Cells[4].Value.ToString();
			formCadastrocliente.txb_numenderecocliente.Text = dataGridView_Clientes.CurrentRow.Cells[5].Value.ToString();
			formCadastrocliente.txb_bairrocliente.Text = dataGridView_Clientes.CurrentRow.Cells[6].Value.ToString();
			formCadastrocliente.txb_cidadecliente.Text = dataGridView_Clientes.CurrentRow.Cells[7].Value.ToString();
			formCadastrocliente.cxb_estadocliente.Text = dataGridView_Clientes.CurrentRow.Cells[8].Value.ToString();
			formCadastrocliente.maskedtxb_cepcliente.Text = dataGridView_Clientes.CurrentRow.Cells[9].Value.ToString();
			formCadastrocliente.maskedtxb_telefonecliente.Text = dataGridView_Clientes.CurrentRow.Cells[10].Value.ToString();
			formCadastrocliente.maskedtxb_celularcliente.Text = dataGridView_Clientes.CurrentRow.Cells[11].Value.ToString();
			formCadastrocliente.txb_emailcliente.Text = dataGridView_Clientes.CurrentRow.Cells[12].Value.ToString();

			formCadastrocliente.ShowDialog();
		}

        private void btn_atualizarGridView_Click(object sender, EventArgs e)
        {
			CarregarGridClientes();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {			
			int id = Convert.ToInt32(dataGridView_Clientes.CurrentRow.Cells[0].Value.ToString());
			
				var ResultResp = MessageBox.Show("Deseja realmente excluir o cliente selecionado?", "Exclusão Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (ResultResp == System.Windows.Forms.DialogResult.Yes)
				{
				bll.Excluir(id);
				CarregarGridClientes();
				}
			
		}

		private void txb_consultacliente_TextChanged(object sender, EventArgs e)
		{
		}

		private void btn_buscar_Click(object sender, EventArgs e)
		{
			dto.Nome = txb_consultacliente.Text.Trim();
			if (txb_consultacliente.Text == "")
			{
				CarregarGridClientes();
			}
			else
			{
				PesquisarCliente();
			}
		}
	}
}
