using System;

namespace StructsCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            // OBS: VALORES PADRÃO - Quando alocamos (new) qualquer tipo estruturado 
            // (classe, struct, array) são atribuidos valores padrão aos seus elementos
            // numeros:0 ,  bool:False,  char:Caractere codigo 0, objeto:null
            // Lembrando: uma variavel apenas declarada, mas não instanciada, incia em estado
            // "nao atribuida", e o proprio compilador náo permite que ela seja acessada.

            // vamos declarar uma variavel tipo Point(o struct)
            Point p;     
            
                    // para que 'p' seja impresso, cada variavel terá que ser inicializado

            p.X = 10;      
            p.Y = 13;
            Console.WriteLine(p);

            //ou
                    // aqui as variaveis serao inicializados com o valor padrao, por causa da 
                    // alocação (new).

            p = new Point();
            Console.WriteLine(p);
        }
    }
}
