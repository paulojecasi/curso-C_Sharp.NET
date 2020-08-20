using System;
using System.Globalization;
using System.Xml.Linq;

namespace MedidaDoTriangulo
{
    class Program
    {

        /* calculo para area do triangulo ( formula de Heron) 
         *          ______________________________
         *  area = V     p(p-a) (p-b) (p-c)
         * 
         *      onde
         * 
         *         a + b + c    
         *  p = --------------
         *             2
         * 
         */

        static void Main(string[] args)
        {
            double x1, x2, x3, y1, y2, y3, medidaX, medidaY;

            Console.WriteLine("------Entre com as medidas do TRIANGULO X -------");
            Console.Write("Lado 01 = ");
            x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado 02 = ");
            x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado 03 = ");
            x3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("------Entre com as medidas do TRIANGULO Y -------");
            Console.Write("Lado 01 = ");
            y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado 02 = ");
            y2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado 03 = ");
            y3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("------ Resultado -------");
            medidaX = CalculaArea(x1, x2, x3);
            Console.WriteLine("areaX é >>>>>> " + medidaX.ToString("F4"));

            medidaY = CalculaArea(y1, y2, y3);
            Console.WriteLine("area Y é >>>>>> " + medidaY.ToString("F4"));

            Console.WriteLine("------ A Maior área é -------");
            if (medidaX > medidaY)
            {
                Console.WriteLine("Area X é maior que a area Y");
            } else if (medidaX < medidaY)
            {
                Console.WriteLine("Area Y é maior que a area X");
            } else
            {
                Console.WriteLine("Area X é igual a area Y");
            }

            Console.ReadLine();
            

        }

        static double CalculaArea(double a, double b, double c)
        {
            /* vamos calcular valor de P
             *       a + b + c
             * p = --------------
             *           2
             */
            
            double p = (a + b + c) / 2;


            /* vamos calcular a raiz quadrada 
             *      ______________________________
             *  area = V     p(p-a) (p-b) (p-c)
             */

            double area = Math.Sqrt(p *(p-a)*(p-b)*(p-c));

            return area;

        }

    }
}
