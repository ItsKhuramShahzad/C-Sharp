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
            try
            {
                int drinks = Convert.ToInt32(Console.ReadLine());
                int shelves = Convert.ToInt32(Console.ReadLine());

                //your code goes here
                System.Console.WriteLine(drinks/ shelves);
            }
            /*
             * 1. DivideByZeroException => "At least 1 shelf"
             * 2. FormatException => "Please insert an integer"
            */
            catch (DivideByZeroException)
            {
                System.Console.WriteLine("At least 1 shelf");
            }
            catch (FormatException )
            {

                System.Console.WriteLine("Please insert an integer");
            }
            System.Console.ReadKey();
        }
    }
}
