using FluentNHibernate.Mapping;
using NovoProjetoNHibernate.Entities;

namespace NovoProjetoNHibernate.Maps
{
    class ProductMapper : ClassMap<Product>
    {
        public ProductMapper()
        {
            Table("PRoDuCT");
            Id(product => product.Id, "ID").GeneratedBy.Identity();
            Map(product => product.Name, "NAME").Length(100).Not.Nullable();
            Map(product => product.Price, "PRICE").Length(100).Not.Nullable();
            Map(product => product.Quantity, "QUANTITY").Not.Nullable();
        }
    }
}
