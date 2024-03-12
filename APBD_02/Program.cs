﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            if (int.TryParse(Console.ReadLine(), out int userInput)) {
                if(userInput == 7)
                {
                    Console.WriteLine("You have entered a lucky value!");
                }else if (userInput < 0)
                {
                    Console.WriteLine("The value is a negative one");
                }else if (userInput > 0)
                {
                    Console.WriteLine("The value is a positive one");
                }
                else
                {
                    Console.WriteLine("The value is equal to 0");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer");
            }
        }
    }
}