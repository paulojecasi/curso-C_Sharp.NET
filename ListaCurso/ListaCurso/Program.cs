using System;
using System.Collections.Generic;

namespace ListaCurso
{
    // revendo LISTAS
    class Program
    {
        static void Main(string[] args)
        {
            List<string> minhaLista = new List<string>();

            //-------------- adicionar elementos na lista ADD
            minhaLista.Add("Paulo");
            minhaLista.Add("Vanessa");
            minhaLista.Add("Lidia");
            minhaLista.Add("Ana Beata");
            minhaLista.Add("Evelyn");
            minhaLista.Add("Victoria");
            minhaLista.Add("Rackel");
            minhaLista.Add("Cristina");
            minhaLista.Add("Cardoso");
            minhaLista.Add("Cabral");
            minhaLista.Add("Silva");
            minhaLista.Add("Jesus");


            foreach (string itensDaLista in minhaLista)
            {
                Console.WriteLine("1- " + itensDaLista);
            }

            //----------INSERT, aqui podemos escolher a posição do elemento
            //----------sobrepondo e elemento da posição escolhida

            minhaLista.Insert(2, "Lidia Raquel");

            foreach (string itensDaLista in minhaLista)
            {
                Console.WriteLine("2- " + itensDaLista);
            }

            Console.WriteLine("Tamanho da lista= " + minhaLista.Count);

            //----------- procurando dados na lista/ usando a função LAMBDA

                    //--- procurar o nome onde a primeira ocorrencia seja = V  
            string procuraNome = minhaLista.Find(nome => nome[0] == 'V');
            Console.WriteLine("Nome que a primeira ocorrencia comece com V = " + procuraNome );

            //--- procurar o nome onde a ultima ocorrencia seja = V  
            string procuraNomeUlt = minhaLista.FindLast(nome => nome[0] == 'V');
            Console.WriteLine("Nomes que a ultima ocorrencia comece com V = " + procuraNomeUlt);


            // --- removendo item da lista pelo nome
            minhaLista.Remove("Paulo");
            foreach (string itensDaLista in minhaLista)
            {
                Console.WriteLine("remove = " + itensDaLista);
            }

            // ---- removendo todos que começam com a letra V 
            minhaLista.RemoveAll(x => x[0] == 'V');
            foreach (string itensDaLista in minhaLista)
            {
                Console.WriteLine("remove V = " + itensDaLista);
            }

            // ----- removando pela posição 
            minhaLista.RemoveAt(2);
            foreach (string itensDaLista in minhaLista)
            {
                Console.WriteLine("remove P = " + itensDaLista);
            }

            //----- remover elementos por faixa 
            minhaLista.RemoveRange(2, 3);  // vou remover 3 elementos a partir da posição 2. 
            foreach (string itensDaLista in minhaLista)
            {
                Console.WriteLine("remove FAIXA = " + itensDaLista);
            }

        }
    }
}
