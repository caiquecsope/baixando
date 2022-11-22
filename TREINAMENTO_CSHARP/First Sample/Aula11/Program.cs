// See https://aka.ms/new-console-template for more information


namespace InterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            
            do
            {
                a++;

                Console.WriteLine(a.ToString());
            } while (a < 10);

         /*   while (a < 10)
            {
                Console.WriteLine(a.ToString());
            } 
         */

        }
    }
}


/* DO {} WHILE() que me diz faça alguma coisa enquanto está condição informada for verdadeira, podemos usar os sinais de > < = para uma funcionalidade específica
 *  enquanto a for menor que 10 ele vai ficar imprindo os valores na tela, caso eu não queira que sse loop seja infinito ele vai aumentar o valor do a cade vez que ele é passado
 * f11 para avançar linha a linha no debug, f5 avança todas as linhas de uma vez até o breakpoint
 * while - No caso ele faz a verificação primeiro do item se n for compatível ele nem executa o código.
 * Quando tiver uma situação de loop qualquer é possível fazer um break no código
 */