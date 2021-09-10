using System;
using System.Threading;

namespace projetoCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando uma instância do celular

            Celular smartPhome = new Celular();
            smartPhome.modelo = "Iphone XX";
            smartPhome.cor = "Black";
            smartPhome.tamanho = "49 polegadas";

            do
            {
                Console.Clear();
                if (smartPhome.StatusDoCelular() == true)
                {
                    Console.Write("Status: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ligando");
                }
                else
                {
                    Console.Write("Status: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Desligando");
                }
                Console.WriteLine(smartPhome.StatusDoCelular());
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("1 - Ligar o celular");
                Console.WriteLine("2 - Desligar o celular");
                Console.WriteLine("3 - Efetuar ligação");
                Console.WriteLine("4 - Enviar mensagem");
                Console.WriteLine("5 - Sobre o dispositivo");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        //chamar o método de ligar
                        smartPhome.Ligar();
                        Theread.Sleep(3000);
                        break;
                    case "2":
                        //chamar o método de desligar
                        smartPhome.Desligar();
                        Theread.Sleep(3000);
                        break;
                    case "3":
                        //chamar o método de EfetuarLicação
                        smartPhome.EfetuarLigação();
                        Theread.Sleep(3000);
                        break;
                    case "4":
                        //chamar o método de EnviarMensagem
                        smartPhome.EnviarMensagem();
                        Theread.Sleep(3000);
                        break;
                    case "5":
                        //chamar o método do Sobre
                        smartPhome.Sobre();
                        Theread.Sleep(3000);
                        break;
                    default:
                        break;
                }

            } while (true);
        }
    }
}
