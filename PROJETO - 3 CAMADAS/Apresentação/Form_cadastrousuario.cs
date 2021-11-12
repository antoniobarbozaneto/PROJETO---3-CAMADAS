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
	public partial class Form_cadastrousuario : Form
	{
		public Form_cadastrousuario()
		{
			InitializeComponent();
		}

		UsuarioDTO dto = new UsuarioDTO();
		UsuarioBLL bll = new UsuarioBLL();

		

		private void LimparCampos()
		{
			txb_codigousuario.Clear();
			txb_nomeusuario.Clear();
			txb_senhausuario.Clear();
		}

		private void btn_gravar_Click(object sender, EventArgs e)
		{
			dto.Usuario = txb_nomeusuario.Text;
			dto.Senha = txb_senhausuario.Text;

			if (txb_nomeusuario.Text == "" || txb_senhausuario.Text == "")
			{
				MessageBox.Show("Preencha os campos obrigatórios!", "Preencher o campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				if (txb_codigousuario.Text == "")
				{
					bll.Inserir(dto);
					MessageBox.Show("O usuário foi cadastrado com sucesso!!!", "Inserido com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LimparCampos();
				}
				else
				{
					dto.Id = int.Parse(txb_codigousuario.Text);
					bll.Editar(dto);
					MessageBox.Show("O dados do usuário foram alterados e salvo com sucesso!!!", "Editado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LimparCampos();
				}

			}
		}

		private void Form_cadastrousuario_Load(object sender, EventArgs e)
		{
			this.ActiveControl = txb_nomeusuario;
		}

		private void btn_limpar_Click(object sender, EventArgs e)
		{
			LimparCampos();
		}

		private void btn_voltar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

