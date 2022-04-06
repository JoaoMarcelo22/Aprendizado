namespace Ex024{
    class Program{
        static void Main(string[]args){
            Menu();
        }
        static void Menu(){
            double salario = 0;
            double salarioNovo = 0;
            Console.WriteLine("Calculo Salario novo");
            Console.WriteLine("--------------------");
            for ( int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o seu salario : ");
                salario = Convert.ToDouble(Console.ReadLine());
                if(salario<= 300){
                    salarioNovo = salario * 1.5; 
                }
                else if(salario > 300 && salario <= 500){
                    salarioNovo = salario + (salario * 0.3);
                }
                else{
                    salarioNovo = salario + (salario * 0.2);
                }
            Console.WriteLine($"Seu novo salario é {salarioNovo}");
            Console.WriteLine("----------------------------");
            }
        Console.ReadKey();
        Console.Clear();
        Menu();
        }
    }
}