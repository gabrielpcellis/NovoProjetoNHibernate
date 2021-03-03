using System;
using System.Globalization;
using System.Text;

namespace NovoProjetoNHibernate.Entities
{
    public class Product
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual double Price { get; set; }
        public virtual int Quantity { get; set; }

        public Product()
        {

        }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public static Product CreateNewProduct()
        {
            Console.Clear();
            Console.WriteLine("Informe os dados do produto: \n");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantity = int.Parse(Console.ReadLine());

            return new Product(name, price, quantity);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome: {Name}");
            sb.AppendLine($"Preço: R$ {Price.ToString("F2", CultureInfo.InvariantCulture)} ");
            sb.AppendLine($"Quantidade: {Quantity}");

            return sb.ToString();
        }
    }
}
