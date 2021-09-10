using System;

namespace funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lembrando que os benéficios so seram pra sálarios com valor abaixo de 500 reais");
            Console.WriteLine("Por favor digite seu sálario");
            double valorSalario = double.Parse(Console.ReadLine());

            if(valorSalario < 500){
                double salarioReajustado = valorSalario + (valorSalario * 0.3);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("O seu benéficio foi de = "+ salarioReajustado);
                Console.ForegroundColor = ConsoleColor.Blue;
            }else{
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Você não possui reajuste!");
                Console.ForegroundColor = ConsoleColor.Black;  
            }
        }
    }
}
