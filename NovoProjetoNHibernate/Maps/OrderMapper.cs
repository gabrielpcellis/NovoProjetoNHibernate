using FluentNHibernate;
using FluentNHibernate.Mapping;
using NovoProjetoNHibernate.Entities;

namespace NovoProjetoNHibernate.Maps
{
    public class OrderMapper : ClassMap<Order>
    {
        public OrderMapper()
        {
            Table("ORDER_PRODUCT");
            Id(order => order.Id, "ID")
                .GeneratedBy.Identity();
            Map(order => order.Date)
                .Not.Nullable();
            HasMany<Product>(Reveal.Member<Order>("Products"))
                .LazyLoad()
                .KeyColumn("PRODUCT_FK")
                .Cascade.AllDeleteOrphan()
                .Inverse()
                .ForeignKeyConstraintName("PROD_FK");

            //HasMany(order => order.Products)
            //    .Table("PRODUCT")
            //    .ForeignKeyConstraintName("FK_PRODUCT_ORDERS")
            //    .KeyColumn("FK_PRODUCT")
            //    .Inverse();
        }
    }
}
