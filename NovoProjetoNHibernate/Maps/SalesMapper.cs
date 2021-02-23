using FluentNHibernate.Mapping;
using NovoProjetoNHibernate.Entities;

namespace NovoProjetoNHibernate.Maps
{
    public class SalesMapper : ClassMap<Sales>
    {
        public SalesMapper()
        {
            Table("SALES");
            Id(sales => sales.Id, "ID")
                .GeneratedBy.Identity();
            Map(sales => sales.SaleDate, "SALE_DATE")
                .Not.Nullable();
            References(sales => sales.Customer)
                .Not.Nullable()
                .ForeignKey()
                .Columns("FK_CUSTOMER");
            References(sales => sales.Orders);
        }
    }
}
