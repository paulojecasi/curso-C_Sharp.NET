using System;
using System.Globalization;

namespace Estoque
{
    class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)    // construtor
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade; 
        }
        
        public Produto(string nome, double preco)                   //  sobrecarga usando o construtor
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 100;    // quantidade automatica, caso o usuário digite 0 (ZERO)

        }

        public double ValorTotalEmEstoque()
        {
            double precoUnitario = Preco;
            double precoTotal = (Preco * Quantidade);

            return precoTotal;

        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = (Quantidade + quantidade);
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade = (Quantidade - quantidade);
        }


        public override string ToString()
        {
            return 
               "Descrição: "    + Nome                                     + " - " +
               " Vl Unitario: " + Preco.ToString("F2", 
                                    CultureInfo.InvariantCulture)          + " - " +
               " Quantidade: "  + Quantidade              + " Unidades - " +
               " Vl Total: "    + ValorTotalEmEstoque().ToString("F2", 
                                    CultureInfo.InvariantCulture);
        }


    }
}
