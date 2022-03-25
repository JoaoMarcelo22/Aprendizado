using System;
using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();                    //array como inteiro

            var meuArray = new int[5]{1,2,3,4,5};// new é usado para todas as referencias
            //var meuArrai = new Teste[1]{new Teste(), new Teste()}

           // meuArray.Length;
            meuArray[0] = 12;

            foreach(var item in meuArray)  //pra cada 
            {
                Console.WriteLine(item);
            }
            var funcionarios = new funcionario[5];
           // funcionarios[0] = new funcionario(){ Id = 2579, Nome="joao"}; //inicialização para qualquer item no C#

            foreach( var funcionario in funcionarios){
                Console.WriteLine(funcionario.Id);
            }






















          //  for (var index = 0; item <= meuArray.Length;index++){  // um modo de percorrer uma array
           //         Console.WriteLine(meuArray[index]);
            }

           // Console.WriteLine(meuArray[0]);
        }
        struct Teste
        {
            public int Id {get; set;}
            public int Nome {get; set;}
        }
    }
    public struct funcionario{
        public int Id {get; set;}
    }

