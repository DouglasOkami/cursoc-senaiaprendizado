using System;

namespace tabuada_DoCem
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Console.WriteLine("Digite um número , vamos faz uma tabuada de 1 a 100 desse número!");
            int numero = int.Parse(Console.ReadLine());
           while (contador < 100){
             
             Console.WriteLine($"{numero} X {contador} = {numero*contador}");
             // Console.white
             contador++;
           }// fim while
        }// fim
    }
}
