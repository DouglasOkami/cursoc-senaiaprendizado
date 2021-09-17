using System;
using System.Collections.Generic;
using projectCarros.Models;

namespace projectCarros.Controllers
{
    public class VeiculoController
    {
        public Veiculo CadastrarVeiculo()
        {
            Console.WriteLine("Digite o tipo do veículo");
            string tipo = Console.ReadLine();

            Console.WriteLine("Digite o modelo do veículo");
            string modelo = Console.ReadLine();

            Console.WriteLine("Digite a marca do veículo");
            string marca = Console.ReadLine();

            Console.WriteLine("Digite o ano do veículo");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o N° do Chassi");
            string chassi = Console.ReadLine();

            Veiculo veiculo = new Veiculo(tipo, marca, modelo, ano, chassi);

            return veiculo;
        }// Fim cadastrar

        //Método para listar os veículos
        public void ListarVeiculos(List<Veiculo> lista)
        {
            foreach (var item in lista)
            { 
                Console.WriteLine($"Marca: {item.Marca} Modelo: {item.Modelo} Ano: {item.Ano} Tipo: {item.Tipo} Chassi: {item.Chassi}");
            }
        }//Fim Listar
        //Método para buscar um veículo através do n° de chassi
        public Veiculo BuscarVeiculo(string chassiPesquisado, List<Veiculo> lista)
        {
            Veiculo veiculoRetornado = lista.Find(veiculo => veiculo.Chassi == chassiPesquisado);
            return veiculoRetornado;
        }// Fim buscar
        public void RemoverVeiculo(string _chassi, List<Veiculo> lista)
        {
            Veiculo veiculoRetornado = lista.Find(veiculo => veiculo.Chassi == _chassi);
            lista.Remove(veiculoRetornado);
        }//Fim Remover
    }//Fim VeiculoController
}