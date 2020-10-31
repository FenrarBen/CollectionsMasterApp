using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void NoOdds(List<int> intList)
        {
            for (int i = intList.Count -1; i >= 0; i--)
            {
                if (intList[i] % 2 != 0)
                {
                    intList.RemoveAt(i);
                }
            }
        }

        static void IsNumInList(List<int> intList)
        {
            Console.WriteLine("What number would you like to search for?");
            var number = Console.ReadLine();
            if (Int32.TryParse(number, out int result))
            {
                if (intList.Contains(result))
                {
                    Console.WriteLine("Yes, that number is in the list");
                } else
                {
                    Console.WriteLine("No, that number is not in the list");
                }
            } else
            {
                Console.WriteLine("That's not a number.");
                IsNumInList(intList);
            }
        }

        static int[] ReverseCustom(int[] arr)
        {
            int[] reverseArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                reverseArr[i] = arr[arr.Length - i - 1];
            }
            return reverseArr;
        }

        static void NoThrees(int[] arr)
        {
           for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0)
                {
                    arr[i] = 0;
                }
            }
        }

        static void PopulateInts(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 50);
            }
        }

        static void PopulateInts(List<int> intList)
        {
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                intList.Add(rnd.Next(0,50));
            }
        }

        static void NumberPrinter(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
        }

        static void NumberPrinter(List<int> list)
        {
            foreach (int num in list)
            {
                Console.WriteLine(num);
            }
        }

        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            int[] intArray = new int[10];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            PopulateInts(intArray);

            //Print the first number of the array
            Console.WriteLine(intArray[0]);
            //Print the last number of the array            
            Console.WriteLine(intArray[intArray.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");
            NumberPrinter(intArray);

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(intArray);
            NumberPrinter(intArray);
            Console.WriteLine("---------REVERSE CUSTOM------------");
            intArray = ReverseCustom(intArray);
            NumberPrinter(intArray);
            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            NoThrees(intArray);
            NumberPrinter(intArray);

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Array.Sort(intArray);
            Console.WriteLine("Sorted numbers:");
            NumberPrinter(intArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            List<int> intList = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine("List capacity: " + intList.Capacity);

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            PopulateInts(intList);

            //Print the new capacity
            Console.WriteLine("List capacity: " + intList.Capacity);

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            IsNumInList(intList);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(intList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            NoOdds(intList);
            NumberPrinter(intList);
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            intList.Sort();
            NumberPrinter(intList);
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            int[] listToArr = new int[intList.Count()];
            listToArr = intList.ToArray();

            NumberPrinter(listToArr);
            //Clear the list
            intList.Clear();

            #endregion
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
