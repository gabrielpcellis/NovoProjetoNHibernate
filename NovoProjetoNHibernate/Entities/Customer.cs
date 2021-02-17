using System.Text;

namespace NovoProjetoNHibernate.Entities
{
    class Customer
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Address { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string CPF { get; set; }
        //public List<Order> Orders { get; set; } = new List<Order>();

        //public Customer(string firstName, string lastName, DateTime birthDate, string address, string phoneNumber, string cpf)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    BirthDate = birthDate;
        //    Address = address;
        //    PhoneNumber = phoneNumber;
        //    CPF = cpf;
        //}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Name: " + FirstName);
            sb.AppendLine("Last name: " + LastName);
            sb.AppendLine("Address: " + Address);
            sb.AppendLine("Phone number: " + PhoneNumber);
            sb.AppendLine("Email: " + CPF);

            return sb.ToString();
        }
    }
}
