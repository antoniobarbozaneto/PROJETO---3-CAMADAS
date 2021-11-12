using PROJETO___3_CAMADAS.CODE.BLL;
using PROJETO___3_CAMADAS.CODE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO___3_CAMADAS.Apresentação
{
    public partial class Form_cadastrocliente : Form
    {     
        ClienteBLL bll = new ClienteBLL();
        ClienteDTO dto = new ClienteDTO();

        public Form_cadastrocliente()
        {
            InitializeComponent();           
        }

        private void Form_cadastrocliente_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txb_nomecliente; //INICIA A FORM COM O FOCO NESSA TXTBOX.
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {                      
            dto.Nome = txb_nomecliente.Text;/////PASSAR OS OBJETOS PREENCHIDOS PARA ACAMADA CAMADA DE NEGÓCIOS
            dto.Cpf = maskedtxb_cpfcliente.Text;
            dto.Rg = maskedtxb_rgcliente.Text;
            dto.Endereco = txb_enderecocliente.Text;
            dto.Numero = txb_numenderecocliente.Text;
            dto.Bairro = txb_bairrocliente.Text;
            dto.Cidade = txb_cidadecliente.Text;
            dto.Estado = cxb_estadocliente.Text;
            dto.Cep = maskedtxb_cepcliente.Text;
            dto.Telefone = maskedtxb_telefonecliente.Text;
            dto.Celular = maskedtxb_celularcliente.Text;
            dto.Email = txb_emailcliente.Text;////////////////////////////////

            if (!maskedtxb_cpfcliente.MaskCompleted || !maskedtxb_rgcliente.MaskCompleted)
            {
                MessageBox.Show("Preencha os campos obrigatórios!", "Preencher o campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (txb_codigocliente.Text == "")//verifica o codigo se o codigo do cliente está vazio ou não
                {

                    bll.Inserir(dto); //inserindo os dados.
                    MessageBox.Show("O cliente foi cadastrado com sucesso!!!", "Inserido com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                else
                {
                    dto.Codigo = int.Parse(txb_codigocliente.Text);
                    bll.Editar(dto); //Editar o dados do cliente.
                    MessageBox.Show("O dados do cliente foram alterados e salvo com sucesso!!!", "Editado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            
        }

		private void btn_voltar_Click(object sender, EventArgs e)
		{
            this.Close();
		}

        private void btn_limparcampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txb_codigocliente.Clear();
            txb_nomecliente.Clear();
            maskedtxb_cpfcliente.Clear();
            maskedtxb_rgcliente.Clear();
            txb_enderecocliente.Clear();
            txb_numenderecocliente.Clear();
            txb_bairrocliente.Clear();
            txb_cidadecliente.Clear();
            cxb_estadocliente.Items.Clear();
            maskedtxb_cepcliente.Clear();
            maskedtxb_telefonecliente.Clear();
            maskedtxb_celularcliente.Clear();
            txb_emailcliente.Clear();
        }
    }
}
