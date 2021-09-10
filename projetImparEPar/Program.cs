using System;

namespace projet21
{
    class Program
    {
  
        static void Main(string[] args)
        {
            int[] par = new int[6];
            int[] impar = new int[6];
            int[] numero = new int[6];
            int contadorPar = 0, contadorImpar = 0;

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º de 6 numeros.");
                numero[i] = int.Parse(Console.ReadLine());
                if ((numero[i] % 2) == 0)
                {
                    par[contadorPar] = numero[i];
                    contadorPar++;
                }
                else
                {
                    impar[contadorImpar] = numero[i];
                    contadorImpar++;
                }
            }
            Console.WriteLine($"Os numeros pares são :");

            for (int i = 0; i < contadorPar; i++)
            {
                Console.Write($" {par[i]}, ");
            }

            Console.WriteLine($"\nOs numeros impares são :");

            for (int i = 0; i < contadorImpar; i++)
            {
                Console.Write($"{impar[i]}, ");
            }
        }
    }
}