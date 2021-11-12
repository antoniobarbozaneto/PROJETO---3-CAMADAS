using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJETO___3_CAMADAS.CODE.DTO;
using PROJETO___3_CAMADAS.CODE.DAL;
using System.Data;
using System.Windows.Forms;

namespace PROJETO___3_CAMADAS.CODE.BLL
{
    class ClienteBLL
    {
        AcessoBD bd;
        
        public void Inserir(ClienteDTO dto) //Metodo inserir cliente
        {
            try //tentar a execução do cadastro. TRATAR O ERRO.
            {
                string nome = dto.Nome.Replace("'", "''"); // (Tem q substituir a variavel no INSERT). tratar o erro caso um nome tenha apóstrofo.
                AcessoBD bd = new AcessoBD(); //criar um novo objeto quando entrar no try.
                bd.Conectar(); //usar metodo conectar
                string comando = "INSERT INTO tbl_cliente (nome,cpf,rg,endereco,numero,bairro,cidade,estado,cep,telefone,celular,email) VALUES ('" + nome + "','" + dto.Cpf + "','" + dto.Rg + "','" + dto.Endereco + "','" + dto.Numero + "','" + dto.Bairro + "','" + dto.Cidade + "','" + dto.Estado + "','" + dto.Cep + "','" + dto.Telefone + "','" + dto.Celular + "','" +  dto.Email + "')"; // comando inserir no banco
                bd.ExecutarComandoSQL(comando); //chamo o metodo executar comando passando o camando SQL que eu quero executar.
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível cadastrar o cliente: " + ex.Message); //Mostrar a mensagem de erro pro usuário.
            }
            finally //esse bloco é executado sempre, caindo no try ou no catch.
            {
                bd = null; //estou mantando esse objeto Conexão com o banco de dados.
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void Editar(ClienteDTO dto) // Metodo editar cliente.
        {
            try //tentar a execução do cadastro. TRATAR O ERRO.
            {
                string nome = dto.Nome.Replace("'", "''"); // (Tem q substituir a variavel no INSERT). tratar o erro caso um nome tenha apóstrofo.
                AcessoBD bd = new AcessoBD(); //criar um novo objeto quando entrar no try.
                bd.Conectar(); //usar metodo conectar
                string comando = "UPDATE tbl_cliente SET nome = '" + nome + "', cpf = '" + dto.Cpf + "', rg = '" + dto.Rg + "', endereco = '" + dto.Endereco + "', numero = '" + dto.Numero + "', bairro = '" + dto.Bairro + "', cidade = '" + dto.Cidade + "', estado = '" + dto.Estado + "', cep = '" + dto.Cep + "', telefone = '" + dto.Telefone + "', celular = '" + dto.Celular + "', email = '" + dto.Email + "' WHERE codigo = " + dto.Codigo; //UPDATE
                bd.ExecutarComandoSQL(comando); //criar metodo executar comando
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Editar o cadastro do cliente: " + ex.Message); //Mostrar a mensagem de erro pro usuário.
            }
            finally //esse bloco é executado sempre, caindo no try ou no catch.
            {
                bd = null; //estou mantando esse objeto.
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void Excluir(int Codcliente)//Metodo Excluir cliente
        {
            try //tentar a execução do cadastro. TRATAR O ERRO.
            {
                AcessoBD bd = new AcessoBD(); //criar um novo objeto quando entrar no try.
                bd.Conectar(); //usar metodo conectar
                string comando = "DELETE FROM tbl_cliente WHERE codigo = " + Codcliente; //Comando DELETAR 
                bd.ExecutarComandoSQL(comando); //criar metodo executar comando
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Excluir o cadastro do cliente: " + ex.Message); //Mostrar a mensagem de erro pro usuário.
            }
            finally //esse bloco é executado sempre, caindo no try ou no catch.
            {
                bd = null; //estou mantando esse objeto.
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public DataTable SelecionaTodosClientes() //uma função que retorna um valor, no casa um DATATABLE.
        {
            DataTable dt = new DataTable();
            try
            {                
                AcessoBD bd = new AcessoBD();
                bd.Conectar();

                dt = bd.RetDataTable("SELECT codigo,nome,cpf,rg,endereco,numero,bairro,cidade,estado,cep,telefone,celular,email FROM tbl_cliente");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar selecionar todos os clientes:" + ex.Message); //Mostrar pra o usuário caso der erro ao tentar selecionar todos os clientes.
            }
            finally
            {
                bd = null;
            }
            return dt;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public DataTable PesquisarClientes(ClienteDTO dto) //Método pesquisar cliente
        {
            DataTable dt = new DataTable();
            try
            {
                AcessoBD bd = new AcessoBD();
                bd.Conectar();

                dt = bd.RetDataTable("SELECT * FROM tbl_cliente WHERE nome LIKE '%" + dto.Nome + "%' ORDER BY nome");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar pesquisar o cliente:" + ex.Message); //Mostrar pra o usuário caso der erro ao tentar pesquisar todos os clientes.
            }
            finally
            {
                bd = null;
            }
            return dt;
        }
    }
}
