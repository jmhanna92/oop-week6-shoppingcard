using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>();

                items.Add("Apple");
                items.Add("Apple");
                items.Add("Orange");
                items.Add("Apple");

            Console.WriteLine("The total price is : " + Cost(items));
            Console.ReadLine();
        }

        static double Cost(List<string>items)
        {
            double price=0.0;
            foreach(string element in items)
            {
                if (element == "Apple")
                { price += 0.60; }

                else
                {
                    price += 0.25;
                }
            }
            return price;
        }
    }
}
