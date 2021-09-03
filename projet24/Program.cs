using System;

namespace projet24
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variaveis
            string opcao, resposta;
            string[] nomes = new string[5];
            string[] origens = new string[5];
            string[] destinos = new string[5];
            string[] datas = new string[5];
            int contador = 0;

            Console.WriteLine("Digite a senha");
            string senhaDigitada = Console.ReadLine();
            bool retornoDaFuncao = ValidaSenha(senhaDigitada);
            //quando a condição for verdadeira ou true entraremos no laço
            while (!retornoDaFuncao)
            {
                Console.WriteLine("Senha inválida");
                Console.WriteLine("Digite a senha novamente");
                senhaDigitada = Console.ReadLine();
                retornoDaFuncao = ValidaSenha(senhaDigitada);
            }//fim while

            Console.WriteLine("-------------------------------");
            Console.WriteLine(" Bem vindo a Tsukamoto Airlines");
            Console.WriteLine("-------------------------------");

            do
            {
                Console.WriteLine("-----Selecione uma opção-------");
                Console.WriteLine("[1] - Cadastrar Passagem");
                Console.WriteLine("[2] - listar Passagens");
                Console.WriteLine("[3] - Busca Passagem");
                Console.WriteLine("[0] - Sair");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Cadastro de passagens");
                        CadastroDePassagens();
                        break;
                    case "2":
                        Console.WriteLine("Listar passagens");
                        ListarPassagens();
                        break;
                    case "3":
                        Console.WriteLine("Busca Passageiro");
                        string nome = Console.ReadLine();
                        BuscaPassagem(nome);
                        break;
                    case "0":
                        Console.WriteLine("Obrigado por usar a Tsukamoto Air lines");
                        Console.WriteLine("Volte sempre");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }// fim switch
            } while (opcao != "0");// fim Do while


            //funções
            bool ValidaSenha(string senha)
            {
                if (senha == "123456")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }//fim validar senha
            void CadastroDePassagens()
            {
                do
                {
                    if (contador < 5)
                    {
                        Console.WriteLine("Digite o nome do passageiro");
                        nomes[contador] = Console.ReadLine();
                        Console.WriteLine("Digite a origem");
                        origens[contador] = Console.ReadLine();
                        Console.WriteLine("Digite o Destino");
                        destinos[contador] = Console.ReadLine();
                        Console.WriteLine("Digite a data da vaigem");
                        datas[contador] = Console.ReadLine();
                        Console.WriteLine("Gostaria de cadastrar outra passagem");
                        resposta = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Limite Excedido");
                        break;
                    }//fim else
                    contador++;
                } while (resposta == "sim");

            }//fim Cadastro de Passagens

            void ListarPassagens()
            {
                for (var i = 0; i < contador; i++)
                {
                    Console.WriteLine($"nome :{nomes[i]} data :{datas[i]} origem :{origens[i]} destino:{destinos[i]}");
                }//fim for
            }// fim void

            void BuscaPassagem(string nome)
            {
                for (var i = 0; i < contador; i++)
                {
                    if(nome == nomes[i]){
                    Console.WriteLine($"Passageiro {nomes[i]} tem a viagem para o dia {datas[i]}");
                    }
                }
            }//fim void
        }//fim main
    }
}
