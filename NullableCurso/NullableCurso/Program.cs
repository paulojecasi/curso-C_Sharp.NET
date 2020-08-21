using System;

namespace NullableCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            // para uma variavel aceitar valor NULL, a mesma terá um ? na frente

            double? x = null;
            double? y = 10.0;

            // o GetValueOrDefault vai trazer o valor default(x=0), caso a variavel não
            // seja preenchida
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            // o HasValue verifica se o variavel tem valor, retorna False ou True 
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);


            //aqui, veremos como fazer para uma variavel aceitar outra de valor NULL, e
            // vamos substituir o valor NULL por outro qualquer

            y = x ?? 10;    // se X for NULL, vamos atribuir o valor 10 em Y 
            Console.WriteLine("=== " + y);

        }
    }
}
