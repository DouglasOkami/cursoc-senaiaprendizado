using System;
using System.Collections.Generic;
using projectConstrutor.Models;

namespace projectConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar uma classe gerando um objeto           
            Pessoa p1 = new Pessoa("Douglas", "Ferreira", "9999-9999", 17);
            Pessoa p2 = new Pessoa("Caio B.", "Santana", "3232-3232", 25);
            Pessoa p3 = new Pessoa("Dornellas", "Souza", "8888-888", 20);
            Pessoa p4 = new Pessoa("Drieli", "Figuereido", "7777-7777", 30);
            Pessoa p5 = new Pessoa("Nicolas", "Lombardi", "5555-5555", 35);

            // Armazenando as 5 pessoas em uma lista
            List<Pessoa> listaDePessoas = new List<Pessoa>();
            listaDePessoas.Add(p1);
            listaDePessoas.Add(p2);
            listaDePessoas.Add(p3);
            listaDePessoas.Add(p4);
            listaDePessoas.Add(p5);
            listaDePessoas.Add(new Pessoa("Kamilla","Emanuelle","1212-1212",16));
            // Exibir a lista
            Console.WriteLine("Pessoas cadastradas");
            foreach (var item in listaDePessoas)
            {
                Console.WriteLine($"nome : {item.nome} {item.sobrenome} idade: {item.idade}");
            }
        }//Fom main
    }
}