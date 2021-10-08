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
            ViewBag.ListaDeProfessores = professorModel.ListarProf();
            return View();
        }
        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection formulario)
        {
            Professor professor = new Professor();
            //Vamos receber os dados do formulário 
            professor.Nome = formulario["professorNome"];
            professor.Email = formulario["professorEmail"];
            professor.Endereco = formulario["professorEndereco"];
            professor.Telefone = formulario["professorTelefone"];
            professor.Cargo = formulario["professorCargo"];

            professor.CadastrarProf(professor);
            return LocalRedirect("/");
        }
        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection formulario)
        {
            Professor professor = new Professor();
            //Vamos receber os dados do formulário 
            professor.Id = int.Parse(formulario["professorId"]);
            professor.Nome = formulario["professorNome"];
            professor.Email = formulario["professorEmail"];
            professor.Endereco = formulario["professorEndereco"];
            professor.Telefone = formulario["professorTelefone"];
            professor.Cargo = formulario["professorCargo"];

            professor.AtualizarProf(professor);
            return LocalRedirect("/");
        }
        [Route("Cadastro")]
        public IActionResult Cadastro()
        {
            return View();
        }// Fim Cadastro
        [Route("~/Professor/Remover/{id}")]
        public IActionResult Remover(int id)
        {
            professorModel.RemoverProf(id);
            return LocalRedirect("/Professor");
        }//fim Remover
        [Route("~/Professor/Editar/{id}")]
        public IActionResult Editar(int id)
        {
            var listaRetornada = professorModel.BuscarPorId(id);
            var professorRetornado = listaRetornada.Find(professor => professor.Id == id);

            ViewBag.professorRetornado = professorRetornado;

            return View();
        }//fim Editar





    }
}
