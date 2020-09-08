using System;
using EnumCurso.Entities;
using EnumCurso.Entities.Enums;


namespace EnumCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedidos pedidos = new Pedidos
            {
                Id = 1000,
                MomentoPedido = DateTime.Now,
                Status = StatusDoPedido.AguardandoPagamento

            };

            Console.WriteLine(pedidos);

            // conversao de enumeração pra string

            string txtStatus = StatusDoPedido.AguardandoPagamento.ToString();
            Console.WriteLine(txtStatus);

            // conversao de string para enumeração

            StatusDoPedido sp = Enum.Parse<StatusDoPedido>("Entregue");
            Console.WriteLine(sp);





        }
    }
}
