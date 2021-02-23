using System;
using System.Collections.Generic;
using System.Text;

namespace NovoProjetoNHibernate.Entities
{
    public class Sales
    {
        public virtual long Id { get; set; }
        public virtual DateTime SaleDate { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Order Orders { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Date:" + SaleDate);
            sb.AppendLine("Customer" + Customer);
            return sb.ToString();
        }
    }
}
