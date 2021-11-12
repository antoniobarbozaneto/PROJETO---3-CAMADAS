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
	public partial class Form_consultausuario : Form
	{
		public Form_consultausuario()
		{
			InitializeComponent();
		}

		UsuarioBLL bll = new UsuarioBLL();
		UsuarioDTO dto = new UsuarioDTO();
		public void CarregarGridUsuario()
		{
			dataGridView_Usuario.DataSource = bll.SelecionaTodosUsuarios();
		}

		public void PesquisarUsuario()
		{
			dataGridView_Usuario.DataSource = bll.PesquisarUsuario(dto);
		}

		private void Form_consultausuario_Load(object sender, EventArgs e)
		{
			CarregarGridUsuario();
		}		

		private void btn_editar_Click(object sender, EventArgs e)
		{
			Form_cadastrousuario form_Cadastrousuario = new Form_cadastrousuario();
			form_Cadastrousuario.txb_codigousuario.Text = dataGridView_Usuario.CurrentRow.Cells[0].Value.ToString();
			form_Cadastrousuario.txb_nomeusuario.Text = dataGridView_Usuario.CurrentRow.Cells[1].Value.ToString();
			form_Cadastrousuario.txb_senhausuario.Text = dataGridView_Usuario.CurrentRow.Cells[2].Value.ToString();

			form_Cadastrousuario.ShowDialog();
		}
		private void dataGridView_Usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Form_cadastrousuario form_Cadastrousuario = new Form_cadastrousuario();
			form_Cadastrousuario.txb_codigousuario.Text = dataGridView_Usuario.Rows[e.RowIndex].Cells[0].Value.ToString();
			form_Cadastrousuario.txb_nomeusuario.Text = dataGridView_Usuario.Rows[e.RowIndex].Cells[1].Value.ToString();
			form_Cadastrousuario.txb_senhausuario.Text = dataGridView_Usuario.Rows[e.RowIndex].Cells[2].Value.ToString();

			form_Cadastrousuario.ShowDialog();
		}

		private void btn_atualizarGridView_Click(object sender, EventArgs e)
		{
			CarregarGridUsuario();
		}

		private void btn_voltar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_excluir_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(dataGridView_Usuario.CurrentRow.Cells[0].Value.ToString());

			var ResultResp = MessageBox.Show("Deseja realmente excluir o usuario selecionado? ", "Exclusão Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (ResultResp == System.Windows.Forms.DialogResult.Yes)
			{
				bll.Excluir(id);
				CarregarGridUsuario();
			}
		}

		private void btn_buscar_Click(object sender, EventArgs e)
		{
			dto.Usuario = txb_consultausuario.Text.Trim();

			if (txb_consultausuario.Text == "")
			{
				CarregarGridUsuario();
			}
			else
			{
				PesquisarUsuario();
			}
		}
	}
}
