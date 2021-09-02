using System;

namespace QuintoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque o ano atual e o ano em que você nasceu, pra saber quantas semana você vive!!");
            // Dados de entrada
            Console.WriteLine("Digite data do ano Atual");
            int anoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite data de nascimento ");
            int anoDeNascimento = int.Parse(Console.ReadLine());

            // processamento

            int idade = anoAtual - anoDeNascimento;
            
            //Condicional
            if(idade>=18){
                // Console.writeLine("Liberado!")
                Console.WriteLine("O Clinte possui o ingresso (Sim ou Não)?");
                string resposta = Console.ReadLine();
                if(resposta == "sim"){

                    Console.WriteLine("Liberado Acesso");
                }else{

                Console.WriteLine("Encaminhar para a bilheteria!");}

            }else{
                Console.WriteLine("Vai estudar depois diversão");
            }
        }
    }
}
