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
            Map(order => order.Date).Not.Nullable();
            Map(order => order.Customer).Not.Nullable();
            References(order => order.Products).Not.Nullable();
            HasManyToMany(order => order.Sales);
        }
    }
}
