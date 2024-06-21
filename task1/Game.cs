using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Game
    {
        public string Name { get; set; }
        public double price { get; set; }
        public Category Category { get; set; }
    }
    public class Category
    {
        public string Name { get; set; }
    }
}
