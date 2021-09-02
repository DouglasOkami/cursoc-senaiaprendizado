using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade para sabermos qual categoria vai fazer parte");
            double idade = double.Parse(Console.ReadLine());    

            if(idade >= 18){
                Console.WriteLine("Sua categoria é Sênior");
            }else if(idade >= 14){
                Console.WriteLine("Sua categoria é Juvenil B");
            }else if(idade >= 11){
                Console.WriteLine("Sua categoria é Juvenil A");
            }else if(idade >= 8){
                Console.WriteLine("Sua categoria é Infatil B");
            }else if(idade >= 5){
                Console.WriteLine("Sua categoria é Infatil A");
            }else{
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("idade insuficiente pra participar do torneio");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
        }// fim main
    }
}
