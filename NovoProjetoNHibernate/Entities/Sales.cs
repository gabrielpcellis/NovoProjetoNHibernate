using System;
using System.Collections.Generic;
using System.Text;

namespace NovoProjetoNHibernate.Entities
{
    class Sales
    {
        public virtual int Id { get; set; }
        public virtual DateTime SaleDate { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<Order> Orders { get; set; } = new List<Order>();

        //public Sales(int id, DateTime dateSale)
        //{
        //    Id = id;
        //    SaleDate = dateSale;
        //}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Date:" + SaleDate);
            sb.AppendLine("Customer" + Customer);
            return sb.ToString();
        }
    }
}
