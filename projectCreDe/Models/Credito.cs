using System;

namespace projectCreDe.Models
{
    public class Credito : Cartao
    {
        //atributos
        private double limite;
        public double limiteDisponivel;
        private string senhaC;
        //métodos
        public void DefinirSenhaC(string novaSenhaC)
        {
            this.senhaC = novaSenhaC;
        }
        public string ExibirNumeroC()
        {
            return this.numero;
        }
        public void DefinirNumeroC(string nummeroDigitadoC)
        {
            this.numero = nummeroDigitadoC;
        }

        public void DefinirLimite(double valor)
        {
            this.limite = this.limite + valor;
        }//Fim definir
        public void PagarFatura()
        {

        }//Fim Pagar
        public void Comprar(string senhaDigitadaC, double valorComprar, Credito contaDestinoC)
        {
            if (senhaDigitadaC == this.senhaC)
            {
                //vamos fazer a compra
                if (this.limite >= valorComprar)
                {
                    this.limite = this.limite - valorComprar;
                    contaDestinoC.limite = contaDestinoC.limite + valorComprar;
                    Console.WriteLine("Pagamento efetuado!!");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente");
                }
            }
            else
            {
                Console.WriteLine("Senha inválida");
            }
        }//Fim comprar
        public double LimiteDisponivel()
        {
            return this.limite;
        }
    }//Fim class
}