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
	public partial class Form_cadastrofornecedor : Form
	{
		FornecedorBLL bll = new FornecedorBLL();
		FornecedorDTO dto = new FornecedorDTO();

		public Form_cadastrofornecedor()
		{
			InitializeComponent();
		}

		private void btn_voltar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_gravar_Click(object sender, EventArgs e)
		{
			dto.Nomefantasia = txb_nomefantasiafornecedor.Text;
			dto.Razaosocial = txb_razaosocialfornecedor.Text;
			dto.Cnpj = maskedtxb_cnpjfornecedor.Text;
			dto.Ie = maskedtxb_iefornecedor.Text;
			dto.Endereco = txb_enderecofornecedor.Text;
			dto.Numero = txb_numerofornecedor.Text;
			dto.Bairro = txb_bairrofornecedor.Text;
			dto.Cidade = txb_cidadefornecedor.Text;
			dto.Estado = cxb_estadofornecedor.Text;
			dto.Cep = maskedtxb_cepfornecedor.Text;
			dto.Telefoneum = maskedtxb_telefoneumfornecedor.Text;
			dto.Telefonedois = maskedtxb_telefonedoisfornecedor.Text;
			dto.Celularum = maskedtxb_celularumfornecedor.Text;
			dto.Celulardois = maskedtxb_celulardoisfornecedor.Text;
			dto.Fax = maskedtxb_faxfornecedor.Text;
			dto.Email = txb_emailfornecedor.Text;
			dto.Emailenfe = txb_emaildoisfornecedor.Text;
			dto.Ramoatividade = txb_ramoativadefornecedor.Text;
			dto.Observacao = txb_observacaofornecedor.Text;

			if (!maskedtxb_cnpjfornecedor.MaskCompleted)
			{
				MessageBox.Show("Preencha os campos obrigatórios!", "Preencher o campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				if (txb_codigofornecedor.Text == "")//verifica o codigo se o codigo do cliente está vazio ou não
				{

					bll.Inserir(dto); //inserindo os dados.
					MessageBox.Show("O fornecedor foi cadastrado com sucesso!!!", "Inserido com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LimparCampos();
				}
				else
				{
					dto.Codigo = int.Parse(txb_codigofornecedor.Text);
					bll.Editar(dto); //Editar o dados do cliente.
					MessageBox.Show("O dados do fornecedor foram alterados e salvo com sucesso!!!", "Editado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LimparCampos();
				}
			}
		}

		private void Form_cadastrofornecedor_Load(object sender, EventArgs e)
		{
			this.ActiveControl = txb_nomefantasiafornecedor;
		}

		private void LimparCampos()
		{
			txb_codigofornecedor.Clear();
			txb_nomefantasiafornecedor.Clear();
			txb_razaosocialfornecedor.Clear();
			maskedtxb_cnpjfornecedor.Clear();
			maskedtxb_iefornecedor.Clear();
			txb_enderecofornecedor.Clear();
			txb_numerofornecedor.Clear();
			txb_bairrofornecedor.Clear();
			txb_cidadefornecedor.Clear();
			cxb_estadofornecedor.Items.Clear();
			maskedtxb_cepfornecedor.Clear();
			maskedtxb_telefoneumfornecedor.Clear();
			maskedtxb_telefonedoisfornecedor.Clear();
			maskedtxb_celularumfornecedor.Clear();
			maskedtxb_celulardoisfornecedor.Clear();
			maskedtxb_faxfornecedor.Clear();
			txb_emailfornecedor.Clear();
			txb_emaildoisfornecedor.Clear();
			txb_ramoativadefornecedor.Clear();
			txb_observacaofornecedor.Clear();
		}

		private void btn_limparcampos_Click(object sender, EventArgs e)
		{
			LimparCampos();
		}
	}
}
