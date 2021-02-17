﻿using System;
using System.Globalization;
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
                    @"Data Source=localhost;Initial Catalog=NHTest; User Id=sa;Password=sa"))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
                .ExposeConfiguration(config => new SchemaUpdate(config).Execute(true, true))
                .BuildSessionFactory();

            using (ISession session = sessionFactory.OpenSession())
            {
                Customer customer1 = new Customer
                {
                    FirstName = "Gabriel",
                    LastName = "O trouxa",
                    Address = "Rua Humberto de Campos 123",
                    PhoneNumber = "47 992335562",
                    CPF = "111111111"
                };

                Console.WriteLine($"Creating customer:{customer1}");

                session.Save(customer1);
                session.Flush();

                Console.WriteLine("Saved on database");
                Console.WriteLine($"Customer: {customer1}");

                Customer customer2 = new Customer
                {
                    FirstName = "Bruno",
                    LastName = "Da Silva",
                    Address = "Rua Humberto de Campos 222",
                    PhoneNumber = "47 982335561",
                    CPF = "2222222222"
                };

                Console.WriteLine($"Creating customer:{customer2}");

                session.Save(customer2);
                session.Flush();

                Console.WriteLine("Saved on database");
                Console.WriteLine($"Customer: {customer2}");

                customer1.Customers.Add(customer1);
                customer2.Customers.Add(customer2);
            }

            using (ISession session = sessionFactory.OpenSession())
            {
                Product product = new Product
                {
                    Name = "TV",
                    Price = 1000.00,
                    Quantity = 1
                };

                session.Save(product);
                session.Flush();

                Console.WriteLine("Saved on database");
                Console.WriteLine($"Product: {product}");

                Product AnotherProduct = new Product
                {
                    Name = "PS5 no Brasil",
                    Price = 100000.00,
                    Quantity = 1
                };

                session.Save(product);
                session.Flush();

                Console.WriteLine("Saved on database");
                Console.WriteLine($"Product: {product}");

                Order order = new Order
                {
                    Date = DateTime.Now
                };

                order.Products.Add(product);
                order.Products.Add(AnotherProduct);
            }

            using (ISession session = sessionFactory.OpenSession())
            {
              
            }
        }
    }
}
