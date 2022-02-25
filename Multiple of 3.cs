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
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)

                if (i % 3 == 0)
                { Console.Write("*"); }
                else
                { Console.Write(i); }
            System.Console.ReadKey();
        }
    }
}
/*
Multiple of 3


You are an elementary school teacher and explaining multiplication to students.
You are going to use multiplication by 3 as your example.
The program you are given takes N number as input. Write a program to output all numbers from 1 to N, replacing all numbers that are multiples of 3 by "*".

Sample Input
7

Sample Output
12*45*7
The N number is a multiple of 3 if N%3==0.
     */
