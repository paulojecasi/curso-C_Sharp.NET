using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaCurso.Entities
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        public Conta()
        {
        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Saque(double saque)
        {
            Saldo -= saque;
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }


    }
}
