using System;
using System.IO;

namespace Ex012{
    class Program
    {
        static void Main(string[] args)
        {
           Menu(); 
            
        }
        static void Menu(){

            Console.Clear();
            Console.WriteLine("Faça uma escolha");
            Console.WriteLine(" 1 - Abrir Arquivo ");
            Console.WriteLine(" 2 - Editar Arquivo ");
            Console.WriteLine(" 0 - Sair");
            short opcao = short.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 0 : System.Environment.Exit(0); break;
                case 1 : Abrir(); break;
                case 2 : Editar(); break;
                

            }
        }
        static void Abrir(){
            Console.Clear();
            Console.WriteLine("Qual caminho do arquivo?");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path)) // adiciona o conteudo do arquivo na VAR file
            {
                string text = file.ReadToEnd();       // adiciona todo os caracteres no arvivo para a VAR text
                Console.WriteLine(text);
            }
            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }
        static void Editar(){
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("-------------------------------------");
            string text = "";

            do{
                text += Console.ReadLine();
                text += Environment.NewLine;
            }

            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);

        }
        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();    // salva os dados salvos em um arquivo fisico.( uma pasta)

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu();

        }
    }
}
