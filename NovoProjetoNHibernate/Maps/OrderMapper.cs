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
            Table("ORDER");
            Id(order => order.Id, "ID").GeneratedBy.Identity();
            Map(order => order.Date).Not.Nullable();
            References(order => order.Customer).Not.Nullable().ForeignKey("FK_CUSTOMER");
            References(order => order.Product).Not.Nullable();
            HasManyToMany(order => order.Sales).Cascade.None();
        }
    }
}
