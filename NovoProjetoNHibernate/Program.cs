using System;
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
                    @"Data Source=DEVMYRP-00105\SQLEXPRESS;Initial Catalog=ProjetoNHibernate; User Id=sa;Password=sa"))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
                .ExposeConfiguration(config => new SchemaUpdate(config).Execute(true, true))
                .BuildSessionFactory();

           

        }
    }
}
