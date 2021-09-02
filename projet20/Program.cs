using System;

namespace lacoDeRepeticao2
{
    class Program
    {
        static void Main(string[] args)
        {
            // While () e Do wile();

            Console.WriteLine("Digite o nome de usúario:");
            string usuario = Console.ReadLine();
            // usuário dor diferente de dev
            while (usuario != "dev")// se a condição for verdadeira então ele abre o laço
            {
                // aqui fica o contrúdo do laço
                Console.WriteLine("Usuário Inválido");
                Console.WriteLine("Digite novamente o nome do usuário");
                usuario = Console.ReadLine();
            }// fim while

            string senha = "";
            string conta = "";
            // Do while - executa ao menos uma vez o laço 
            int contador = 0;
            do
            {
                // inscremento 
                if (contador < 3)
                {
                    Console.WriteLine("Digite a senha:");
                    senha = Console.ReadLine();
                    contador = contador + 1;
                }
                else
                {
                    Console.WriteLine("Conta Bloqueada");
                    conta = "Bloqueada";
                    break;
                }
            } while (senha != "dev@123");
            if (conta == "Bloqueada")
            {
                Console.WriteLine("Entre em contato com o gerente");
            }
            else
            {
                Console.WriteLine("Aqui está o acesso a sua conta");
            }
     
        }// fim
    }
}
