using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJETO___3_CAMADAS.CODE.DTO;
using PROJETO___3_CAMADAS.CODE.DAL;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using System.Security.Cryptography.X509Certificates;
using System.Data;

namespace PROJETO___3_CAMADAS.CODE.BLL
{
	class UsuarioBLL
	{
		public bool tem;
		AcessoBD bd = new AcessoBD();
		SqlDataReader dr;

		public void Inserir(UsuarioDTO dto)
		{
			try
			{
				AcessoBD bd = new AcessoBD();
				bd.Conectar();
				string comando = "INSERT INTO tbl_login (usuario,senha) VALUES ('" + dto.Usuario + "','" + dto.Senha + "')";
				bd.ExecutarComandoSQL(comando);
			}
			catch (Exception ex) 
			{
				throw new Exception("Erro ao tentar cadastrar o usuário" + ex.Message);
			}
			finally
			{
				bd = null;
			}
		}

		public void Editar(UsuarioDTO dto)
		{
			try
			{
				string usuario = dto.Usuario.Replace("'", "''");
				AcessoBD bd = new AcessoBD();
				bd.Conectar();
				string comando = "UPDATE tbl_login SET usuario = '" + usuario + "', senha = '" + dto.Senha + "' WHERE idusuario = " + dto.Id;
				bd.ExecutarComandoSQL(comando);
			}
			catch (Exception ex)
			{
				throw new Exception("Erro ao tentar Editar o cadastro do usuário : " + ex.Message);
			}
			finally
			{
				bd = null;
			}
		}

		public void Excluir(int IdUsuario)
		{
			try 
			{
				AcessoBD bd = new AcessoBD(); 
				bd.Conectar(); 
				string comando = "DELETE FROM tbl_login WHERE idusuario = " + IdUsuario; 
				bd.ExecutarComandoSQL(comando);
			}
			catch (Exception ex)
			{
				throw new Exception("Não foi possível Excluir o cadastro do cliente: " + ex.Message);
			}
			finally 
			{
				bd = null; 
			}
		}

		public bool VerificarLogin(UsuarioDTO dto)
		{
			try
			{
				AcessoBD bd = new AcessoBD();
				bd.Conectar();
				string comando = "SELECT * FROM tbl_login WHERE usuario = '" + dto.Usuario + "'AND senha = '" + dto.Senha + "'";
				dr = bd.RetDataReader(comando);

				if (dr.HasRows)
				{
					tem = true;
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Erro com o banco de dados: " + ex.Message);
			}
			finally
			{
				bd = null;
			}
			return tem;
		}

		public DataTable SelecionaTodosUsuarios()
		{
			DataTable dt = new DataTable();
			try
			{
				AcessoBD bd = new AcessoBD();
				bd.Conectar();

				dt = bd.RetDataTable("SELECT idusuario,usuario,senha FROM tbl_login" );
			}
			catch (Exception ex)
			{
				throw new Exception("Erro ao tentar selecionar todos os clientes: " + ex.Message);
			}
			finally
			{
				bd = null;
			}
			return dt;
		}

		public DataTable PesquisarUsuario(UsuarioDTO dto)
		{
			DataTable dt = new DataTable();
			try
			{
				AcessoBD bd = new AcessoBD();
				bd.Conectar();

				dt = bd.RetDataTable("SELECT * FROM tbl_login WHERE usuario LIKE '%" + dto.Usuario + "%' ORDER BY usuario");
			}
			catch (Exception ex)
			{
				throw new Exception("Erro ao tentar pesquisar usuário: " + ex.Message);
			}
			finally
			{
				bd = null;
			}
			return dt;
		}
	}
}
