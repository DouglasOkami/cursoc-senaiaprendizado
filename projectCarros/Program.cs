using System;
using projectCarros.Models;
using projectCarros.Controllers;

namespace projectCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("[1] - Cadastrar Veículo");
                Console.WriteLine("[2] - Listar Veículos");
                Console.WriteLine("[0] - Sair");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        // Aqui iremos cadastrar um veículo
                        VeiculoController veiculoController = new VeiculoController();
                        veiculoController.CadastrarVeiculo();
                        break;
                    case "2":
                        // Aqui iremos listar os veículos cadastrados
                        break;
                    case "0":
                        // Aqui iremos finalizar a operação
                        Console.WriteLine("Obrigado por utilizar nosso sistema");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != "0");
        }//Fim main
    }
}
