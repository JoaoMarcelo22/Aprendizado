using System;

namespace Ex009
{
    class Program
    {
        static void main(string[] args)
        {
            int inteiro = 100;
            float real = 25.5f;

            real = inteiro; //conversão Implícita virou 100.0f

            inteiro = (int)real; //conversão Explícita  vira 25

            string valorReal = real.ToString();
            inteiro = int.Parse(valorReal); //conversão Parse precisa receber uma string

            inteiro = Convert.ToInt32(real); //conversão Convert converte todos os valores primitivos
            
               

        }
    }
}