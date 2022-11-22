// See https://aka.ms/new-console-template for more information



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
            ma1[0,0] = 10;

            int[] a2 = new int[] { 10, 20, 30 };
            bool[] a3 = new bool[] {true, false, true };

            string[] a4 = { "one", "two", "three" };

            ArrayList a5 = new ArrayList();
            a5.Add(10);
            a5.Add("Ok");
            a5.Add(true);
        }
    }
}


// no int[] foi declarado a array a1 de tamanho definido 3 para agregar 3 valores dentro desta estrutura
// devo fazer uma declaração do a1 de 0 a 2
// no int[,] é uma array multidimensional onde você define o número de linhas e colunas 
// no int[] a2 no caso estou fazendo a mesma declaração de cima mas de forma diferente.
// O array possui um tamanho de scopo definido só que as vezes eu tenho que inserir valores dentro desta estrutura e ai é necessário setar valores de tamanho para minha array
// tem um library chamada System.collections que pode listar o que eu posso ou n inserir nos tamanhos
// tenho o ArrayList que é uma lista onde tenho uma série de métodos onde posso fazer inserções de tipos diferentes com tamanhos definidos, um método de clear onde ele limpa todos os dados e um método de adição
// onde posso inserir ao mesmo tempo um valor inteiro, string e boleano também