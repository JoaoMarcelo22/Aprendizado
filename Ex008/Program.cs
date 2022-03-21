using System;

namespace Ex008
{
    class Program 
    {
        static void Main(string[] args)
        {
            //int? idade = 0;
            //Console.WriteLine(idade);
            //lidade = null;
            //Console.WriteLine(idade);
            //idade = 25;
            //Console.WriteLine(idade);
            //double x = 2;
            //x = 75-23.8;
            //Console.WriteLine(x);
            int idade = 72;

            if(idade <18){
                Console.WriteLine("ADOLECENTE");
            }
            else if((idade<=29)&&(idade>=18)){
                Console.WriteLine("JOVEM ADULTO");
            }
            else if((idade<40)&&(idade>=30)){
                Console.WriteLine("ADULTO");
            }
            else if((idade<=65)&&(idade>40)){
                Console.WriteLine("SENHOR");
            }
            else{
                Console.WriteLine("IDOSO");
            }
        }
    }
}