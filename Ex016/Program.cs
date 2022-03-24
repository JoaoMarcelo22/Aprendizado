using System;
using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10536.25m;
            
            Console.WriteLine(
                valor.ToString(
                    // "F" tem uma precisão maior
                    // "N"  formato de numero apenas
                    // "P" formata para porcentagem
                    "C",  //converte para a moeda 
                    CultureInfo.CreateSpecificCulture("es-ES") // de onde vem a moeda
                )
            );
        Math.Round(valor); // faz o arrendondamento
        Math.Ceiling(valor); // arrendonda sempre para cima
        Math.Floor(valor); // sempre arredonda para baixo
        }
    }
}