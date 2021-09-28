using System;

namespace ConectandoComBancoD
{
    class Program
    {
        static void Main(string[] args)
        {
            TestarConexao();
        }//fim main
        static void TestarConexao()
        {
            try
            {
                //Tenta executar oque tem aqui dentro 
                var conn = Conexao.GetConnection();//aqui me retorna o link da conexão
                conn.Open();
                Console.WriteLine("Abriu a porta da esperança");
                conn.Close();
                Console.WriteLine("Fechou a porta da esperança");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Mensagem de erro"+ex.Message);
            }
        }//Fim Testar
    }
}
