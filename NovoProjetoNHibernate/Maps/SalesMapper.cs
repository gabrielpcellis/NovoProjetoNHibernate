using FluentNHibernate.Mapping;
using NovoProjetoNHibernate.Entities;

namespace NovoProjetoNHibernate.Maps
{
    class SalesMapper : ClassMap<Sales>
    {
        public SalesMapper()
        {
            Table("SALES");
            Id(sales => sales.Id, "ID")
                .GeneratedBy.Identity();
            Map(sales => sales.SaleDate, "SALE_DATE")
                .Not.Nullable();
            References(sales => sales.Orders)
                .Cascade.None();
        }
    }
}
