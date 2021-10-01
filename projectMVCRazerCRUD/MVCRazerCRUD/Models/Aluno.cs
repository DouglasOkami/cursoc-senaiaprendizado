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

        public Aluno AlterarAluno(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public Aluno CasdastrarAluno(Aluno aluno)
        {
            try
            {
                //Definir a conexão - Precisamos criar a classe de conexão
                var connection = Conexao.GetSqlConnection();
                connection.Open();
                //Agora vamos definir o comando SQL
                var query = "Insert into alunos (alunoNome, alunoEmail, alunoEndereco, alunoTelefone, alunoEscolaridade)";
                //Agora vamos juntar a query com a conexão
                var command = new SqlCommand(query, connection);
                //Agora vamos atribuir os valores para as variáveis - Formato CamelCase
                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = aluno.Nome;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = aluno.Email;
                command.Parameters.Add("@endereco", SqlDbType.VarChar).Value = aluno.Endereco;
                command.Parameters.Add("@telefone", SqlDbType.VarChar).Value = aluno.Telefone;
                command.Parameters.Add("@escolarida", SqlDbType.VarChar).Value = aluno.Escolaridade;
                //Agora vamos executar a query
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Aluno> ListarAluno()
        {
            throw new NotImplementedException();
        }

        public Aluno RemoverAluno(int id)
        {
            throw new NotImplementedException();
        }
    }
}
