using Microsoft.Data.SqlClient;
using MVCRazerCRUD.Context;
using MVCRazerCRUD.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRazerCRUD.Models
{
    public class Aluno : UsuarioBase , IAluno
    {
        public string Escolaridade { get; set; }

        public void AtualizarAluno(Aluno aluno)
        {
            var connection = Conexao.GetSqlConnection();
            connection.Open();

            var query = "update alunos set alunoNome = @nome, alunoEmail = @email, alunoEndereço = @endereco, alunoTelefone = @telefone, alunoEscolaridade = @escolaridade where alunoId =@id";
            var command = new SqlCommand(query, connection);

            command.Parameters.Add("@nome", SqlDbType.VarChar).Value = aluno.Nome;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = aluno.Email;
            command.Parameters.Add("@endereco", SqlDbType.VarChar).Value = aluno.Endereco;
            command.Parameters.Add("@telefone", SqlDbType.VarChar).Value = aluno.Telefone;
            command.Parameters.Add("@escolaridade", SqlDbType.VarChar).Value = aluno.Escolaridade;
            command.Parameters.Add("@id", SqlDbType.Int).Value = aluno.Id;
            command.ExecuteNonQuery();
        }

        public List<Aluno> BuscarPorId(int id)
        {
            var connection = Conexao.GetSqlConnection();
            connection.Open();

            var query = "select * from alunos where alunoId = @id";
            var command = new SqlCommand(query, connection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            var dataSet = new DataSet();
            var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataSet);

            var rows = dataSet.Tables[0].Rows;

            List<Aluno> listaAlunos = new List<Aluno>();

            foreach (DataRow item in rows)
            {
                var colunas = item.ItemArray;

                Aluno aluno = new Aluno();

                aluno.Id = int.Parse(colunas[0].ToString());
                aluno.Nome = colunas[1].ToString();
                aluno.Email = colunas[2].ToString();
                aluno.Endereco = colunas[3].ToString();
                aluno.Telefone = colunas[4].ToString();
                aluno.Escolaridade = colunas[5].ToString();
                listaAlunos.Add(aluno);
            }
            connection.Close();
            return listaAlunos;
        }
        public Aluno CasdastrarAluno(Aluno aluno)
        {
            try
            {
                //Definir a conexão - Precisamos criar a classe de conexão
                var connection = Conexao.GetSqlConnection();
                connection.Open();
                //Agora vamos definir o comando SQL
                var query = "Insert into alunos (alunoNome, alunoEmail, alunoEndereço, alunoTelefone, alunoEscolaridade) values (@nome, @email, @endereco, @telefone, @escolaridade)";
                //Agora vamos juntar a query com a conexão
                var command = new SqlCommand(query, connection);
                //Agora vamos atribuir os valores para as variáveis - Formato CamelCase
                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = aluno.Nome;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = aluno.Email;
                command.Parameters.Add("@endereco", SqlDbType.VarChar).Value = aluno.Endereco;
                command.Parameters.Add("@telefone", SqlDbType.VarChar).Value = aluno.Telefone;
                command.Parameters.Add("@escolaridade", SqlDbType.VarChar).Value = aluno.Escolaridade;
                //Agora vamos executar a query
                command.ExecuteNonQuery();

                connection.Close();
                return aluno;
            }
            catch (Exception)
            {
                throw;
            }
        }//Fim Cadastrar
        public List<Aluno> ListarAluno()
        {
            try
            {
                //Definir a conexão - Precisamos criar a classe de conexão
                var connection = Conexao.GetSqlConnection();
                connection.Open();
                //query
                var query = "select * from alunos";
                var command = new SqlCommand(query, connection);
                var dataSet = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet);

                var rows = dataSet.Tables[0].Rows;

                List<Aluno> listaDeAlunos = new List<Aluno>();
                foreach (DataRow item in rows)
                {
                    Aluno aluno = new Aluno();
                    var colunas = item.ItemArray;
                    aluno.Id = int.Parse(colunas[0].ToString());
                    aluno.Nome = colunas[1].ToString();
                    aluno.Email = colunas[2].ToString();
                    aluno.Endereco = colunas[3].ToString();
                    aluno.Telefone = colunas[4].ToString();
                    aluno.Escolaridade = colunas[5].ToString();

                    listaDeAlunos.Add(aluno);
                }//fim foreach
                connection.Close();
                return listaDeAlunos;
            }
            catch(Exception)
            {
                throw;
            }
        }// fim ListarAluno
        public void RemoverAluno(int id)
        {
            var connection = Conexao.GetSqlConnection();
            connection.Open();
            var query = "delete from alunos where alunoId = @Id";
            var command = new SqlCommand(query, connection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            //Aqui executamos a query no banco de dados
            command.ExecuteNonQuery();
        }//fim remover aluno
    }
}
