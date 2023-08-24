using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sendMessage.Models
{
    public class Product
    {
        public string Id { get; }
        public string Name { get; }
        public double Price { get; }

        public Product(string id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}