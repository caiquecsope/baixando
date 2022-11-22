// See https://aka.ms/new-console-template for more information


using Microsoft.VisualBasic;

namespace ValueTypes
{
    class Progam
    {
        static void Main(string[] args)
        {
            int i = 10;
            string a = "Ok";
            float f = 10,89;
            double d = 98.9876;
            decimal c = 10.88M;
            Console.WriteLine(a);
            Console.WriteLine(i);
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}

namespace selectionStatements
{
    class program
    {
        static void Main(string[] args)
        {
            int a = 10;
            if (a == 5)
            {
                Console.WriteLine("a = 5");
            }
            else if (a == 10)
            {
                Console.WriteLine("a <> 5");
            }
            else if (a == 10)
            {
                Console.WriteLine("a == 8");
            }
            else
            {
                Console.WriteLine("a == " + a.ToString());
            }


        }
    }
}


/* Eu posso querer realizar multiplas verificações dentro de um código, no caso eu posso aninhar minha função if
 * else if() ele considera está validação como uma outra condição que só vai ser executada se a primeira não for atendida
 */