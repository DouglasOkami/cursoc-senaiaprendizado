using System;
using projectCarros.Models;
using projectCarros.Controllers;
using System.Collections.Generic;
using projectCarros.Usuarios;

namespace projectCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> listaDeUsuarios = new List<Usuario>();
            UsuarioController usuarioController = new UsuarioController();

            List<Veiculo> listaDeVeiculos = new List<Veiculo>();
            VeiculoController veiculoController = new VeiculoController();
            string opcao;

            do
            {
                Console.WriteLine("[1] - Cadastrar Usuário");
                Console.WriteLine("[2] - Login de Usuário");
                Console.WriteLine("[3] - Cadastrar Veículo");
                Console.WriteLine("[4] - Listar Veículos");
                Console.WriteLine("[5] - Listar Usuários");
                Console.WriteLine("[6] - Buscar Veículo");
                Console.WriteLine("[0] - Sair");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        // Aqui iremos cadastrar usuários
                        Usuario usuarioRetornado = usuarioController.CadatroDeUsuarios();
                        listaDeUsuarios.Add(usuarioRetornado);
                        break;
                    case "2":
                        // Aqui iremos login de usuários

                        break;
                    case "3":
                        // Aqui iremos cadastrar um veículo
                        Veiculo veiculoRetornado = veiculoController.CadastrarVeiculo();
                        listaDeVeiculos.Add(veiculoRetornado);
                        break;
                    case "4":
                        // Aqui temos que acessar a lista de veículos e exibir cada item da lista
                        veiculoController.ListarVeiculos(listaDeVeiculos);//aqui eu passo o método para lista
                        break;
                    case "5":
                        // Aqui temos que acessar a lista de usuários e exibir cada item da lista
                        usuarioController.ListarUsurios(listaDeUsuarios);//aqui eu passo o método para lista
                        break;
                    case "6":
                        // Aqui temos que acessar a lista de usuários e exibir cada item da lista
                        Console.WriteLine("Digite o chassi do veículo");
                        string chassiPesquisado = Console.ReadLine();
                        Veiculo veiculoPesquisado = veiculoController.BuscarVeiculo(chassiPesquisado ,listaDeVeiculos);
                        Console.WriteLine($"Veículo retornado {veiculoPesquisado.Modelo}");
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
