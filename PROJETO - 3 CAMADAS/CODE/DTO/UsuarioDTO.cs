using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO___3_CAMADAS.CODE.DTO
{
	class UsuarioDTO
	{
		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		///////////////////////////////////////////

		private string usuario;
		public string Usuario
		{
			get { return usuario; }
			set { usuario = value; }
		}
		///////////////////////////////////////////

		private string senha;
		public string Senha
		{
			get { return senha; }
			set { senha = value; }
		}
		///////////////////////////////////////////
	}
}
