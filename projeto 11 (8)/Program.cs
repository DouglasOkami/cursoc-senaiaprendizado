using System;

namespace calculadora2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primerio número");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escola a forma a operação (+ - * / )? ");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o segundo número");
            double numero2 = double.Parse(Console.ReadLine());

            double resultado = 0;
            bool validador = true;
            switch (operacao)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    if(numero2 == 0){
                        Console.WriteLine("Impossível dividir por zero");
                    }else{
                    resultado = numero1 / numero2;}
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    validador = false;
                    break;
            }
            if (validador == true){
                Console.WriteLine("O resultado é = " + resultado + " !");
            }
        }// fim main
    }
}
