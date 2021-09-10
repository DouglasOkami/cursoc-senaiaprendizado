using System;

namespace arraysLaço
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vamos criar um sistema para cadastrar usuários utilizando while,do while e for
            int opcao;
            string[] nomes = new string[3];
            string[] sobrenomes = new string[3];
            string[] senhas = new string[3];
            do
            {

                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("1 - Cadastro de usuário com Do while");
                Console.WriteLine("2 - Cadastro de usuário com For ");
                Console.WriteLine("3 - Listar usuários com While ");
                Console.WriteLine("4 - Listar usuários com for ");
                Console.WriteLine("0 - sair ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        //Cadastro de usuário com Do while
                        int contador = 0;
                        do
                        {
                            Console.WriteLine("Digite o nome do usuário");
                            nomes[contador] = Console.ReadLine();
                            contador++;
                        } while (contador < 3);
                        break;
                    case 2:
                        //Cadastro de usuário com For
                        for (int cont = 0; cont < 3; cont++)
                        {   
                            Console.WriteLine("Digite o sobrenome");
                            sobrenomes[cont] = Console.ReadLine();
                            Console.WriteLine("Digite a Senha");
                            senhas[cont] = Console.ReadLine();
                        }
                        break;
                    case 3:
                        //Listar usuários com While
                        int contadorLista = 0;
                        while (contadorLista < 3)
                        {
                            Console.WriteLine(nomes[contadorLista]);
                            contadorLista++;
                        }
                        break;
                    case 4:
                        //Listar usuários com for
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"Nome: {nomes[i]} {sobrenomes[i]} senha: {senhas[i]}");
                        }
                            break;
                    case 0:
                        //sair
                        break;
                    default:
                        // quando selecionar uma opcao inválida
                        break;
                }// fim switch
            } while (opcao != 0); // fim while
        }// fim main
    }
}
