using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int userInput)) {
                
                Console.WriteLine();
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
            Console.WriteLine("Avg is: " + AvgFromArr(2, 3, 5, 8, 9, 10, 99));
            Console.WriteLine("Max is: " + MaxFromArr(2, 3, 5, 8, 9, 10, 99));
        }

        static decimal AvgFromArr(params int[] arr)
        {
            return (decimal) arr.Average();
        }
        
        static int MaxFromArr(params int[] arr)
        {
            return arr.Max();
        }
    }
}