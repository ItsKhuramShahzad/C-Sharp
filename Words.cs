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
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();
            bool f = false;
            for (int x = 0; x < words.Length; x++)
            {
                if (words[x].Contains(letter))
                {
                    Console.WriteLine(words[x]);
                    f = true;
                }

            }
            if (!f)
                Console.WriteLine("No match");
            //your code goes here
            Console.ReadKey();

        }
    }

   
}
/*
Words

The program you are given defines an array with 10 words and takes a letter as input.
Write a program to iterate through the array and output words containing the taken letter.
If there is no such word, the program should output "No match".

Sample Input
u

Sample Output
fun
Recall the Contains() method.

     */
