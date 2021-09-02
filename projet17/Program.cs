using System;

namespace AtividadeSimNao
{
    class Program
    {
        static void Main(string[] args)
        {//começo
            int contPessoas = 0, contHomens = 0, contMulheres = 0, simHomem = 0 , simMulher = 0 ;
            char sexo , resposta;

            do
            {
                Console.WriteLine("Digite M para masculino ou F para feminino");
                sexo = char.Parse(Console.ReadLine());

                Console.WriteLine("Digite S para sim que gostou do produto e N para não gostou do produto");
                resposta = char.Parse(Console.ReadLine());

                if(sexo == 'M'){
                    contHomens ++;

                    if(resposta == 'S'){
                        simHomem++;
                    }
                }else{// feminino
                    contMulheres ++;

                    if(resposta == 'S'){
                        simMulher++;
                    }
                }
                contPessoas ++;
            } while (contPessoas < 4);//fim while

            Console.WriteLine($"A quantidade de pessoas que falaram sim = {simHomem + simMulher }");
            Console.WriteLine($"A quantidade de pessoas que falatam não = {contPessoas - (simHomem + simMulher)}");
            Console.WriteLine($"A quantidade de mulheres que falaram sim = {simMulher} ");
            Console.WriteLine($"A porcentagem de homens que responderam NÃO entre todos os homens analisados = {(((double)contHomens - (double)simHomem) / (double)contHomens)  * 100}%");
        }//fim
    }
}
