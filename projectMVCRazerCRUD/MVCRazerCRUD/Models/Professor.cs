using MVCRazerCRUD.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRazerCRUD.Models
{
    public class Professor : UsuarioBase, IProfessores
    {
        public string Cargo {get;set;}

        public void AtualizarProf(int id)
        {
            throw new NotImplementedException();
        }

        public List<Professor> BuscarPorId()
        {
            throw new NotImplementedException();
        }
        public Professor CadastrarProf(Professor prof)
        {
            throw new NotImplementedException();
        }

        public List<Professor> ListarProf()
        {
            throw new NotImplementedException();
        }

        public void RemoverProf(int id)
        {
            throw new NotImplementedException();
        }
    }
}
