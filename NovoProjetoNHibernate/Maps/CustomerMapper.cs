using FluentNHibernate.Mapping;
using NovoProjetoNHibernate.Entities;

namespace NovoProjetoNHibernate.Maps
{
    class CustomerMapper : ClassMap<Customer>
    {
        public CustomerMapper()
        {
            Table("CUSTOMER");
            Id(product => product.Id, "ID").GeneratedBy.Identity();
            Map(product => product.FirstName, "NAME").Length(100).Not.Nullable();
            Map(product => product.LastName, "LAST NAME").Length(100).Not.Nullable();
            Map(product => product.Address, "ADDRESS").Length(100).Not.Nullable();
            Map(product => product.PhoneNumber, "PHONE NUMBER").Length(100).Not.Nullable();
            Map(product => product.CPF, "CPF").Length(100).Not.Nullable();
        }
    }
}
