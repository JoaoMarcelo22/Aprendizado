using System;
using System.Threading;

namespace Ex010{
    class Program
    {
        static void Main(string[] args)
        {
           Menu(); 
            
        }
        static void Start(int time)
        {
            
            int tempoAtual = 0;

            while(tempoAtual != time){
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);        
            }

            Console.Clear();
            Console.WriteLine("Cronômetro finalizado!");
            Thread.Sleep(2500);
            Menu();

        }
        static void Menu(){
            //Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower(); // transforma toda as string em minusculo.
            char type = char.Parse(data.Substring(data.Length-1,1)); // pegamos o ultimo caractere
            int time = int.Parse(data.Substring(0, data.Length-1));  // pegamos o corpo dos caracteres menos o ultimo caractere.
            int multiplier = 1;
            //Console.WriteLine(data);
            //Console.WriteLine(time);
            //Console.WriteLine(type);
            if(type == 'm'){
                multiplier = 60;
            }
            if(time == 0){
                System.Environment.Exit(0);
            }
            PreStart(time * multiplier);
        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!!");
            Thread.Sleep(2500);

            Start(time);
            //Cronômetro
        }
    }
}