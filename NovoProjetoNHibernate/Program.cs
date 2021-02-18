using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using NovoProjetoNHibernate.Entities;

namespace NovoProjetoNHibernate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the JUNGLE! TANANANANAANANISSSSNISSS");

            ISessionFactory sessionFactory = Fluently
                .Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(
                    @"Data Source=DEVMYRP-00105\SQLEXPRESS;Initial Catalog=ProjetoNHibernate; User Id=sa;Password=sa"))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
                .ExposeConfiguration(config => new SchemaUpdate(config).Execute(true, true))
                .BuildSessionFactory();

            var listProduct = Auxiliar.CreateProducts();

            Auxiliar.SavingProducts(sessionFactory, listProduct);

            using (ISession session = sessionFactory.OpenSession())
            {
                var vendas = session.Query<Sales>().Where(x => x.Products.Any());
                foreach (var venda in vendas)
                {
                    Console.WriteLine(venda.ToString());
                }
            }

        }

        internal static class Auxiliar
        {
            public static List<Product> CreateProducts()
            {
                return new List<Product>
                {
                new Product(){Name = "Lapis", Quantity = 10, Price= 1.50 },
                new Product(){Name = "Caderno", Quantity = 10, Price= 2.50 },
                new Product(){Name = "Borracha", Quantity = 10, Price= 13.50 },
                new Product(){Name = "Caneta", Quantity = 10, Price= 11.50 },
                new Product(){Name = "Apontador", Quantity = 10, Price= 21.50 },
                };
            }

            public static void SavingProducts(ISessionFactory sessionFactory, List<Product> productList)
            {
                using (ISession session = sessionFactory.OpenSession())
                {
                    Console.WriteLine("Salvando os produtos");

                    foreach (var item in productList)
                    {
                        session.Save(item);

                    }

                    session.Flush();
                    Console.WriteLine("Finalizada a persistência dos produtos no banco");
                }

                using (ISession session = sessionFactory.OpenSession())
                {
                    Customer customer1 = new Customer { FirstName = "João", LastName = "Ricardo", CPF = "12345678901", BirthDate = new DateTime(1990, 02, 27), Address = "Avenida dos papagaios" };
                    Customer customer2 = new Customer { FirstName = "Maria", LastName = "Antonia", CPF = "10987654321", BirthDate = new DateTime(1998, 08, 10), Address = "Avenida dos papagaios" };

                    session.Save(customer1);
                    session.Save(customer2);

                    Order order1 = new Order { Date = DateTime.Now, Customer = customer1, Product = productList[0]};
                    Order order2 = new Order { Date = DateTime.Now, Customer = customer2 , Product = productList[1]};

                    session.Save(order1);
                    session.Save(order2);

                    Sales sale1 = new Sales { Orders = order1, Products = productList };
                    Sales sale2 = new Sales { Orders = order1, Products = productList };
                    Sales sale3 = new Sales { Orders = order1, Products = productList };
                    Sales sale4 = new Sales { Orders = order1, Products = productList };

                    session.Save(sale1);
                    session.Save(sale2);
                    session.Save(sale3);
                    session.Save(sale4);

                    session.Flush();
                }
            }
        }
    }
}
