using System.Collections;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[3];
            a1[0] = 10;
            a1[1] = 20;
            a1[2] = 30;
            int[,] ma1 = new int[5, 10];
            ma1[0, 0] = 10;

            int[] a2 = new int[] { 10, 20, 30 };
            bool[] a3 = new bool[] { true, false, true };

            string[] a4 = { "one", "two", "three" };

            ArrayList a5 = new ArrayList();
            a5.Add(10);
            a5.Add("Ok");
            a5.Add(true);

            List<int> l1 = new List<int>();
            l1.Add(10);
            l1.Add(20);
            l1.Add(30);

            List<bool> l2 = new List<bool>();  
        }
    }
}



/* O arraylist poderia adicionar qualquer valor, internamente ele realiza a técnica de boxing transformando as informações em objeto só que isso n me permite ter uma performance tão rápida.
 * O conceito de lista ele utiliza o assembly sistemconnection generic list que funciona com a seguinte sintaxe list<int>
 * botão direito em cima da assembly e clique no go to definition para verificar os métodos e propriedades disponíveis ou usando o nome do meu assembly com um ponto na frente ex .list
 * Generic vai me dar mais recursos de busca de informações fortemente tipado, tipo = int, bool, float e etc
 */