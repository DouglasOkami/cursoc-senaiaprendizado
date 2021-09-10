using System;
using projetoPoo.Models;

namespace projetoPoo
{
    class Program
    {
        static void Main(string[] args)
        {
        Debito cartaoDebitoDouglas = new Debito();
        cartaoDebitoDouglas.titular = "Douglas";
        cartaoDebitoDouglas.Depositar(500);
        cartaoDebitoDouglas.ExibirSaldo();



        }//fim main
    }
}
