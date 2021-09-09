using System;
using System.Threading;

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
            perso1.soco = 40;
            perso1.chute = 60;

            Personagem perso2 = new Personagem();
            perso2.nome = "Wonder Woman";
            perso2.idade = 100;
            perso2.armadura = "Master Tinium";
            perso2.iA = "Amazon Prime";
            perso2.soco = 40;
            perso2.chute = 60;

            //Console.WriteLine($"{perso1.nome} Vs {perso2.nome}");

            //perso2.Defender(30);

            //Console.WriteLine($"Personagem {perso2.nome} recebeu um ataque, sua vida restante {perso2.ExibirVida()}");

            //perso2.Defender(40);

            //Console.WriteLine($"Personagem {perso2.nome} recebeu um ataque, sua vida restante {perso2.ExibirVida()}");

            Console.WriteLine($"{perso1.nome} Vs {perso2.nome}");
            string opcao, ataque, defesa;
            int contadorRound = 1;
            int contadorP1 = 0, contadorP2 = 0;
            do
            {
                Console.WriteLine($"Round {contadorRound} prepare-se");
                Console.WriteLine("Selecione qual personagem você quer jogar:");
                if (contadorP1 == contadorP2)
                {
                    Console.WriteLine($"1 - {perso1.nome} vida = {perso1.ExibirVida()} quantidade jogadas = {contadorP1}");
                    Console.WriteLine($"2 - {perso2.nome} vida = {perso2.ExibirVida()} quantidade jogadas = {contadorP2}");
                }
                else if (contadorP1 < contadorP2)
                {
                    Console.WriteLine($"1 - {perso1.nome} vida = {perso1.ExibirVida()} quantidade jogadas = {contadorP1}");
                }
                else if (contadorP2 < contadorP1)
                {
                    Console.WriteLine($"2 - {perso2.nome} vida = {perso2.ExibirVida()} quantidade jogadas = {contadorP2}");
                }
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
                            if (ataque == "1")
                            {
                                Console.WriteLine($"O {perso2.nome} recebeu um dano de {perso1.soco}");
                                perso2.ReceberAtaque(perso1.soco);
                            }
                            else
                            {
                                Console.WriteLine($"O {perso2.nome} recebeu um dano de {perso1.chute}");
                                perso2.ReceberAtaque(perso1.chute);
                            }//Fim else
                            if (perso2.ExibirVida() > 0)
                            {
                                Console.WriteLine($"Vida restante = {perso2.ExibirVida()}");
                            }
                            else
                            {
                                Console.WriteLine("KO!!!");
                            }
                            Thread.Sleep(3000);
                        }//Fim else Princial
                        break;
                    case "2":
                        //Atacar personagem 1
                        Console.WriteLine("Selecione o ataque");
                        Console.WriteLine("1 - Soco Alto");
                        Console.WriteLine("2 - Chute Baixo");
                        ataque = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Personagem {perso1.nome} qual será sua defesa?");
                        Console.WriteLine("1 - Defesa de soco");
                        Console.WriteLine("2 - Defesa de chute");
                        defesa = Console.ReadLine();
                        if (ataque == defesa)
                        {
                            Console.WriteLine($"O {perso1.nome} defendeu!");
                        }
                        else
                        {
                            if (ataque == "1")
                            {
                                Console.WriteLine($"O {perso1.nome} recebeu um dano de {perso2.soco}");
                                perso1.ReceberAtaque(perso2.soco);
                            }
                            else
                            {
                                Console.WriteLine($"O {perso1.nome} recebeu um dano de {perso2.chute}");
                                perso1.ReceberAtaque(perso2.chute);
                            }//Fim else
                            if (perso1.ExibirVida() > 0)
                            {
                                Console.WriteLine($"Vida restante = {perso1.ExibirVida()}");
                            }
                            else
                            {
                                Console.WriteLine("KO!!!");
                            }
                            Thread.Sleep(3000);
                        }//Fim else Princial
                        break;
                    case "0":
                        Console.WriteLine("Covarde!!!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }//fim switch
                if (perso1.ExibirVida() <= 0)
                {
                    Console.WriteLine($"A vitória do jogo {perso2.nome}");
                    break;
                }//Fim if
                else if (perso2.ExibirVida() <= 0)
                {
                    Console.WriteLine($"A vitória do jogo {perso1.nome}");
                    break;
                }//Fim if else
                else if (opcao != "0")
                {
                    Console.WriteLine("Prepare-se para o próximo ROUND");
                    Thread.Sleep(2000);
                }//Fim if else
                Console.Clear();
                contadorP1++;
                contadorP2++;
            } while (opcao != "0");
        }//fim main
    }
}
