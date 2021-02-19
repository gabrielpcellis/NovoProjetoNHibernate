using System;
using System.Collections.Generic;

namespace NovoProjetoNHibernate.Entities
{
    class Order
    {
        public virtual long Id { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual List<Product> Products { get; set; }
        public virtual Customer Customer { get; set; }

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine($"");
        //}
    }
}
