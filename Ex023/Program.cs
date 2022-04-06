namespace Ex023{
    class Program{
        static void Main(string[] Args){
            Menu();
        }
        static void Menu(){
            int idade = 0;
            int Qtd = 0;
            int i = 0;
            Console.WriteLine("Verificador de idade");
            Console.WriteLine("--------------------");
            while (i<10)
            {
                i++;
                Console.WriteLine("Digite a idade : ");
                idade = Convert.ToInt32(Console.ReadLine());
                if(idade>=18){
                    Qtd++;
                }
            }
            Console.WriteLine($"Existem {Qtd} pessoas com 18 anos ou mais.");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
    }
}