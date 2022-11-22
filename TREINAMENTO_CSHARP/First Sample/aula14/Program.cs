using System.Collections;

namespace ForeachStatement
{
    class Program
    {
        public struct livro
        {
            public String título;
            public String autor;
            public int código;
            public int anoPublicacao;
        }
        static void Main(string[] args)
        {
            livro l1 = new livro();
            l1.autor = "Machado de Assis";
            l1.código = 1;
            l1.título = "Dom Casmurro";
            l1.anoPublicacao = 1940;
            livro l2;
            l2.autor = "Jorge Amando";
            l2.código = 2;
            l2.título = "Dama";
            l2.anoPublicacao = 1965;

          /*  ArrayList livros = new ArrayList();
            livros.Add(l1);
            livros.Add(l2);

            foreach (livro item in livros)
            {
                Console.WriteLine("Livro Código:" + item.código.ToString());
                Console.WriteLine("Livro Autor:" + item.autor.ToString());
                Console.WriteLine("Livro Título:" + item.título);
                Console.WriteLine("Livro AnoPublicacao:" + item.anoPublicacao.ToString());
                Console.WriteLine("---------------------------------------------------------");
            }
            Console.ReadKey();
          */
            List <livro> livro = new List<livro>();
            livro.Add(l1);
            livro.Add(l2);
            

            foreach (livro item in livro)
            {
                Console.WriteLine("Livro Código:" + item.código.ToString());
                Console.WriteLine("Livro Autor:" + item.autor.ToString());
                Console.WriteLine("Livro Título:" + item.título);
                Console.WriteLine("Livro AnoPublicacao:" + item.anoPublicacao.ToString());
                Console.WriteLine("---------------------------------------------------------");
            }
          
            Console.ReadKey();

        }
    }
}


/* é preciso criar um ArrayList para que o mesmo possa conter uma coleção de livros no caso o l1 e o l2 do meu exemplo
 * Quando eu tenho um tipo de coleção de informações que possui um enumerador pois possui mais de um item assim posso usar o foreach
 * Para cada um dos itens encontrados dentro da execução ele vai executar a linha de código, o arraylist é algo bem genérico só para facilitar o entendimento
 * É muito usado em varreduras de coleções
 * O exemplo acima é a base para aprender a utilizar as estruturas que são tão importantes
 * No exemplo abaixo seria a forma correta de se fazer o foreach pois dessa forma n se pode conter valores duplicados ou distintos.
 */