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


            //ESTRUTURA CONDICIONAL--------------SWITCH-------------------------
            int valor = 20;                        //Com Numero 
            switch(valor)
            {
                case 1: Console.WriteLine("1"); break;
                case 2: Console.WriteLine("2"); break;
                case 3: Console.WriteLine("3"); break;
                default:Console.WriteLine("4"); break;
            }
            string valor = "andre";
            switch(valor)                          //Com string
            {
                case "joao": Console.WriteLine("Não é o cara"); break;
                case "marcelo": Console.WriteLine("Não é o cara"); break;
                case "andre": Console.WriteLine("É este"); break;
                default:Console.WriteLine("não encontrado"); break;
            }
            bool? valor = null;                    //Com bolleano aceita Null
            switch(valor)
            {
                case true: Console.WriteLine("Verdade"); break;
                case false: Console.WriteLine("Falso"); break;
                default:Console.WriteLine("Nulo"); break;
            }
            //LAÇOS DE REPETIÇÃO---------------FOR--------------------------------
            for(var i = 0; i<=5; i++){ //Conta de 0 a 5
            Console.WriteLine(i);
            }
            for(var i = 1; i<=5; i++){ //conta de 1 a 5
            Console.WriteLine(i);
            }
            for(var i = 0; i<5; i++){  //conta de 0 a 4
            Console.WriteLine(i);
            }
            for(var i = 5; i<=0; i++){ //conta de 5 a 0
            Console.WriteLine(i);
            }
            // Value Types e Reference Types--------------------------------------
            int x = 25;
            int y = x;       //o Y é apenas uma copia do X não mantem o mesmo valor de X
            Console.WriteLine(x);
            Console.WriteLine(y);

            x= 32;               
            Console.WriteLine(x);
            Console.WriteLine(y);

            //---------------------------------------------------------------------

            var arr = new string[2];
            arr[0] = "Item 1";

            var arr2 = arr;

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            arr[0] = "Item 2";
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]); // é apenas a referencia não é a copia

        }
    }
}