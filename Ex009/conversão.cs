using System;

namespace Ex009
{
    class Program
    {
        static void main(string[] args)
        {
            //METODOS DE CONVERSAÇÃO----------------------------------

            int inteiro = 100;
            float real = 25.5f;

            real = inteiro; //conversão Implícita virou 100.0f

            inteiro = (int)real; //conversão Explícita  vira 25

            string valorReal = real.ToString();
            inteiro = int.Parse(valorReal); //conversão Parse precisa receber uma string

            inteiro = Convert.ToInt32(real); //conversão Convert converte todos os valores primitivos




            //OPERADORES----------------------------------------------

            double x = 2;
            x = 75-23.8;                    //subtração
            Console.WriteLine(x);
            x = 75 + 23;                    //soma
            x = 75 * 23;                    //multiplicação
            x = 75 / 23;                    //divisão
            x++;                            //acrecenta um
            x--;                            //subtrai um

            //ESTRUTURA CONDICIONAL--------------IF/ELSE-------------
            int idade = 72;

            if(idade <18){
                Console.WriteLine("ADOLECENTE");   //caso seja verdadeiro
            }
            else if((idade<=29)&&(idade>=18)){     //senão,testa outra condição
                Console.WriteLine("JOVEM ADULTO");
            }
            else if((idade<40)&&(idade>=30)){      //senão,testa outra condição
                Console.WriteLine("ADULTO");
            }
            else if((idade<=65)&&(idade>40)){      //senão,testa outra condição
                Console.WriteLine("SENHOR");
            }
            else{
                Console.WriteLine("IDOSO");        //senão.
            }
        }
    }
}