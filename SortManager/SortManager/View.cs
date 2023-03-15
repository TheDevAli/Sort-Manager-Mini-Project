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
            Console.WriteLine("Enter a positive number smaller or equal to 1000: ");
            


            int number = 0;
            
            
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out number))
                {
                    
                    if(number <= 1000 && number > 0)
                    {
                        Console.WriteLine("The number you entered is: " + number);
                        ;
                    } else
                    {
                        Console.WriteLine("Number should be less than or equal to 1000 ");
                    AskArraySize();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine("Try again!");
                    AskArraySize();
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

        public static string  AskSortAlgor()
        {
            Console.WriteLine("Which Sorting Algorithm would you like to use?");
            Console.WriteLine("Please enter one of the choices");
            Console.WriteLine("A: Bubble Sort B: Merge Sort C: D: E:");


            string userInput = Console.ReadLine().ToLower();
            string choice = "";

            
            switch (userInput)
            {
                case "a":
                    Console.WriteLine("You chose Bubble Sort");
                        choice =  "a";
                        
                        break;
                    case "b":
                    Console.WriteLine("You chose Merge Sort");
                        choice = "b";
                        
                        break;
                    case "c":
                    Console.WriteLine("You chose Insertion Sort");
                        choice = "c";
                        
                        break;
                    case "d":
                    Console.WriteLine("You chose Sort");
                        choice = "d";
                       
                        break;
                    case "e":
                    Console.WriteLine("You chose Sort");
                        choice = "e";
                       
                        break;
                    default:
                        Console.WriteLine("Wrong input please try again");
                        AskSortAlgor();
                        break;

            }
            return choice;




        }




        


    }
}
