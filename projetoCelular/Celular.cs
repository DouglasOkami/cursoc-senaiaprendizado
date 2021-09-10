using System;
using System.Threading;

namespace projetoCelular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public string tamanho;
        private bool ligado = false;

        public bool StatusDoCelular()
        {
            return this.ligado;
        }
        public void Ligar()
        {
            if (this.ligado == false)
            {
                this.ligado = true;
                Console.WriteLine("Ligando celular ...");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("O celular já está ligado");
            }

        }//Fim ligar
        public void Desligar()
        {
            if (this.ligado == true)
            {
                this.ligado = false;
                Console.WriteLine("Desligando celular");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("O celular já está desligado");
            }

        }//Fim desligar
        public void EnviarMensagem()
        {
            if (this.ligado == true)
            {
                System.Console.WriteLine("Enviando Mensagem ...");
            }
            else
            {
                System.Console.WriteLine("Você precisa ligar o celular para enviar mensagens");
            }
        }//Fim EnviarMensagem
        public void EfetuarLigacao()
        {
              if (this.ligado == true)
            {
                System.Console.WriteLine("Ligando ...");
            }
            else
            {
                System.Console.WriteLine("Você precisa ligar o celular para efetuar ligações");
            }

        }//fim EfetuarLigação
        public void Sobre(){
            

        }//Fim Sobre
    }
}