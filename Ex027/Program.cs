using System;

namespace Ex027{
    class Program{
        static void Main(string[]args){
            Executavel();
        }
        static void Executavel(){
            Pessoa p1;
            Pessoa p2;
            Pessoa p3;
            Console.WriteLine("Determina qual é a pessoa mais velha");
            Console.WriteLine("Nome da primeira pessoa");
            p1 = new Pessoa();
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade da primeira pessoa");
            p1.Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nome da segunda pessoa");
            p2 = new Pessoa();
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade da segunda pessoa");
            p2.Idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nome da terceira pessoa");
            string nome = Console.ReadLine();
            Console.Write("Idade da terceira pessoa");
            int idade = Convert.ToInt32(Console.ReadLine());
            p3 = new Pessoa(nome,idade);

            if ((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é : ");
                p1.ExibirDados();
            }
            else if ((p2.Idade > p1.Idade) && (p2.Idade > p3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é : ");
                p2.ExibirDados();
            }
            else if ((p3.Idade > p2.Idade) && (p3.Idade > p1.Idade))
            {
                Console.WriteLine("A pessoa mais velha é : ");
                p3.ExibirDados();
            }
            else{
                Console.WriteLine("Todos tem a mesma idade: ");
            }
            Console.ReadKey();
              
        }
    }
    public class Pessoa{
        public Pessoa(){
            this.Nome = "";
            this.Idade = 0;
        }
        public Pessoa(string nome, int idade){
            this.Nome = nome;
            this.Idade = idade;
        }
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }
        private int Idade;
        public int Idade
        {
            get { return idade; }
            set { 
                if (value >= 0)
                {
                    idade = value;
                }
                else
                {
                    this.idade = 0; 
                }
             }
        }
        public void ExibirDados()
        {
            Console.WriteLine("Nome: "+ this.Nome);
            Console.WriteLine("Idade: "+ this.Idade);
        }
        
        
    }
}