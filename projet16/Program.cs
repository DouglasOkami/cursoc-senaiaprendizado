using System;

namespace AtividadePessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0, aprovado = 0, reprovado = 0, somaIdades = 0;
            do
            {
                Console.WriteLine("Digite a idade de " + (10 - contador) + " pessoas");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 18)
                {
                    aprovado = aprovado + 1;
                }
                else
                {
                    reprovado = reprovado + 1;
                }
                somaIdades = somaIdades + idade;
                double media = somaIdades / contador;
                contador = contador + 1;
            } while (contador < 10);
            Console.WriteLine("Pessoas com maior de 18 são " + aprovado + " e pessoas com menor de " + reprovado);
        }
    }
}
