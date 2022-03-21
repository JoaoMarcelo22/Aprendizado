using System;

namespace Ex008
{
    class Program 
    {
        static void Main(string[] args)
        {
            bool? valor = null;
            switch(valor)
            {
                case true: Console.WriteLine("Verdade"); break;
                case false: Console.WriteLine("Falso"); break;
                default:Console.WriteLine("Nulo"); break;
            }
        }
    }
}