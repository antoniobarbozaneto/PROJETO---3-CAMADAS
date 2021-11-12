using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETO___3_CAMADAS.CODE.DAL
{
    class AcessoBD
    {
        private SqlConnection conn;
        private DataTable data;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private SqlCommandBuilder cb;

        public void Conectar() //METODO ABIR E FECHAR CONEXÃO E CONECTAR COM O BANCO.
        {
            if (conn != null) // SE A CONEXÃO ESTIVER NULA, FECHA!
                conn.Close();

            string connStr = String.Format("Data Source=NETO-PC;Initial Catalog=BDBACCA;Integrated Security=True"); // MUDAR SEMPRE O BANCO QUANDO FOR MEXER NA LOJA OU EM CASA.

            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();// ABRE A CONEXÃO QUE ESTÁ FECHADA.
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        
        public void ExecutarComandoSQL(string comandosql) //METODO EXECUTAR COMANDO!
        {
            SqlCommand comando = new SqlCommand(comandosql, conn);
            comando.ExecuteNonQuery();
            conn.Close();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        
        public DataTable RetDataTable(string sql) //retorna uma tabela. espera como parametro um comando sql.
        {
            DataTable data = new DataTable();
            da = new SqlDataAdapter(sql, conn);
            cb = new SqlCommandBuilder(da);
            da.Fill(data);

            return data;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////

        public SqlDataReader RetDataReader(string sql)
        {
            SqlCommand comando = new SqlCommand(sql, conn);
            SqlDataReader dr = comando.ExecuteReader();
            dr.Read();

            return dr;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////

    }
}
