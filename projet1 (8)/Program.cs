using System;

namespace terceiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              crie um programa que receba um número inteiro e calcule a tabuada desse número de 0 a 10
            */
            Console.WriteLine("Calcule a tabuada do número entregue");
            Console.WriteLine("Digite um número");
            //Entrada de dados
            double númeroInteiro = double.Parse(Console.ReadLine());
            //Segunda entrada de dados
            Console.WriteLine("E o resultado "+númeroInteiro+" é:");

            Console.WriteLine(númeroInteiro+" x 0 = "+númeroInteiro*0);
            Console.WriteLine(númeroInteiro+" x 1 = "+númeroInteiro*1);
            Console.WriteLine(númeroInteiro+" x 2 = "+númeroInteiro*2);
            Console.WriteLine(númeroInteiro+" x 3 = "+númeroInteiro*3);
            Console.WriteLine(númeroInteiro+" x 4 = "+númeroInteiro*4);
            Console.WriteLine(númeroInteiro+" x 5 = "+númeroInteiro*5);
            Console.WriteLine(númeroInteiro+" x 6 = "+númeroInteiro*6);
            Console.WriteLine(númeroInteiro+" x 7 = "+númeroInteiro*7);
            Console.WriteLine(númeroInteiro+" x 8 = "+númeroInteiro*8);
            Console.WriteLine(númeroInteiro+" x 9 = "+númeroInteiro*9);
            Console.WriteLine(númeroInteiro+" x 10 = "+númeroInteiro*10);

            Console.ReadLine();
        }
    }
}
