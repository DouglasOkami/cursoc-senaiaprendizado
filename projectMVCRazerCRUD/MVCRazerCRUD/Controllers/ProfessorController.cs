using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCRazerCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRazerCRUD.Controllers
{
    [Route("Professor")]
    public class ProfessorController : Controller
    {
        Professor professorModel = new Professor();
        public IActionResult Index()
        {

            return View();
        }
        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection formulario)
        {
            Professor professor = new Professor();
            //Vamos receber os dados do formulário 
            professor.Nome = formulario["alunoNome"];
            professor.Email = formulario["alunoEmail"];
            professor.Endereco = formulario["alunoEndereco"];
            professor.Telefone = formulario["alunoTelefone"];

            professor.CasdastrarProfessor(professor);
            return LocalRedirect("/");
        }

    }
}
