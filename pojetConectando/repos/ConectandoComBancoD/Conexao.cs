using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectandoComBancoD
{
    class Conexao
    {
        //Aqui vai a string para acessar o banco
        private static string ConnStr = @"Data Source=LAB07-PC09\SERVIDORTARDE;Initial Catalog=BancoDeDados;Integrated Security=True";

        //método para conectar com a base de dados
        public static SqlConnection GetConnection()
        {

            var conn = new SqlConnection(ConnStr);
            return conn;
        }
    }
}
