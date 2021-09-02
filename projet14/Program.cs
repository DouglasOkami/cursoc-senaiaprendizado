using System;

namespace AtividadeDowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0, soma = 0;
            do
            {
                Console.WriteLine("Digite um número inteiro");
                int numero = int.Parse(Console.ReadLine());
                soma = soma + numero; // Incrementa a soma com o valor do número digitado
                contador = contador + 1;// Incrementa um ao contador
            } while (contador < 10);
            Console.WriteLine($"resultado da soma = {soma}");
        }
    }
}
