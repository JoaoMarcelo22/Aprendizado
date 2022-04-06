namespace Ex025{
    class Program{
        static void Main(string[]args){
            Menu();
        }
        static void Menu(){
            String maMatricula;
            Double maAltura;

            String meMatricula;
            Double meAltura;

            String Matricula;
            Double Altura;

            int i = 1;

            Console.WriteLine("Determinar o maior aluno e o menor aluno");
            Console.Write("Matricula : ");
            Matricula = Console.ReadLine();
            Console.Write("Altura : ");
            Altura = Convert.ToDouble(Console.ReadLine());

            maAltura = Altura;
            meAltura = Altura;
            maMatricula = Matricula;
            meMatricula = Matricula;

            while ( i < 3 ){
                Console.WriteLine("Determinar o maior aluno e o menor aluno");
                Console.Write("Matricula : ");
                Matricula = Console.ReadLine();
                Console.Write("Altura : "); 
                Altura = Convert.ToDouble(Console.ReadLine());
                if(maAltura< Altura){
                    maAltura = Altura;
                    maMatricula = Matricula;
                }
                else if(meAltura > Altura){
                    meAltura = Altura;
                    meMatricula = Matricula;
                }
                i++;
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Maior aluno");
            Console.WriteLine($"Matricula : {maMatricula} Altura : {maAltura}");
            Console.WriteLine("Menor aluno");
            Console.WriteLine($"Matricula : {meMatricula} Altura : {meAltura}");
            Console.ReadKey();
        }
    }
}