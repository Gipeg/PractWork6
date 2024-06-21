using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3;

namespace task3
{
    public class Game
    {
        public string Name { get; set; }
        public double price { get; set; }
        public Category Category { get; set; }
        public double Discount { get; set; }
        public double DiscountedPrice => price * (1 - Discount / 100);
    }
    public class Category
    {
        public string Name { get; set; }
    }
}
