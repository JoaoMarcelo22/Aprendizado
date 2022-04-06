
namespace Ex021
{
    class Program
    {
        static void Main (string [] args){
            Principal();
        }
        static void Principal(){
            double idade1 = 0;
            double    idade2 = 0;
            double    idade3 = 0;
            double    idade4 = 0;
            double    idade5 = 0;
            double    total  = 0;
            Console.WriteLine("Digite as idades referente a cada aluno");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Digite a idade : ");
            idade1 = Convert.ToDouble(Console.ReadLine());
            Texto();
            idade2 = Convert.ToDouble(Console.ReadLine());
            Texto();
            idade3 = Convert.ToDouble(Console.ReadLine());
            Texto();
            idade4 = Convert.ToDouble(Console.ReadLine());
            Texto();
            idade5 = Convert.ToDouble(Console.ReadLine());
            total = (idade1+idade2+idade3+idade4+idade5)/5;
            Console.WriteLine("A Media das idades é " + total +" anos.");
        }
        static void Texto() {
            Console.WriteLine("Digite outra idade ; ");
        } 
    }
}
