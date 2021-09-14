using System;
using projectCreDe.Models;

namespace projectCreDe
{

    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância de Débito
            Debito cartaoDouglas = new Debito();
            cartaoDouglas.titular = "Douglas Ferreira";
            cartaoDouglas.DefinirNumero("1234 1234 1234 1234");
            cartaoDouglas.DefinirSenha("4321");
            cartaoDouglas.Depositar(5000);

            Debito cartaoTsukamoto = new Debito();
            cartaoTsukamoto.titular = "Tsukamoto";
            cartaoTsukamoto.DefinirNumero("4321 4321 4321 4321");
            cartaoTsukamoto.DefinirSenha("1234");
            cartaoTsukamoto.Depositar(1000);
            cartaoTsukamoto.Depositar(3000);

            //exibindo dados dos objetos

            Console.WriteLine($"Cartão - {cartaoDouglas.titular}");
            Console.WriteLine($"n° {cartaoDouglas.ExibirNumero()}");
            Console.WriteLine($"saldo {cartaoDouglas.ExibirSaldo()}");

            Console.WriteLine($"Cartão - {cartaoTsukamoto.titular}");
            Console.WriteLine($"n° {cartaoTsukamoto.ExibirNumero()}");
            Console.WriteLine($"saldo {cartaoTsukamoto.ExibirSaldo()}");

            // Fazer transferência
            cartaoDouglas.Transferir("4321", 3000, cartaoTsukamoto);
            //Depois da transferência
            Console.WriteLine($"Conta - {cartaoDouglas.titular} = Saldo Atual {cartaoDouglas.ExibirSaldo()}");
            Console.WriteLine($"Conta - {cartaoTsukamoto.titular} = Saldo Atual {cartaoTsukamoto.ExibirSaldo()}");

            //Cartao crédito
            Console.ForegroundColor = ConsoleColor.Blue;
            Credito cartaoDouglasF = new Credito();
            cartaoDouglasF.titular = "Douglas";
            cartaoDouglasF.DefinirNumeroC("4567 4567 4567 4567");
            cartaoDouglasF.DefinirSenhaC("2345");
            cartaoDouglasF.DefinirLimite(10000);

            // Exibir dados da conta

            Console.WriteLine($"Conta - {cartaoDouglasF.titular}");
            Console.WriteLine($"Número - {cartaoDouglasF.ExibirNumeroC()}");
            //fazer comprar

            cartaoDouglasF.Comprar("2345", 4500);

            Console.WriteLine("Compra efetuada");
            Console.WriteLine($"{cartaoDouglasF.ExibirLimiteDisponivel()}");

            // Credito cartaoCarlos = new Credito();
            //cartaoCarlos.titular = "Carlos";
            // cartaoCarlos.DefinirNumeroC("2345 2345 2345 2345");
            //cartaoCarlos.DefinirSenhaC("5432");
            //cartaoCarlos.DefinirLimite(100);

            //Fazer pagamento
            //cartaoDouglasF.Comprar("2345", 5000, cartaoCarlos);
            //Console.WriteLine($"Conta - {cartaoDouglasF.titular} = Saldo Atual {cartaoDouglasF.LimiteDisponivel()}");
            //Console.WriteLine($"Conta - {cartaoCarlos.titular} = Saldo Atual {cartaoCarlos.LimiteDisponivel()}");
            //depois do pagamento

            //Pagando Fatura
            cartaoDouglasF.PagarFatura(2000);
            Console.WriteLine($"Pagamento efetuado");
            Console.WriteLine($"");
        }//Fim main
    }//Fim Promam
}
