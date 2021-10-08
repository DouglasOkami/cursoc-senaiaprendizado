using MVCRazerCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRazerCRUD.Interfaces
{
    interface IProfessores
    {
        Professor CadastrarProf(Professor professsor);
        List<Professor> ListarProf();
        List<Professor> BuscarPorId(int id);
        void RemoverProf(int id);
        void AtualizarProf(Professor professor);
    }
}
