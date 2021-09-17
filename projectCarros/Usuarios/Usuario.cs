using System;

namespace projectCarros.Usuarios
{
    public class Usuario
    {
        public string Nome { get; set; }//Conseguimos acessar o atributo atrráves do get e set;
        public string Emails { get; set; }
        public string Senha { get; set; }
        public int Cpf { get; set; }

        public Usuario(string _nome, string _emails, int _cpf, string _senha)
        {
            Nome = _nome;
            Emails = _emails;
            Cpf = _cpf;
            Senha = _senha;
        }//Fim Veiculo
    }//Fim class
}