using System;


namespace MedidaDoTriangulo
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {

            Console.WriteLine(A + "-" + B + "-" + C);

            /* vamos calcular valor de P
             *       a + b + c
             * p = --------------
             *           2
             */

            double p = (A + B + C) / 2;


            /* vamos calcular a raiz quadrada 
             *      ______________________________
             *  area = V     p(p-a) (p-b) (p-c)
             */

            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return area;

        }
    }
}
