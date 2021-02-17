using System.Collections.Generic;
using System.Text;

namespace NovoProjetoNHibernate.Entities
{
    class Product
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual double Price { get; set; }
        public virtual int Quantity { get; set; }

        //public Product(string name, double price, int quantity)
        //{
        //    Name = name;
        //    Price = price;
        //    Quantity = quantity;
        //}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name:" + Name);
            sb.AppendLine("Price:" + Price);
            sb.AppendLine("Quantity:" + Quantity);

            return sb.ToString();
        }
    }
}
