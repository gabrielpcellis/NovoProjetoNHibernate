using System;
using System.Collections.Generic;

namespace NovoProjetoNHibernate.Entities
{
    public class Order
    {
        public virtual long Id { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual IList<Product> Products { get; set; }

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine($"");
        //}
    }
}
