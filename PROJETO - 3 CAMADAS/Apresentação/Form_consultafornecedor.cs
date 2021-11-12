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
	public partial class Form_consultafornecedor : Form
	{
		FornecedorBLL bll = new FornecedorBLL();
		FornecedorDTO dto = new FornecedorDTO();

		public Form_consultafornecedor()
		{	
			InitializeComponent();
		}

        private void btn_voltar_Click(object sender, EventArgs e)
        {
			this.Close();
        }

		public void CarregarGridFornecedores()
		{
			dataGridView_Fornecedor.DataSource = bll.SelecionaTodosFornecedores();
		}

		public void PesquisarFornecedores()
        {
			dataGridView_Fornecedor.DataSource = bll.PesquisaFornecedores(dto);
        }

		private void dataGridView_Fornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Form_cadastrofornecedor form_Cadastrofornecedor = new Form_cadastrofornecedor();
			form_Cadastrofornecedor.txb_codigofornecedor.Text = dataGridView_Fornecedor.Rows[e.RowIndex].Cells[0].Value.ToString();
			form_Cadastrofornecedor.txb_nomefantasiafornecedor.Text = dataGridView_Fornecedor.Rows[e.RowIndex].Cells[1].Value.ToString();
			form_Cadastrofornecedor.txb_razaosocialfornecedor.Text = dataGridView_Fornecedor.Rows[e.RowIndex].Cells[2].Value.ToString();
			form_Cadastrofornecedor.maskedtxb_cnpjfornecedor.Text = dataGridView_Fornecedor.Rows[e.RowIndex].Cells[3].Value.ToString();
			form_Cadastrofornecedor.maskedtxb_iefornecedor.Text = dataGridView_Fornecedor.Rows[e.RowIndex].Cells[4].Value.ToString();
			form_Cadastrofornecedor.txb_enderecofornecedor.Text = dataGridView_Fornecedor.Rows[e.RowIndex].Cells[5].Value.ToString();
			form_Cadastrofornecedor.txb_numerofornecedor.Text = dataGridView_Fornecedor.Rows[e.RowIndex].Cells[6].Value.ToString();
			form_Cadastrofornecedor.txb_bairrofornecedor.Text = dataGridView_Fornecedor.Rows[e.RowIndex].Cells[7].Value.ToString();
			form_Cadastrofornecedor.txb_cidadefornecedor.Text = dataGridView_Fornecedor.Rows[e.RowIndex].Cells[8].Value.ToString();
			form_Cadastrofornecedor.cxb_estadofornecedor.Text = dataGridView_Fornecedor.Rows[e.RowIndex].Cells[9].Value.ToString();
			form_Cadastrofornecedor.maskedtxb_cepfornecedor.Text = dataGridView_Fornecedor.Rows[e.RowIndex].Cells[10].Value.ToString();
			form_Cadastrofornecedor.maskedtxb_telefoneumfornecedor.Text = dataGridView_Fornecedor.Rows[e.RowIndex].Cells[11].Value.ToString();
			form_Cadastrofornecedor.maskedtxb_telefonedoisfornecedor.Text = dataGridView_Fornecedor.Rows[e.RowIndex].Cells[12].Value.ToString();
			form_Cadastrofornecedor.maskedtxb_celularumfornecedor.Text = dataGridView_Fornecedor.Rows[e.RowIndex].Cells[13].Value.ToString();
			form_Cadastrofornecedor.maskedtxb_celulardoisfornecedor.Text = dataGridView_Fornecedor.Rows[e.RowIndex].Cells[14].Value.ToString();
			form_Cadastrofornecedor.maskedtxb_faxfornecedor.Text = dataGridView_Fornecedor.Rows[e.RowIndex].Cells[15].Value.ToString();
			form_Cadastrofornecedor.txb_emailfornecedor.Text = dataGridView_Fornecedor.Rows[e.RowIndex].Cells[16].Value.ToString();
			form_Cadastrofornecedor.txb_emaildoisfornecedor.Text = dataGridView_Fornecedor.Rows[e.RowIndex].Cells[17].Value.ToString();
			form_Cadastrofornecedor.txb_ramoativadefornecedor.Text = dataGridView_Fornecedor.Rows[e.RowIndex].Cells[18].Value.ToString();
			form_Cadastrofornecedor.txb_observacaofornecedor.Text = dataGridView_Fornecedor.Rows[e.RowIndex].Cells[19].Value.ToString();

			form_Cadastrofornecedor.ShowDialog();
		}

		private void btn_editar_Click(object sender, EventArgs e)
        {
			Form_cadastrofornecedor form_Cadastrofornecedor = new Form_cadastrofornecedor();
			form_Cadastrofornecedor.txb_codigofornecedor.Text = dataGridView_Fornecedor.CurrentRow.Cells[0].Value.ToString();
			form_Cadastrofornecedor.txb_nomefantasiafornecedor.Text = dataGridView_Fornecedor.CurrentRow.Cells[1].Value.ToString();
			form_Cadastrofornecedor.txb_razaosocialfornecedor.Text = dataGridView_Fornecedor.CurrentRow.Cells[2].Value.ToString();
			form_Cadastrofornecedor.maskedtxb_cnpjfornecedor.Text = dataGridView_Fornecedor.CurrentRow.Cells[3].Value.ToString();
			form_Cadastrofornecedor.maskedtxb_iefornecedor.Text = dataGridView_Fornecedor.CurrentRow.Cells[4].Value.ToString();
			form_Cadastrofornecedor.txb_enderecofornecedor.Text = dataGridView_Fornecedor.CurrentRow.Cells[5].Value.ToString();
			form_Cadastrofornecedor.txb_numerofornecedor.Text = dataGridView_Fornecedor.CurrentRow.Cells[6].Value.ToString();
			form_Cadastrofornecedor.txb_bairrofornecedor.Text = dataGridView_Fornecedor.CurrentRow.Cells[7].Value.ToString();
			form_Cadastrofornecedor.txb_cidadefornecedor.Text = dataGridView_Fornecedor.CurrentRow.Cells[8].Value.ToString();
			form_Cadastrofornecedor.cxb_estadofornecedor.Text = dataGridView_Fornecedor.CurrentRow.Cells[9].Value.ToString();
			form_Cadastrofornecedor.maskedtxb_cepfornecedor.Text = dataGridView_Fornecedor.CurrentRow.Cells[10].Value.ToString();
			form_Cadastrofornecedor.maskedtxb_telefoneumfornecedor.Text = dataGridView_Fornecedor.CurrentRow.Cells[11].Value.ToString();
			form_Cadastrofornecedor.maskedtxb_telefonedoisfornecedor.Text = dataGridView_Fornecedor.CurrentRow.Cells[12].Value.ToString();
			form_Cadastrofornecedor.maskedtxb_celularumfornecedor.Text = dataGridView_Fornecedor.CurrentRow.Cells[13].Value.ToString();
			form_Cadastrofornecedor.maskedtxb_celulardoisfornecedor.Text = dataGridView_Fornecedor.CurrentRow.Cells[14].Value.ToString();
			form_Cadastrofornecedor.maskedtxb_faxfornecedor.Text = dataGridView_Fornecedor.CurrentRow.Cells[15].Value.ToString();
			form_Cadastrofornecedor.txb_emailfornecedor.Text = dataGridView_Fornecedor.CurrentRow.Cells[16].Value.ToString();
			form_Cadastrofornecedor.txb_emaildoisfornecedor.Text = dataGridView_Fornecedor.CurrentRow.Cells[17].Value.ToString();
			form_Cadastrofornecedor.txb_ramoativadefornecedor.Text = dataGridView_Fornecedor.CurrentRow.Cells[18].Value.ToString();
			form_Cadastrofornecedor.txb_observacaofornecedor.Text = dataGridView_Fornecedor.CurrentRow.Cells[19].Value.ToString();

			form_Cadastrofornecedor.ShowDialog();
		}

        private void Form_consultafornecedor_Load(object sender, EventArgs e)
        {
			CarregarGridFornecedores();
        }

        private void btn_atualizarGridView_Click(object sender, EventArgs e)
        {
			CarregarGridFornecedores();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
			int id = Convert.ToInt32(dataGridView_Fornecedor.CurrentRow.Cells[0].Value.ToString());

			var ResultResp = MessageBox.Show("Deseja realmente excluir o cliente selecionado?", "Exclusão Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (ResultResp == System.Windows.Forms.DialogResult.Yes)
			{
				bll.Excluir(id);
				CarregarGridFornecedores();
			}
		}

        private void btn_buscar_Click(object sender, EventArgs e)
        {
			dto.Nomefantasia = txb_consultafornecedor.Text.Trim();
			if (txb_consultafornecedor.Text == "")
			{
				CarregarGridFornecedores();
			}
			else
			{
				PesquisarFornecedores();
			}
		}
    }
}
