using System;
using System.Linq;

namespace LinqCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            // especificação do data source (Fonte de dados)
            // vetor
            int[] numero = new int[] { 1, 2, 3, 4, 5, 6, 7,8,9,10,11,12,13,14 };

            // definir a query (consulta) atravéz do LINQ (tem que usar a biblioteca LINQ)
            var resultado_par = numero.Where(x => x % 2 == 0);
            var resultado_impar = numero.Where(x => x % 2 != 0);

            var resultado_impar10 = numero.Where(x => x % 2 != 0).Select(x => x*10);

            var resultado_m_10 = numero.Where(x => x > 10);

            // imprimir a consulta (query) 
            Console.WriteLine("------- Os numero pares selecionados foram:");
            foreach (int res_par in resultado_par) {
                Console.WriteLine(". " + res_par);
            }

            Console.WriteLine("------- Os numero impares selecionados foram:");
            foreach (int res_impar in resultado_impar)
            {
                Console.WriteLine(". " + res_impar);
            }

            Console.WriteLine("------- Os numero impares MULTIPLICADO POR 10:");
            foreach (int res_impar10 in resultado_impar10)
            {
                Console.WriteLine(". " + res_impar10);
            }

            Console.WriteLine("------- Os numero MAIORES que 10:");
            foreach (int res_m_10 in resultado_m_10)
            {
                Console.WriteLine(". " + res_m_10);

            }





        }
    }
}
