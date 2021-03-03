﻿using NHibernate;
using NovoProjetoNHibernate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

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
            bool exit = true;
            do
            {
                Console.WriteLine("Escolha uma das opções abaixo: \n"
                        + "1) Cadastrar novo cliente; \n"
                        + "2) Cadastrar novo produto; \n"
                        + "3) Visualizar produtos; \n"
                        + "4) Pesquisar produto; \n"
                        + "5) Visualizar clientes; \n"
                        + "6) Pesquisar cliente; \n"
                        + "7) Sair.");

                try
                {
                    string opt = Console.ReadLine();
                    switch (opt)
                    {
                        case "1":
                            Session.Save(Customer.CreateNewCustomer());
                            Console.Clear();
                            Console.WriteLine("Cliente cadastrado com sucesso!");
                            Console.WriteLine("Precione qualquer tecla para continuar!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "2":
                            Session.Save(Product.CreateNewProduct());
                            Console.Clear();
                            Console.WriteLine("Produto cadastrado com sucesso!");
                            Console.WriteLine("Precione qualquer tecla para continuar!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "3":
                            VisualizeAllTheProducts();
                            break;
                        case "4":
                            SearchProduct();
                            break;
                        case "5":
                            VisualizeAllTheCustomers();
                            break;
                        case "6":
                            SearchCustomer();
                            break;
                        case "7":
                            exit = false;
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro encontrado: {e.Message}");
                }

                IList<Product> VisualizeAllTheProducts()
                {
                    IList<Product> products = Session.Query<Product>().OrderBy(p => p.Name).ToList();
                    foreach (Product product in products)
                    {
                        Console.WriteLine(product);
                    }
                    return products;
                }

                void SearchProduct()
                {
                    Console.Write("Informe o Id do produto que deseja encontrar: ");
                    int productId = int.Parse(Console.ReadLine());

                    Product prod = (from p in Session.Query<Product>()
                                    where p.Id == productId
                                    select p).SingleOrDefault();

                    Console.WriteLine(prod.ToString());
                }

                IList<Customer> VisualizeAllTheCustomers()
                {
                    IList<Customer> customers = Session.Query<Customer>().OrderBy(customer => customer.FirstName).ToList();
                    foreach (Customer customer in customers)
                    {
                        Console.WriteLine(customer);
                    }

                    Session.Save(customers);

                    return customers;
                }

                void SearchCustomer()
                {
                    Console.Write("Informe o CPF do cliente que deseja encontrar: ");
                    string customerCpf = Console.ReadLine();

                    Customer customer = (from c in Session.Query<Customer>()
                                         where c.CPF == customerCpf
                                         select c).SingleOrDefault();

                    Console.WriteLine(customer.ToString());
                }

            } while (exit);
        }
    }
}
