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

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("------Entre com as medidas do TRIANGULO X -------");
            Console.Write("Lado 01 = ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado 02 = ");
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado 03 = ");
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("------Entre com as medidas do TRIANGULO Y -------");
            Console.Write("Lado 01 = ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado 02 = ");
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado 03 = ");
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("------ Resultado -------");
            medidaX = x.CalculaArteaTriangulo();
            Console.WriteLine("areaX é >>>>>> " + medidaX.ToString("F4"));

            medidaY = y.CalculaArteaTriangulo();
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

    }
}
