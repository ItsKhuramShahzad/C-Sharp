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
            int levels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Points(levels));
            System.Console.ReadKey();

        }

        static int Points(int levels)
        {
            //your code goes here
            if (levels == 1)
                return 1;
            else
                return levels + Points(levels - 1);

        }
        
    }
}
/*
Level Points


Passing the first level of a video game awards the player 1 point. For each subsequent level passed, the points awarded increment by 1 (2 for the 2nd level, 3 for the 3rd, and so on).
The program you are given takes the number of passed levels as input. Complete the given function to take that number as an argument, and recursively calculate and return the total number of points given for all passed levels.

Sample Input
3

Sample Output
6

Explanation
Level 1: 1 point
Level 2: 2 points
Level 3: 3 points
Total: 1+2+3 = 6 points.
Don't forget about the base case.

     */
