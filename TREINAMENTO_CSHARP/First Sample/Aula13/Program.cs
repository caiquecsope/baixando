

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
            Console.WriteLine(l1);
            Console.ReadKey();
        }
    }
}


/* O static void Main é chamado sempre que minha aplicação é inicializada, também temos uma classe e essa classe ela pode receber declarações de variáveis para ser executada durante todo o scopo de classe
 * Existem situações que eu preciso representar algo em mais de uma variável, quando eu tenho essa situação uma das estruturas mais básicas dentro do C# é o chamado struct que é a representação de estrutura
 * Para ter uma estrutura ela precisa ser declarada através do public Struct e os atributos dentro dela qualificam e identificam minha estrutura.
 * O segundo passo representa essa estrutura de um modelo definido. No caso um livro, no exemplo o new diz que a declaração do livro l1 vai receber uma nova instância
 * eu tenho sempre da minha declaração um esqueleto da forma como ela vai funcionar, e sempre na declaração dessas variáveis haverão uma objetificação com informações específicas em suas instâncias.
 * A minha estrutura de dados possui uma personificação limitada quando eu quero reprensentar seus valores preciso colocá-los de forma concreta. 
 */