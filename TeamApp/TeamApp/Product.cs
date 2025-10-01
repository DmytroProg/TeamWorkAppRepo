using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamApp
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public Product(int id, string name, decimal price, int count)
        {
            id = Id;
            name = Name;
            price = Price;
            count = Count;
        }
        public override string ToString()
        {
            return $"Product: {Name}\nPrice: {Price}\nCount: {Count}";
        }
    }
}
