using System;

namespace quartoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notas e Média final");
            // Atividade 
            // Dados de entrada

            Console.WriteLine("Digite o primeiro nota");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo nota");
            double nota2 = double.Parse(Console.ReadLine());

             Console.WriteLine("Digite o terceira nota");
            double nota3 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o quarta nota");
            double nota4 = double.Parse(Console.ReadLine());

            
            // double resultadoDivisão = numeroUm/numeroDois
            double soma = (nota1+nota2+nota3+nota4)/4;

            Console.WriteLine("Média Final Ano = "+soma);

        }
    }
}
