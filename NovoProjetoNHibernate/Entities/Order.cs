using System;
using System.Collections.Generic;
using System.Text;

namespace NovoProjetoNHibernate.Entities
{
    class Order
    {
        public virtual int Id { get; set; }
        public virtual List<Product> Products { get; set; } = new List<Product>();
        public virtual DateTime Date { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
