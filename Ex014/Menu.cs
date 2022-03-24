using System;

namespace Ex014
{
    public static class Menu
    {
         public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }
        public static void DrawScreen(){
                ComandoUm();

            for(int lines = 0; lines <= 10; lines++){
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
                ComandoUm();
        }
        public static void ComandoUm(){
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }  
        public static void WriteOptions(){
            Console.SetCursorPosition(8,2);
            Console.WriteLine("Editor HTML :");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("=====================");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione uma opção : ");
            Console.SetCursorPosition(3,5);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3,9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,10);
            Console.WriteLine("Opção: ");

        } 

        public static void HandleMenuOption(short option)
        {
            switch(option){
                case 1 : Viewer.Show("");break;
                case 2 : Editor.Show();break;
                case 0 : { 
                    Console.Clear();
                    Environment.Exit(0);
                    break;}
                default: Show();break;
            }
        }
    }
}