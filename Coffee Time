using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
             int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);

            var val = coffee.Keys.ToArray();
            string  []val2 = new string[6];
            //your code goes here
            for (int i = coffee.Count - 1; i >= 0; i--)
            {
                var item = coffee.ElementAt(i);
                var itemKey = item.Key;
                var itemValue = item.Value;
                val2[i] = Convert.ToString(Convert.ToInt32(item.Value) - (item.Value*discount/100));
            }
            //System.Console.WriteLine("Sample Output");
            System.Console.WriteLine("Americano: "+ val2[0]);
            System.Console.WriteLine("Latte: " + val2[1] );
            System.Console.WriteLine("Flat White: " + val2[2] );
            System.Console.WriteLine("Espresso: " + val2[3]) ;
            System.Console.WriteLine("Cappuccino: " + val2[4] );
            System.Console.WriteLine("Mocha: " + val2[5]);


        }
    }
}
