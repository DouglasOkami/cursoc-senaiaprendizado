using System;

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BancoConectando
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuarios> listaRetornada = ListarUsuarios();
            ExibirListaDeUsuarios(listaRetornada);

            Console.WriteLine("FOI");
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
            catch (Exception ex)
            {
                Console.WriteLine("Mensagem de erro" + ex.Message);
            }
        }//Fim Testar
        static List<Usuarios> InserirNaLista()
        {
            //Criando lista para receber usuarios
            List<Usuarios> listaUsuarios = new List<Usuarios>();
            //criando objetos usuarios
            var u1 = new Usuarios("Carlos", "carlos@gmail.com", "1234");
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
                Console.WriteLine("erro.." + ex.Message);
            }

        }//fim cadastrar

        static void CadastrarUsuario(List<Usuarios> listaUsuarios)
        {
            try
            {
                var conn = Conexao.GetConnection();
                conn.Open();

                foreach (var usuario in listaUsuarios)
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
            catch (Exception ex)
            {
                Console.WriteLine("Erro:" + ex.Message);
            }
        }//fim ListaCadastrar

        //Agora vamos criar um método para buscar os dados no banco de dados
        static List<Usuarios> ListarUsuarios()
        {
            try
            {
                List<Usuarios> listaDeUsuarios = new List<Usuarios>();//lista vazia
                var conection = Conexao.GetConnection();
                conection.Open();
                //Comando que será executado no SQL
                var query = "select usuarioId, usuarioNome, usuarioEmail, usuarioSenha from usuarios";

                var command = new SqlCommand(query, conection);
                var dataset = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset);
                //aqui vai ficar a lista de usuarios do banco de dados
                var rows = dataset.Tables[0].Rows;
                //agora vamos inserir cada usuario da lista rowns dentro de uma lista de usuários List<Usuarios>
                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;
                    int id = int.Parse(colunas[0].ToString());
                    string nome = colunas[1].ToString();
                    string email = colunas[2].ToString();
                    string senha = colunas[3].ToString();
                    //Agora vamos construiu um objeto usuario com os dados
                    Usuarios usuario = new Usuarios(id, nome, email, senha);
                    //Agora vamos inserir esse usuário na lista
                    listaDeUsuarios.Add(usuario);
                }//fim foreach

                conection.Close();
                return listaDeUsuarios;
            }
            catch (Exception ex)
            {
                Console.WriteLine("OPS econtramos um erro:" + ex.Message);
                throw ex;
            }
        }// Fim Listar

        //Vamos criar um metódo para exibir os dados de uma lista de usuários

        static void ExibirListaDeUsuarios(List<Usuarios> listarDeUsuarios)
        {
            Console.WriteLine("Usuário Cadastrados");
            foreach (var item in listarDeUsuarios)
            {
                Console.WriteLine($"id: {item.Id} Nome: {item.Nome} Email: {item.Email} Senha: {item.Senha}");
            }
        }//fim Exibir
    }
}
