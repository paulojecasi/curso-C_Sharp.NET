using System;
using LinqComLambidaCurso.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LinqComLambidaCurso
{
    class Program
    {
        static void Main(string[] args)
        {

            Categoria c1 = new Categoria() { Id = 1, Name = "Ferramentas", Tier = 2 };
            Categoria c2 = new Categoria() { Id = 2, Name = "Brinquedos", Tier = 1 };
            Categoria c3 = new Categoria() { Id = 3, Name = "Calçados", Tier = 3 };
            Categoria c4 = new Categoria() { Id = 4, Name = "Confecção", Tier = 4 };

            static void Imprimir<I> (string mensagem, IEnumerable<I> colecao)
            {
                Console.WriteLine(mensagem);
                foreach (I objeto in colecao){
                    Console.WriteLine(objeto);
                }
                Console.WriteLine("----------------------------");
            }

            List<Produto> produtos = new List<Produto>(){
                new Produto() {Id = 1, Name = "MARTELO", Price = 1200.00, Categoria = c1 },
                new Produto() {Id = 2, Name = "CAMISA POLO", Price = 80.00, Categoria = c4 },
                new Produto() {Id = 3, Name = "SAPATO BICO FINO", Price = 120.00, Categoria = c3 },
                new Produto() {Id = 4, Name = "BONECA BARBIE", Price = 250.00, Categoria = c2 },
                new Produto() {Id = 5, Name = "CALÇÃO", Price = 40.00, Categoria = c4 },
                new Produto() {Id = 6, Name = "CHAVE DE FENDA", Price = 35.00, Categoria = c1 },
                new Produto() {Id = 7, Name = "CARRINHO DE CONTROLE", Price = 400.00, Categoria = c2 },
                new Produto() {Id = 8, Name = "SANDALIA", Price = 190.00, Categoria = c3 },
                new Produto() {Id = 9, Name = "MEIAO", Price = 20.00, Categoria = c4 },
                new Produto() {Id = 9, Name = "SERROTE", Price = 50.00, Categoria = c1 },
                new Produto() {Id = 9, Name = "CHAVE T", Price = 220.00, Categoria = c1 },

            };

            var resultado1 = produtos.Where(prod => prod.Categoria.Tier == 1);
            Imprimir("Produtos quando a importancia = 1 ", resultado1);

            var resultado2 = produtos.Where(prod => prod.Id == 9);
            Imprimir("Produto que o ID = 9 ", resultado2);

            var resultado3 = produtos.Where(prod => prod.Price < 100);
            Imprimir("Produto que o valor seja menor que 100 ", resultado3);

            var resultado4 = produtos.Where(prod => prod.Categoria.Id == 1 && prod.Price > 100);
            Imprimir("Produto que a CATEGORIA seja =1 e o valor maior que 100 ", resultado4);

            var resultado5 = produtos.Where(prod => prod.Categoria.Name == "Calçados");
            Imprimir("Produto que o NOME DA CATEGORIA seja CALÇADOS ", resultado5);

            var resultado6 = produtos.Where(prod => 
                        prod.Categoria.Name == "Calçados").Select(prod => prod.Name);
            Imprimir("Produto que o NOME DA CATEGORIA seja CALÇADOS(somente o nome) ", resultado6);


        }
    }
}
