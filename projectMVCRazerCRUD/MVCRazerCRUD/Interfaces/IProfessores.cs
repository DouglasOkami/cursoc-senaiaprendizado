using MVCRazerCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRazerCRUD.Interfaces
{
    interface IProfessores
    {
        Professor CadastrarProf(Professor prof);
        List<Professor> ListarProf();
        List<Professor> BuscarPorId();
        void RemoverProf(int id);
        void AtualizarProf(int id);
    }
}
