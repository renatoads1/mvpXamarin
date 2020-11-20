using MySql.Data.MySqlClient;
using System;

namespace AppMatur2020
{
    internal class MysqlCommand
    {
        private string sqlQuery;
        private Conexao con;
        private MySqlConnection con1;

        public MysqlCommand(string sqlQuery, Conexao con)
        {
            this.sqlQuery = sqlQuery;
            this.con = con;
        }

        public MysqlCommand(string sqlQuery, MySqlConnection con1)
        {
            this.sqlQuery = sqlQuery;
            this.con1 = con1;
        }

        public static implicit operator MySqlCommand(MysqlCommand v)
        {
            throw new NotImplementedException();
        }
    }
}