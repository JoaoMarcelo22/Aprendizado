using System;

namespace Ex026{
    class Program{
        static void Main(){
            Executavel();
        } 
        static void Executavel(){
            Animal a1 = new Animal();
            int tlCachorro = 0, tlGato = 0, tlPeixe = 0, i=0;

            Console.WriteLine("Controle de animais");

            while(i<3){
                
            Console.WriteLine("Informe o Nome do animal:");
            a1.Nome = Console.ReadLine();
            Console.WriteLine("Informe o Tipo : ");
            a1.Tipo = Console.ReadLine();
            Console.WriteLine("------------------------");

            if (a1.Tipo == "cachorro") tlCachorro++;
            if (a1.Tipo == "gato")tlGato++;
            if (a1.Tipo == "peixe")tlPeixe++;
            i++;
            }
            Console.WriteLine($"Cachorros : {tlCachorro}\n Gatos    : {tlGato} \n Peixes   : {tlPeixe}");
        }
    }
    public class Animal{
        private String nome;

        public String Nome
        {
            get{return nome;}
            set{nome = value.ToUpper();}
        }
        private String tipo;
        public String Tipo
        {
            get { return tipo; }
            set 
            { 
              string tipoC = value.ToLower();
                if(tipoC == "cachorro"|| tipoC =="gato" || tipoC == "peixe")
                   {
                    tipo = tipoC;
                   } 
                else{
                    tipo = "peixe";
                }
            }
        }
        

    }
}