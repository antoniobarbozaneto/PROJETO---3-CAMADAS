using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PROJETO___3_CAMADAS.CODE.DAL;
using PROJETO___3_CAMADAS.CODE.DTO;

namespace PROJETO___3_CAMADAS.CODE.BLL
{
	class FornecedorBLL
	{
		AcessoBD bd = new AcessoBD();

		public void Inserir(FornecedorDTO dto)
		{
			try
			{
				AcessoBD bd = new AcessoBD();
				bd.Conectar();
				string comando = "INSERT INTO tbl_fornecedor (nomefantasia,razaosocial,cnpj,ie,endereco,numero,bairro,cidade,estado,cep,telefoneum,telefonedois,celularum,celulardois,fax,email,emailenfe,ramoatividade,observacao) VALUES ('" + dto.Nomefantasia + "','" + dto.Razaosocial + "','" + dto.Cnpj + "','" + dto.Ie + "','" + dto.Endereco + "','" + dto.Numero + "','" + dto.Bairro + "','" + dto.Cidade + "','" + dto.Estado + "','" + dto.Cep + "','" + dto.Telefoneum + "','" + dto.Telefonedois + "','" + dto.Celularum + "','"+ dto.Celulardois +"','" + dto.Fax + "','" + dto.Email + "','" + dto.Emailenfe + "','" + dto.Ramoatividade + "','" + dto.Observacao + "')";
				bd.ExecutarComandoSQL(comando);
			}
			catch (Exception ex)
			{
				throw new Exception("Não foi possível cadastrar o forncedor: " + ex.Message);
			}
			finally 
			{
				bd = null;
			}			
		}

		public void Editar(FornecedorDTO dto)
        {
			try //tentar a execução do cadastro. TRATAR O ERRO.
			{
				//string nome = dto.Nome.Replace("'", "''"); // (Tem q substituir a variavel no INSERT). tratar o erro caso um nome tenha apóstrofo.
				AcessoBD bd = new AcessoBD(); //criar um novo objeto quando entrar no try.
				bd.Conectar(); //usar metodo conectar
				string comando = "UPDATE tbl_fornecedor SET nomefantasia = '"+ dto.Nomefantasia+ "', razaosocial ='" +dto.Razaosocial+ "', cnpj ='" +dto.Cnpj+ "', ie ='" +dto.Ie+ "', endereco ='" +dto.Endereco+ "', numero ='" +dto.Numero+ "', bairro ='" +dto.Bairro+ "', cidade ='" +dto.Cidade+ "', estado ='" +dto.Estado+ "', cep ='" +dto.Cep+ "', telefoneum ='" +dto.Telefoneum+ "', telefonedois ='" +dto.Telefonedois+ "', celularum ='" +dto.Celularum+ "', celulardois ='" +dto.Celulardois+ "', fax ='" +dto.Fax+ "', email ='" +dto.Email+ "', emailenfe ='" +dto.Emailenfe+ "', ramoatividade ='" +dto.Ramoatividade+ "', observacao ='"+dto.Observacao+ "' WHERE codigo = " +dto.Codigo;
				bd.ExecutarComandoSQL(comando); //criar metodo executar comando
			}
			catch (Exception ex)
			{
				throw new Exception("Não foi possível Editar o cadastro do fornecedor: " + ex.Message); //Mostrar a mensagem de erro pro usuário.
			}
			finally //esse bloco é executado sempre, caindo no try ou no catch.
			{
				bd = null; //estou mantando esse objeto.
			}
		}

		public void Excluir(int CodFornecedor)
        {
			try //tentar a execução do cadastro. TRATAR O ERRO.
			{
				AcessoBD bd = new AcessoBD(); //criar um novo objeto quando entrar no try.
				bd.Conectar(); //usar metodo conectar
				string comando = "DELETE FROM tbl_fornecedor WHERE codigo = " + CodFornecedor; //Comando DELETAR 
				bd.ExecutarComandoSQL(comando); //criar metodo executar comando
			}
			catch (Exception ex)
			{
				throw new Exception("Não foi possível Excluir o cadastro do fornecedor: " + ex.Message); //Mostrar a mensagem de erro pro usuário.
			}
			finally //esse bloco é executado sempre, caindo no try ou no catch.
			{
				bd = null; //estou mantando esse objeto.
			}
		}

		public DataTable SelecionaTodosFornecedores()
		{
			DataTable dt = new DataTable();
			try
			{
				AcessoBD bd = new AcessoBD();
				bd.Conectar();

				dt = bd.RetDataTable("SELECT codigo, nomefantasia,razaosocial,cnpj,ie,endereco,numero,bairro,cidade,estado,cep,telefoneum,telefonedois,celularum,celulardois,fax,email,emailenfe,ramoatividade,observacao FROM tbl_fornecedor");
			}
			catch (Exception ex)
			{
				throw new Exception("Erro ao tentar selecionar todos os fornecedores:" + ex.Message); //Mostrar pra o usuário caso der erro ao tentar selecionar todos os clientes.
			}
			finally
			{
				bd = null;
			}

			return dt;
		}

		public DataTable PesquisaFornecedores(FornecedorDTO dto)
        {
			DataTable dt = new DataTable();
			try
			{
				AcessoBD bd = new AcessoBD();
				bd.Conectar();

				dt = bd.RetDataTable("SELECT * FROM tbl_fornecedor WHERE nomefantasia LIKE '%" + dto.Nomefantasia + "%' ORDER BY nomefantasia");
			}
			catch (Exception ex)
			{
				throw new Exception("Erro ao tentar pesquisar o fornecedor:" + ex.Message); //Mostrar pra o usuário caso der erro ao tentar pesquisar todos os clientes.
			}
			finally
			{
				bd = null;
			}
			return dt;
        }
	}
}
