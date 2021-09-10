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

            Celular celularThiago = new Celular();
            celularThiago.modelo = "Sansung";
            celularThiago.cor = "Red";
            celularThiago.tamanho = "9 polegadas";

            do
            {
                Console.Clear();
                if (smartPhome.StatusDoCelular() == true)
                {
                    Console.Write("Status: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ligando");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.Write("Status: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Desligando");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine(smartPhome.StatusDoCelular());
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("1 - Ligar o celular");
                Console.WriteLine("2 - Desligar o celular");
                Console.WriteLine("3 - Efetuar ligação");
                Console.WriteLine("4 - Enviar mensagem");
                Console.WriteLine("5 - Sobre o dispositivo");
                Console.WriteLine("6 - Sobre o dispositivo do Thiago");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        //chamar o método de ligar
                        smartPhome.Ligar();
                        celularThiago.Ligar();
                        Thread.Sleep(3000);
                        break;
                    case "2":
                        //chamar o método de desligar
                        smartPhome.Desligar();
                        Thread.Sleep(3000);
                        break;
                    case "3":
                        //chamar o método de EfetuarLicação
                        smartPhome.EfetuarLigacao();
                        Thread.Sleep(3000);
                        break;
                    case "4":
                        //chamar o método de EnviarMensagem
                        smartPhome.EnviarMensagem();
                        Thread.Sleep(3000);
                        break;
                    case "5":
                        //chamar o método do Sobre
                        smartPhome.Sobre();
                        Console.ReadKey();
                        break;
                    case "6":
                        // celularThiago.Sobre()
                        SobreCelular(celularThiago);
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }

            } while (true);
        }//Fim main
        static void SobreCelular(Celular celular)
        {
            Console.WriteLine($"Modelo {celular.modelo}");
            Console.WriteLine($"Cor {celular.cor}");
            Console.WriteLine($"Tamanho {celular.tamanho}");
        }

    }
}
