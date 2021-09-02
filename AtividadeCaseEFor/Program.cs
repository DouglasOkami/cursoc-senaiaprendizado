using System;

namespace AtividadeCaseEFor
{
    class Program
    {  static void Main(string[] args)
        {
            int[] numerosInteiros = new int[10];
            int soma = 0;

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Insira o {i + 1}º de 10 valores");
                numerosInteiros[i] = int.Parse(Console.ReadLine());
            
                soma += numerosInteiros[i]; 
            }
                Console.WriteLine($"a soma dos valores é: {soma}");
        }
    }
}