using System;

namespace aulaUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem perso1 = new Personagem();
            perso1.nome = "Batmão";
            perso1.idade = 46;
            perso1.armadura = "Bat Roupa seda";
            perso1.iA = "Alfred";

            Personagem perso2 = new Personagem();
            perso2.nome = "Wonder Woman";
            perso2.idade = 100;
            perso2.armadura = "Master Tinium";
            perso2.iA = "Amazon Prime";

            //Console.WriteLine($"{perso1.nome} Vs {perso2.nome}");

            //perso2.Defender(30);

            //Console.WriteLine($"Personagem {perso2.nome} recebeu um ataque, sua vida restante {perso2.ExibirVida()}");

            //perso2.Defender(40);

            //Console.WriteLine($"Personagem {perso2.nome} recebeu um ataque, sua vida restante {perso2.ExibirVida()}");

            Console.WriteLine($"{perso1.nome} Vs {perso2.nome}");
            string opcao ,ataque , defesa;
            do
            {
                Console.WriteLine("Selecione qual personagem você quer jogar:");
                Console.WriteLine($"1 - {perso1.nome} vida = {perso1.ExibirVida()}");
                Console.WriteLine($"2 - {perso2.nome} vida = {perso2.ExibirVida()}");
                Console.WriteLine($"0 - Desistir");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        //Atacar personagem 2
                        Console.WriteLine("Selecione o ataque");
                        Console.WriteLine("1 - Soco Alto");
                        Console.WriteLine("2 - Chute Baixo");
                        ataque = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Personagem {perso2.nome} qual será sua defesa?");
                        Console.WriteLine("1 - Defesa de soco");
                        Console.WriteLine("2 - Defesa de chute");
                        defesa = Console.ReadLine();
                        if (ataque == defesa)
                        {
                            Console.WriteLine($"O {perso2.nome} defendeu!");
                        }
                        else
                        {
                            Console.WriteLine($"O {perso2.nome} recebeu um dano de 25");
                            perso2.Defender(25);
                            Console.WriteLine($"Vida restante = {perso2.ExibirVida()}");

                        }//fim else
                        break;
                    case "2":
                        //Atacar personagem 1
                        Console.WriteLine("Selecione o ataque");
                        Console.WriteLine("1 - Soco Alto");
                        Console.WriteLine("2 - Chute Baixo");
                        string ataque1 = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Personagem {perso1.nome} qual será sua defesa?");
                        Console.WriteLine("1 - Defesa de soco");
                        Console.WriteLine("2 - Defesa de chute");
                        string defesa1 = Console.ReadLine();
                        if (ataque1 == defesa1)
                        {
                            Console.WriteLine($"O {perso1.nome} defendeu!");
                        }
                        else
                        {
                            Console.WriteLine($"O {perso1.nome} recebeu um dano de 25");
                            perso1.Defender(25);
                            Console.WriteLine($"Vida restante = {perso1.ExibirVida()}");
                        }//fim else
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }//fim switch
            } while (opcao != "0");
        }//fim main
    }
}
