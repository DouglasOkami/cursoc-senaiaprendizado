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
        Aluno AlterarAluno(Aluno aluno);
        Aluno RemoverAluno(int id);

    }
}
