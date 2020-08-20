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
            medidaX = TrianguloX(x1, x2, x3);
            Console.WriteLine("areaX é >>>>>> " + medidaX.ToString("F4"));

            medidaY = TrianguloY(y1, y2, y3);
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


        }

        static double TrianguloX(double xa, double xb, double xc)
        {
            /* vamos calcular valor de P
             *       a + b + c
             * p = --------------
             *           2
             */
            
            double p = (xa + xb + xc) / 2;


            /* vamos calcular a raiz quadrada 
             *      ______________________________
             *  area = V     p(p-a) (p-b) (p-c)
             */

            double areaX = Math.Sqrt(p *(p-xa)*(p-xb)*(p-xc));

            return areaX;

        }

        static double TrianguloY(double ya, double yb, double yc)
        {
            /* vamos calcular valor de P
            *       a + b + c
            * p = --------------
            *           2
            */

            double p = (ya + yb + yc) / 2;


            /* vamos calcular a raiz quadrada 
             *      ______________________________
             *  area = V     p(p-a) (p-b) (p-c)
             */

            double areaY = Math.Sqrt(p * (p - ya) * (p - yb) * (p - yc));

            return areaY;


        }
    }
}
