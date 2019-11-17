/*
Author: Amina Khan
Date: 11/12/2019
CTEC 135: Microsoft Software Development with C#
Module 8

Task: Programming Assignment Console Apps
Prob 2
CA2

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    class Program
    {
        static void Main(string[] args)
        {
            // program name
            Console.WriteLine("\n\nThis is CA2\n");

            // variable someText holds the input string
            string someText = Console.ReadLine();
            Console.WriteLine("\nYou entered: {0}", someText);

            // using while loop to get input
            int s = 0;
            while (s < 3)
            {
                someText = Console.ReadLine();
                Console.WriteLine("\nYou entered: {0}", someText);

                s++;
            }

        }
    }
}
