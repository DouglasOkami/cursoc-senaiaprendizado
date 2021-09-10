using System;

namespace Hamburgue
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            { Console.WriteLine("faça seu pedido");
            Console.WriteLine("Digite 1 para Hamburgue, 2 para Cheese Salada , 3 para Cheese Hamburgue, 4 para bacon");
            opcao = int.Parse(Console.ReadLine());
                
            } while (opcao <1 || opcao >4);
            

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Pedido entregue de Hamburgue");
                    break;
                case 2:
                    Console.WriteLine("Pedido entregue de Cheese Salada");
                    break;
                case 3:
                    Console.WriteLine("Pedido entregue de Cheese Humburgue");
                    break;
                case 4:
                    Console.WriteLine("Pedido entregue de Bacon");
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }        
        }
    }
}
