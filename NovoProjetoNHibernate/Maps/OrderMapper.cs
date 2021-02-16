using FluentNHibernate.Mapping;
using NovoProjetoNHibernate.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NovoProjetoNHibernate.Maps
{
    class OrderMapper : ClassMap<Order>
    {
        public OrderMapper()
        {
            Table("Order");
            Id(order => order.Id, "ID").GeneratedBy.Identity();
            Map(order => order.Customer.FirstName, "Customer");
            Map(order => order.Date).Not.Nullable();
            References(order => order.Products).Not.Nullable();
        }
    }
}
