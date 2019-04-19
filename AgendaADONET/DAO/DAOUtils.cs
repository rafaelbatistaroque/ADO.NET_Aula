using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaADONET.DAO
{
    class DAOUtils
    {
        public static DbConnection GetConexao()
        {
            string strConexao = @"Server=localhost;Database=db_dev;Uid=root;Pwd=;";
            DbConnection conexao = new MySqlConnection(strConexao);
            conexao.Open();
            return conexao;
        }
        public static DbCommand GetComando(DbConnection conexao)
        {
            DbCommand comando = conexao.CreateCommand();
            return comando;
        }
        public static DbDataReader GetDataReader(DbCommand comando)
        {
            return comando.ExecuteReader();
        }
    }
}
