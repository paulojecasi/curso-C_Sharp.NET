using System;


// EXPRESSAO CONDICIONAL TERNARIA 
// Estrutura opcional ap if-else quando se deseja decidir um VALOR com base em uma condição

//SINTAXE:
// (condição) ? valor_se_verdadeiro : valor_se_falso

namespace ExpressaoTernariaCurso
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe valor para que seja aplicado e desconto: ");
            double valor = double.Parse(Console.ReadLine());
            double desconto = 0;

            // COM IF FICA ASSIM 

            if (valor < 100)
            {
                desconto = valor * 0.1;
            }
            else
            {
                desconto = valor * 0.05;
            }

            Console.WriteLine("(IF) Valor com desconto é " + (valor - desconto));

            // EXPRESSAO CONDICIONAL TERNARIA, FICA ASSIM

            desconto = (valor < 100) ? desconto = valor * 0.1 : desconto = valor * 0.05;
            Console.WriteLine("(TER) Valor com desconto é " + (valor - desconto));


        }
    }
}
