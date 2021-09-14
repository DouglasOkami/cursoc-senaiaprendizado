using System;

namespace projectCreDe.Models
{
    public class Credito : Cartao
    {
        //atributos
        private double limite;
        private double limiteDisponivel;
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

        public void DefinirLimite(double novoLimite)
        {
            this.limite = novoLimite;
            this.limiteDisponivel = this.limite;
        }//Fim definir
        public void PagarFatura(double valor)
        {//quanto tenho que pagar?
            double fatura = this.limite - this.limiteDisponivel;
            if (valor >= fatura)
            {
                this.limiteDisponivel = this.limiteDisponivel + valor;
            }
            else
            {
                Console.WriteLine("Valor acima do custo da sua fatura");
            }
        }//Fim Pagar


        // public void Comprar(string senhaDigitadaC, double valorComprar, Credito contaDestinoC)
        // {
        //    if (senhaDigitadaC == this.senhaC)
        //   {
        //vamos fazer a compra
        //     if (this.limite >= valorComprar)
        //     {
        //          this.limite = this.limite - valorComprar;
        //         contaDestinoC.limite = contaDestinoC.limite + valorComprar;
        //         Console.WriteLine("Pagamento efetuado!!");
        //     }
        //     else
        //    {
        //        Console.WriteLine("Saldo insuficiente");
        //    }
        //  }
        //  else
        //   {
        //       Console.WriteLine("Senha inválida");
        //  }
        // }//Fim comprar
        public void Comprar(string senhaDigitada, double valorDaCompra)
        {
            if (senhaDigitada == this.senhaC)
            {
                if (this.limiteDisponivel >= valorDaCompra)
                {
                    this.limiteDisponivel = this.limiteDisponivel - valorDaCompra;
                }
                else
                {
                    Console.WriteLine("Limite insuficiente");
                }
            }
            else
            {
                Console.WriteLine("Senha inválida");
            }//fim else
        }// fim comprar
        public double ExibirLimiteDisponivel()
        {
            return this.limiteDisponivel;
        }//fim disponivel
    }//Fim class
}