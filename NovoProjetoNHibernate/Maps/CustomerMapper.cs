using FluentNHibernate.Mapping;
using NovoProjetoNHibernate.Entities;

namespace NovoProjetoNHibernate.Maps
{
    class CustomerMapper : ClassMap<Customer>
    {
        public CustomerMapper()
        {
            Table("CUSTOMER");
            Id(customer => customer.Id, "ID").GeneratedBy.Identity();
            Map(customer => customer.FirstName, "NAME").Length(100).Not.Nullable();
            Map(customer => customer.LastName, "LAST_NAME").Length(100).Not.Nullable();
            Map(customer => customer.Address, "ADDRESS").Length(100).Not.Nullable();
            Map(customer => customer.PhoneNumber, "PHONE_NUMBER").Length(14);
            Map(customer => customer.CPF, "CPF").Length(100).Not.Nullable();
        }

    }
}
