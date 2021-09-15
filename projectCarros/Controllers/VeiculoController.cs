using System;
using System.Collections.Generic;
using projectCarros.Models;

namespace projectCarros.Controllers
{
    public class VeiculoController
    {
        public List<Veiculo> listaVeiculo = new List<Veiculo>();
        public void CadastrarVeiculo()
        {

            Console.WriteLine("Digite o tipo do veículo");
            string tipo = Console.ReadLine();

            Console.WriteLine("Digite o modelo do veículo");
            string modelo = Console.ReadLine();

            Console.WriteLine("Digite a marca do veículo");
            string marca = Console.ReadLine();

            Console.WriteLine("Digite o ano do veículo");
            int ano = int.Parse(Console.ReadLine());

            Veiculo veiculo = new Veiculo(tipo, marca, modelo, ano);
        }
    }
}