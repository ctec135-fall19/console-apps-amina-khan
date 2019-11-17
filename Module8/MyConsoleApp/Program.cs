/*
Author: Amina Khan
Date: 11/12/2019
CTEC 135: Microsoft Software Development with C#
Module 8

Task: Programming Assignment Console Apps
Prob 1

 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            if(args.Length == 0)
            {
                Console.WriteLine("no args");
            }
            else
            {
                // printing length of args
                Console.WriteLine("Length of args is: {0}", args.Length);

                // printing each item in args
                foreach (string s in args)
                {
                    Console.WriteLine(s);
                }

            }

            Console.ReadLine();

        }
    }
}
