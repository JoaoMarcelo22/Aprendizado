using System;

namespace Ex010{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
            
        }
        static void menu(){
            
            Console.Clear();
            Console.WriteLine("Digite a opção desejada:");
            Console.WriteLine("0-Sair ; 1-Soma ; 2-subtração ; 3-divisão ; 4-multiplicação ;  5-Media" );

            int.TryParse(Console.ReadLine(),out int opcao);
            switch(opcao){
                case 0 : System.Environment.Exit(0); break;
                case 1 : Soma(); break;
                case 2 : Subtracao(); break;
                case 3 : Divisao(); break;
                case 4 : Multiplicacao(); break;
                case 5: Media(); break;
                default : menu();break;
            }
            //if(opcao == 1){
            //    Soma();
           // }
            //else if(opcao == 2){
            //    Subtracao();
           // }
           // else if(opcao == 3){
           //     Divisao();
           // }
           // else if(opcao == 4){
           //     Multiplicacao();
           // }
           // else{
           //     Console.WriteLine("Opção invalida ");
           // }
        }
        static void Soma(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float.TryParse(Console.ReadLine(),out float n1);

            Console.WriteLine("Segundo valor: ");
            float.TryParse(Console.ReadLine(), out float n2);

            Console.WriteLine(" ");

            float resultado = n1 + n2;

            Console.WriteLine("O resultado da Soma é : "+ resultado);
            //Console.WriteLine($"O resultado é : {resultado}");
            //Console.WriteLine($"O resultado é : {v1 + v2}");
            //Console.WriteLine("O resultado é :" (v1 + v2));
            Console.ReadKey();
            menu();
        }
        static void Subtracao(){

            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float.TryParse(Console.ReadLine(), out float n1);

            Console.WriteLine("Segundo valor: ");
            float.TryParse(Console.ReadLine(), out float n2);

            Console.WriteLine("");

            float resultado = n1 - n2;

            Console.WriteLine("O resultado da subtração é : "+ resultado);
            Console.ReadKey();
            menu();
            
        }
        static void Divisao(){
            
            Console.Clear();
            Console.WriteLine("Digite o Primeiro numero : ");
            float.TryParse(Console.ReadLine(),out float n1);

            Console.WriteLine("Digite o Segundo valor : ");
            float.TryParse(Console.ReadLine(),out float n2);

            float resultado = n1 / n2;

            Console.WriteLine("");

            Console.WriteLine("O resultado da divisão é : " + resultado); 
            Console.ReadKey();
            menu();
        }
        static void Multiplicacao(){

            Console.Clear();

            Console.WriteLine("Digite o Primeiro numero : ");
            float.TryParse(Console.ReadLine(),out float n1);

            Console.WriteLine("Digite o Segundo numero : ");
            float.TryParse(Console.ReadLine(),out float n2);

            float resultado = n1 * n2;

            Console.WriteLine("");

            Console.WriteLine("O resultado da Multiplicação é : " + resultado);
            Console.ReadKey();
            menu();

        }
        static void Media(){
            Console.Clear();

            Console.WriteLine("Digite o Primeiro numero : ");
            float.TryParse(Console.ReadLine(),out float n1);

            Console.WriteLine("Digite o Segundo numero : ");
            float.TryParse(Console.ReadLine(),out float n2);

            float resultado = (n1 + n2) /2;

            Console.WriteLine("");

            Console.WriteLine("A media é : " + resultado );
            Console.ReadKey();
            menu();

        }
        
    }
        
}