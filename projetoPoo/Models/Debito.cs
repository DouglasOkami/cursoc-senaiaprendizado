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
            System.Console.WriteLine($"O saldo é de {this.titular} é de {this.saldo}");
        }//fim Exibir
    }//fim Débito
}