using System;

namespace MatrizCurso
{
    // REVENDO MATRIZ 
    class Program
    {
        static void Main(string[] args)
        {
            double[,] minhaMatriz = new double[2, 3]; //criei uma matriz com 2 LINHAS e 3 COLUNAS

            Console.WriteLine("Elementos Total da MATRIZ = " + minhaMatriz.Length);
            Console.WriteLine("primeira dimensão - Quantidade de Linhas da MATRIZ = " +
                minhaMatriz.Rank);

            Console.WriteLine("primeira dimensão - Quantidade de Linhas da MATRIZ = " +
                minhaMatriz.GetLength(0));
            Console.WriteLine("segunda dimensão - Quantidade de Colunas da MATRIZ = " +
                minhaMatriz.GetLength(1));
        }

    }
}
