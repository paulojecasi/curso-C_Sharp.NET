using System;
using System.Collections.Generic;
using System.Text;

// vamos rever propriedades (properties) 

namespace EstoqueProperties
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }   // Auto-properties
        private int _quantidade;


        // AO INVES DE UM GET E UM SET, VAMOS FAZER TUDO NUMA PROPERTIES 
        public string Nome
        {
            get 
            {
                return _nome;
            }
            set
            { 
  
                if (value == null)           //  se for nulo, não altera
                {
                    Console.WriteLine("ERRO!!   Informe um nome para que possa ser alterado!");
                }
                else if (value.Length < 4) // se tiver menos de 4 caracteres, nao altera
                {
                    Console.WriteLine("ERRO!!   O Nome deverá ter no minimo 4(quatro) caracteres");

                }
                else
                {
                    _nome = value;
       
                }
                
            }

        }

        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }

       
        public Produto(string nome, double preco, int quantidade)    // construtor
        {
            _nome = nome;
            Preco = preco;
            _quantidade = quantidade;
        }

        public Produto(string nome, double preco)                   //  sobrecarga usando o construtor
        {
            _nome = nome;
            Preco = preco;
            _quantidade = 100;    // quantidade automatica, caso o usuário digite 0 (ZERO)

        }

        public double ValorTotalEmEstoque()
        {
            double precoUnitario = Preco;
            double precoTotal = (Preco * _quantidade);

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



    }
}
