
namespace Operators
{
    class Program
    {

        static void Main(string[] args)
        {

            int a = 10;
            int b = 2;

            //add
            int add = a + b;

            //sub
            int sub = a - b;

            //mult
            int mult = a * b;

            //div
            int div = a / b;

            //Rest div
            int rest = 5 % 2;

            //Primary - Operadores primários

            //x++
            //x--

            //Comparativos

            if (a > b)
                Console.WriteLine("a > b");

            if(b < a)
                Console.WriteLine("b < a");

            if (a >= b) // => - Lambda
                Console.WriteLine("a > b");

            if (b <= a)
                Console.WriteLine("b < a");

            //Equals
            if(a == b)
                Console.WriteLine("a == b");


            // NOT
            if (a != b)
                Console.WriteLine("a != b");

            //lógicos
            //XOR - Lógico Exclusivo - Um ou outro
            if (true ^ false)

            //condicionais
            //AND 
            if (true && true) ;
            Console.WriteLine("true");

            //OR
            if (false || true)
                Console.WriteLine("true");
        }
    }
}


/* operadores em c# eles vão além das operações básicas de matemática
 * No exemplo AND as duas afirmações devem ser verdadeiras
 * No exemplo OR uma das duas  afirmações precisa ser correta
 * No exemplo XOR um ou outro tem que ser verdadeiro nunca os dois
 */