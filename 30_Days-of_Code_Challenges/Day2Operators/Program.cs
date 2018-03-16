using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Operators
{
    class Program
    {
        static void Main(String[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());
            double tip_percent = Convert.ToInt32(Console.ReadLine());
            double tax_percent = Convert.ToInt32(Console.ReadLine());


            double tipCost = meal_cost*(tip_percent/100);
            double taxCost = meal_cost*(tax_percent/100);

            double totalCost = meal_cost + tipCost + taxCost;


            Console.WriteLine("The total meal cost is {0} dollars.", Math.Round(totalCost));
            Console.ReadKey();
        }
    }
}
