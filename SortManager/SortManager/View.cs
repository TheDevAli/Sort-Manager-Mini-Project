using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManager
{
    public class View
    {



        public static int AskArraySize()
        {
            Console.WriteLine("Enter a number:");



            int number = 0;
            bool flag = true;
            while (flag)
            {
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out number))
                {
                    Console.WriteLine("You entered: " + number);
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine("Try again!");
                    flag = true;
                }

            }

            return number;
        }

        public static void PrintArray(int[] arr)
        {
            Console.WriteLine("Here is your array:");
            Console.Write("[ ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i != arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(" ]");
        }


    }
}
