// See https://aka.ms/new-console-template for more information

namespace SelectionStatements
{
    class program
    {
        static void Main(string[] args)
        {
            int a = 10;

            if (a == 5)
            {
                Console.WriteLine("a = 5");

                int b = (a < 10) ? 5 : 0;

            }
            else if(a == 10)
            {
                Console.WriteLine("a == 10");
            }
            else if(a == 8)
            {
                Console.WriteLine("a == 8");
            }
            else
            {
                Console.WriteLine("a == " + a.ToString());
            }

            int number;

            Console.Write("Number? ");
            number = Convert.ToInt32(Console.ReadLine());

            if ((number == 9) || (number == 10))
                Console.WriteLine("Sobresaliente");
            else if ((number == 7) || (number == 8))
                Console.WriteLine("Notable");
            else if (number == 6)
                Console.WriteLine("Bien");
            else if (number == 5)
                Console.WriteLine("Aprobado");
            else if ((number >= 0) && (number <= 4))
                Console.WriteLine("Suspenso");
            else
                Console.WriteLine("No válido");

            /*  double f = 4;
              if (f >= 9.10)
                  {
                      Console.WriteLine("sobresaliente");            
                  }
              else if(f == 7.8)
                  {
                      Console.WriteLine("Notável");
                  }
              else if (f == 6)
                  {
                      Console.WriteLine("Bien");
                  }
              else if (f == 5)
                  {
                  Console.WriteLine("Aprovado");
                  }
              else
              {
                  Console.WriteLine("a == Suspenso");
              }

              switch(f)
              {
                  case 9.10:
                          Console.WriteLine("Sobresaliente");
                      break;
                  case 7.8:
                      Console.WriteLine("Notável");
                      break;
                  case 6:
                      Console.WriteLine("bien");
                      break;
                  case 5:
                      Console.WriteLine("aprovado");
                      break;
                  default:
                      Console.WriteLine(f.ToString("Reprovado"));
                      break;

              }
             */


            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 0:
                    Console.WriteLine("c == 0");
                    break;
                case 5:
                    Console.WriteLine("c == 5");
                    break;
                case 10:
                    Console.WriteLine("c == 10");
                    break;
                default:
                    Console.WriteLine("c ==" + c.ToString());
                    break;
            }
            Console.ReadKey();
        }
    }
}




/* Eu posso querer realizar multiplas verificações dentro de um código, no caso eu posso aninhar minha função if
 * else if() ele considera está validação como uma outra condição que só vai ser executada se a primeira não for atendida
 * Eu posso tammbém colocar um if dentro do outro também mas ter um if grande demanda muito uso do processamento pela condição estabelecida
 * Posso fazer um teste usando um atalho, int b = (a < 10) ? 5 :0; - neste caso eu tenho uma variável b se a for menor que 10 então o valor de b vai ser 5 senão 0 
 * Switch é um comando para if aninhado ele  precisa de uma declaração, e eu posso realizar uma série de testes, para essas condições ao invés de eu fazer um if eu uso um case e quando o comando chegar ao fim preciso usar o break para sair do switch
 * No exemplo acima estamos fazendo o switch Passar por algumas condições onde eu digito um valor e ele faz as comparações para isso usamos o conversor int.Parse
 */