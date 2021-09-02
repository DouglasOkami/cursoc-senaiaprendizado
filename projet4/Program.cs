using System;

namespace segundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma de dois números inteiros");
            Console.WriteLine("Digite o primeiro número");
            int numeroUm = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite se o segundo número");
            int numeroDois = int.Parse(Console.ReadLine());

            //Processamento

            int soma = numeroUm + numeroDois;

            //Saída

            Console.WriteLine("A soma dos valores = "+soma);
        
        }
    }
}
