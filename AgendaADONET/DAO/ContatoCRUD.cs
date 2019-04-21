using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaADONET.DAO
{
    public class ContatoCRUD
    {
        //Carregar contato no form
        public DataTable GetContatos()
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM tbl_aluno";
            DbDataReader reader = DAOUtils.GetDataReader(comando);

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            return dataTable;
        }
        //Excluir Contato
        public void Excluir(int id)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM tbl_aluno WHERE id_aluno = @id";
            comando.Parameters.Add(new MySqlParameter("@id", id));

            comando.ExecuteNonQuery();
        }
    }
}
