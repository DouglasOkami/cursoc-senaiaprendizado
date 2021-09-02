using System;

namespace condicionalDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora dois digitos");

            Console.WriteLine("Digite o primerio valor");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            double numero2 = double.Parse(Console.ReadLine()); 

            Console.WriteLine("Qual operação gostaria de fazer?");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            double resposta = double.Parse(Console.ReadLine());

            double resultado = 0;
            // bool poder ser true ou false 
            bool validacao = true;

            if(resposta == 1){
                resultado = numero1 + numero2;
            }else if(resposta == 2){
                resultado = numero1 - numero2;
            }else if(resposta == 3){
                resultado = numero1 / numero2;
            }else if(resposta == 4){
                 resultado = numero1 * numero2;
            }else{
                Console.WriteLine("Opção Inválida");
                validacao = false;
            }
            if(validacao == true){
            Console.WriteLine("O resultado = "+resultado);
            }
        }
    }
}