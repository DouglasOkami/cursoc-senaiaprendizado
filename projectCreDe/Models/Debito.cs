namespace projectCreDe.Models
{
    public class Debito : Cartao
    {
        //atributo
        private double saldo;
        //métodos
        public void DefenirNumero(string numeroDigitado){
            this.numero = numeroDigitado;
        }
        public void Transferir(){

        }//Fim Transferir
    }//Fim main
}