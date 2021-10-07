using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCRazerCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRazerCRUD.Controllers
{
    [Route("Aluno")]
    public class AlunoController : Controller
    {
        //Agora vamos criar o método para receber uma ação
        //e encaminhar para a view
        Aluno alunoModel = new Aluno();
        public IActionResult Index()
        {
            ViewBag.ListaDeAlunos = alunoModel.ListarAluno();
            return View();
        }//fim IAction

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection formulario)
        {
            Aluno aluno = new Aluno();
            //Vamos receber os dados do formulário 
            aluno.Nome = formulario["alunoNome"];
            aluno.Email = formulario["alunoEmail"];
            aluno.Endereco = formulario["alunoEndereco"];
            aluno.Telefone = formulario["alunoTelefone"];
            aluno.Escolaridade = formulario["alunoEscolaridade"];

            aluno.CasdastrarAluno(aluno);
            return LocalRedirect("/");
        }
        [Route ("Atualizar")]
        public IActionResult Atualizar(IFormCollection formulario)
        {
            Aluno aluno = new Aluno();
            //Vamos receber os dados do formulário 
            aluno.Id = int.Parse(formulario["alunoId"]);
            aluno.Nome = formulario["alunoNome"];
            aluno.Email = formulario["alunoEmail"];
            aluno.Endereco = formulario["alunoEndereco"];
            aluno.Telefone = formulario["alunoTelefone"];
            aluno.Escolaridade = formulario["alunoEscolaridade"];

            aluno.AtualizarAluno(aluno);
            return LocalRedirect("/");
        }

        [Route("Cadastro")]
        public IActionResult Cadastro()
        {
            return View();
        }// Fim Cadastro
        [Route("~/Aluno/{id}")]
        public IActionResult Remover(int id)
        {
            alunoModel.RemoverAluno(id);
            return LocalRedirect("/Aluno");
        }//fim Remover
        [Route("~/Aluno/Editar/{id}")]
        public IActionResult Editar(int id)
        {
            var listaRetornada = alunoModel.BuscarPorId(id);
            var alunoRetornado = listaRetornada.Find(aluno => aluno.Id == id);

            ViewBag.alunoRetornado = alunoRetornado;

            return View();
        }//fim Editar
    }//fim class
}