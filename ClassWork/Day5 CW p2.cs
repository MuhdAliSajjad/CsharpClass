//using System;
//using System.Linq;

//namespace LINQExample
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Define an array of integers
//            //int[] nums = { 1, 2, 3, 3, 3, 1, 4, 12, 1, 2 }; // own test case  

//            /////////////////////////////////////////////////////////////////////////////
//            //Q1. Use LINQ to find the numbers of frequenciy
//            int[] nums = { 1, 2, 3, 1, 2, 1, 0 }; // test case
//            var groups = nums.GroupBy(x => x);
//            foreach (var i in groups)
//            {
//                Console.WriteLine("Value: {0}, Frequency: {1}", i.Key, i.Count());
//            }
//            // sirs method for Q1
//            var number2 = from num in nums group num by num into newnum select newnum;
//            foreach (var i in number2)
//            {
//                Console.WriteLine($"{i.Key} --> {i.Count()}");
//            }
//            /////////////////////////////////////////////////////////////////////////////

//            /////////////////////////////////////////////////////////////////////////////
//            //Q2 LINQSquares question
//            int[] numbers = { 1, 2, 3, 42, 35, 56, 17, 48, 19, 120 };
//            var numbersAndPower = from n in numbers
//                                  where n > 20
//                                  select new
//                                  {
//                                      Number = n,
//                                      Square = n * n
//                                  };
//            // Print the Square output
//            foreach (var i in numbersAndPower)
//            {
//                Console.WriteLine($"Number:{i.Number}, Square: {i.Square}");
//            }
//            /////////////////////////////////////////////////////////////////////////////

//            /////////////////////////////////////////////////////////////////////////////
//            // Q3 LINQDivBy2
//            //Print the Div 2 Output
//            int[] number3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//            var numbersAndDiv = from n in number3
//                                where n % 2 == 0
//                                select n;

//            foreach (var i in numbersAndDiv)
//            {
//                Console.WriteLine($"Number: {i}");
//            }
//            /////////////////////////////////////////////////////////////////////////////
//        }
//    }
//}