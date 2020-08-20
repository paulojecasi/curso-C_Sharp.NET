using System;

namespace Funcao
{

    // AQUI VEREMOS COMO FAZER UMA FUNÇÂO EM C#
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- INFORME 3 NUMEROS ---");
            Console.Write("Digite o Primeiro Numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo Numero: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o Terceiro Numero: ");
            int n3 = int.Parse(Console.ReadLine());

            int maiorEscolhido = NumeroMaior(n1, n2, n3);

            Console.WriteLine("O Maior Numero Escolhido Foooiiiii o " + maiorEscolhido);

        }

        // AQUI VAMOS FAZER UMA FUNÇAO 

        static int NumeroMaior(int a, int b, int c)
        {
            int maior = 0;
            if (a > b && a > c)
            {
                maior = a;
            }
            else if (b > a && b > c)
            {
                maior = b;
            }
            else if (c > a && c > b)
            {
                maior = c;
            }
            else
            {
                maior = 0;
            }

            return maior;

        }
    }
}
