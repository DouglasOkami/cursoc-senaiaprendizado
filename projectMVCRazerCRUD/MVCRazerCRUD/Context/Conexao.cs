using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRazerCRUD.Context
{
    public class Conexao
    {
        private static string ConnStr = @"Data Source=LAB07-PC09\SERVIDORTARDE;Initial Catalog=EscolaSenai;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            var conn = new SqlConnection(ConnStr);
            return conn;
        }//fim Connection
    }
}
