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
            Map(customer => customer.BirthDate, "BIRTH_DATE").Length(20);
            Map(customer => customer.CPF, "CPF").Length(100).Not.Nullable();
        }

    }
}
