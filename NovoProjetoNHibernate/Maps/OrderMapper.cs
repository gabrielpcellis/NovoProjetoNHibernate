using FluentNHibernate.Mapping;
using NovoProjetoNHibernate.Entities;

namespace NovoProjetoNHibernate.Maps
{
    class OrderMapper : ClassMap<Order>
    {
        public OrderMapper()
        {
            Table("ORDER");
            Id(order => order.Id, "ID")
                .GeneratedBy.Identity();
            Map(order => order.Date)
                .Not.Nullable();
            References(order => order.Customer)
                .Not.Nullable()
                .ForeignKey()
                .Columns("FK_CUSTOMER");
            HasMany(order => order.Products)
                .Table("PRODUCT")
                .KeyColumn("FK_PRODUCT")
                .ForeignKeyConstraintName("FK_PRODUCT_ORDERS");
        }
    }
}
