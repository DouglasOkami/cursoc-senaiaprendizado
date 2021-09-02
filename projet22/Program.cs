using System;

namespace projeto22
{
    class Program
    {
        static void Main(string[] args)
        {

            double maior = 0, menor = 0;
            double[] temp = new double[12];

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"Digite a temperatura do {i + 1}º mes de 12 meses");
                temp[i] = double.Parse(Console.ReadLine());
                if (i == 0)
                {
                    menor = temp[0];
                    maior = temp[0];
                }
                if (temp[i] > maior)
                {
                    maior = temp[i];
                }
                else if(temp[i] < menor)
                {
                    menor = temp[i] ;   
                }//fim else
            }// fim for
            Console.WriteLine($"A menor temperatura de todos os meses foi: {menor}");
            Console.WriteLine($"A maior temperatura de todos os meses foi: {maior}");
        }
    }
}