


using System.Runtime.Intrinsics;

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
         //       Console.WriteLine("a > b");

            if (b < a)
           //     Console.WriteLine("b < a");

            if (a >= b) // => - Lambda
         //       Console.WriteLine("a > b");

            if (b <= a)
           //     Console.WriteLine("b < a");

            //Equals
            if (a == b)
        //        Console.WriteLine("a == b");


            // NOT
            if (a != b)
          //      Console.WriteLine("a != b");

            //lógicos
            //XOR - Lógico Exclusivo - Um ou outro
            if (true ^ false)

                //condicionais
                //AND 
                if (true && true) ;
            //   Console.WriteLine("true");

            //OR
            if (false || true)
                //       Console.WriteLine("true");

                /*     Console.WriteLine("Valor 1: ");
                 int p = int.Parse(Console.ReadLine());
                 Console.WriteLine("Valor 2: ");
                 int h = int.Parse(Console.ReadLine());

                 Console.WriteLine("Soma: " + Convert.ToString(p + h));
                 Console.WriteLine("Subtração: " + Convert.ToString(p - h));
                 Console.WriteLine("Multiplicação: " + Convert.ToString(p * h));
                 Console.WriteLine("Divisão: " + Convert.ToString(p / h));


                 if (p > 0 && h > 0)
                     Console.WriteLine("Valores p e h Maiores que zero");

                 if (p + h <= 0 || p - h <= 0 || p * h <= 0 || p / h <= 0) ;
                 Console.WriteLine("Uma ou mais opções possui um valor Menor ou igual a Zero");
                 Console.ReadKey(); */

                Console.WriteLine("Qual o valor 1?");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o Valor 2?");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("A soma dos valores é: " + Convert.ToString(p + h));
            Console.WriteLine("A média dos valores é: " + Convert.ToString((p + h)/2));
            Console.ReadKey();
        }
    }
}
