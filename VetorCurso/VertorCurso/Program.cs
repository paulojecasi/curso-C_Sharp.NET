using System;

namespace VertorCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de Itens do Vetor : ");
            int n = int.Parse(Console.ReadLine());

            double[] meuVetor =new double[n];

            int cont = 0;
            double valor = 100;

            // usando while

            while (cont < n)
            {
                meuVetor[cont] = valor;
                Console.WriteLine("WHILLE = Valor atribuido a posição " + 
                    cont + " = " + meuVetor[cont]);
                cont++;
                valor = valor+50;
            }

     
            // usando for

            double vallor = 70;
            for (int contt=0; contt < n; contt++)
            {
                meuVetor[contt] = vallor;
                Console.WriteLine("FOR = Valor atribuido a posição "
                    + contt + " = " + meuVetor[contt]);
                vallor = vallor + 150;

            }

            Console.WriteLine("                PROCESSO FINALIZADO !!");

        }
    }
}
