using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            return View();
        }//fim IAction
        [Route("Cadastro")]
        public IActionResult Cadastro()
        {
            return View();
        }// Fim Cadastro

    }//fim class
}