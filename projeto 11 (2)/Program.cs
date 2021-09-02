using System;

namespace arraysBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com Arrays");

            string[] nomes = new string[3];
            string[] sobrenome = new string[3];

            nomes[0] = "Lucas";
            nomes[1] = "Caio";
            nomes[2] = "Nicolas";

            sobrenome[0] = "Leite";
            sobrenome[1] = "Bezerra";
            sobrenome[2] = "Dornellas";

            int[] idades = {20 , 48 , 28};

            Console.WriteLine("Nomes cadastrados");

            Console.WriteLine("Qual nome você gostaria de visualizar");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"{nomes[numero]} {sobrenome[numero]} {idades[numero]}");


        }
    }
}
