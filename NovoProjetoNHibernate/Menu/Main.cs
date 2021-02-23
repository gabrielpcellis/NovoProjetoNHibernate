using NHibernate;
using NovoProjetoNHibernate.Entities;
using System;
using System.Globalization;

namespace NovoProjetoNHibernate.Menu
{
    public class Main
    {
        private readonly ISession Session;

        public Main(ISession session)
        {
            Session = session;
        }

        public void Menu()
        {
            bool sair = true;
            do
            {
                Console.Clear();
                Console.WriteLine("O que deseja fazer? \n"
                        + "1) Cadastrar novo cliente; \n"
                        + "2) Cadastrar novo produto; \n"
                        + "3) Visualizar produtos; \n"
                        + "4) Visualizar cliente; \n"
                        + "5) Sair.");

                string opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        CreateCustomer();
                        break;
                    case "2":
                        CreateProduct();
                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "5":
                        sair = false;
                        break;
                    default:
                        break;
                }
            } while (sair);
        }

        private void CreateCustomer()
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
            while (cpf.Length < 1)
            {
                Console.Write("CPF: ");
                cpf = Console.ReadLine();

                if (string.IsNullOrEmpty(cpf))
                    Console.WriteLine("CPF inválido");
            }

            var customer = new Customer(name, lastName, address, birthDate, cpf);
            try
            {
                Session.Save(customer);
                Console.WriteLine("Usuário cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar cliente: {ex.Message}");
            }
            Console.ReadLine();
        }

        private void CreateProduct()
        {
            Console.Clear();
            Console.WriteLine("Informe os dados do produto: \n");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantity = int.Parse(Console.ReadLine());

            var product = new Product(name, price, quantity);
            Session.Save(product);
        }
    }
}
