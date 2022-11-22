

namespace AnonymousTypes
{
    class Program
    {

        static void Main(string[] args)
        {
            var valores = new[] { new { idade = 18, nome = "luis" }, new { idade = 20, nome = "Alberto" } };

            foreach (var item in valores)
            {
                Console.WriteLine("Idade: " + item.idade.ToString());
                Console.WriteLine("Nome: " + item.nome);
                Console.WriteLine("____________________________________________");

                string[] nomes = { "andré", "Caio","Breno", "Carlos"};

                foreach (string nome in nomes)
                {
                    Console.WriteLine(nome);
                }

                int[] num = { 1, 2, 3, 4 };
                foreach (int numeros in num)
                {
                    Console.WriteLine(numeros);
                }
            }
        }
    }
}


/* Os anonymous types abrem a tipificação para que eu n precise ter todas as informações fortementes tipadas
 * A sua principal utilidade é eu usar uma variável sem ter que determinar um tipo de variável
 * Devo saber quando eu vou utilizar os anonymous pois as variáveis na maioria das vezes deve receber um valor
 * O anonymous tem problemas pois ele n pode declarar um valor como nullo, obrigatóriamente ele deve atribuir valores
 * Para que eu possa anular eu preciso transformar ela um nullable, para que uma variável se torne anulável eu preciso fazer da seguinte forma ( int? i = null)
 */