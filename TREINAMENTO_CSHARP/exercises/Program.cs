/*
double salario = 0;
double salario_novo = 0;
Console.WriteLine("efetua o reajuste salarial");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("informe o salário: ");
    salario = Convert.ToDouble(Console.ReadLine());
    if (salario <= 300)
    {
        //50%
        salario_novo = salario * 1.50;
    }
    else
    {
        salario_novo = salario * 1.30;
    }
    Console.WriteLine("Salário reajustado: " + salario_novo);
}
Console.ReadKey();
*/

double salario = 0;
double salario_novo = 0;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Digite o valor do seu salário: ");
    salario = Convert.ToDouble(Console.ReadLine());


    if (salario <= 300)
    {
        salario_novo = salario * 1.50;
    }
    else
    {
        salario_novo = salario * 1.30;
    }
    Console.WriteLine("Seu Salário com reajuste é: " + salario_novo);

}
Console.ReadKey();

