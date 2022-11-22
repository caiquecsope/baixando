// See https://aka.ms/new-console-template for more information


namespace selectionStatements
{
    class program
    {
        static void Main(string[] args)
        {
            #region if

            int a = 10;
            if (a == 5)
                {
                    Console.WriteLine("a = 5");
                }
                else
                {
                    Console.WriteLine("a <> 5");
                }
            Console.ReadKey();

        //    if (true)
        //        Console.WriteLine("OK"); - um if pode ser feito sem o Else normalmente.
        }
    }
}






//Posso declarar uma váriavel int a = 10; e posso perguntar se a é igual a 5 na sintaxe do c# é atribuido dois sinais de igual para comparação
// ele me da o retorno devido de acordo se a condição for aplicada ou não
// sempre quando tiver muitas condições dentro de um if significa que ele não está bem montado, para isso é importante usar a refatoração que é a otimização do meu código
// if (a == 5)
//  Console.WriteLine("a = 5");
// else
// Console.WriteLine("a <> 5");