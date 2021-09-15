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
        }//Fim definir //criar um método para Comprar

        public void Comprar(string senhaDigitada, double valorDaCompra)
        {
            if (senhaDigitada == this.senhaC)
            {
                // 10000                    3000
                if (this.limiteDisponivel >= valorDaCompra)
                {
                    // 7000                         10000         -   3000
                    this.limiteDisponivel = this.limiteDisponivel - valorDaCompra;
                }
                else
                {
                    Console.WriteLine("Limite insuficiente");
                }
            }else{
                Console.WriteLine("Senha inválida!");
            }//fim validação senha
        }

        public double ExibirSaldoDisponivel(){
            return this.limiteDisponivel;
        }

        public void PagarFatura(double valor){
            //quanto tenho que pagar?
            //                  10000   -     5500
            double fatura = this.limite - this.limiteDisponivel;

            if(valor <= fatura){
                this.limiteDisponivel = this.limiteDisponivel + valor; 
            }else{
                Console.WriteLine("Valor acima do custo de sua fatura");
            }
        }


    }
}