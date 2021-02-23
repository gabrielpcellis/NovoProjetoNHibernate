using System;
using System.Text;

namespace NovoProjetoNHibernate.Entities
{
    public class Customer
    {
        public virtual long Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Address { get; set; }
        public virtual DateTime BirthDate { get; set; }
        public virtual string CPF { get; set; }

        public Customer()
        {

        }

        public Customer(string firstName, string lastName, string address, DateTime birthDate, string cpf)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            BirthDate = birthDate;
            CPF = cpf;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Name: " + FirstName);
            sb.AppendLine("Last name: " + LastName);
            sb.AppendLine("Address: " + Address);
            sb.AppendLine("Birth Date: " + BirthDate.ToString("dd/MM/yyyy"));
            sb.AppendLine("CPF: " + CPF);

            return sb.ToString();
        }
    }
}
