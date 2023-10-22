using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тортики
{
   
    internal class Price
    {
        public string Name { get; set; }
        public int price { get; set; }
        public Price(string name, int prices)
        {
            Name = name;
            price = prices;
        }


    }
}