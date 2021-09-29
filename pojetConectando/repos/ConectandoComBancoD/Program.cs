using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ConectandoComBancoD
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuario = new Usuarios("marcelo", "marcelo@gmail.com", "1234");
            CadastrarUsuario(usuario);
        }//fim main
        static void TestarConexaoD()
        {
            try
            {
                //Tenta executar oque tem aqui dentro 
                var conn = Conexao.GetConnection();//aqui me retorna o link da conexão
                conn.Open();
                Console.WriteLine("Abriu a porta da esperança");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Mensagem de erro"+ex.Message);
            }
        }//Fim Testar
        static List<Usuarios> InserirNaLista()
        {
        //Criando lista para receber usuarios
            List<Usuarios> listaUsuarios = new List<Usuarios>();
            //criando objetos usuarios
            var u1 = new Usuarios("Carlos","carlos@gmail.com","1234");
            var u2 = new Usuarios("Douglas", "douglas@gmail.com", "4321");
            var u3 = new Usuarios("Dornellas", "dornellas@gmail.com", "5678");

            listaUsuarios.Add(u1);
            listaUsuarios.Add(u2);
            listaUsuarios.Add(u3);

            return listaUsuarios;
        }//fim 
        //vamos cadatrar um usuario no banco de dados
        static void CadastrarUsuario(Usuarios usuario)
        {
            try
            {
                var conn = Conexao.GetConnection();
                conn.Open();
                // vamos criar o query
                var query = "insert into usuarios (usuarioNome,usuarioEmail,usuarioSenha) values (@nome,@email,@senha)";
                var command = new SqlCommand(query, conn);//esse comando ainda não foi executado , somente solicitado.
                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = usuario.Nome;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = usuario.Email;
                command.Parameters.Add("@senha", SqlDbType.VarChar).Value = usuario.Senha;
                //finalizando o preenchimento da query
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("erro.."+ex.Message);
            }
        
        }//fim cadastrar

        static void CadastrarUsuario(List<Usuarios> listaUsuarios)
        {
            try
            {
                var conn = Conexao.GetConnection();
                conn.Open();

                foreach(var usuario in listaUsuarios)
                {
                    var query = "insert into usuarios (usuarioNome,usuarioEmail,usuarioSenha) values (@nome,@email,@senha)";
                    var command = new SqlCommand(query, conn);//esse comando ainda não foi executado , somente solicitado.
                    command.Parameters.Add("@nome", SqlDbType.VarChar).Value = usuario.Nome;
                    command.Parameters.Add("@email", SqlDbType.VarChar).Value = usuario.Email;
                    command.Parameters.Add("@senha", SqlDbType.VarChar).Value = usuario.Senha;
                    //finalizando o preenchimento da query
                    command.ExecuteNonQuery();
                }//fim foreach
                conn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro:"+ ex.Message);
            }
        }//fim ListaCadastrar
    }
}
