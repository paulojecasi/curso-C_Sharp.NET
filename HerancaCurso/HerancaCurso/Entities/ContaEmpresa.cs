using System;

namespace HerancaCurso.Entities
{
    class ContaEmpresa : Conta        // aqui ha a herança 
    {
        public double LimiteEmprestimo { get; set; }

        public ContaEmpresa()
        {
        }

        public ContaEmpresa(int numero, string titular, double saldo,
            double limiteEmprestimo): base(numero,titular,saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo (double valorEmprestimo)
        {
            if (Saldo <= LimiteEmprestimo)
            {
                Saldo += valorEmprestimo;
            } else
            {
                Console.WriteLine("Limite para Emprestimo Excedido !");
            }
            
        }

        
    }



}
