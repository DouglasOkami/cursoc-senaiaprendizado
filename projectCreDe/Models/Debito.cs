using System;

namespace projectCreDe.Models
{
    public class Debito : Cartao
    {
        //atributo
        private double saldo;
        private string senha;
        //métodos
        public void DefinirSenha(string novaSenha)
        {
            this.senha = novaSenha;
        }
        public string ExibirNumero()
        {
            return this.numero;
        }
        public void DefinirNumero(string numeroDigitado)
        {
            this.numero = numeroDigitado;
        }
        // Para transferir é necessária a senha , valor e a conta de destino
        public void Transferir(string senhaDigitada, double valorDaTransferencia, Debito contaDestino)
        {
            if (senhaDigitada == this.senha)
            {
                //vamos fazer a transfêrencia
                if (this.saldo >= valorDaTransferencia)
                {
                    this.saldo = this.saldo - valorDaTransferencia;
                    contaDestino.saldo = contaDestino.saldo + valorDaTransferencia;
                    Console.WriteLine("Transferência efetuada!!");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente");
                }
            }
            else
            {
                Console.WriteLine("Senha inválida");
            }//fim else

        }//Fim Transferir
        //criar um método para depositar dinheiro na conta
        public void Depositar(double valor)
        {
            this.saldo = this.saldo + valor;
        }//Fim Depositar
        public double ExibirSaldo()
        {
            return this.saldo;
        }
        //Fim exibir 
    }//Fim main
}