using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkApp5.Models
{
    public class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nPrice: {Price}\nQuantity: {Quantity}";
        }
    }
}