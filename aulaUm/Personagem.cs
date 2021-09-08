namespace aulaUm
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public string armadura;
        public string iA;
        private int vida = 100;

        public void Defender(int ataque)
        {
            this.vida = this.vida - ataque;
        }//fim void
        public int ExibirVida()
        {
            return vida;
        }//fim public
    }
}