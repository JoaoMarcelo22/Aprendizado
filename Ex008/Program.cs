using System;

namespace Ex008
{
    class program 
    {
        static void main(string[] args)
        {
            int? idade = 0;
            Console.WriteLine(idade);
            idade = null;
            Console.WriteLine(idade);
            idade = 25;
            Console.WriteLine(idade);
        }
    }
}