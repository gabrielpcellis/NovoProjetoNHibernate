using FluentNHibernate.Mapping;
using NovoProjetoNHibernate.Entities;

namespace NovoProjetoNHibernate.Maps
{
    class SalesMapper : ClassMap<Sales>
    {
        public SalesMapper()
        {
            Table("iD");
            Id(product => product.Id, "ID").GeneratedBy.Identity();
            Map(product => product.SaleDate.Date, "SALE DATE").Not.Nullable();
        }
    }
}
