using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тортики
{
    internal class cake
    {
        private string Name { get; set; }
        public static int FullPrice { get; set; }
        public static string Purchase { get; set; }
        private List<Price> Price { get; set; }
        private List<cake> cakes = new List<cake>();

        public cake(string name, List<Price> price = null)
        {
            Name = name;
            Price = price;
        }

        public static void MenuOutput(List<cake> cakes)
        {
            foreach (var item in cakes)
            {
                Console.WriteLine("  " + item.Name);
            }

        }

        public static void AdditionalMenuOutput(List<Price> Price)
        {
            foreach (var tyty in Price)
            {
                Console.WriteLine("   " + tyty.Name + "-" + tyty.price);
            }

            int selected = Program.Checker(3, 7, "->");
            FullPrice = FullPrice + Price[selected - 3].price;
            int it = 0;
            FullPrice += it;
            Console.WriteLine(FullPrice);

            Purchase = Purchase + Price[selected - 3].Name + " - " + Price[selected - 3].price + " ";
            

            Console.WriteLine(Purchase);


        }

        public static void Nulli()
        {
            FullPrice = 0;
            Purchase = "";
        }


    }
}

