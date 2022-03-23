using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Aula15();
        }

        static void Aula0()
        {
            var texto = "Testando " + " ";
            var texto2 = $"Testando {texto}";
            var texto3 = $"Testando {1 + 1}";
            var texto4 = @"\Testando \\";
            Console.WriteLine(texto);
            Console.WriteLine(texto2);
            Console.WriteLine(texto3);
            Console.WriteLine(texto4);
        }

        static void Aula1()  //COMPARANDO PALAVRA POR INTEIRO
        {
            var texto = "Testando";
            Console.WriteLine(texto.CompareTo("Testando")); // Retorna 1 - Verdadeiro
            Console.WriteLine(texto.CompareTo("testando")); // Retorna 0
            Console.WriteLine(texto.CompareTo("")); // Retorna 0
            Console.WriteLine(texto.CompareTo(null)); // Retorna 0
        }

        static void Aula2() //COMPARANDO PARTES DE UMA PALAVRA
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Contains("teste")); // true
            Console.WriteLine(texto.Contains("Teste")); // false
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase)); // true          IGNORA O CaseSensitive
            // Console.WriteLine(texto.Contains(null)); // ERRO
        }

        static void Aula3() //COMPARAÇÃO COMEÇA COM or TERMINA COM
        {
            var texto = "Este é um texto de teste";       
            Console.WriteLine(texto.StartsWith("Este")); // true
            Console.WriteLine(texto.StartsWith("este")); // false
            Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase)); // true         IGNORA O CaseSensitive

            Console.WriteLine(texto.EndsWith("Teste")); // false
            Console.WriteLine(texto.EndsWith("teste")); // true
            Console.WriteLine(texto.EndsWith("teste", StringComparison.OrdinalIgnoreCase)); // true          IGNORA O CaseSensitive
        }

        static void Aula4() //COMPARAÇÃO EXATAMENTE IGUAL
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Equals("Este é um texto de teste")); // true
            Console.WriteLine(texto.Equals("este é um texto de teste")); // false
            Console.WriteLine(texto.Equals("este é um texto de teste", StringComparison.OrdinalIgnoreCase)); // true               IGNORA O CaseSensitive
        }

        static void Aula5() //INDICE busca por tal caractere
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.IndexOf("é"));  // qual posição está o é
            Console.WriteLine(texto.LastIndexOf("s"));  // quais posições se encontra o caractere S
        }

        static void Aula6() //CONVERTER TEXTO MAIUSCULO / MINUSCULO
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.ToLower());  //converte todo o texto para minusculo
            Console.WriteLine(texto.ToUpper());  //converte todo o texto para maiusculo
        }

        static void Aula7() // ACRESCENTANDO UMA CADEIA DE CARACTERES POR UM INDICE
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Insert(5, "AQUI "));  //acrescenta um caractere em um indicie 
        }

        static void Aula8() //MEDIR QUANTOS CARACTERES TEM
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Length);       //calculando quantos caracteres tem
        }

        static void Aula9() // DELETANDO UMA CADEIA DE CARACTERES POR UM INDICE
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Remove(0, 5));    //excluindo um caractere por meio de dois indicies 
        } 

        static void Aula10() // TROCA DE UMA CADEIA DE CARACTERES POR OUTRA
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Replace("Este", "Isto"));     //trocando "Este" por "Isto"
            Console.WriteLine(texto.Replace("texto", "exemplo"));
        }

        static void Aula11() //SEPARAÇÃO DE UMA CADEIDA DE CARACTERES POR MEIO DOS SPAÇOS 
        {
            var texto = "Este é um texto, de teste";
            var divisao = texto.Split(','); //exemplo usando o "," para a separação dos caracteres e consequentemente transformando em listas
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            // Console.WriteLine(divisao[2]); // ERRO
        }

        static void Aula12() //SELECIONA OS CARACTERES
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Substring(0, 5));        //neste caso está selecionando o caractere 0 até o 5 ou seja "Este " com o espaço
            Console.WriteLine(texto.Substring(texto.LastIndexOf(" ") + 1, 5));
        }

        static void Aula13() //REMOVE OS ESPAÇOS
        {
            var texto = "Este é           um texto de teste";
            Console.WriteLine(texto.Trim());                       // remove os espaços do começo e no final

            texto = "       Este é um texto de teste             ";
            Console.WriteLine(texto.Trim());
        }

        static void Aula14() //CRIAÇÃO DE UMA SERIE DE CARACTERES SÓ
        {
            var texto = new StringBuilder(); // juntando todas as linhas em apenas uma
            texto.Append("Este");
            texto.Append("é");
            texto.Append("um");
            texto.Append(Environment.NewLine);
            texto.Append("texto");
            Console.WriteLine(texto.ToString());
        }

        static void Aula15()
        {
            // https://regexr.com/
            var regex = new Regex(@"([0-9])\w+");
            Console.WriteLine(regex.IsMatch("Este é um texto de teste"));
            Console.WriteLine(regex.IsMatch("Este 25 um texto de teste"));
        }

        static void Aula16()
        {
            Console.WriteLine(
                string.Compare(
                    "texto",
                    "texto"));

            Console.WriteLine(
                string.Compare(
                    "Isto é um texto",
                    "Isto e um texto",
                    CultureInfo.CurrentCulture,
                    CompareOptions.IgnoreNonSpace));

            Console.WriteLine(
                string.Compare(
                    "Isto é um texto",
                    "isto e um texto",
                    CultureInfo.CurrentCulture,
                    CompareOptions.IgnoreNonSpace));

            Console.WriteLine(
                string.Compare(
                    "Isto é um texto",
                    "isto e um texto",
                    CultureInfo.CurrentCulture,
                    CompareOptions.IgnoreSymbols));
        }
    }
}
