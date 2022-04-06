namespace Ex022{
    class Program{
        static void Main(string [] args){
           Menu();
        }
        static void Menu(){
            int r = 0;
            int n = 0; 
            Console.WriteLine("Identificador Impar/Par : ");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Digite um numero:");

            n = Convert.ToInt32(Console.ReadLine());
            r = n %2;
            if (r == 1){
                Console.WriteLine("O numero informado é Impar");
            }
            else{
                Console.WriteLine("O numero informado é Par");
            }
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
    }
}