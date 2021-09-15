using System;
namespace projectCarros.Models
{
    public class Veiculo
    {
        // private string modelo;
        // //Set = Definir
        // public void SetTipo(string modeloDigitado)
        // {
        //     this.modelo = modeloDigitado;
        // }//Fim Set
        // //Get - Pegar
        // public string GetTipo()
        // {
        //     return this.modelo;
        // }//Fim Get
        // private string marca;
        // public string Marca{
        //     get { return marca;}
        //     set { marca = value;}
        // }//Fim Marca
        public string Tipo { get; set; }//Conseguimos acessar o atributo atrráves do get e set;
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public Veiculo(string _tipo, string _marca, string _modelo, int _ano)
        {
            Tipo = _tipo;
            Marca = _marca;
            Modelo = _modelo;
            Ano = _ano;
        }//Fim Veiculo
    }//FIm Class
}