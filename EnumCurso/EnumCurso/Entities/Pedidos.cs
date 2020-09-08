using System;
using EnumCurso.Entities.Enums;

namespace EnumCurso.Entities
{
    class Pedidos
    {
        public int Id { get; set; }
        public DateTime MomentoPedido { get; set; }
        public StatusDoPedido Status { get; set; }

        public override string ToString()
        {
            return Id + ", "
                   + MomentoPedido + ", "
                   + Status;
        }
    }
}
