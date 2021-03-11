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

        public static Customer CreateNewCustomer()
        {
            Console.Clear();
            Console.WriteLine("Informe os dados do cliente: \n");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Sobrenome: ");
            string lastName = Console.ReadLine();
            Console.Write("Endereço: ");
            string address = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            string cpf = string.Empty;
            while (cpf.Length != 11)
            {
                Console.Write("CPF: ");
                cpf = Console.ReadLine();

                if (string.IsNullOrEmpty(cpf) || cpf.Length != 11)
                {
                    Console.WriteLine("CPF inválido");
                }
            }
            Console.Clear();
            Console.WriteLine("Cliente cadastrado com sucesso!");
            Console.WriteLine("Precione qualquer tecla para continuar!");
            Console.ReadKey();
            Console.Clear();
            return new Customer(name, lastName, address, birthDate, cpf);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nome: " + FirstName);
            sb.AppendLine("Sobrenome: " + LastName);
            sb.AppendLine("Endereço: " + Address);
            sb.AppendLine("Data de nascimento: " + BirthDate.ToString("dd/MM/yyyy"));
            sb.AppendLine("CPF: " + CPF);

            return sb.ToString();
        }
    }
}
