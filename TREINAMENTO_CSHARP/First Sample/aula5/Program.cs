// See https://aka.ms/new-console-template for more information



using System.Runtime.Versioning;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            object o = (object)a;

           Console.WriteLine(o.GetType().ToString());

            int b = (int)o;


            Console.WriteLine(b);

            System.Type t = b.GetType();
            t.ToString();

           Console.ReadLine();
        }
    }
}

//object recebe os valores e qualquer coisa você consegue guardar dentro de um object, dentro desse conceito de box ou unboxing que todo tipo de operação que é preciso trabalhar dentro de um object
// ela precisa de uma condição especial 
//System.Type - é uma definição do FrameworkName de uma declaração de tipo de uma classe