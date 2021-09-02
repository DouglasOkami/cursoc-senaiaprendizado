using System;

namespace babaca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------");

            int num1 = int.Parse(Console.ReadLine());

            int num2 = int.Parse(Console.ReadLine());


            //saida
            int Resultad = num1 + num2;

            Console.WriteLine("Resultado " +Resultad);

            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            //saida

            int Valos = num3 * num4;

            Console.WriteLine("resultado = ()"+ Valos);

            int Carlos = Valos + Resultad;
            Console.WriteLine("total "+Carlos);
        }
    }
}
