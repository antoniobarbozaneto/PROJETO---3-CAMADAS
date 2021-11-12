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
	public partial class Form_login : Form
	{
		public Form_login()
		{
			InitializeComponent();
		}

		private void btn_entrar_Click(object sender, EventArgs e)
		{
			UsuarioBLL bll = new UsuarioBLL();
			UsuarioDTO dto = new UsuarioDTO();

			dto.Usuario = txb_usuario.Text;
			dto.Senha = txb_senha.Text;

			bll.VerificarLogin(dto); //METÓDO VERIFICAR LOGIN!!!!!

			if (bll.tem)
			{
				MessageBox.Show("Logado com sucesso!!!", "Entrando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Hide(); //esconde a form de login
				Form_inicio form_Inicio = new Form_inicio();
				form_Inicio.ShowDialog();
			}
			else
			{
				MessageBox.Show("Usuário não cadastrado, verifique login ou senha!", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txb_usuario.Clear();
				txb_senha.Clear();
			}
		}

		private void btn_sair_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
