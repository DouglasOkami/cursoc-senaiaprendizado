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
                Console.WriteLine("[2] - Cadastrar Veículo");
                Console.WriteLine("[3] - Listar Veículos");
                Console.WriteLine("[4] - Listar Usuários");
                Console.WriteLine("[5] - Buscar Veículo");
                Console.WriteLine("[6] - Buscar Usuário");
                Console.WriteLine("[7] - Remover Veículo");
                Console.WriteLine("[8] - Remover Usuário");
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
                        // Aqui iremos cadastrar um veículo
                        Console.WriteLine("Digite o email do usuário");
                        string emailUsuarioPesquisado = Console.ReadLine();
                        Console.WriteLine("Digite a senha do usuário");
                        string senhaPesquisado = Console.ReadLine();
                        Usuario usuarioLoginPesquisado = usuarioController.BuscarUsuario(emailUsuarioPesquisado, listaDeUsuarios);
                        if (usuarioLoginPesquisado == null && senhaPesquisado == null)
                        {
                            Console.WriteLine("Usuário não encontrado");
                        }
                        else
                        {
                            if (senhaPesquisado != usuarioLoginPesquisado.Senha)
                            {
                                Console.WriteLine("senha inválida");
                            }
                            else
                            {
                                Veiculo veiculoRetornado = veiculoController.CadastrarVeiculo();
                                listaDeVeiculos.Add(veiculoRetornado);
                            }
                        }
                        break;
                    case "3":
                        // Aqui temos que acessar a lista de veículos e exibir cada item da lista
                        veiculoController.ListarVeiculos(listaDeVeiculos);//aqui eu passo o método para lista
                        break;
                    case "4":
                        // Aqui temos que acessar a lista de usuários e exibir cada item da lista
                        usuarioController.ListarUsurios(listaDeUsuarios);//aqui eu passo o método para lista
                        break;
                    case "5":
                        Console.WriteLine("Digite o chassi do veículo");
                        string chassiPesquisado = Console.ReadLine();
                        Veiculo veiculoPesquisado = veiculoController.BuscarVeiculo(chassiPesquisado, listaDeVeiculos);
                        if (veiculoPesquisado == null)
                        {
                            Console.WriteLine("Veículo não encontrado");
                        }
                        else
                        {
                            Console.WriteLine($"Veículo retornado {veiculoPesquisado.Modelo}");
                        }
                        break;
                    case "6":
                        Console.WriteLine("Digite o email do usuário");
                        string emailPesquisado = Console.ReadLine();
                        Usuario usuarioPesquisado = usuarioController.BuscarUsuario(emailPesquisado, listaDeUsuarios);
                        if (usuarioPesquisado == null)
                        {
                            Console.WriteLine("Usuário não encontrado");
                        }
                        else
                        {
                            Console.WriteLine($"Usuário retornado {usuarioPesquisado.Nome}");
                        }
                        break;
                    case "7":
                        // Aqui iremos remover veículos
                        Console.WriteLine("Digite o chassi do veículo para remover");
                        string chassiParaRemover = Console.ReadLine();
                        veiculoController.RemoverVeiculo(chassiParaRemover, listaDeVeiculos);
                        break;
                    case "8":
                        // Aqui iremos remover usuários
                        Console.WriteLine("Digite o email do usuário para remover");
                        string emailParaRemover = Console.ReadLine();
                        usuarioController.RemoverUsuario(emailParaRemover, listaDeUsuarios);
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
