using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EstoqueEncapsulamento
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        // para que o nome possa ser impresso depois de instanciado , somente pelo metodo GET
        public string GetNome()
        {
            return _nome;
        }

        public double GetPreco()
        {
            return _preco;
        }

        // para alterar o nome, somente pelo método SET
        public string SetNome(string nome)
        {
            if (nome == null)           //  se for nulo, não altera
            {
                Console.WriteLine("ERRO!!   Informe um nome para que possa ser alterado!");
            } else if (nome.Length < 4) // se tiver menos de 4 caracteres, nao altera
            {
                Console.WriteLine("ERRO!!   O Nome deverá ter no minimo 4(quatro) caracteres");

            } else 
            {
                _nome = nome;
         
            }
            return _nome;

        }


        public Produto(string nome, double preco, int quantidade)    // construtor
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public Produto(string nome, double preco)                   //  sobrecarga usando o construtor
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 100;    // quantidade automatica, caso o usuário digite 0 (ZERO)

        }

        public double ValorTotalEmEstoque()
        {
            double precoUnitario = _preco;
            double precoTotal = (_preco * _quantidade);

            return precoTotal;

        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade = (_quantidade + quantidade);
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade = (_quantidade - quantidade);
        }


        public override string ToString()
        {
            return
               "Descrição: " + _nome + " - " +
               " Vl Unitario: " + _preco.ToString("F2",
                                    CultureInfo.InvariantCulture) + " - " +
               " Quantidade: " + _quantidade + " Unidades - " +
               " Vl Total: " + ValorTotalEmEstoque().ToString("F2",
                                    CultureInfo.InvariantCulture);
        }


    }
}
