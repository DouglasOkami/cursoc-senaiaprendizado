using MVCRazerCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRazerCRUD.Interfaces
{
    interface IAluno
    {
        Aluno CasdastrarAluno(Aluno aluno);
        List<Aluno> ListarAluno();
        List<Aluno> BuscarPorId(int id);
        void RemoverAluno(int id);
        void AtualizarAluno(Aluno aluno);
    }
}
