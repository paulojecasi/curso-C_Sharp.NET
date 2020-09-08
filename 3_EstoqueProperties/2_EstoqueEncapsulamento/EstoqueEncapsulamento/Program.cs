using System;
using System.Globalization;

// AQUI VAMOR REVER ENCAPSULAMENTOS (GET E SETS) 

namespace EstoqueEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("BICICLETA", 550.00, 10);
            Console.WriteLine("Nome= {0}, Preco= {1} ",produto.GetNome(),produto.GetPreco());
            string nome1 = produto.GetNome();

            // alterando o nome pelo método SET
            produto.SetNome("BIKE DO SAARA");
            string nome2 = produto.GetNome();
            if (nome1 == nome2)
            {
                Console.WriteLine("ERRO! O Nome não foi alterado!");
            } else
            {
                Console.WriteLine("Nome alterado= " + produto.GetNome());
                Console.WriteLine("Nome Alterado Com Sucesso!");

            }



        }
    }
}
