using System;
using projectCarros.Usuarios;
using System.Collections.Generic;

namespace projectCarros.Controllers
{
    public class UsuarioController
    {
        public Usuario CadatroDeUsuarios()
        {
            Console.WriteLine($"Digite o nome do usuário");
            string nome = Console.ReadLine();

            Console.WriteLine($"Digite um email");
            string emails  = Console.ReadLine();

            Console.WriteLine($"Digite uma senha;");
            string senha = Console.ReadLine();

            Console.WriteLine($"Digite seu CPF");
            int cpf = int.Parse(Console.ReadLine());

            Usuario usuario = new Usuario(nome, emails, senha, cpf);

            return usuario;
        }//fim Cadastrar
         public void ListarUsurios(List<Usuario> lista){
            foreach (var item in lista)
            {
                Console.WriteLine($"Nome: {item.Nome} Email: {item.Emails} CPF: {item.Cpf} Senha: {item.Senha}");
            }
        }//Fim Listar
    }//Fim UsurioController
}