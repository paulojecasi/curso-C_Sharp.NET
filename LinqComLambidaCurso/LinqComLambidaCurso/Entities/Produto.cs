using System;
using System.Text;
using System.Globalization;

namespace LinqComLambidaCurso.Entities
{
    class Produto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Categoria Categoria { get; set; }


        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Categoria.Name
                + ", "
                + Categoria.Tier;
        }

    }
}
