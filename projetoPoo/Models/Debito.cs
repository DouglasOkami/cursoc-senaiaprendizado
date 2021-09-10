namespace projetoPoo.Models
{
    public class Debito : Cartao
    {
        public double saldo;
        public void Transferir()
        {

        }//fim Transferir
        public void Depositar(double valor)
        {
            this.saldo = this.saldo + valor;
        }//fim Depositar
        public void ExibirSaldo()
        {
            System.Console.WriteLine($"O saldo é de {this.numero} é de {this.saldo}");
        }//fim Exibir
        public void DefenirNumero(string numeroDoCartao){
            this.numero = numeroDoCartao;
        }
    }//fim Débito
}