// See https://aka.ms/new-console-template for more information

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        { 
            string s1 = "one,two,three";

            string s2 = "one";

            s2 += ",two";
            s2 += ",Three";

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("one");
            sb.Append(",two");
            sb.Append(",three");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(sb);
            Console.ReadKey();

            // s2.EndsWith("ree");
            // s2.Equals("");
            //s2.GetType();
            //  s2.IndexOf("two");
            // sb.ToString();
           // s2.Insert(4, "Ok");
            Console.WriteLine(s2.Insert(4, "OK"));
        }
    }

  
    }




// Se eu tenho uma string informando um valor eu tenho como utilizar ela para realizar um calculo
// Uma das possíveis formas é realizar uma concatenação

// as 3 formas acima sendo a s1, s2 ou sb fazem a mesma função de mostrar one, two e three  utilizando strings.
// s2.EndsWith ele consegue pesquisar e retornar um buleano se eu passar uma sequência de caracteres retornando verdadeiro ou falso
// s2.Equals faz uma comparação com uma string ou outro objeto para verificar se um método é igual ao outro
// s2.GetType pego o tipo do valor no exemplo acima é uma string
// s2.IndexOf ele mostra onde ocorre os comandos dentro da string
// sb.ToString Podemos usar o ToString no StringBuilder para buscar essas informações
// s2.Insert ele pode ser usado para colocar um valor em uma string no exemplo acima é no ponto 4.
