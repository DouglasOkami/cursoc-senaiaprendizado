using MVCRazerCRUD.Interfaces;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
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
