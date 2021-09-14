namespace projectCreDe.Models
{
    public class Cartao
    {
        public string titular;// todas classes tem acesso
        protected string numero;// Somente classes filhas tem acesso
        private string token;// Somente a própria classe tem acesso
        //Métodos
        public void Pagar(){

        }// Fim Pagar
        public string ValidarToken(){
            return this.token;
        }//Fim Validar
    }// Fim main
}