using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace sendMessage.Models
{
    public class Inventory
    {
        private List<Product> items = new List<Product>();

        public void AddItem(Product product)
        {
            items.Add(product);
        }

        public bool HasItem(Product product)
        {
            return items.Contains(product);
        }
    }
}