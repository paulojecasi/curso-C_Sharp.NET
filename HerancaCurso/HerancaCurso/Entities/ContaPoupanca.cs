using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaCurso.Entities
{
    class ContaPoupanca: Conta
    {
        public double TaxaDeJuros { get; set; }

        public ContaPoupanca()
        {
        }

        public ContaPoupanca(int numero, string titular, double saldo,
            double taxaDeJuros) : base(numero, titular, saldo)
        {
            TaxaDeJuros = taxaDeJuros; 
        }

        public void AtualizaSaldo()
        {
            Saldo += Saldo * TaxaDeJuros; 
        }
    }
}
