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
    public class Professor : UsuarioBase, IProfessores
    {
        public string Cargo {get;set;}

        public void AtualizarProf(Professor professor)
        {
            var connection = Conexao.GetSqlConnection();
            connection.Open();

            var query = "update professores set professorNome = @nome, professorEmail = @email, professorEndereco = @endereco, professorTelefone = @telefone, professorCargo = @cargo where professorId =@id";
            var command = new SqlCommand(query, connection);

            command.Parameters.Add("@nome", SqlDbType.VarChar).Value = professor.Nome;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = professor.Email;
            command.Parameters.Add("@endereco", SqlDbType.VarChar).Value = professor.Endereco;
            command.Parameters.Add("@telefone", SqlDbType.VarChar).Value = professor.Telefone;
            command.Parameters.Add("@cargo", SqlDbType.VarChar).Value = professor.Cargo;
            command.Parameters.Add("@id", SqlDbType.Int).Value = professor.Id;
            command.ExecuteNonQuery();
        }

        public List<Professor> BuscarPorId(int id)
        {
            var connection = Conexao.GetSqlConnection();
            connection.Open();

            var query = "select * from professores where professorId = @id";
            var command = new SqlCommand(query, connection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            var dataSet = new DataSet();
            var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataSet);

            var rows = dataSet.Tables[0].Rows;

            List<Professor> listaProfessores = new List<Professor>();

            foreach (DataRow item in rows)
            {
                var colunas = item.ItemArray;

                Professor professor = new Professor();

                professor.Id = int.Parse(colunas[0].ToString());
                professor.Nome = colunas[1].ToString();
                professor.Email = colunas[2].ToString();
                professor.Endereco = colunas[3].ToString();
                professor.Telefone = colunas[4].ToString();
                professor.Cargo = colunas[5].ToString();
                listaProfessores.Add(professor);
            }
            connection.Close();
            return listaProfessores;
        }

        public Professor CadastrarProf(Professor professor)
        {
            try
            {
                //Definir a conexão - Precisamos criar a classe de conexão
                var connection = Conexao.GetSqlConnection();
                connection.Open();
                //Agora vamos definir o comando SQL
                var query = "Insert into professores (professorNome, professorEmail , professorEndereco, professorTelefone, professorCargo) values (@nome, @email, @endereco, @telefone, @cargo)";
                var command = new SqlCommand(query, connection);

                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = professor.Nome;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = professor.Email;
                command.Parameters.Add("@endereco", SqlDbType.VarChar).Value = professor.Endereco;
                command.Parameters.Add("@telefone", SqlDbType.VarChar).Value = professor.Telefone;
                command.Parameters.Add("@cargo", SqlDbType.VarChar).Value = professor.Cargo;
                command.ExecuteNonQuery();

                connection.Close();
                return professor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Professor> ListarProf()
        {
            try
            {
                //Definir a conexão - Precisamos criar a classe de conexão
                var connection = Conexao.GetSqlConnection();
                connection.Open();
                //query
                var query = "select * from professores";
                var command = new SqlCommand(query, connection);
                var dataSet = new DataSet();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet);

                var rows = dataSet.Tables[0].Rows;

                List<Professor> listaDeProfessores = new List<Professor>();
                foreach (DataRow item in rows)
                {
                    Professor professor = new Professor();
                    var colunas = item.ItemArray;
                    professor.Id = int.Parse(colunas[0].ToString());
                    professor.Nome = colunas[1].ToString();
                    professor.Email = colunas[2].ToString();
                    professor.Endereco = colunas[3].ToString();
                    professor.Telefone = colunas[4].ToString();
                    professor.Cargo = colunas[5].ToString();

                    listaDeProfessores.Add(professor);
                }//fim foreach
                connection.Close();
                return listaDeProfessores;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RemoverProf(int id)
        {
            var connection = Conexao.GetSqlConnection();
            connection.Open();
            var query = "delete from professores where professorId = @Id";
            var command = new SqlCommand(query, connection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.ExecuteNonQuery();
        }
    }
}
