using System;

namespace EstoqueProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("BICICLETA", 550.00, 10);
            string nome = produto.Nome;
            double preco = produto.Preco;
            Console.WriteLine("Nome= {0}, Preco= {1} ", nome, preco);

            // alterando o nome pelo método SET
            produto.Nome= "BIKE";
            string nome2 = produto.Nome;
            if (nome == nome2)
            {
                Console.WriteLine("ERRO! O Nome não foi alterado!");
            }
            else
            {
                Console.WriteLine("Nome alterado= " + produto.Nome);
                Console.WriteLine("Nome Alterado Com Sucesso!");

            }
        }
    }
}
